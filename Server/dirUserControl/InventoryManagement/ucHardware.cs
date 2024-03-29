﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.InventoryManagement
{
    public partial class ucHardware : UserControl
    {
        public static ucHardware mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public static int inventoryType { get; set; }
        public static int category { get; set; }

        private bool hasError = false;

        public ucHardware()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucHardware_Load(object sender, EventArgs e)
        {
            loadCapacityData();
            loadSupplierData();
            loadUnitData();
            loadLocationData();

            dtpDateAcquired.MaxDate = DateTime.Today;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (inventoryType == 0)
            {
                MessageBox.Show("Please select the type of inventory of the item you want to add.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasError = true;
                return;
            }
            else
            {
                if (category == 0)
                {
                    MessageBox.Show("Please select the type of category of the item you want to add.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hasError = true;
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(cbSupplier.Text) || cbSupplier.SelectedIndex == -1 || cbSupplier.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please select the supplier of the item you want to add.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                        cbSupplier.Focus();
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtItem.Text))
                        {
                            MessageBox.Show("Please indicate the item name.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtItem.Focus();
                            hasError = true;
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtDescription.Text))
                            {
                                MessageBox.Show("Please indicate the description of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtDescription.Focus();
                                hasError = true;
                                return;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtBrand.Text))
                                {
                                    MessageBox.Show("Please indicate the brand of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtBrand.Focus();
                                    hasError = true;
                                    return;
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtModel.Text))
                                    {
                                        MessageBox.Show("Please indicate the model of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtModel.Focus();
                                        hasError = true;
                                        return;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(txtSerialNumber.Text))
                                        {
                                            MessageBox.Show("Please indicate the serial number of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtSerialNumber.Focus();
                                            hasError = true;
                                            return;
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(txtQuantity.Text))
                                            {
                                                MessageBox.Show("Please indicate the quantity of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtQuantity.Focus();
                                                hasError = true;
                                                return;
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(cbUnit.Text) || cbUnit.SelectedIndex == -1 || cbUnit.SelectedIndex == 0)
                                                {
                                                    MessageBox.Show("Please select the unit of quantity of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    cbUnit.Focus();
                                                    hasError = true;
                                                    return;
                                                }
                                                else
                                                {
                                                    if (chkCapacity.Checked)
                                                    {
                                                        if (string.IsNullOrEmpty(txtCapacity.Text) || string.IsNullOrEmpty(cbCapacity.Text) || cbCapacity.SelectedIndex == -1 || cbCapacity.SelectedIndex == 0)
                                                        {
                                                            MessageBox.Show("Please indicate the capacity and its size of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            txtCapacity.Focus();
                                                            hasError = true;
                                                            return;
                                                        }
                                                    }

                                                    if (string.IsNullOrEmpty(txtPropertyNumber.Text))
                                                    {
                                                        MessageBox.Show("Please indicate the property number of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        txtPropertyNumber.Focus();
                                                        hasError = true;
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        if (string.IsNullOrEmpty(cbLocation.Text) || cbLocation.SelectedIndex == -1 || cbLocation.SelectedIndex == 0)
                                                        {
                                                            MessageBox.Show("Please select the room/office/department where the item is located.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            cbLocation.Focus();
                                                            hasError = true;
                                                            return;
                                                        }
                                                        else
                                                        {
                                                            if (rdbCondemned.Checked == false && rdbDefective.Checked == false && rdbWorking.Checked == false)
                                                            {
                                                                MessageBox.Show("Please choose the current status of the item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                hasError = true;
                                                                return;
                                                            }
                                                            else
                                                            {
                                                                if (hasError == false)
                                                                {
                                                                    int supplier = Convert.ToInt32(cbSupplier.SelectedValue);
                                                                    string itemName = txtItem.Text;
                                                                    string description = txtDescription.Text;
                                                                    string brand = txtBrand.Text;
                                                                    string model = txtModel.Text;
                                                                    string serialNumber = txtSerialNumber.Text;

                                                                    int capacity = 0, capacityMeasurement = 0;
                                                                    if (chkCapacity.Checked)
                                                                    {
                                                                        capacity = Convert.ToInt32(txtCapacity.Text);
                                                                        capacityMeasurement = Convert.ToInt32(cbCapacity.SelectedValue);
                                                                    }
                                                                    int quantity = Convert.ToInt32(txtQuantity.Text);
                                                                    int unit = Convert.ToInt32(cbUnit.SelectedValue);
                                                                    string propertyNumber = txtPropertyNumber.Text;
                                                                    int location = Convert.ToInt32(cbLocation.SelectedValue);
                                                                    string dateAcquired = dtpDateAcquired.Value.ToString("yyyy-MM-dd");
                                                                    string status = string.Empty;

                                                                    foreach (Control c in gbStatus.Controls)
                                                                    {
                                                                        if (c.GetType() == typeof(Guna.UI.WinForms.GunaRadioButton))
                                                                        {
                                                                            Guna.UI.WinForms.GunaRadioButton rb = c as Guna.UI.WinForms.GunaRadioButton;
                                                                            if (rb.Checked)
                                                                            {
                                                                                status = rb.Text;
                                                                            }
                                                                        }
                                                                    }

                                                                    byte[] byteImage = dirClasses.Configuration.ConvertImageToByte(pbImage.Image, pbImage);

                                                                    dirClasses.Inventory addItem = new dirClasses.Inventory();
                                                                    if (addItem.addHardware(inventoryType, category, supplier, itemName, description, brand, model, serialNumber,
                                                                        capacity, capacityMeasurement, quantity, unit, propertyNumber, location, dateAcquired, status, byteImage))
                                                                    {
                                                                        MessageBox.Show("The " + itemName.ToUpper() + " has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        if (dirOtherForms.InventoryManagement.frmAddItems.request == "CameFromInventory")
                                                                        {
                                                                            dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemData();
                                                                            dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemCount();
                                                                        }
                                                                        else
                                                                        {
                                                                            dirOtherForms.MaintenanceReport.frmFeedback.mainInstance.loadPeripheralsForReplace(category);
                                                                        }
                                                                        new dirClasses.AuditTrail().audit(dirClasses.Session.username, "INSERT ITEM", " ", itemName);
                                                                        ((Form)this.TopLevelControl).Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("There is a problem on the server. Please try again later.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                        return;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("There is a problem on the server. Please try again later.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
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
            ((Form)this.TopLevelControl).Close();
        }

        public void loadSupplierData()
        {
            try
            {
                this.query = "SELECT id, businessName FROM InventorySuppliers";
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
                        row[1] = "--Select Supplier--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbSupplier.DataSource = dt;
                        cbSupplier.DisplayMember = "businessName";
                        cbSupplier.ValueMember = "id";

                        cbSupplier.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }
        }

        public void loadUnitData()
        {
            try
            {
                this.query = "SELECT id, unit FROM InventoryUnits";
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
                        row[1] = "--Select Unit--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbUnit.DataSource = dt;
                        cbUnit.DisplayMember = "unit";
                        cbUnit.ValueMember = "id";

                        cbUnit.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading unit: " + ex.Message, "Add Item");
            }
        }

        public void loadCapacityData()
        {
            try
            {
                this.query = "SELECT id, capacity FROM InventoryCapacities";
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
                        row[1] = "--Select Capacity Size--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbCapacity.DataSource = dt;
                        cbCapacity.DisplayMember = "capacity";
                        cbCapacity.ValueMember = "id";

                        cbCapacity.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading capacity: " + ex.Message, "Add Item");
            }
        }

        public void loadLocationData()
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
                        row[1] = "--Select Room/Office/Department--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbLocation.DataSource = dt;
                        cbLocation.DisplayMember = "department";
                        cbLocation.ValueMember = "id";

                        cbLocation.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading department: " + ex.Message, "Add Item");
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                int v = Convert.ToInt32(txtQuantity.Text);
                if (v <= 0)
                {
                    MessageBox.Show("Invalid quantity. Please try again.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Text = "";
                    txtQuantity.Focus();
                }
            }
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCapacity.Text))
            {
                int v = Convert.ToInt32(txtCapacity.Text);
                if (v <= 0)
                {
                    MessageBox.Show("Invalid size capacity. Please try again.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCapacity.Text = "";
                    txtCapacity.Focus();
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void chkCapacity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapacity.Checked)
            {
                txtCapacity.Enabled = true;
                cbCapacity.Enabled = true;
                btnAddCapacity.Enabled = true;
                txtCapacity.BaseColor = Color.FromArgb(249, 249, 249);
                cbCapacity.BaseColor = Color.FromArgb(249, 249, 249);
                txtCapacity.Focus();
            }
            else
            {
                txtCapacity.Enabled = false;
                btnAddCapacity.Enabled = false;
                txtCapacity.BaseColor = Color.FromArgb(196, 196, 196);
                cbCapacity.BaseColor = Color.FromArgb(196, 196, 196);
                cbCapacity.Enabled = false;
                txtQuantity.Focus();
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddSupplier.request = "add";
            new dirOtherForms.InventoryManagement.frmAddSupplier().ShowDialog();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddUnit.request = "add";
            new dirOtherForms.InventoryManagement.frmAddUnit().ShowDialog();
        }

        private void btnAddCapacity_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddCapacity.request = "add";
            new dirOtherForms.InventoryManagement.frmAddCapacity().ShowDialog();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddDepartment.request = "inventory";
            new dirOtherForms.UserManagement.frmAddDepartment().ShowDialog();
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
                    pbImage.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbImage.Image = Resource1.placeholder;
        }
    }
}
