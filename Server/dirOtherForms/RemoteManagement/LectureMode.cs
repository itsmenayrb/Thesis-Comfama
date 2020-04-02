using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.RemoteManagement
{
    public partial class LectureMode : Form
    {
        public static LectureMode mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;


        public LectureMode()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void LectureMode_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            startLoadingClient();
        }

        private void timerWaitingToClientToAccept_Tick(object sender, EventArgs e)
        {
            loadAllClientThatSendedRequest();
        }

        public void startLoadingClient()
        {
            timerWaitingToClientToAccept.Start();
        }

        public void stopLoadingClient()
        {
            timerWaitingToClientToAccept.Stop();
        }

        private void loadAllClientThatSendedRequest()
        {
            
            SetDoubleBuffered(clbClient);

            try
            {
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT machineName, currentUser, ipAddress, inLectureMode FROM RemotePC WHERE remoteType!=@remoteType";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            clbClient.Items.Clear();
                            if (reader["inLectureMode"].ToString() == "Requesting")
                            {
                                this.clbClient.Items.Add(reader["machineName"].ToString() + "(" + reader["currentUser"].ToString() + ")", false);
                            }

                            if (reader["inLectureMode"].ToString() == "Accepted")
                            {
                                this.clbClient.Items.Add(reader["machineName"].ToString() + "(" + reader["currentUser"].ToString() + ")", true);
                                if (clbClient.CheckedItems.Count == getClientCount())
                                {
                                    timerWaitingToClientToAccept.Stop();
                                    btnStart.Enabled = true;
                                    break;
                                }
                            }
                            
                        }

                        
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending request for lecture mode: " + ex.Message, "Remote Management");
            }
        }

        private int getClientCount()
        {
            int count = 0;

            try
            {
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT COUNT(*) as rc FROM RemotePC WHERE remoteType!=@remoteType";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader["rc"]);
                        }
                    }
                    conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending request for lecture mode: " + ex.Message, "Remote Management");
            }

            return count;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timerWaitingToClientToAccept.Stop();
            DialogResult res = MessageBox.Show("Cancel lecture mode?", "Lecture Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                cancelLectureModeRequest();
                this.Close();
            }
            else
            {
                timerWaitingToClientToAccept.Start();
            }
        }

        private void cancelLectureModeRequest()
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
                        cmd.Parameters.AddWithValue("@inLectureMode", DBNull.Value);
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on cancelling request for lecture mode: " + ex.Message, "Remote Management");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnForceStart.Enabled = false;
            startLectureModeSession();
            new frmMain().startScreenCast();
            this.Hide();
            new dirOtherForms.RemoteManagement.LectureModePlayer().Show();
        }

        private void startLectureModeSession()
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
                        cmd.Parameters.AddWithValue("@inLectureMode", "inSession");
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on session for lecture mode: " + ex.Message, "Remote Management");
            }
        }

        public void endLectureModeSession()
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
                        cmd.Parameters.AddWithValue("@inLectureMode", "Stopped");
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");
                        cmd.Parameters.AddWithValue("@status", "Connected");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on ending session for lecture mode: " + ex.Message, "Remote Management");
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

        public void dispose()
        {
            if (!this.Visible)
            {
                this.Close();
            }
        }
    }
}
