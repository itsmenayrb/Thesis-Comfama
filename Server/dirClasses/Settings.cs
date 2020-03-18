using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Settings
    {
        public static Settings mainInstance = null;

        public string connectionString = string.Empty;
        public string query = string.Empty;

        public static DateTime timein { get; set; }

        public Settings()
        {
            mainInstance = this;
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }
    }

    class AcademicYear : Settings
    {
        internal bool addAcademicYear(string semester, string academicYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    if (checkExistingAcademicYear(semester, academicYear))
                    {
                        MessageBox.Show("The " + semester + " of Academic Year " + academicYear + " is already added", "Add Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO AcademicYear (semester, academicYear, status, hasBeenSet) VALUES (@semester, @academicYear, @status, @hasBeenSet)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.AddWithValue("@semester", semester);
                            cmd.Parameters.AddWithValue("@academicYear", academicYear);
                            cmd.Parameters.AddWithValue("@status", 0);
                            cmd.Parameters.AddWithValue("@hasBeenSet", 0);
                            cmd.ExecuteNonQuery();
                        }
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

        private bool checkExistingAcademicYear(string semester, string academicYear)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT semester, academicYear FROM AcademicYear WHERE semester=@semester AND academicYear=@academicYear";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@academicYear", academicYear);
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
        }

        internal bool checkIfAcademicYearHasBeenSet(int academicYearID)
        {
            bool hasBeenSet = false;
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                this.query = "SELECT hasBeenSet FROM AcademicYear WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", academicYearID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        hasBeenSet = Convert.ToBoolean(reader["hasBeenSet"]);
                    }

                    if (hasBeenSet == true)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
        }

        internal bool setAcademicYear(int academicYearID)
        {
            try
            {
                setInactiveForAllAcademicYear();
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE AcademicYear SET status=@status, hasBeenSet=@hasBeenSet WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", academicYearID);
                        cmd.Parameters.AddWithValue("@status", 1);
                        cmd.Parameters.AddWithValue("@hasBeenSet", 1);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    dirClasses.Session.academicYearID = academicYearID;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Academic Year");
                return false;
            }
        }

        private void setInactiveForAllAcademicYear()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                this.query = "UPDATE AcademicYear SET status=@status";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", 0);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
