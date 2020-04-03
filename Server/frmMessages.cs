using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class frmMessages : Form
    {
        public static frmMessages mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        Panel pnl;
        Guna.UI.WinForms.GunaCirclePictureBox pb;
        Label lblName;
        Label lblEmployeeID;
        Label lblDate;

        Font read = new Font("Century Gothic", 9, FontStyle.Regular);
        Font unread = new Font("Century Gothic", 9, FontStyle.Bold);

        public frmMessages()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmMessages_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            loadLatestMessagesByUser();
        }

        public void loadLatestMessagesByUser()
        {
            flowLayoutPanel1.Controls.Clear();
            SetDoubleBuffered(flowLayoutPanel1);

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT m.conversationID as conversationID, e.employeeID as employeeID, concat(e.firstName + ' ', e.lastName) as fullName, MAX(m.dateSend) as dateSend, " +
                                 "CASE c.seenBySender WHEN 0 THEN 'Unread' ELSE 'Read' END as seenBySender, CASE c.seenByReceiver WHEN 0 THEN 'Unread' ELSE 'Read' END as seenByReceiver, CAST(e.profilePicture as varbinary(max)) as profilePicture, MAX(m.sendBy) as sendBy " +
                                 "FROM Employees e " +
                                 "INNER JOIN Messages m ON e.employeeID = m.receivedBy or e.employeeID = m.sendBy " +
                                 "INNER JOIN Conversation c ON m.conversationID = c.conversationID " +
                                 "WHERE (m.sendBy=@employeeID and m.receivedBy = e.employeeID) or (m.receivedBy=@employeeID and m.sendBy = e.employeeID) " +
                                 "GROUP BY e.employeeID, e.firstName, e.lastName, m.conversationID, c.seenBySender, c.seenByReceiver, CAST(e.profilePicture as varbinary(max)) " +
                                 "ORDER BY dateSend DESC";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@employeeID", dirClasses.Session.username);

                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            pnl = new Panel();
                            pnl.Size = new Size(307, 70);
                            pnl.BorderStyle = BorderStyle.None;
                            pnl.Margin = new Padding(0, 0, 0, 0);
                            pnl.Padding = new Padding(0, 0, 0, 0);
                            pnl.Name = reader["conversationID"].ToString();
                            pnl.Click += new System.EventHandler(this.pnl_Click);

                            pb = new Guna.UI.WinForms.GunaCirclePictureBox();
                            pb.Size = new Size(40, 40);
                            pb.BackColor = Color.Transparent;
                            pb.BaseColor = Color.Transparent;
                            pb.Location = new Point(18, 14);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Image = Image.FromStream(new MemoryStream((Byte[])reader["profilePicture"]));
                            pb.Name = reader["profilePicture"].ToString();

                            lblName = new Label();
                            lblName.Text = reader["fullName"].ToString();
                            lblName.ForeColor = Color.Black;
                            lblName.Location = new Point(72, 16);
                            lblName.Name = "lblFullName";

                            lblEmployeeID = new Label();
                            lblEmployeeID.Text = reader["employeeID"].ToString();
                            lblEmployeeID.ForeColor = Color.Black;
                            lblEmployeeID.Location = new Point(72, 32);
                            lblEmployeeID.Name = "lblEmployeeID";

                            lblDate = new Label();
                            lblDate.Text = Convert.ToDateTime(reader["dateSend"]).ToShortTimeString();
                            lblDate.ForeColor = Color.Black;
                            lblDate.Location = new Point(228, 27);
                            lblDate.Name = "lblDate";

                            if (reader["sendBy"].ToString() == dirClasses.Session.username && reader["seenByReceiver"].ToString() == "Unread")
                            {
                                lblName.Font = unread;
                                lblEmployeeID.Font = unread;
                                lblDate.Font = unread;
                            }
                            else if (reader["sendBy"].ToString() == dirClasses.Session.username && reader["seenByReceiver"].ToString() == "Read")
                            {
                                lblName.Font = read;
                                lblEmployeeID.Font = read;
                                lblDate.Font = read;
                            }
                            else if (reader["sendBy"].ToString() != dirClasses.Session.username && reader["seenBySender"].ToString() == "Unread")
                            {
                                lblName.Font = unread;
                                lblEmployeeID.Font = unread;
                                lblDate.Font = unread;
                            }
                            else if (reader["sendBy"].ToString() != dirClasses.Session.username && reader["seenBySender"].ToString() == "Read")
                            {
                                lblName.Font = read;
                                lblEmployeeID.Font = read;
                                lblDate.Font = read;
                            }


                            pnl.Controls.Add(pb);
                            pnl.Controls.Add(lblDate);
                            pnl.Controls.Add(lblEmployeeID);
                            pnl.Controls.Add(lblName);

                            flowLayoutPanel1.Controls.Add(pnl);
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load latest messages by user: " + ex.Message, "Messages");
            }
        }

        private bool hasSelected = false;
        private void pnl_Click(object sender, EventArgs e)
        {
            foreach (Panel a in flowLayoutPanel1.Controls)
            {
                a.BackColor = Color.WhiteSmoke;
            }

            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.FromArgb(231, 231, 231);
            string conversationID = pnl.Name;
            dirClasses.Message sendMessage = new dirClasses.Message();
            sendMessage.updateConversation(Guid.Parse(conversationID));

            dirUserControl.Messages.ucOldMessage.conversationID = conversationID;
            dirUserControl.Messages.ucOldMessage.mainInstance.fullName = pnl.Controls["lblFullName"].Text;
            dirUserControl.Messages.ucOldMessage.mainInstance.employeeID = pnl.Controls["lblEmployeeID"].Text;
            dirUserControl.Messages.ucOldMessage.mainInstance.loadConversation();
            dirUserControl.Messages.ucOldMessage.mainInstance.scrollDown();
            ucOldMessage1.startLoadingMessages();
            /* ucOldMessage1.loadConversation();
             ucOldMessage1.scrollDown();*/
            ucOldMessage1.Visible = true;

        }

        private void btnComposeMessage_Click(object sender, EventArgs e)
        {
            ucOldMessage1.Visible = false;
            ucNewMessage1.Visible = true;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                stopReceivingMessages();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                loadLatestMessagesByUser();
                startReceivingMessages();
            }
        }

        private void loadSearchedUSer(string text)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT m.conversationID as conversationID, e.employeeID as employeeID, concat(e.firstName + ' ', e.lastName) as fullName, MAX(m.dateSend) as dateSend,  " +
                                 "CASE c.seenBySender WHEN 0 THEN 'Unread' ELSE 'Read' END as seenBySender, CASE c.seenByReceiver WHEN 0 THEN 'Unread' ELSE 'Read' END as seenByReceiver, CAST(e.profilePicture as varbinary(max)) as profilePicture, MAX(m.sendBy) as sendBy " +
                                 "FROM Employees e " +
                                 "INNER JOIN Messages m ON e.employeeID = m.receivedBy or e.employeeID = m.sendBy " +
                                 "INNER JOIN Conversation c ON m.conversationID = c.conversationID " +
                                 "WHERE (e.firstName LIKE '" + text + "%' OR e.lastName LIKE '" + text + "%') AND (m.sendBy=@employeeID OR m.receivedBy=@employeeID) " +
                                 "GROUP BY e.employeeID, e.firstName, e.lastName, m.conversationID, c.seenBySender, c.seenByReceiver, CAST(e.profilePicture as varbinary(max)) " +
                                 "ORDER BY dateSend DESC";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@employeeID", dirClasses.Session.username);

                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            pnl = new Panel();
                            pnl.Size = new Size(307, 70);
                            pnl.BorderStyle = BorderStyle.None;
                            pnl.Margin = new Padding(0, 0, 0, 0);
                            pnl.Padding = new Padding(0, 0, 0, 0);
                            pnl.Name = reader["conversationID"].ToString();
                            pnl.Click += new System.EventHandler(this.pnl_Click);

                            pb = new Guna.UI.WinForms.GunaCirclePictureBox();
                            pb.Size = new Size(40, 40);
                            pb.BackColor = Color.Transparent;
                            pb.BaseColor = Color.Transparent;
                            pb.Location = new Point(18, 14);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Image = Image.FromStream(new MemoryStream((Byte[])reader["profilePicture"]));
                            pb.Name = reader["profilePicture"].ToString();

                            lblName = new Label();
                            lblName.Text = reader["fullName"].ToString();
                            lblName.ForeColor = Color.Black;
                            lblName.Location = new Point(72, 16);
                            lblName.Name = "lblFullName";

                            lblEmployeeID = new Label();
                            lblEmployeeID.Text = reader["employeeID"].ToString();
                            lblEmployeeID.ForeColor = Color.Black;
                            lblEmployeeID.Location = new Point(72, 32);
                            lblEmployeeID.Name = "lblEmployeeID";

                            lblDate = new Label();
                            lblDate.Text = Convert.ToDateTime(reader["dateSend"]).ToShortTimeString();
                            lblDate.ForeColor = Color.Black;
                            lblDate.Location = new Point(228, 27);
                            lblDate.Name = "lblDate";

                            if (reader["status"].ToString() == "Unread")
                            {
                                lblName.Font = unread;
                                lblEmployeeID.Font = unread;
                                lblDate.Font = unread;
                            }
                            else if (reader["status"].ToString() == "Read")
                            {
                                lblName.Font = read;
                                lblEmployeeID.Font = read;
                                lblDate.Font = read;
                            }


                            pnl.Controls.Add(pb);
                            pnl.Controls.Add(lblDate);
                            pnl.Controls.Add(lblEmployeeID);
                            pnl.Controls.Add(lblName);

                            flowLayoutPanel1.Controls.Add(pnl);
                        }

                    }
                        conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load search user: " + ex.Message, "Messages");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search" || !string.IsNullOrEmpty(txtSearch.Text))
            {
                string text = txtSearch.Text;
                loadSearchedUSer(text);
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

        private void timerUpcomingMessages_Tick(object sender, EventArgs e)
        {
            loadLatestMessagesByUser();
        }

        public void startReceivingMessages()
        {
            timerUpcomingMessages.Start();
        }

        public void stopReceivingMessages()
        {
            timerUpcomingMessages.Stop();
        }

        private void frmMessages_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopReceivingMessages();
            ucOldMessage1.stopLoadingMessages();
            frmMain.mainInstance.notifyMessages = true;
        }
    }
}
