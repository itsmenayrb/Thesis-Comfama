using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Server.dirUserControl.Messages
{
    public partial class ucOldMessage : UserControl
    {
        public static ucOldMessage mainInstance = null;
        public static string conversationID { get; set; }
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private bool hasError = false;

        public string fullName
        {
            set { lblName.Text = value; }
            get { return lblName.Text; }
        }

        public string employeeID
        {
            set { lblEmployeeID.Text = value; }
            get { return lblEmployeeID.Text; }
        }

        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        public int curtop = 5;
        ucBubble old_bubble = new ucBubble();

        public ucOldMessage()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
            mainInstance = this;

            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();

            old_bubble.Top = 0 - old_bubble.Height + 5;
            ucBubble1.Visible = false;
        }

        private void ucOldMessage_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Add);
        }

        public void addMessageReceived(string message, string time)
        {
            ucBubble bubble = new ucBubble(message, time, messageType.received);
            bubble.Anchor = ucBubble1.Anchor;
            bubble.Location = ucBubble1.Location;
            bubble.Size = ucBubble1.Size;
            bubble.Top = old_bubble.Bottom + 5;

            curtop = bubble.Bottom + 5;
            panelContainer.Controls.Add(bubble);

            panelContainer.VerticalScroll.Value = panelContainer.VerticalScroll.Maximum;

            old_bubble = bubble;
        }

        public void addMessageSent(string message, string time)
        {
            ucBubble bubble = new ucBubble(message, time, messageType.send);
            bubble.Anchor = ucBubble1.Anchor;
            bubble.Location = ucBubble1.Location;
            bubble.Size = ucBubble1.Size;
            bubble.Left += 344;
            bubble.Top = old_bubble.Bottom + 5;

            curtop = bubble.Bottom + 5;
            panelContainer.Controls.Add(bubble);

            old_bubble = bubble;
        }

        public void loadConversation()
        {
            panelContainer.Controls.Clear();
            old_bubble.Top = 0 - old_bubble.Height + 5;
            SetDoubleBuffered(panelContainer);

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT m.sendBy as sendBy, m.receivedBy as receivedBy, m.message as message, m.dateSend as dateSend " +
                                 "FROM Messages m " +
                                 "WHERE m.conversationID=@conversationID " +
                                 "ORDER BY dateSend ASC";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@conversationID", conversationID);
                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            string message = reader["message"].ToString();
                            string time = Convert.ToDateTime(reader["dateSend"]).ToShortTimeString();
                            string sendBy = reader["sendBy"].ToString();
                            string receivedBy = reader["receivedBy"].ToString();
                            string me = dirClasses.Session.username;

                            if (sendBy == me && receivedBy != me)
                            {
                                addMessageSent(message, time);
                            }
                            else if (sendBy != me && receivedBy == me)
                            {
                                addMessageReceived(message, time);
                            }
                            else if (sendBy == me && receivedBy == me)
                            {
                                addMessageSent(message, time);
                            }

                            scrollDown();
                        }
                        

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conversation: " + ex.Message, "Messages");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMessage.Text) || txtMessage.Text == "Type your message... (Press enter to send)")
            {
                hasError = true;
                MessageBox.Show("Please enter your message.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMessage.Focus();
                return;
            }
            else
            {
                if (hasError == false)
                {
                    string message = txtMessage.Text;
                    string sendTo = lblEmployeeID.Text;
                    string sendBy = dirClasses.Session.username;
                    Guid thisConversationID = Guid.Parse(conversationID);

                    dirClasses.Message sendMessage = new dirClasses.Message();
                    if (sendMessage.updateConversation(thisConversationID))
                    {
                        if (sendMessage.sendMessage(thisConversationID, sendBy, sendTo, message))
                        {
                            frmMessages.mainInstance.loadLatestMessagesByUser();
                            loadConversation();
                            scrollDown();
                            txtMessage.Text = "";
                            txtMessage.Focus();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
                    
        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            if (txtMessage.Text == "Type your message... (Press enter to send)")
            {
                txtMessage.Text = "";
            }
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                txtMessage.Text = "Type your message... (Press enter to send)";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSend.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void scrollDown()
        {
            panelContainer.VerticalScroll.Value = panelContainer.VerticalScroll.Maximum;
        }

        private void panelContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            panelContainer.ScrollControlIntoView(e.Control);
        }

        private void timerLoadThisMessages_Tick(object sender, EventArgs e)
        {
            loadConversation();
        }

        public void startLoadingMessages()
        {
            timerLoadThisMessages.Start();
        }

        public void stopLoadingMessages()
        {
            timerLoadThisMessages.Stop();
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

        private void panelContainer_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollProperties vs = panelContainer.VerticalScroll;
            if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
            {
                startLoadingMessages();
            }
            else
            {
                stopLoadingMessages();
            }
        }
    }
}
