using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using Zuby.ADGV;

namespace Server.dirUserControl.RemoteManagement
{
    public partial class ucRemoteManagement : UserControl
    {
        public static ucRemoteManagement mainInstance = null;

        PictureBox pb;
        Panel pnl;
        Label lbl;
        ToolTip tooltip;

        FlowLayoutPanel flpRemoteManagement = new FlowLayoutPanel();

        public string connectionString = string.Empty;
        public string query = string.Empty;

        private string _ipAddress = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _machineName = string.Empty;

        private int panelWidth = 250;
        private int panelHeight = 270;
        private int pictureBoxWidth = 250;
        private int pictureBoxHeight = 250;

        Font font = new Font("Century Gothic", 9, FontStyle.Bold);

        private bool list = false;

        public ucRemoteManagement()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucRemoteManagement_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            loadAllData();
        }

        public void StartServer()
        {
            timerLoadPC.Start();
        }

        public void StopServer()
        {
            timerLoadPC.Stop();
        }

        public void loadRemoteManagementData()
        {
            try
            {
                //foreach (Control control in gunaLinePanel4.Controls)
                //{
                //    if (control is UserControl)
                //    {
                //        gunaLinePanel4.Controls.Remove(control);
                //    }
                //}
                ucDetailedView1.Visible = false;
                
                flpRemoteManagement.Size = new Size(1321, 310);
                flpRemoteManagement.Location = new Point(22, 56);

                flpRemoteManagement.Controls.Clear();
                SetDoubleBuffered(flpRemoteManagement);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT * FROM RemotePC WHERE machineName!=@machineName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", Environment.MachineName.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pnl = new Panel();
                            pnl.Size = new System.Drawing.Size(panelWidth, panelHeight);

                            pb = new PictureBox();
                            pb.Size = new Size(pictureBoxWidth, pictureBoxHeight);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Dock = DockStyle.Top;
                            pb.Name = reader["machineName"].ToString();
                            pb.MouseDown += new MouseEventHandler(this.pb_MouseDown);

                            if (reader["status"].ToString() == "Idle")
                            {
                                pb.Image = Resource1.idle_computer;
                            }
                            else if (reader["status"].ToString() == "Connected")
                            {
                                pb.Image = switchEnableLiveView.Checked ? Image.FromStream(new MemoryStream((Byte[])reader["screenImage"])) : Resource1.online_computer;
                            }
                            else
                            {
                                pb.Image = Resource1.offline_computer;
                            }

                            lbl = new Label();
                            lbl.Text = reader["machineName"].ToString();
                            lbl.AutoSize = false;
                            lbl.Dock = DockStyle.Fill;
                            lbl.Font = font;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;

                            pnl.Controls.Add(lbl);
                            pnl.Controls.Add(pb);

                            tooltip = new ToolTip();
                            tooltip.AutoPopDelay = 5000;
                            tooltip.InitialDelay = 500;
                            tooltip.ReshowDelay = 500;
                            tooltip.SetToolTip(pb, "Machine name: " + reader["machineName"].ToString() + "\n" +
                                                    "Status: " + reader["status"].ToString() + "\n" +
                                                    "IP address: " + reader["ipAddress"].ToString() + "\n" +
                                                    "Port: " + reader["portNumber"].ToString() + "\n" +
                                                    "Mac address: " + reader["macAddress"].ToString() + "\n" +
                                                    "-\n" +
                                                    "Current User: " + reader["currentUser"].ToString() + "\n" +
                                                    "Room: " + reader["serverLocation"].ToString()
                                                    );

                            flpRemoteManagement.Controls.Add(pnl);
                        }
                    }
                    conn.Close();
                    gunaLinePanel4.Controls.Add(flpRemoteManagement);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading remote pc: " + ex.Message, "Remote Management");
            }
        }

        void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsRemoteManagement.Show(Cursor.Position);
                loadSelectedMachineInformation(pb.Name);
            }
        }

        public void loadSelectedMachineInformation(string machineName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT * FROM RemotePC WHERE machineName=@machineName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", machineName);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            this._ipAddress = reader["ipAddress"].ToString();
                            this._machineName = reader["machineName"].ToString();
                            this._username = reader["username"].ToString();
                            this._password = reader["password"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading selected remote pc: " + ex.Message, "Remote Management");
            }
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void fullControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performFullControl();
        }

        public void performFullControl()
        {
            dirOtherForms.RemoteManagement.FullControl.ipAddress = this._ipAddress;
            dirOtherForms.RemoteManagement.FullControl.username = this._username;
            dirOtherForms.RemoteManagement.FullControl.password = this._password;

            dirOtherForms.RemoteManagement.FullControl fullControl = new dirOtherForms.RemoteManagement.FullControl();

            fullControl.Text = "Session started: " + this._machineName + "(" + this._ipAddress + ")";
            fullControl.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performRestart();
        }

        public void performRestart()
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to restart " + _machineName + " PC?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var shutdown = new ProcessStartInfo("shutdown", " /r /m " + _ipAddress + " /c " + "\"The Administrator has initiated a remote restart on your computer. Your computer will restart after 30 seconds. Please save your work.\"" + " /t 30");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on restarting remote pc: " + ex.Message);
            }
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performShutdown();
        }

        public void performShutdown()
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to shutdown " + _machineName + " PC?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var shutdown = new ProcessStartInfo("shutdown", " /s /m " + _ipAddress + " /c " + "\"The Administrator has initiated a remote restart on your computer. Your computer will shutdown after 30 seconds. Please save your work.\"" + " /t 30");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on shutdown remote pc: " + ex.Message);
            }
        }

        private void timerLoadPC_Tick(object sender, EventArgs e)
        {
            if (list == true)
            {
                loadDetailView();
            }
            else
            {
                loadRemoteManagementData();
            }
        }

        private void btnLectureMode_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("You are about to facilitate a lecture. This means that your screen will display to all connected user. Proceed?", "Lecture Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                sendLectureModeRequest();
                dirOtherForms.RemoteManagement.LectureMode lectureMode = new dirOtherForms.RemoteManagement.LectureMode();
                lectureMode.ShowDialog();
            }
        }

        private void viewOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performViewOnly();
        }

        public void performViewOnly()
        {
            StopServer();
            dirOtherForms.RemoteManagement.ViewOnly view = new dirOtherForms.RemoteManagement.ViewOnly();
            view._machineName = this._machineName;
            view._inSession = this._machineName.ToUpper() + ": " + this._ipAddress;
            view.ShowDialog();
        }

        private void sendLectureModeRequest()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "UPDATE RemotePC SET inLectureMode=@inLectureMode WHERE remoteType!=@remoteType AND status=@status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@inLectureMode", "Requesting");
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending request for lecture mode: " + ex.Message, "Remote Management");
            }
        }

        private void btnSelectDisplay_Click(object sender, EventArgs e)
        {
            cmsSelectDisplay.Show(btnSelectDisplay, new Point(-115, btnSelectDisplay.Height + 5));
        }

        private void detailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchEnableLiveView.Enabled = false;
            list = true;
            detailViewToolStripMenuItem.Checked = true;
            smallIconToolStripMenuItem.Checked = false;
            mediumIconToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = false;
            loadDetailView();
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchEnableLiveView.Enabled = true;
            list = false;
            detailViewToolStripMenuItem.Checked = false;
            smallIconToolStripMenuItem.Checked = true;
            mediumIconToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = false;

            panelWidth = 70;
            panelHeight = 90;
            pictureBoxWidth = 70;
            pictureBoxHeight = 70;

            font = new Font("Century Gothic", 8, FontStyle.Regular);
            loadRemoteManagementData();
        }

        private void mediumIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchEnableLiveView.Enabled = true;
            list = false;
            detailViewToolStripMenuItem.Checked = false;
            smallIconToolStripMenuItem.Checked = false;
            mediumIconToolStripMenuItem.Checked = true;
            largeIconToolStripMenuItem.Checked = false;

            panelWidth = 150;
            panelHeight = 170;
            pictureBoxWidth = 150;
            pictureBoxHeight = 150;

            font = new Font("Century Gothic", 8, FontStyle.Bold);
            loadRemoteManagementData();
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchEnableLiveView.Enabled = true;
            list = false;
            detailViewToolStripMenuItem.Checked = false;
            smallIconToolStripMenuItem.Checked = false;
            mediumIconToolStripMenuItem.Checked = false;
            largeIconToolStripMenuItem.Checked = true;

            panelWidth = 250;
            panelHeight = 270;
            pictureBoxWidth = 250;
            pictureBoxHeight = 250;

            font = new Font("Century Gothic", 9, FontStyle.Bold);
            loadRemoteManagementData();
        }

        private void loadDetailView()
        {
            foreach (Control control in gunaLinePanel4.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    gunaLinePanel4.Controls.Remove(control);
                }
            }

            ucDetailedView1.Visible = true;
        }

        private void cbComputerCountByDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbComputerCountByDepartment.Text);
            loadComputerCountByDepartment(numberToDisplay);
        }

        private void cbMostReportedComputerUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToDisplay = Convert.ToInt32(cbMostReportedComputerUnit.Text);
            loadMostReportedComputerUnit(numberToDisplay);
        }

        private void loadMostReportedComputerUnit(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " machineName, reportCount " +
                             "FROM RemotePC " +
                             "WHERE reportCount is not null " +
                             "ORDER BY reportCount DESC";
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
                            dgvMostReportedComputerUnit.DataSource = dt;
                            dgvMostReportedComputerUnit.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading most reported unit: " + ex.Message, "Remote Management");
            }
        }

        public void loadComputerCountByDepartment(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " serverLocation, COUNT(*) as computerCount " +
                             "FROM RemotePC " +
                             "GROUP BY serverLocation " +
                             "ORDER BY computerCount DESC";
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
                            dgvComputerCountByDepartment.DataSource = dt;
                            dgvComputerCountByDepartment.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading computer per department: " + ex.Message, "Remote Management");
            }
        }

        public void loadPCCount()
        {
            try
            {
                this.query = "SELECT " +
                                "(SELECT COUNT(*) FROM RemotePC WHERE remoteType=@main OR remoteType=@sub) as serverCount, " +
                                "(SELECT COUNT(*) FROM RemotePC WHERE remoteType=@client) as clientCount";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@main", "Main Server");
                        cmd.Parameters.AddWithValue("@sub", "Sub Server");
                        cmd.Parameters.AddWithValue("@client", "Client");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblServerCount.Text = reader["serverCount"].ToString();
                            lblClientCount.Text = reader["clientCount"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading server and client count: " + ex.Message, "Remote Management");
            }
        }

        public void loadAllData()
        {
            loadPCCount();
            loadRemoteManagementData();
            loadComputerCountByDepartment(5);
            loadMostReportedComputerUnit(5);
        }

        private void switchEnableLiveView_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
