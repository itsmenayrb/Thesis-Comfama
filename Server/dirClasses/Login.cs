using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Login
    {
        public static Login mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public static DateTime timein { get; set; }

        public Login()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        internal bool login(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    password = dirClasses.Configuration.HashPassword(password);

                    this.query = "SELECT username, password, is_logged_in, userType FROM Accounts WHERE username=@username AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        int count = 0;
                        bool isLoggedIn = false;
                        string userType = string.Empty;

                        while (reader.Read())
                        {
                            count = count + 1;
                            isLoggedIn = Convert.ToBoolean(reader["is_logged_in"]);
                            userType = reader["userType"].ToString();
                        }

                        if (count == 1)
                        {
                            if (isLoggedIn == false)
                            {
                                dirClasses.Session.userType = userType;
                                dirClasses.Session.username = username;

                                if (userType == "Student" || userType == "Employee")
                                {
                                    MessageBox.Show("You do not have enough privelege to login with this account. Please try a different account.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    conn.Close();
                                    return false;
                                }
                                else if (userType == "Administrator")
                                {
                                    setEmployeeInformation(username);
                                }
                                else
                                {
                                    dirClasses.Session.firstName = "Super Administrator";
                                    dirClasses.Session.middleName = "";
                                    dirClasses.Session.lastName = "";
                                }

                                conn.Close();
                                return true;
                                
                            }
                            else
                            {
                                MessageBox.Show("Session has already been started with this account.\nIf you think this is a mistake, please inform your instructor or the administrator immediately.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                conn.Close();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return false;
        }

        private void setEmployeeInformation(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "SELECT * FROM Employees WHERE employeeID=@employeeID";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@employeeID", username);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dirClasses.Session.firstName = reader["firstName"].ToString();
                            dirClasses.Session.middleName = reader["middleName"].ToString();
                            dirClasses.Session.lastName = reader["lastName"].ToString();
                            dirClasses.Session.department = Convert.ToInt32(reader["department"].ToString());
                            dirClasses.Session.position = Convert.ToInt32(reader["position"].ToString());
                            dirClasses.Session.profilePicture = (Byte[])reader["profilePicture"];
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal bool isAccountActive(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    password = dirClasses.Configuration.HashPassword(password);

                    this.query = "SELECT username, password, status FROM Accounts WHERE username=@username AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        int count = 0;
                        bool status = false;

                        while (reader.Read())
                        {
                            count = count + 1;
                            status = Convert.ToBoolean(reader["status"]);
                        }

                        if (count == 1)
                        {
                            if (status == true)
                            {
                                conn.Close();
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Your account is currently in-active.\nTo continue, please set-up your new password.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                conn.Close();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Employee ID or Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public void endUserSession()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Accounts SET is_logged_in=@is_logged_in WHERE username=@username";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@username", dirClasses.Session.username);
                        cmd1.Parameters.AddWithValue("@is_logged_in", 0);
                        cmd1.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on end user session: " + ex.Message);
            }
        }

        public void logoutLastUserLogin(int id)
        {
            DateTime logout = DateTime.Now;
            TimeSpan timeDiff = DateTime.Parse(logout.ToString("HH:mm:ss")).Subtract(DateTime.Parse(timein.ToString("HH:mm:ss")));
            string duration = timeDiff.Hours.ToString("00") + " hour/s and " + timeDiff.Minutes.ToString("00") + " minute/s";

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE LoginHistory SET endTime=@endTime, duration=@duration, remarks=@remarks WHERE id=@id";

                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@endTime", logout.ToString("HH:mm:ss"));
                        cmd1.Parameters.AddWithValue("@duration", duration);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.Parameters.AddWithValue("@remarks", "Normal");
                        cmd1.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logout last user login: " + ex.Message);
            }
        }

        public void disconnectThisMachine()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE RemotePC SET status=@status, currentUser=@currentUser WHERE machineName=@machineName";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@machineName", dirClasses.Session.machineName);
                        cmd1.Parameters.AddWithValue("@status", "Idle");
                        cmd1.Parameters.AddWithValue("@currentUser", DBNull.Value);
                        cmd1.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on disconnecting this machine: " + ex.Message);
            }
        }
    }
}
