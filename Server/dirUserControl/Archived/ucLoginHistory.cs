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
    public partial class ucLoginHistory : UserControl
    {
        public static ucLoginHistory mainInstance = null;
        public string query = string.Empty;
        public string connectionString = string.Empty;

        public ucLoginHistory()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();

            dgvLoginHistory.Columns["appsUsed"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public void loadLoginHistoryData(int id)
        {
            try
            {
                this.query = "SELECT a.loginDate as loginDate, CONCAT(b.firstName + ' ', b.lastName) as fullName, a.startTime as startTime, a.endTime as endTime, a.duration as duration, a.location as location, a.machineName as machineName, a.appsUsed as appsUsed, a.remarks as remarks " +
                             "FROM LoginHistory a " +
                             "INNER JOIN Employees b ON a.username = b.employeeID " +
                             "WHERE a.academicYear=@academicYear " +
                             "UNION ALL " +
                             "SELECT c.loginDate as loginDate, CONCAT(d.firstName + ' ', d.lastName) as fullName, c.startTime as start, c.endTime as endTime, c.duration as duration, c.location as location, c.machineName as machineName, c.appsUsed as appsUsed, c.remarks as remarks " +
                             "FROM LoginHistory c " +
                             "INNER JOIN Students d ON c.username = d.studentNumber " +
                             "WHERE c.academicYear=@academicYear";
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
                            dgvLoginHistory.DataSource = dt;
                            dgvLoginHistory.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading login history: " + ex.Message, "Archived");
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
