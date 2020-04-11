using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Server.dirUserControl.Profile
{
    public partial class ucPersonalInformation : UserControl
    {
        public static ucPersonalInformation mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;
        private bool hasError = false;

        public ucPersonalInformation()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucPersonalInformation_Load(object sender, EventArgs e)
        {
            
        }

        public void loadPersonalData()
        {
            pbProfilePicture.Image = Image.FromStream(new MemoryStream((Byte[])dirClasses.Session.profilePicture));
            txtFirstName.Text = dirClasses.Session.firstName;
            txtMiddleName.Text = dirClasses.Session.middleName;
            txtLastName.Text = dirClasses.Session.lastName;
            loadDepartment();
            loadPosition();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtFirstName.Text) || txtFirstName.Text == "First Name")
            {
                hasError = true;
                MessageBox.Show("Please indicate your first name.", "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text == "Last Name")
                {
                    hasError = true;
                    MessageBox.Show("Please indicate your last name.", "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(cbDepartment.Text) || cbDepartment.SelectedIndex == -1 || cbDepartment.SelectedIndex == 0)
                    {
                        hasError = true;
                        MessageBox.Show("Please select your department.", "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbDepartment.Focus();
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbPosition.Text) || cbPosition.SelectedIndex == -1 || cbPosition.SelectedIndex == 0)
                        {
                            hasError = true;
                            MessageBox.Show("Please select your position.", "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cbPosition.Focus();
                            return;
                        }
                        else
                        {
                            if (hasError == false)
                            {
                                string employeeID = dirClasses.Session.username;
                                string firstName = txtFirstName.Text;
                                string middleName = txtMiddleName.Text == "Middle Name" ? "" : txtMiddleName.Text;
                                string lastName = txtLastName.Text;
                                int department = Convert.ToInt32(cbDepartment.SelectedValue);
                                int position = Convert.ToInt32(cbPosition.SelectedValue);
                                byte[] byteImage = dirClasses.Configuration.ConvertImageToByte(pbProfilePicture.Image, pbProfilePicture);

                                dirClasses.Profile updateProfile = new dirClasses.Profile();
                                if (updateProfile.updateProfile(employeeID, firstName, middleName, lastName, department, position, byteImage))
                                {
                                    MessageBox.Show("Your profile has been updated", "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadPersonalData();
                                    frmMain.mainInstance.loadPersonalData();
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

        private void loadDepartment()
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

                        cbDepartment.SelectedIndex = cbDepartment.FindStringExact(dirClasses.Session.department);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading department: " + ex.Message, "Personal Information");
            }
        }

        private void loadPosition()
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

                        cbPosition.SelectedIndex = cbPosition.FindStringExact(dirClasses.Session.position);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading position: " + ex.Message, "Personal Information");
            }
        }
    }
}
