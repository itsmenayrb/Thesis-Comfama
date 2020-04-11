using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Server.dirClasses
{
    class Profile
    {
        public static Profile mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Profile()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        internal bool updateProfile(string employeeID, string firstName, string middleName, string lastName, int department, int position, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Employees SET employeeID=@employeeID, firstName=@firstName, middleName=@middleName, lastName=@lastName, department=@department, position=@position, profilePicture=@profilePicture WHERE employeeID=@employeeID";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@middleName", middleName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@profilePicture", byteImage);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                    new Login().setEmployeeInformation(employeeID);
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
