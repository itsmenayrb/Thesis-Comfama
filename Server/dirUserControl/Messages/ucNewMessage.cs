using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.Messages
{
    public partial class ucNewMessage : UserControl
    {
        public static ucNewMessage mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private bool hasError = false;

        public ucNewMessage()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucNewMessage_Load(object sender, EventArgs e)
        {
            loadEmployees();
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            hasError = false;

            if (string.IsNullOrEmpty(cbEmployee.Text) || cbEmployee.Text == "--Select the name of the person--" || cbEmployee.SelectedIndex == -1)
            {
                hasError = true;
                MessageBox.Show("Please select the name of the employee.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEmployee.Focus();
                return;
            }
            else
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
                        string sendTo = cbEmployee.SelectedValue.ToString();
                        string message = txtMessage.Text;
                        string sendBy = dirClasses.Session.username;
                        Guid conversationID = Guid.NewGuid();

                        dirClasses.Message sendMessage = new dirClasses.Message();
                        Guid existingConversationID = sendMessage.checkConversationWithUserIfExist(sendTo, sendBy);

                        if (existingConversationID == Guid.Empty)
                        {
                            if (sendMessage.saveConversation(conversationID))
                            {
                                if (sendMessage.sendMessage(conversationID, sendBy, sendTo, message))
                                {
                                    frmMessages.mainInstance.loadLatestMessagesByUser();
                                    txtMessage.Text = "";
                                    txtMessage.Focus();
                                    cbEmployee.SelectedIndex = 0;
                                    frmMessages.mainInstance.Controls["panelContainer"].Controls["ucNewMessage1"].Visible = false;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (sendMessage.updateConversation(existingConversationID))
                            {
                                if (sendMessage.sendMessage(existingConversationID, sendBy, sendTo, message))
                                {
                                    frmMessages.mainInstance.loadLatestMessagesByUser();
                                    txtMessage.Text = "";
                                    txtMessage.Focus();
                                    cbEmployee.SelectedIndex = 0;
                                    frmMessages.mainInstance.Controls["panelContainer"].Controls["ucNewMessage1"].Visible = false;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void loadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT employeeID, CONCAT(firstName + ' ', lastName) as fullName FROM Employees ORDER BY fullName ASC";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(this.query, conn))
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select the name of the person--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbEmployee.DataSource = dt;
                            cbEmployee.DisplayMember = "fullName";
                            cbEmployee.ValueMember = "employeeID";

                            cbEmployee.SelectedIndex = 0;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message, "Messages");
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
    }
}
