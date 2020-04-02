using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
        private bool normalExit = false;
        readonly List<string> appsUsed = new List<string>();

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
            timerIncomingRequest.Start();
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
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 10;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnRemoteManagement_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = true;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 10;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StartServer();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = true;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 10;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnMaintenanceReport_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = true;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnAuditTrail.LineLeft = 0;
            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 10;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = true;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 10;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = true;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 10;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnBackupAndRestore_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = true;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 10;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnAuditTrail_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = true;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 10;

            ucRemoteManagement1.StopServer();
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = true;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 10;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = false;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 10;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucDashboard1.Visible = false;
            ucInventoryManagement1.Visible = false;
            ucUserManagement1.Visible = false;
            ucRemoteManagement1.Visible = false;
            ucBackupRestore1.Visible = false;
            ucSettings1.Visible = true;
            ucMaintenanceReport1.Visible = false;
            ucLoginHistory1.Visible = false;
            ucArchived1.Visible = false;
            ucAuditTrail1.Visible = false;

            btnDashboard.LineLeft = 0;
            btnRemoteManagement.LineLeft = 0;
            btnInventoryManagement.LineLeft = 0;
            btnMaintenanceReport.LineLeft = 0;
            btnLoginHistory.LineLeft = 0;
            btnManageUsers.LineLeft = 0;
            btnBackupAndRestore.LineLeft = 0;
            btnArchived.LineLeft = 0;
            btnAbout.LineLeft = 0;
            btnAuditTrail.LineLeft = 0;

            ucRemoteManagement1.StopServer();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to end your session?", "Comfama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                normalExit = true;
                string application = String.Join(", ", appsUsed);
                timerIncomingRequest.Stop();
                ucRemoteManagement1.StopServer();
                dirClasses.Login logout = new dirClasses.Login();
                logout.endUserSession();
                logout.logoutLastUserLogin(lastEntryID, application, "Normal");
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
                normalExit = true;
                string application = String.Join(", ", appsUsed);
                timerIncomingRequest.Stop();
                dirClasses.Login logout = new dirClasses.Login();
                logout.endUserSession();
                logout.logoutLastUserLogin(lastEntryID, application, "Normal");
                logout.disconnectThisMachine();
                Application.Exit();
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

        

        private void ucSettings1_Load(object sender, EventArgs e)
        {

        }

        private void incomingRequestAssistance()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT RequestAssistance.title as 'problem', RequestAssistance.dateRequest as 'dateRequest', RequestAssistance.location as 'location', CONCAT(Employees.firstName, ' ', Employees.middleName, ' ', Employees.lastName) as 'fullName' FROM RequestAssistance INNER JOIN Employees ON RequestAssistance.employeeID = Employees.employeeID";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DateTime dateRequest;
                        while (reader.Read())
                        {
                            dateRequest = Convert.ToDateTime(reader["dateRequest"]);
                            if (Math.Abs((DateTime.Now - dateRequest).TotalSeconds) < .5)
                            {
                                string fullname = reader["fullName"].ToString();
                                string location = reader["location"].ToString();
                                string problem = reader["problem"].ToString();

                                Notification toastNotification = new Notification("success", "Request Assistance", "You received a report from " + fullname.ToUpper() + " in " + location.ToUpper() + "\nProblem: " + problem, 30, dirClasses.FormAnimator.AnimationMethod.Slide, dirClasses.FormAnimator.AnimationDirection.Left);
                                toastNotification.Show();
                                dirClasses.Configuration.PlayNotificationSound("garden");
                                dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadMaintenanceReportData();
                                dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadReportCount();
                                break;
                            }

                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void timerIncomingRequest_Tick(object sender, EventArgs e)
        {
            incomingRequestAssistance();
            //checkApplicationOpenedByUser();
        }

        private void insertCapturedImage(Image _screen)
        {
            byte[] byteImage = dirClasses.Configuration.ConvertScreenCaptureToByte(_screen);

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE RemotePC SET screenImage=@screenImage WHERE machineName=@machineName";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@screenImage", byteImage);
                        cmd1.Parameters.AddWithValue("@machineName", dirClasses.Session.machineName);
                        cmd1.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on screen capturing: " + ex.Message);
            }
        }

        private static Image GrabDesktop()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphic = Graphics.FromImage(screenshot);
            graphic.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return screenshot;
        }

        private void timerCastScreenToClient_Tick(object sender, EventArgs e)
        {
            insertCapturedImage(dirClasses.CaptureScreen.CaptureDesktopWithCursor());
        }

        public void startScreenCast()
        {
            timerCastScreenToClient.Start();
        }

        public void stopScreenCast()
        {
            timerCastScreenToClient.Stop();
        }

        public void checkApplicationOpenedByUser()
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Length > 0)
                {
                    if (!appsUsed.Contains(process.MainWindowTitle.ToString()))
                    {
                        appsUsed.Add(process.MainWindowTitle.ToString());
                    }
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (normalExit == false)
            {
                string application = String.Join(", ", appsUsed);
                timerIncomingRequest.Stop();
                dirClasses.Login logout = new dirClasses.Login();
                logout.endUserSession();
                logout.logoutLastUserLogin(lastEntryID, application, "Unexpected Shutdown");
                logout.disconnectThisMachine();
                Environment.Exit(0);
            }
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmMessages"];
            if (fc != null)
                fc.Close();

            new frmMessages().Show();
        }
    }
}
