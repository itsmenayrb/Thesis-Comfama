using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.MaintenanceReport
{
    public partial class ucMaintenanceReport : UserControl
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;
        public static ucMaintenanceReport mainInstance = null;

        public ucMaintenanceReport()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucMaintenanceReport_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            loadMaintenanceReportData();
            loadReportCount();
            loadAllReportCount();
        }

        private void btnLogReport_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        public void loadMaintenanceReportData()
        {
            dgvMaintenanceReport.DataSource = null;

            try
            {
                this.query = "SELECT RequestAssistance.id as id, RequestAssistance.ticketNumber as ticketNumber, RequestAssistance.title as title, RequestAssistance.dateRequest as dateReported, RequestAssistance.status as status, CONCAT(Employees.firstName + ' ', Employees.lastName) as fullName FROM RequestAssistance " +
                             "INNER JOIN Employees ON RequestAssistance.employeeID = Employees.employeeID " +
                             "WHERE RequestAssistance.academicYear=@academicYear " +
                             "ORDER BY CASE RequestAssistance.status WHEN 'Pending' THEN 1 WHEN 'Ongoing' THEN 2 WHEN 'Completed' THEN 3 WHEN 'Cancelled' THEN 4 END ASC, RequestAssistance.dateRequest ASC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvMaintenanceReport.DataSource = dt;
                            dgvMaintenanceReport.AutoGenerateColumns = false;

                            if (dgvMaintenanceReport.Columns.Contains("action") && dgvMaintenanceReport.Columns["action"].Visible)
                            {
                                
                            }
                            else
                            {
                                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                                {
                                    button.Name = "action";
                                    button.HeaderText = "ACTION";
                                    button.Text = "VIEW REPORT";
                                    button.UseColumnTextForButtonValue = true;
                                    this.dgvMaintenanceReport.Columns.Add(button);
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading maintenance report: " + ex.Message, "Maintenance Report");
            }
        }

        public void loadReportCount()
        {
            try
            {
                this.query = "SELECT " +
                                "(SELECT COUNT(*) FROM RequestAssistance WHERE status=@pending) as pendingCount, " +
                                "(SELECT COUNT(*) FROM RequestAssistance WHERE status=@completed) as completedCount";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@pending", "Pending");
                        cmd.Parameters.AddWithValue("@completed", "Completed");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblPendingReportCount.Text = reader["pendingCount"].ToString();
                            lblCompletedReportCount.Text = reader["completedCount"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }
        }

        DataTable o = null;
        private void dgvMaintenanceReport_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            Zuby.ADGV.AdvancedDataGridView fdgv = dgvMaintenanceReport;
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

        private void dgvMaintenanceReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMaintenanceReport.Columns["action"].Index)
            {
                int RequestAssistanceID = Convert.ToInt32(dgvMaintenanceReport.Rows[dgvMaintenanceReport.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                dirOtherForms.MaintenanceReport.frmViewReport.RequestAssistanceID = RequestAssistanceID;
                new dirOtherForms.MaintenanceReport.frmViewReport().ShowDialog();
            }
        }

        private void dgvMaintenanceReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvMaintenanceReport.Rows)
            {
                if (row.Cells["status"].Value.ToString() == "Completed")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(92, 184, 92);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
                else if (row.Cells["status"].Value.ToString() == "Pending")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(240, 173, 78);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
                else if (row.Cells["status"].Value.ToString() == "Cancelled")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(217, 83, 79);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
                else if (row.Cells["status"].Value.ToString() == "Ongoing")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(91, 192, 222);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
            }
        }

        public void loadAllReportCount()
        {
            cbMostCommonIssue.SelectedIndex = 0;
            cbReportCountByDepartment.SelectedIndex = 0;
            cbReportCountByEmployee.SelectedIndex = 0;

            int a = 5;
            loadReportCountByDepartment(a);
            loadReportCountByEmployee(a);
            loadMostCommonIssue(a);
        }

        public void loadReportCountByDepartment(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " location, COUNT(*) as departmentCount " +
                             "FROM RequestAssistance " +
                             "WHERE academicYear=@academicYear " +
                             "GROUP BY location " +
                             "ORDER BY departmentCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvReportCountByDepartment.DataSource = dt;
                            dgvReportCountByDepartment.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading reports per department: " + ex.Message, "Maintenance Report");
            }
        }

        public void loadReportCountByEmployee(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " CONCAT(e.firstName + ' ', e.lastName) as fullName, COUNT(r.employeeID) as employeeCount " +
                             "FROM RequestAssistance r " +
                             "INNER JOIN Employees e ON r.employeeID = e.employeeID " +
                             "WHERE r.academicYear=@academicYear " +
                             "GROUP BY r.employeeID, e.firstName, e.lastName " +
                             "ORDER BY employeeCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvReportCountByEmployees.DataSource = dt;
                            dgvReportCountByEmployees.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading reports per employee: " + ex.Message, "Maintenance Report");
            }
        }

        public void loadMostCommonIssue(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " title, COUNT(*) as commonCount " +
                             "FROM RequestAssistance " +
                             "WHERE academicYear=@academicYear " +
                             "GROUP BY title " +
                             "ORDER BY commonCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvMostCommonIssue.DataSource = dt;
                            dgvMostCommonIssue.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading most common issue: " + ex.Message, "Maintenance Report");
            }
        }

        private void cbReportCountByEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbReportCountByEmployee.Text);
            loadReportCountByEmployee(numberToDisplay);
        }

        private void cbReportCountByDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbReportCountByDepartment.Text);
            loadReportCountByDepartment(numberToDisplay);
        }

        private void cbMostCommonIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbMostCommonIssue.Text);
            loadMostCommonIssue(numberToDisplay);
        }
    }
}
