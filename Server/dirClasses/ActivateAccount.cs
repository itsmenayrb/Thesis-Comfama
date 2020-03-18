using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class ActivateAccount
    {
        public static ActivateAccount mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ActivateAccount()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        internal bool activateAccount(string employeeID, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    password = dirClasses.Configuration.HashPassword(password);

                    this.query = "UPDATE Accounts SET password=@password, status=@status WHERE username=@studentNumber";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@studentNumber", employeeID);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@status", 1);
                        cmd.ExecuteNonQuery();
                        
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
