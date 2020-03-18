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
            loadData();
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
    }
}
