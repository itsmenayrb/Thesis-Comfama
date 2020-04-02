using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class AuditTrail
    {
        public static AuditTrail mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public AuditTrail()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        internal void audit(string employeeID, string actionTaken, string oldValue, string newValue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "INSERT INTO AuditTrail (guid, employeeID, actionTaken, oldValue, newValue, dateCreated) VALUES (@guid, @employeeID, @actionTaken, @oldValue, @newValue, @dateCreated)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@guid", Guid.NewGuid());
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        cmd.Parameters.AddWithValue("@actionTaken", actionTaken);
                        cmd.Parameters.AddWithValue("@oldValue", oldValue);
                        cmd.Parameters.AddWithValue("@newValue", newValue);
                        cmd.Parameters.AddWithValue("@dateCreated", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on audit: " + ex.Message);
            }
        }
    }
}
