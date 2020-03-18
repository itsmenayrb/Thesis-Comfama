using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.InventoryManagement
{
    public partial class frmAddSupplier : Form
    {
        public static frmAddSupplier mainInstance = null;
        private bool hasError = false;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public static string request { get; set; }

        public frmAddSupplier()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            txtSupplierCode.Text = generateRandomSupplierCode();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            loadBusinessType();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtSupplierID.Text == "Supplier ID" || string.IsNullOrEmpty(txtSupplierID.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the Supplier ID", "Inventory Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierID.Focus();
                return;
            }
            else
            {
                if (txtBusinessName.Text == "Company/Business Name" || string.IsNullOrEmpty(txtBusinessName.Text))
                {
                    hasError = true;
                    MessageBox.Show("Please indicate the Business or Company Name", "Inventory Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBusinessName.Focus();
                    return;
                }
                else
                {
                    if (cbBusinessType.SelectedIndex == -1 || string.IsNullOrEmpty(cbBusinessType.Text))
                    {
                        hasError = true;
                        MessageBox.Show("Please select the Business Type", "Inventory Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbBusinessType.Focus();
                        return;
                    }
                    else
                    {
                        if (txtAddress.Text == "Address" || string.IsNullOrEmpty(txtAddress.Text))
                        {
                            hasError = true;
                            MessageBox.Show("Please indicate the Business Address", "Inventory Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAddress.Focus();
                            return;
                        }
                        else
                        {
                            if (txtPhoneNumber.Text == "Phone Number" || string.IsNullOrEmpty(txtPhoneNumber.Text))
                            {
                                hasError = true;
                                MessageBox.Show("Please indicate the Business Phone Number", "Inventory Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPhoneNumber.Focus();
                                return;
                            }
                            else
                            {
                                if (hasError == false)
                                {
                                    string _supplierCode = txtSupplierCode.Text;
                                    string _supplierID = txtSupplierID.Text;
                                    string _businessName = txtBusinessName.Text;
                                    int _businessType = Convert.ToInt32(cbBusinessType.SelectedValue);
                                    string _businessAddress = txtAddress.Text;
                                    string _businessContactNumber = txtPhoneNumber.Text;
                                    string _contactPerson = txtContactPerson.Text != "Contact Person" ? txtContactPerson.Text : "";
                                    string _contactNumber = txtContactNumber.Text != "Contact Number" ? txtContactNumber.Text : "";

                                    dirClasses.Supplier addSupplier = new dirClasses.Supplier();
                                    if (addSupplier.addSupplier(_supplierCode, _supplierID, _businessName, _businessType, _businessAddress, _businessContactNumber, _contactPerson, _contactNumber))
                                    {
                                        MessageBox.Show(_businessName.ToUpper() + " has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dirUserControl.InventoryManagement.ucInventorySupplierList.mainInstance.loadData();
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

        private void txtSupplierID_Enter(object sender, EventArgs e)
        {
            if (txtSupplierID.Text == "Supplier ID")
            {
                txtSupplierID.Text = "";
            }
        }

        private void txtSupplierID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierID.Text))
            {
                txtSupplierID.Text = "Supplier ID";
            }
        }

        private void txtBusinessName_Enter(object sender, EventArgs e)
        {
            if (txtBusinessName.Text == "Company/Business Name")
            {
                txtBusinessName.Text = "";
            }
        }

        private void txtBusinessName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusinessName.Text))
            {
                txtBusinessName.Text = "Company/Business Name";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.Text = "Address";
            }
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone Number")
            {
                txtPhoneNumber.Text = "";
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                txtPhoneNumber.Text = "Phone Number";
            }
        }

        private void txtContactPerson_Enter(object sender, EventArgs e)
        {
            if (txtContactPerson.Text == "Contact Person")
            {
                txtContactPerson.Text = "";
            }
        }

        private void txtContactPerson_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactPerson.Text))
            {
                txtContactPerson.Text = "Contact Person";
            }
        }

        private void txtContactNumber_Enter(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "Contact Number")
            {
                txtContactNumber.Text = "";
            }
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                txtContactNumber.Text = "Contact Number";
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            txtSupplierCode.Text = generateRandomSupplierCode();
        }

        private void pbAddBusinessType_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddBusinessType.request = "add";
            new dirOtherForms.InventoryManagement.frmAddBusinessType().ShowDialog();
        }

        private string generateRandomSupplierCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var list = Enumerable.Repeat(0, 8).Select(x => chars[random.Next(chars.Length)]);
            return string.Join("", list);
        }

        public void loadBusinessType()
        {
            try
            {
                this.query = "SELECT id, businessType FROM InventoryBusinessTypes";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select Business Type--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbBusinessType.DataSource = dt;
                            cbBusinessType.DisplayMember = "businessType";
                            cbBusinessType.ValueMember = "id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory category: " + ex.Message, "Add Item");
            }
        }
    }
}
