using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.Archived
{
    public partial class ucMaintenanceReport : UserControl
    {
        public static ucMaintenanceReport mainInstance = null;
        public string query = string.Empty;
        public string connectionString = string.Empty;

        public ucMaintenanceReport()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        public void loadMaintenanceReportData(int id)
        {
            try
            {
                this.query = "SELECT a.ticketNumber as ticketNumber, a.title as problem, a.description as description, a.location as location, a.dateRequest as dateReported, a.status as status, " +
                             "CONCAT(b.firstName + ' ', b.lastName) as fullName " +
                             "FROM RequestAssistance a " +
                             "INNER JOIN Employees b ON a.employeeID = b.employeeID " +
                             "WHERE academicYear=@academicYear";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", id);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvMaintenanceReport.DataSource = dt;
                            dgvMaintenanceReport.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading maintenance report: " + ex.Message, "Archived");
            }
        }

        public void loadAcademicInfo(int id)
        {
            try
            {
                this.query = "SELECT CONCAT(semester + ' ', academicYear) as acad FROM AcademicYear WHERE id=@id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblAcademicYear.Text = reader["acad"].ToString();
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading academic year: " + ex.Message, "Archived");
            }
        }
    }
}
