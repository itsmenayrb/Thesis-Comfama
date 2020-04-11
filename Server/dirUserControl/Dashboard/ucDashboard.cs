using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SqlClient;

namespace Server.dirUserControl.Dashboard
{
    public partial class ucDashboard : UserControl
    {
        public static ucDashboard mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private double connectedPC = 0;
        private double disconnectedPC = 0;
        private double idlePC = 0;

        private double condemnedItem = 0;
        private double workingItem = 0;
        private double defectiveItem = 0;

        Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        public ucDashboard()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);

            lblDay.Text = DateTime.Now.DayOfWeek.ToString().ToUpper();
            lblDateTime.Text = DateTime.Now.ToString().ToUpper();

            getPCStatusCount();
            getPCCountPerDepartment();
            loadTotalMaintenanceReport();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString().ToUpper();
            new dirClasses.Configuration().displayCurrentAcademicYear();
            lblAcademicYear.Text = "A.Y " + dirClasses.Session.semester + " " + dirClasses.Session.academicYear;
        }

        private void loadPCStatusPieChart(double connected, double disconnected, double idle)
        {
            pieChartPCStatus.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Connected",
                    Values = new ChartValues<double> {connected},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Disconnected",
                    Values = new ChartValues<double> {disconnected},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Idle",
                    Values = new ChartValues<double> {idle},
                    DataLabels = true
                }
            };

            pieChartPCStatus.LegendLocation = LegendLocation.Bottom;
        }

        private void getPCStatusCount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT (" +
                                    "SELECT COUNT(*) FROM RemotePC WHERE status='Idle'" +
                                    ") AS idleCount, " +
                                    "(" +
                                    "SELECT COUNT(*) FROM RemotePC WHERE status='Connected'" +
                                    ") AS connectedCount, " +
                                    "(" +
                                    "SELECT COUNT(*) FROM RemotePC WHERE status='Disconnected'" +
                                    ") AS disconnectedCount";

                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                connectedPC = Convert.ToDouble(reader["connectedCount"].ToString());
                                disconnectedPC = Convert.ToDouble(reader["disconnectedCount"].ToString());
                                idlePC = Convert.ToDouble(reader["idleCount"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading pc count: " + ex.Message, "Dashboard");
            }

            loadPCStatusPieChart(connectedPC, disconnectedPC, idlePC);
        }

        private void getPCCountPerDepartment()
        {
            SeriesCollection s = new SeriesCollection();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT (" +
                                    "SELECT COUNT(*) FROM RemotePC GROUP BY serverLocation" +
                                    ") AS pcCount, " +
                                    "(" +
                                    "SELECT serverLocation FROM RemotePC GROUP BY serverLocation" +
                                    ") AS department";

                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                s.Add
                                (
                                    new PieSeries
                                    {
                                        Title = reader["department"].ToString(),
                                        Values = new ChartValues<double> { Convert.ToDouble(reader["pcCount"].ToString()) },
                                        DataLabels = true
                                    }
                                );
                            }
                        }

                    }
                    conn.Close();
                }

                pieChartPCCount.Series = s;
                pieChartPCCount.LegendLocation = LegendLocation.Bottom;
                pieChartPCCount.InnerRadius = 20;
                pieChartPCCount.StartingRotationAngle = 315;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private void loadTotalMaintenanceReport()
        {
            SeriesCollection s = new SeriesCollection();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT DATENAME(MONTH, DATEADD(MONTH, DATEPART(MONTH, dateRequest), -1)) as mn, COUNT(*) as numberOfReports " +
                                 "FROM RequestAssistance " +
                                 "GROUP BY DATEPART(MONTH, dateRequest) " +
                                 "ORDER BY DATEPART(MONTH, dateRequest)";

                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                s.Add
                                (
                                    new ColumnSeries
                                    {
                                        Title = reader["mn"].ToString(),
                                        Values = new ChartValues<int> { Convert.ToInt32(reader["numberOfReports"].ToString()) }
                                    }
                                );

                                Labels = new[] { reader["mn"].ToString() };

                            }
                            
                        }

                    }
                    conn.Close();
                }

                lineChartMaintenanceReport.AxisX.Add(new Axis
                {
                    Title = "Month",
                    Labels = Labels
                });

                lineChartMaintenanceReport.AxisY.Add(new Axis
                {
                    Title = "Number of Reports"
                });

                lineChartMaintenanceReport.Series = s;
                lineChartMaintenanceReport.LegendLocation = LegendLocation.Bottom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading maintenance report: " + ex.Message, "Dashboard");
            }
        }
    }
}
