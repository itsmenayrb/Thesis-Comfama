using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Configuration
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Configuration()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool saveConfiguration(string _machineName, string _personalKey, string _serverType, string _location, string _ipAddress, int _port, string _macAddress, string _username, string _password, string _status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "INSERT INTO RemotePC (machineName, personalKey, remoteType, serverLocation, ipAddress, portNumber, macAddress, username, password, status, inSession) VALUES (@machineName, @personalKey, @serverType, @serverLocation, @ipAddress, @portNumber, @macAddress, @username, @password, @status, @inSession)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", _machineName);
                        cmd.Parameters.AddWithValue("@personalKey", _personalKey);
                        cmd.Parameters.AddWithValue("@serverType", _serverType);
                        cmd.Parameters.AddWithValue("@serverLocation", _location);
                        cmd.Parameters.AddWithValue("@ipAddress", _ipAddress);
                        cmd.Parameters.AddWithValue("@portNumber", _port);
                        cmd.Parameters.AddWithValue("@macAddress", _macAddress);
                        cmd.Parameters.AddWithValue("@username", _username);
                        cmd.Parameters.AddWithValue("@password", _password);
                        cmd.Parameters.AddWithValue("@status", _status);
                        cmd.Parameters.AddWithValue("@inSession", 0);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        public static byte[] ConvertImageToByte(Image img, PictureBox profilePicture)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (profilePicture.Image != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }

        public static string HashPassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        public static void PlayNotificationSound(string sound)
        {
            var soundsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds");
            var soundFile = Path.Combine(soundsFolder, sound + ".wav");

            using (var player = new System.Media.SoundPlayer(soundFile))
            {
                player.Play();
            }
        }

        public bool isInstalled(string _machineName)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT machineName FROM RemotePC WHERE machineName=@machineName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", _machineName);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                conn.Close();
                                return true;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        public void displayCurrentAcademicYear()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id, semester, academicYear FROM AcademicYear WHERE status=@status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@status", 1);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Session.academicYearID = Convert.ToInt32(reader["id"]);
                            Session.semester = reader["semester"].ToString();
                            Session.academicYear = reader["academicYear"].ToString();
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

        public void displayMachineInformation()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT * FROM RemotePC WHERE machineName=@machineName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", Environment.MachineName.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Session.machineName = reader["machineName"].ToString();
                            Session.remoteType = reader["remoteType"].ToString();
                            Session.machineStatus = reader["status"].ToString();
                            Session.location = reader["serverLocation"].ToString();
                            Session.ipAddress = reader["ipAddress"].ToString();
                            Session.portNumber = Convert.ToInt32(reader["portNumber"]);
                            Session.macAddress = reader["macAddress"].ToString();
                            Session.machineUsername = reader["username"].ToString();
                            Session.machinePassword = reader["password"].ToString();
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

        public static byte[] ConvertScreenCaptureToByte(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }
    }
}
