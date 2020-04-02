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
    public partial class ucAccounts : UserControl
    {
        public static ucAccounts mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ucAccounts()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucAccounts_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        public void loadAllData()
        {
            loadData();
            loadUserCount();
            loadCurrentLoggedInPerLocation(5);
        }

        

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void dgvAccounts_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            
        }

        private void dgvAccounts_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvAccounts.Columns["action"].Index)
            //{
            //    string username = dgvAccounts.Rows[dgvAccounts.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

            //    DialogResult result = MessageBox.Show("Update " + username + "?", "Update Account Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        if (string.IsNullOrEmpty(username))
            //        {
            //            MessageBox.Show("Please make sure that the field is not empty.", "Update Account Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            loadData();
            //        }
            //        else
            //        {
            //            accountsBindingSource.EndEdit();
            //            this.accountsTableAdapter.Update(this.dbThesisComfamaDataSet.Accounts);
            //            dgvAccounts.Refresh();
            //            MessageBox.Show("Account has been updated!", "Update Account Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
        }

        private void dgvAccounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAccounts.Rows)
            {
                if (row.Cells["status"].Value.ToString() == "Active")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(92, 184, 92);
                    row.Cells["status"].Style.ForeColor = Color.White;
                    row.Cells["status"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else if (row.Cells["status"].Value.ToString() == "Inactive")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(217, 83, 79);
                    row.Cells["status"].Style.ForeColor = Color.White;
                    row.Cells["status"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (row.Cells["is_logged_in"].Value.ToString() == "Yes")
                {
                    row.Cells["is_logged_in"].Style.BackColor = Color.FromArgb(92, 184, 92);
                    row.Cells["is_logged_in"].Style.ForeColor = Color.White;
                    row.Cells["is_logged_in"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else if (row.Cells["is_logged_in"].Value.ToString() == "No")
                {
                    row.Cells["is_logged_in"].Style.BackColor = Color.FromArgb(217, 83, 79);
                    row.Cells["is_logged_in"].Style.ForeColor = Color.White;
                    row.Cells["is_logged_in"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        public void loadData()
        {
            try
            {
                this.query = "SELECT id, username, userType, CASE status WHEN 1 THEN 'Active' ELSE 'Inactive' END as status, CASE is_logged_in WHEN 1 THEN 'Yes' ELSE 'No' END as is_logged_in, last_logged_in FROM Accounts";
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
                            dgvAccounts.DataSource = dt;
                            dgvAccounts.AutoGenerateColumns = false;

                            if (dgvAccounts.Columns.Contains("action") && dgvAccounts.Columns["action"].Visible)
                            {

                            }
                            else
                            {
                                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                                {
                                    button.Name = "action";
                                    button.HeaderText = "ACTION";
                                    button.Text = "VIEW ACCOUNT";
                                    button.UseColumnTextForButtonValue = true;
                                    this.dgvAccounts.Columns.Add(button);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading accounts: " + ex.Message, "User Management");
            }
        }

        public void loadUserCount()
        {
            try
            {
                this.query = "SELECT " +
                                "(SELECT COUNT(*) FROM Accounts) as userCount, " +
                                "(SELECT COUNT(*) FROM Accounts WHERE status=@status) as activeCount, " +
                                "(SELECT COUNT(*) FROM Accounts WHERE is_logged_in=@is_logged_in) as loggedInCount";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@status", 1);
                        cmd.Parameters.AddWithValue("@is_logged_in", 1);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblAccountCount.Text = reader["userCount"].ToString();
                            lblActiveAccountCount.Text = reader["activeCount"].ToString();
                            lblCurrentlyLoggedinCount.Text = reader["loggedInCount"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading user count: " + ex.Message, "User Management");
            }
        }

        public void loadCurrentLoggedInPerLocation(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " a.location AS location, COUNT(a.location) as locationCount " +
                             "FROM LoginHistory a " +
                             "INNER JOIN Accounts b ON a.username = b.username " +
                             "WHERE a.academicYear=@academicYear AND b.is_logged_in=@is_logged_in AND a.remarks is null " +
                             "GROUP BY a.location " +
                             "ORDER BY locationCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                        cmd.Parameters.AddWithValue("@is_logged_in", 1);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvUserPerLocation.DataSource = dt;
                            dgvUserPerLocation.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading current logged in account per room: " + ex.Message, "User Management");
            }
        }

        private void cbUserPerLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbUserPerLocation.Text);
            loadCurrentLoggedInPerLocation(numberToDisplay);
        }
    }
}
