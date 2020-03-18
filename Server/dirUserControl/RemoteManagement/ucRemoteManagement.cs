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

namespace Server.dirUserControl.RemoteManagement
{
    public partial class ucRemoteManagement : UserControl
    {
        public static ucRemoteManagement mainInstance = null;

        PictureBox pb;
        Panel pnl;
        Label lbl;
        ToolTip tooltip;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        private string _ipAddress = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _machineName = string.Empty;

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
            loadRemoteManagementData();
        }

        public void loadRemoteManagementData()
        {
            SetDoubleBuffered(flpRemoteManagement);
            flpRemoteManagement.Controls.Clear();

            try
            {
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
                            pnl.Size = new System.Drawing.Size(150, 170);

                            pb = new PictureBox();
                            pb.Size = new Size(150, 150);
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
                                pb.Image = Image.FromStream(new MemoryStream((Byte[])reader["screenImage"]));
                            }
                            else
                            {
                                pb.Image = Resource1.offline_computer;
                            }

                            lbl = new Label();
                            lbl.Text = reader["machineName"].ToString();
                            lbl.AutoSize = false;
                            lbl.Dock = DockStyle.Fill;
                            lbl.Font = new System.Drawing.Font("Century Gothic", 9, FontStyle.Bold);
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

        private void loadSelectedMachineInformation(string machineName)
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
            dirOtherForms.RemoteManagement.FullControl.ipAddress = this._ipAddress;
            dirOtherForms.RemoteManagement.FullControl.username = this._username;
            dirOtherForms.RemoteManagement.FullControl.password = this._password;

            dirOtherForms.RemoteManagement.FullControl fullControl = new dirOtherForms.RemoteManagement.FullControl();

            fullControl.Text = "Session started: " + this._machineName + "(" + this._ipAddress + ")";
            fullControl.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
