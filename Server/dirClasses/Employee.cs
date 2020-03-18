using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Employee
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Employee()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool addEmployee(string employeeID, string firstName, string middleName, string lastName, int department, int position, byte[] byteImage)
        {
            try
            {
                if (checkExistingEmployeeID(employeeID))
                {
                    MessageBox.Show(employeeID + " is been using by another employee.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (insertPersonalDetails(employeeID, firstName, middleName, lastName, department, position, byteImage) && insertAccountDetails(employeeID))
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

        private bool insertPersonalDetails(string employeeID, string firstName, string middleName, string lastName, int department, int position, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO Employees (employeeID, firstName, middleName, lastName, department, position, profilePicture) VALUES (@employeeID, @firstName, @middleName, @lastName, @department, @position, @profilePicture)";
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
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private bool insertAccountDetails(string employeeID)
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
                        cmd.Parameters.AddWithValue("@username", employeeID);
                        cmd.Parameters.AddWithValue("@password", dirClasses.Configuration.HashPassword(password));
                        cmd.Parameters.AddWithValue("@userType", "Employee");
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

        private bool checkExistingEmployeeID(string employeeID)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT employeeID FROM Employees WHERE employeeID=@employeeID";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
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

        internal bool updateEmployee(int id, string employeeID, string firstName, string middleName, string lastName, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Employees SET employeeID=@employeeID, firstName=@firstName, middleName=@middleName, lastName=@lastName, profilePicture=@profilePicture WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
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

        internal bool updateEmployeeDepartment(int departmentID, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Employees SET department=@department WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@department", departmentID);
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

        internal bool updateEmployeePosition(int positionID, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Employees SET position=@position WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@position", positionID);
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

    class Department : Employee
    {
        internal bool addDepartment(string department)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingDepartment(department))
                    {
                        MessageBox.Show(department.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO Departments (department) VALUES (@department)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@department", department);
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

        private bool checkExistingDepartment(string department)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT department FROM Departments WHERE department=@department";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@department", department);
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

        internal bool updateDepartment(string department, int departmentID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingDepartment(department))
                    {
                        MessageBox.Show(department.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "UPDATE Departments SET department=@department WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", departmentID);
                            cmd.Parameters.AddWithValue("@department", department);
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

    class Position : Employee
    {
        internal bool addPosition(string position)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingPosition(position))
                    {
                        MessageBox.Show(position.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO Positions (position) VALUES (@position)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@position", position);
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

        private bool checkExistingPosition(string position)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT position FROM Positions WHERE position=@position";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@position", position);
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

        internal bool updatePosition(string position, int positionID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingPosition(position))
                    {
                        MessageBox.Show(position.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "UPDATE Positions SET position=@position WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", positionID);
                            cmd.Parameters.AddWithValue("@position", position);
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
