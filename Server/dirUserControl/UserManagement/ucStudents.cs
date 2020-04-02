using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.UserManagement
{
    public partial class ucStudents : UserControl
    {
        public static ucStudents mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ucStudents()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            new dirOtherForms.UserManagement.frmAddStudent().ShowDialog();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            new dirOtherForms.UserManagement.frmViewCourse().ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        DataTable o = null;
        private void dgvStudents_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            Zuby.ADGV.AdvancedDataGridView fdgv = dgvStudents;
            DataTable dt = null;
            if (o == null)
            {
                o = (DataTable)fdgv.DataSource;
            }
            if (fdgv.FilterString.Length > 0)
            {
                dt = (DataTable)fdgv.DataSource;
            }
            else
            {
                dt = o;
            }

            fdgv.DataSource = dt.Select(fdgv.FilterString).CopyToDataTable();
        }

        private void dgvStudents_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {

        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadAllData()
        {
            loadData();
            loadStudentsPerCourse(5);
            loadStudentsPerStatus(5);
            loadStudentsPerYearStanding(5);
            loadStudentCount();
        }

        public void loadData()
        {
            this.coursesTableAdapter.Fill(this.dbThesisComfamaDataSet.Courses);

            try
            {
                this.query = "SELECT id, studentNumber, firstName, middleName, lastName, course, yearLevel, status FROM Students";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvStudents.DataSource = dt;
                            dgvStudents.AutoGenerateColumns = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }
        }

        public void loadStudentsPerStatus(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " status, COUNT(status) as statusCount " +
                             "FROM Students " +
                             "GROUP BY status " +
                             "ORDER BY statusCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvStudentsPerStatus.DataSource = dt;
                            dgvStudentsPerStatus.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading students per status: " + ex.Message, "User Management");
            }
        }

        public void loadStudentsPerYearStanding(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " yearLevel, COUNT(yearLevel) as yearStandingCount " +
                             "FROM Students " +
                             "GROUP BY yearLevel " +
                             "ORDER BY yearStandingCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvStudentsPerYearStanding.DataSource = dt;
                            dgvStudentsPerYearStanding.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading students per year standing: " + ex.Message, "User Management");
            }
        }

        public void loadStudentsPerCourse(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " b.course as course, COUNT(a.course) as courseCount " +
                             "FROM Students a " +
                             "INNER JOIN Courses b ON a.course = b.id " +
                             "GROUP BY b.course, a.course " +
                             "ORDER BY courseCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvStudentsPerCourse.DataSource = dt;
                            dgvStudentsPerCourse.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading students per course: " + ex.Message, "User Management");
            }
        }

        public void loadStudentCount()
        {
            try
            {
                this.query = "SELECT " +
                                "(SELECT COUNT(*) FROM Students) as studentCount, " +
                                "(SELECT COUNT(*) FROM Courses) as sc";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblStudentCount.Text = reader["studentCount"].ToString();
                            lblCourseCount.Text = reader["sc"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading student count: " + ex.Message, "User Management");
            }
        }

        private void cbStudentsPerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbStudentsPerStatus.Text);
            loadStudentsPerStatus(numberToDisplay);
        }

        private void cbStudentPerYearStanding_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbStudentPerYearStanding.Text);
            loadStudentsPerYearStanding(numberToDisplay);
        }

        private void cbStudentsPerCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbStudentsPerCourse.Text);
            loadStudentsPerCourse(numberToDisplay);
        }
    }
}
