using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class BackupRestore
    {
        public static BackupRestore mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public BackupRestore()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        internal bool applyFullSettings(string filename, string path, string day, DateTime time)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (hasSettingsApplied())
                    {
                        this.query = "TRUNCATE TABLE BackupRestoreSettings";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    this.query = "INSERT INTO BackupRestoreSettings (filename, path, day, time) VALUES (@filename, @path, @day, @time)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@filename", filename);
                        cmd.Parameters.AddWithValue("@path", path);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@time", time);
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

        public bool hasSettingsApplied()
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT * FROM BackupRestoreSettings";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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



        internal bool applyPartialSettings(string filename, string path)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (hasSettingsApplied())
                    {
                        this.query = "TRUNCATE TABLE BackupRestoreSettings";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    this.query = "INSERT INTO BackupRestoreSettings (filename, path) VALUES (@filename, @path)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@filename", filename);
                        cmd.Parameters.AddWithValue("@path", path);
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

        internal void logDatabaseAction(int action, int type)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO BackupRestoreLogs (action, actionDateTime, actionType) VALUES (@action, @actionDateTime, @actionType)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@actionDateTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@actionType", type);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
