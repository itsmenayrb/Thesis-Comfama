using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.LoginHistory
{
    public partial class ucLoginHistory : UserControl
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;
        public static ucLoginHistory mainInstance = null;

        public ucLoginHistory()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucLoginHistory_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            dgvLoginHistory.Columns["appsUsed"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            loadAllData();
        }

        public void loadAllData()
        {
            loadLoginHistoryData();
            loadDateWithMostLoggedInUser(5);
        }

        public void loadLoginHistoryData()
        {
            try
            {
                this.query = "SELECT username, loginDate, startTime, endTime, duration, location, machineName, appsUsed, remarks FROM LoginHistory " +
                             "WHERE academicYear=@academicYear " +
                             "ORDER BY loginDate DESC, startTime DESC";
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
                            dgvLoginHistory.DataSource = dt;
                            dgvLoginHistory.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading login history: " + ex.Message, "Login History");
            }
        }

        private void dgvLoginHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLoginHistory.Rows)
            {
                if (row.Cells["remarks"].Value.ToString() == "Normal")
                {
                    row.Cells["remarks"].Style.BackColor = Color.FromArgb(92, 184, 92);
                    row.Cells["remarks"].Style.ForeColor = Color.White;
                }
                else
                {
                    row.Cells["remarks"].Style.BackColor = Color.FromArgb(217, 83, 79);
                    row.Cells["remarks"].Style.ForeColor = Color.White;
                }
            }
        }

        public void loadDateWithMostLoggedInUser(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " loginDate as mostDate, COUNT(DISTINCT username) as userCount " +
                             "FROM LoginHistory " +
                             "WHERE academicYear=@academicYear " +
                             "GROUP BY loginDate " +
                             "ORDER BY userCount DESC";
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
                            dgvMostNumberOfUser.DataSource = dt;
                            dgvMostNumberOfUser.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading date with most user: " + ex.Message, "Login History");
            }
        }

        private void cbMostNumberOfUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbMostNumberOfUser.Text);
            loadDateWithMostLoggedInUser(numberToDisplay);
        }

        DataTable o = null;
        private void dgvLoginHistory_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            Zuby.ADGV.AdvancedDataGridView fdgv = dgvLoginHistory;
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
    }
}
