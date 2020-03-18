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
    public partial class frmAddEmployee : Form
    {
        public static frmAddEmployee mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private bool hasError = false;

        public frmAddEmployee()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            loadDepartmentData();
            loadPositionData();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void loadDepartmentData()
        {
            try
            {
                this.query = "SELECT id, department FROM Departments";
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
                        row[1] = "--Select Department--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbDepartment.DataSource = dt;
                        cbDepartment.DisplayMember = "department";
                        cbDepartment.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Employee");
            }
            
        }

        public void loadPositionData()
        {
            try
            {
                this.query = "SELECT id, position FROM Positions";
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
                        row[1] = "--Select Position--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbPosition.DataSource = dt;
                        cbPosition.DisplayMember = "position";
                        cbPosition.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Employee");
            }

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

        private void pbAddDepartment_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddDepartment.request = "add";
            new frmAddDepartment().ShowDialog();
        }

        private void pbAddPosition_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddPosition.request = "add";
            new frmAddPosition().ShowDialog();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbProfilePicture.Image = Resource1.Portrait_Placeholder;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtEmployeeID.Text) || txtEmployeeID.Text == "Employee ID")
            {
                hasError = true;
                MessageBox.Show("Please indicate the Employee ID", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || txtFirstName.Text == "First Name")
                {
                    hasError = true;
                    MessageBox.Show("Please indicate the first name.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text == "Last Name")
                    {
                        hasError = true;
                        MessageBox.Show("Please indicate the last name.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLastName.Focus();
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbDepartment.Text) || cbDepartment.SelectedIndex == -1 || cbDepartment.SelectedIndex == 0)
                        {
                            hasError = true;
                            MessageBox.Show("Please select the department of the employee.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cbDepartment.Focus();
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cbPosition.Text) || cbPosition.SelectedIndex == -1 || cbPosition.SelectedIndex == 0)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the position of the employee.", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbPosition.Focus();
                                return;
                            }
                            else
                            {
                                if (hasError == false)
                                {
                                    string employeeID = txtEmployeeID.Text;
                                    string firstName = txtFirstName.Text;
                                    string middleName = txtMiddleName.Text == "Middle Name" ? "" : txtMiddleName.Text;
                                    string lastName = txtLastName.Text;
                                    int department = Convert.ToInt32(cbDepartment.SelectedValue);
                                    int position = Convert.ToInt32(cbPosition.SelectedValue);
                                    byte[] byteImage = dirClasses.Configuration.ConvertImageToByte(pbProfilePicture.Image, pbProfilePicture);

                                    dirClasses.Employee addEmployee = new dirClasses.Employee();
                                    if (addEmployee.addEmployee(employeeID, firstName, middleName, lastName, department, position, byteImage))
                                    {
                                        MessageBox.Show(firstName.ToUpper() + " " + lastName.ToUpper() + " has been added!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dirUserControl.UserManagement.ucEmployees.mainInstance.loadData();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
