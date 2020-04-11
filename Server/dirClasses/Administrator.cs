using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Administrator
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Administrator()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool addAdministrator(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO Accounts (username, password, userType, status, is_logged_in) VALUES (@username, @password, @userType, @status, @is_logged_in)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", dirClasses.Configuration.HashPassword(password));
                        cmd.Parameters.AddWithValue("@userType", "Super Administrator");
                        cmd.Parameters.AddWithValue("@status", 1);
                        cmd.Parameters.AddWithValue("@is_logged_in", 0);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
