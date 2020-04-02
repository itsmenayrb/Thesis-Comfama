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
            loadAllData();
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

        public void loadAllData()
        {
            loadData();
            loadEmployeesPerDepartment(5);
            loadEmployeesPerPosition(5);
            loadEmployeeCount();
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
                MessageBox.Show("Error on loading employees: " + ex.Message, "User Management");
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void loadEmployeesPerDepartment(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " b.department as department, COUNT(a.department) as departmentCount " +
                             "FROM Employees a " +
                             "INNER JOIN Departments b ON a.department = b.id " +
                             "GROUP BY b.department, a.department " +
                             "ORDER BY departmentCount DESC";
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
                            dgvEmployeePerDepartment.DataSource = dt;
                            dgvEmployeePerDepartment.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading employees per department: " + ex.Message, "User Management");
            }
        }

        public void loadEmployeesPerPosition(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " b.position as position, COUNT(a.position) as positionCount " +
                             "FROM Employees a " +
                             "INNER JOIN Positions b ON a.position = b.id " +
                             "GROUP BY b.position, a.position " +
                             "ORDER BY positionCount DESC";
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
                            dgvEmployeesPerPosition.DataSource = dt;
                            dgvEmployeesPerPosition.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading employees per position: " + ex.Message, "User Management");
            }
        }

        private void cbEmployeePerDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbEmployeePerDepartment.Text);
            loadEmployeesPerDepartment(numberToDisplay);
        }

        private void cbEmployeePerPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbEmployeePerPosition.Text);
            loadEmployeesPerPosition(numberToDisplay);
        }

        public void loadEmployeeCount()
        {
            try
            {
                this.query = "SELECT " +
                                "(SELECT COUNT(*) FROM Employees) as employeeCount, " +
                                "(SELECT COUNT(*) FROM Departments) as departmentCount, " +
                                "(SELECT COUNT(*) FROM Positions) as positionCount";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblEmployeeCount.Text = reader["employeeCount"].ToString();
                            lblDepartmentCount.Text = reader["departmentCount"].ToString();
                            lblPositionCount.Text = reader["positionCount"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading employee count: " + ex.Message, "User Management");
            }
        }
    }
}
