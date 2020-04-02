using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class frmLogin : Form
    {
        public static frmLogin mainInstance = null;
        private bool hasError = false;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public frmLogin()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            new dirClasses.Configuration().displayCurrentAcademicYear();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtEmployeeID.Text) || txtEmployeeID.Text == "Employee ID")
            {
                hasError = true;
                MessageBox.Show("Please enter your Employee ID.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                {
                    hasError = true;
                    MessageBox.Show("Please enter your password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    if (hasError == false)
                    {
                        string username = txtEmployeeID.Text;
                        string password = txtPassword.Text;

                        dirClasses.Login login = new dirClasses.Login();
                        if (login.login(username, password))
                        {
                            if (login.isAccountActive(username, password))
                            {
                                logHistory();
                                startUserSession();
                                connectThisMachine();
                                new frmMain().Show();
                                this.Close();
                            }
                            else
                            {
                                frmActivateAccount.employeeID = username;
                                this.Close();
                                frmActivateAccount activate = new frmActivateAccount();
                                activate.Show();
                                activate.TopMost = true;
                                activate.txtbox.Focus();
                            }
                        }
                        else
                        {
                            txtPassword.Text = "";
                            txtPassword.Focus();
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEmployeeID_Enter(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "Employee ID")
            {
                txtEmployeeID.Text = "";
            }
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                txtEmployeeID.Text = "Employee ID";
            }
            else
            {
                txtEmployeeID.Text = txtEmployeeID.Text.ToUpper();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {
                if (checkIfHasAnAdminAccount() == false)
                {
                    this.Hide();
                    //new frmCreateAdministrator().Show();
                }
                else
                {
                    MessageBox.Show("Creating an account for the Super Administrator has been prohibited due to any of this reasons:\n\n1)There is an existing account for Super Administrator.\n2)Creating an account for Super Administrator has been disabled.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool checkIfHasAnAdminAccount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT COUNT(*) as isSuperAdmin FROM Accounts WHERE userType=@userType";

                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@userType", "Super Administrator");
                        int count = 0;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader["isSuperAdmin"].ToString());
                        }

                        if (count > 0)
                        {
                            return true;
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

        public void logHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    DateTime loginDate = DateTime.Now;
                    DateTime timeIn = DateTime.Now;
                    dirClasses.Login.timein = timeIn;

                    this.query = "INSERT INTO LoginHistory (academicYear, username, loginDate, startTime, location, machineName) VALUES (@academicYear, @username, @loginDate, @startTime, @location, @machineName)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                        cmd.Parameters.AddWithValue("@username", dirClasses.Session.username);
                        cmd.Parameters.AddWithValue("@loginDate", loginDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@startTime", timeIn.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@location", dirClasses.Session.location);
                        cmd.Parameters.AddWithValue("@machineName", dirClasses.Session.machineName);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Log History: " + ex.Message);
            }
        }

        public void startUserSession()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE Accounts SET last_logged_in=@last_logged_in, is_logged_in=@is_logged_in WHERE username=@username";
                    using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                    {
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("@username", dirClasses.Session.username);
                        cmd1.Parameters.AddWithValue("@last_logged_in", DateTime.Now);
                        cmd1.Parameters.AddWithValue("@is_logged_in", 1);
                        cmd1.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Start User Session: " + ex.Message);
            }
        }

        public void connectThisMachine()
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
                        cmd1.Parameters.AddWithValue("@status", "Connected");
                        cmd1.Parameters.AddWithValue("@currentUser", dirClasses.Session.firstName + " " + dirClasses.Session.lastName);
                        cmd1.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on connecting this machine: " + ex.Message);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Exit application?", "Comfama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
