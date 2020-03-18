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
    public partial class ucEmployees : UserControl
    {
        public static ucEmployees mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ucEmployees()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucEmployees_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new dirOtherForms.UserManagement.frmAddEmployee().ShowDialog();
        }

        private void btnViewDepartment_Click(object sender, EventArgs e)
        {
            new dirOtherForms.UserManagement.frmViewDepartment().ShowDialog();
        }

        private void btnViewPosition_Click(object sender, EventArgs e)
        {
            new dirOtherForms.UserManagement.frmViewPosition().ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        DataTable o = null;
        private void dgvEmployees_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            Zuby.ADGV.AdvancedDataGridView fdgv = dgvEmployees;
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

        private void dgvEmployees_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {

        }

        public void loadData()
        {
            this.departmentsTableAdapter.Fill(this.dbThesisComfamaDataSet.Departments);
            this.positionsTableAdapter.Fill(this.dbThesisComfamaDataSet.Positions);

            try
            {
                this.query = "SELECT id, employeeID, firstName, middleName, lastName, department, position FROM Employees";
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
                            dgvEmployees.DataSource = dt;
                            dgvEmployees.AutoGenerateColumns = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
