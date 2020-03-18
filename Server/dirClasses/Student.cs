using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Server.dirClasses
{
    class Student
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Student()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool addStudent(string studentNumber, string firstName, string middleName, string lastName, int course, string yearLevel, string status, byte[] byteImage)
        {
            try
            {
                if (checkExistingStudentNumber(studentNumber))
                {
                    MessageBox.Show(studentNumber + " is been using by another student.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (insertPersonalDetails(studentNumber, firstName, middleName, lastName, course, yearLevel, status, byteImage) && insertAccountDetails(studentNumber))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        private bool insertPersonalDetails(string studentNumber, string firstName, string middleName, string lastName, int course, string yearLevel, string status, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO Students (studentNumber, firstName, middleName, lastName, course, yearLevel, status, profilePicture) VALUES (@studentNumber, @firstName, @middleName, @lastName, @course, @yearLevel, @status, @profilePicture)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@middleName", middleName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@course", course);
                        cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@profilePicture", byteImage);
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

        private bool insertAccountDetails(string studentNumber)
        {
            string password = "cvsuimus";
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO Accounts (username, password, userType, status, is_logged_in) VALUES (@username, @password, @userType, @status, @is_logged_in)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", studentNumber);
                        cmd.Parameters.AddWithValue("@password", dirClasses.Configuration.HashPassword(password));
                        cmd.Parameters.AddWithValue("@userType", "Student");
                        cmd.Parameters.AddWithValue("@status", 0);
                        cmd.Parameters.AddWithValue("@is_logged_in", 0);
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

        private bool checkExistingStudentNumber(string studentNumber)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT studentNumber FROM Students WHERE studentNumber=@studentNumber";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
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

        internal bool updateStudent(int id, string studentNumber, string firstName, string middleName, string lastName, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Students SET studentNumber=@studentNumber, firstName=@firstName, middleName=@middleName, lastName=@lastName, profilePicture=@profilePicture WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@middleName", middleName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@profilePicture", byteImage);
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

        internal bool updateStudentCourse(int courseID, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Students SET course=@course WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@course", courseID);
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

        internal bool updateStudentYearLevel(string yearLevel, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Students SET yearLevel=@yearLevel WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
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

        internal bool updateStudentStatus(string status, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Students SET status=@status WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@status", status);
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

    class Course : Student
    {
        internal bool addCourse(string course)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingCourse(course))
                    {
                        MessageBox.Show(course.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO Courses (course) VALUES (@course)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@course", course);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        private bool checkExistingCourse(string course)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT course FROM Courses WHERE course=@course";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@course", course);
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

        internal bool updateCourse(string course, int courseID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingCourse(course))
                    {
                        MessageBox.Show(course.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "UPDATE Courses SET course=@course WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", courseID);
                            cmd.Parameters.AddWithValue("@course", course);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }
}
