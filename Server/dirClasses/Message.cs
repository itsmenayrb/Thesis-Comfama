using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Message
    {
        public static Message mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Message()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        internal Guid checkConversationWithUserIfExist(string sendTo, string sendBy)
        {
            Guid conversationID = Guid.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "SELECT conversationID FROM Messages WHERE (sendBy=@sendBy AND receivedBy=@sendTo) OR (sendBy=@sendTo AND receivedBy=@sendBy) OR (sendBy=@sendBy AND receivedBy=@sendBy)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@sendBy", sendBy);
                        cmd.Parameters.AddWithValue("@sendTo", sendTo);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            conversationID = (Guid)reader["conversationID"];
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on checking conversation: " + ex.Message);
            }
            return conversationID;
        }

        internal bool sendMessage(Guid conversationID, string sendBy, string sendTo, string message)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "INSERT INTO Messages (conversationID, sendBy, receivedBy, message, dateSend) VALUES (@conversationID, @sendBy, @receivedBy, @message, @dateSend)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@sendBy", sendBy);
                        cmd.Parameters.AddWithValue("@receivedBy", sendTo);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@dateSend", DateTime.Now);
                        cmd.Parameters.AddWithValue("@conversationID", conversationID);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending message: " + ex.Message);
                return false;
            }
        }

        internal bool saveConversation(Guid conversationID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "INSERT INTO Conversation (conversationID, seenBySender, seenByReceiver, dateSeenBySender) VALUES (@conversationID, @seenBySender, @seenByReceiver, @dateSeenBySender)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@conversationID", conversationID);
                        cmd.Parameters.AddWithValue("@seenBySender", 1);
                        cmd.Parameters.AddWithValue("@seenByReceiver", 0);
                        cmd.Parameters.AddWithValue("@dateSeenBySender", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on saving conversation: " + ex.Message);
                return false;
            }
        }

        internal bool updateConversation(Guid existingConversationID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "UPDATE Conversation SET seenBySender=@seenBySender, seenByReceiver=@seenByReceiver, dateSeenBySender=@dateSeenBySender WHERE conversationID=@conversationID";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@conversationID", existingConversationID);
                        cmd.Parameters.AddWithValue("@seenBySender", 1);
                        cmd.Parameters.AddWithValue("@seenByReceiver", 0);
                        cmd.Parameters.AddWithValue("@dateSeenBySender", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating conversation: " + ex.Message);
                return false;
            }
        }
    }
}
