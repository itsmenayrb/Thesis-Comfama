using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmMain : Form
    {
        public static frmMain mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private int lastEntryID = 0;

        public frmMain()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 50, 3, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 50, 3, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);

            lblName.Text = dirClasses.Session.firstName + " " + dirClasses.Session.lastName;
            pbProfilePicture.Image = Image.FromStream(new MemoryStream((Byte[])dirClasses.Session.profilePicture));
            lblEmployeeID.Text = dirClasses.Session.username;
            getLastEntryToLogout();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            cmsMain.Show(btnShutdown, new Point(0, btnShutdown.Height));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = true;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 10;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnRemoteManagement_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = true;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 10;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = true;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 10;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnMaintenanceReport_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 10;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnActivityLogs_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 10;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = true;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 10;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnBackupAndRestore_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = true;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 10;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 10;
            btnAbout.LineLeft = 0;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 10;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to end your session?", "Comfama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dirClasses.Login logout = new dirClasses.Login();
                logout.endUserSession();
                logout.logoutLastUserLogin(lastEntryID);
                logout.disconnectThisMachine();
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit the application?", "Comfama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dirClasses.Login logout = new dirClasses.Login();
                logout.endUserSession();
                logout.logoutLastUserLogin(lastEntryID);
                logout.disconnectThisMachine();
                Environment.Exit(0);
            }
        }

        public void getLastEntryToLogout()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT MAX(id) as idLastEntry FROM LoginHistory WHERE username=@username";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@username", dirClasses.Session.username);

                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            lastEntryID = Convert.ToInt32(reader["idLastEntry"].ToString());
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error get last entry to logout: " + ex.Message);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = true;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnActivityLogs.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
        }
    }
}
