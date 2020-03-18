using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.UserManagement
{
    public partial class frmAddStudent : Form
    {
        public static frmAddStudent mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;
        private bool hasError = false;

        public frmAddStudent()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            loadCourseData();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void txtStudentNumber_Enter(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text == "Student Number")
            {
                txtStudentNumber.Text = "";
            }
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentNumber.Text))
            {
                txtStudentNumber.Text = "Student Number";
            }
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Text = "First Name";
            }
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == "Middle Name")
            {
                txtMiddleName.Text = "";
            }
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMiddleName.Text))
            {
                txtMiddleName.Text = "Middle Name";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Text = "Last Name";
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtStudentNumber.Text) || txtStudentNumber.Text == "Student Number")
            {
                hasError = true;
                MessageBox.Show("Please indicate the Student Number", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentNumber.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || txtFirstName.Text == "First Name")
                {
                    hasError = true;
                    MessageBox.Show("Please indicate the first name.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text == "Last Name")
                    {
                        hasError = true;
                        MessageBox.Show("Please indicate the last name.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLastName.Focus();
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbCourse.Text) || cbCourse.SelectedIndex == -1 || cbCourse.SelectedIndex == 0)
                        {
                            hasError = true;
                            MessageBox.Show("Please select the course of the student.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cbCourse.Focus();
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cbYearLevel.Text) || cbYearLevel.SelectedIndex == -1 || cbYearLevel.SelectedIndex == 0)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the year level of the student.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbYearLevel.Focus();
                                return;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cbStatus.Text) || cbStatus.SelectedIndex == -1 || cbStatus.SelectedIndex == 0)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please select the status of the student.", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbStatus.Focus();
                                    return;
                                }
                                else
                                {
                                    if (hasError == false)
                                    {
                                        string studentNumber = txtStudentNumber.Text;
                                        string firstName = txtFirstName.Text;
                                        string middleName = txtMiddleName.Text == "Middle Name" ? "" : txtMiddleName.Text;
                                        string lastName = txtLastName.Text;
                                        int course = Convert.ToInt32(cbCourse.SelectedValue);
                                        string yearLevel = cbYearLevel.Text;
                                        string status = cbStatus.Text;
                                        byte[] byteImage = dirClasses.Configuration.ConvertImageToByte(pbProfilePicture.Image, pbProfilePicture);

                                        dirClasses.Student addStudent = new dirClasses.Student();
                                        if (addStudent.addStudent(studentNumber, firstName, middleName, lastName, course, yearLevel, status, byteImage))
                                        {
                                            MessageBox.Show(firstName.ToUpper() + " " + lastName.ToUpper() + " has been added!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            dirUserControl.UserManagement.ucStudents.mainInstance.loadData();
                                            this.Close();
                                        }
                                        else
                                        {
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
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbProfilePicture.Image = Resource1.Portrait_Placeholder;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.Filter = "Image Files (*.jpg, *.JPG, *.png, *.PNG|*.jpg; *.JPG; *.png; *.PNG";
                openFileDialog.Multiselect = false;
                openFileDialog.ValidateNames = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbProfilePicture.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        public void loadCourseData()
        {
            try
            {
                this.query = "SELECT id, course FROM Courses";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(this.query, conn))
                    {
                        //Fill the DataTable with records from Table.
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        //Insert the Default Item to DataTable.
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "--Select Course--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbCourse.DataSource = dt;
                        cbCourse.DisplayMember = "course";
                        cbCourse.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Student");
            }

        }

        private void pbAddCourse_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddCourse.request = "add";
            new dirOtherForms.UserManagement.frmAddCourse().ShowDialog();
        }
    }
}
