using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.InventoryManagement
{
    public partial class frmViewItem : Form
    {
        public static int inventoryItemID { get; set; }
        private bool hasError = false;

        public static frmViewItem mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private static int inventoryTypeID { get; set; }
        private static int inventoryCategoryID { get; set; }
        private static int supplierID { get; set; }
        private static int inventoryUnitID { get; set; }
        private static int inventoryCapacityID { get; set; }
        private static int departmentID { get; set; }

        private static string inventoryCategory { get; set; }

        public frmViewItem()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmViewItem_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            cbInventoryType.BaseColor = cbInventoryType.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbInventoryCategory.BaseColor = cbInventoryCategory.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbSupplier.BaseColor = cbSupplier.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtItem.BaseColor = txtItem.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtDescription.BaseColor = txtDescription.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtBrand.BaseColor = txtBrand.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtModel.BaseColor = txtModel.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtSerialNumber.BaseColor = txtSerialNumber.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtQuantity.BaseColor = txtQuantity.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbUnit.BaseColor = cbUnit.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtCapacity.BaseColor = txtCapacity.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbCapacity.BaseColor = cbCapacity.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtPropertyNumber.BaseColor = txtPropertyNumber.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbLocation.BaseColor = cbLocation.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtLicenseKey.BaseColor = txtLicenseKey.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            dtpDateAcquired.BaseColor = dtpDateAcquired.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            dtpDateExpiry.BaseColor = dtpDateExpiry.Enabled == false ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;

            loadItemData();
            loadUnitData();
            loadSupplierData();
            loadLocationData();
            loadInventoryType();
            loadCapacityData();
            loadCategories();

            if (cbInventoryType.Text != "Software")
            {
                if (dtpDateExpiry.Value == DateTime.Now)
                {
                    dtpDateExpiry.Format = DateTimePickerFormat.Custom;
                    dtpDateExpiry.CustomFormat = " ";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (cbInventoryType.Text == "Software")
            {
                if (string.IsNullOrEmpty(txtLicenseKey.Text))
                {
                    MessageBox.Show("Please indicate the license key of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSerialNumber.Focus();
                    hasError = true;
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtSerialNumber.Text))
                {
                    MessageBox.Show("Please indicate the serial number of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSerialNumber.Focus();
                    hasError = true;
                    return;
                }
            }

            if (string.IsNullOrEmpty(cbInventoryCategory.Text) || cbInventoryCategory.SelectedIndex == 0 || cbInventoryCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category for this item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasError = true;
                cbInventoryCategory.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(cbSupplier.Text) || cbSupplier.SelectedIndex == -1 || cbSupplier.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select the supplier of the item you want to add.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hasError = true;
                    cbSupplier.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtItem.Text))
                    {
                        MessageBox.Show("Please indicate the item name.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtItem.Focus();
                        hasError = true;
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtDescription.Text))
                        {
                            MessageBox.Show("Please indicate the description of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDescription.Focus();
                            hasError = true;
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtBrand.Text))
                            {
                                MessageBox.Show("Please indicate the brand of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBrand.Focus();
                                hasError = true;
                                return;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtModel.Text))
                                {
                                    MessageBox.Show("Please indicate the model of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtModel.Focus();
                                    hasError = true;
                                    return;
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtQuantity.Text))
                                    {
                                        MessageBox.Show("Please indicate the quantity of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtQuantity.Focus();
                                        hasError = true;
                                        return;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(cbUnit.Text) || cbUnit.SelectedIndex == -1 || cbUnit.SelectedIndex == 0)
                                        {
                                            MessageBox.Show("Please select the unit of quantity of the item.", "Updating Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            cbUnit.Focus();
                                            hasError = true;
                                            return;
                                        }
                                        else
                                        {
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
                                                            int itID = Convert.ToInt32(cbInventoryType.SelectedValue);
                                                            int icID = Convert.ToInt32(cbInventoryCategory.SelectedValue);
                                                            int supplier = Convert.ToInt32(cbSupplier.SelectedValue);
                                                            string itemName = txtItem.Text;
                                                            string description = txtDescription.Text;
                                                            string brand = txtBrand.Text;
                                                            string model = txtModel.Text;
                                                            string serialNumber = txtSerialNumber.Text;

                                                            int capacity = string.IsNullOrEmpty(txtCapacity.Text) ? 0 : Convert.ToInt32(txtCapacity.Text);
                                                            int capacityMeasurement = Convert.ToInt32(cbCapacity.SelectedValue);
                                                            
                                                            int quantity = Convert.ToInt32(txtQuantity.Text);
                                                            int unit = Convert.ToInt32(cbUnit.SelectedValue);
                                                            string propertyNumber = txtPropertyNumber.Text;
                                                            int location = Convert.ToInt32(cbLocation.SelectedValue);

                                                            string dateAcquired = dtpDateAcquired.Value.ToString("yyyy-MM-dd");
                                                            string dateExpire = dtpDateExpiry.Value.ToString("yyyy-MM-dd");

                                                            string status = string.Empty;

                                                            string licenseKey = txtLicenseKey.Text;

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
                                                            dirClasses.Inventory updateItem = new dirClasses.Inventory();
                                                            if (cbInventoryType.Text == "Software")
                                                            {
                                                                if (updateItem.updateSoftware(inventoryItemID, itID, icID, supplier, itemName, description, brand, model, licenseKey, quantity, unit, propertyNumber, location, dateAcquired, dateExpire, status, byteImage))
                                                                {
                                                                    MessageBox.Show("The " + itemName.ToUpper() + " has been updated!", "Update Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemData();
                                                                    this.Close();
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("There is a problem on the server. Please try again later.", "Update Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (updateItem.updateHardware(inventoryItemID,itID, icID, supplier, itemName, description, brand, model, serialNumber,
                                                                        capacity, capacityMeasurement, quantity, unit, propertyNumber, location, dateAcquired, status, byteImage))
                                                                {
                                                                    MessageBox.Show("The " + itemName.ToUpper() + " has been updated!", "Update Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemData();
                                                                    this.Close();
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("There is a problem on the server. Please try again later.", "Update Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("There is a problem on the server. Please try again later.", "Update Inventory Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnUpdateThisItem_Click(object sender, EventArgs e)
        {

            //cbInventoryType.BaseColor = cbInventoryType.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;

            cbInventoryCategory.BaseColor = cbInventoryCategory.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbSupplier.BaseColor = cbSupplier.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;

            txtItem.BaseColor = txtItem.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtDescription.BaseColor = txtDescription.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtBrand.BaseColor = txtBrand.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            txtModel.BaseColor = txtModel.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            
            txtQuantity.BaseColor = txtQuantity.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbUnit.BaseColor = cbUnit.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            
            txtPropertyNumber.BaseColor = txtPropertyNumber.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            cbLocation.BaseColor = cbLocation.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            
            dtpDateAcquired.BaseColor = dtpDateAcquired.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
            

            if (cbInventoryType.Text == "Software")
            {

                dtpDateExpiry.BaseColor = dtpDateExpiry.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
                txtLicenseKey.BaseColor = txtLicenseKey.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;

                dtpDateExpiry.Enabled = true;
                txtLicenseKey.Enabled = true;
            }
            else
            {

                txtSerialNumber.BaseColor = txtSerialNumber.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
                txtCapacity.BaseColor = txtCapacity.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;
                cbCapacity.BaseColor = cbCapacity.Enabled == true ? Color.FromArgb(164, 164, 164) : Color.WhiteSmoke;

                txtSerialNumber.Enabled = true;
                txtCapacity.Enabled = true;
                cbCapacity.Enabled = true;
            }

            //cbInventoryType.Enabled = true;

            cbInventoryCategory.Enabled = true;
            cbSupplier.Enabled = true;

            txtItem.Enabled = true;
            txtDescription.Enabled = true;
            txtBrand.Enabled = true;
            txtModel.Enabled = true;
            txtQuantity.Enabled = true;
            cbUnit.Enabled = true;
            txtPropertyNumber.Enabled = true;
            cbLocation.Enabled = true;
            dtpDateAcquired.Enabled = true;

            btnUpload.Enabled = true;
            btnClear.Enabled = true;
            btnSaveChanges.Enabled = true;

            rdbCondemned.Enabled = true;
            rdbDefective.Enabled = true;
            rdbWorking.Enabled = true;

            btnUpdateThisItem.Enabled = false;
        }

        private void loadItemData()
        {
            try
            {
                this.query = "SELECT InventoryCategories.category as cat, InventoryItems.item as item, InventoryItems.description as description, InventoryItems.brand as brand, InventoryItems.model as model, InventoryItems.licenseKey as licenseKey, InventoryItems.picture as picture, " +
                                "InventoryItems.serialNumber as serialNumber, InventoryItems.capacity as capacity, InventoryItems.quantity as quantity, InventoryItems.propertyNumber as propertyNumber, InventoryItems.dateAcquired as dateAcquired, InventoryItems.status as status, " +
                                "InventoryItems.dateExpiry as dateExpiry, InventoryItems.measurement as measurement, InventoryItems.category as category, InventoryItems.inventoryType as inventoryType, InventoryItems.supplier as supplier, InventoryItems.unit as unit, InventoryItems.location as location " +
                             "FROM InventoryItems " +
                             "INNER JOIN InventoryCategories ON InventoryItems.category = InventoryCategories.id " +
                             "WHERE InventoryItems.id=@id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", inventoryItemID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtItem.Text = reader["item"].ToString();
                            txtDescription.Text = reader["description"].ToString();
                            txtBrand.Text = reader["brand"].ToString();
                            txtModel.Text = reader["model"].ToString();
                            txtLicenseKey.Text = reader["licenseKey"].ToString();
                            txtSerialNumber.Text = reader["serialNumber"].ToString();
                            txtCapacity.Text = reader["capacity"].ToString();
                            txtQuantity.Text = reader["quantity"].ToString();
                            txtPropertyNumber.Text = reader["propertyNumber"].ToString();
                            dtpDateAcquired.Value = Convert.ToDateTime(reader["dateAcquired"].ToString());
                            dtpDateExpiry.Value = reader["dateExpiry"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["dateExpiry"]);

                            inventoryCapacityID = reader["measurement"] == DBNull.Value ? 0 : Convert.ToInt32(reader["measurement"]);
                            inventoryCategoryID = Convert.ToInt32(reader["category"]);
                            inventoryTypeID = Convert.ToInt32(reader["inventoryType"]);
                            supplierID = Convert.ToInt32(reader["supplier"]);
                            inventoryUnitID = Convert.ToInt32(reader["unit"]);
                            departmentID = Convert.ToInt32(reader["location"]);

                            inventoryCategory = reader["cat"].ToString();

                            foreach (Control c in gbStatus.Controls)
                            {
                                if (c.GetType() == typeof(Guna.UI.WinForms.GunaRadioButton))
                                {
                                    Guna.UI.WinForms.GunaRadioButton rb = c as Guna.UI.WinForms.GunaRadioButton;
                                    if (rb.Text == reader["status"].ToString())
                                    {
                                        rb.Checked = true;
                                    }
                                }
                            }

                            pbImage.Image = Image.FromStream(new MemoryStream((Byte[])reader["picture"]));
                        }
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error on loading inventory item: " + ex.Message, "Updating Inventory Item");
            }
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

                        cbSupplier.SelectedIndex = supplierID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Updating Inventory Item");
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

                        cbUnit.SelectedIndex = inventoryUnitID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading unit: " + ex.Message, "Updating Inventory Item");
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

                        cbCapacity.SelectedIndex = inventoryCapacityID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading capacity: " + ex.Message, "Updating Inventory Item");
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

                        cbLocation.SelectedIndex = departmentID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading department: " + ex.Message, "Updating Inventory Item");
            }
        }

        public void loadInventoryType()
        {
            try
            {
                this.query = "SELECT id, type FROM InventoryTypes";
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
                        row[1] = "--Select Inventory Type--";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        cbInventoryType.DataSource = dt;
                        cbInventoryType.DisplayMember = "type";
                        cbInventoryType.ValueMember = "id";

                        cbInventoryType.SelectedIndex = inventoryTypeID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory type: " + ex.Message, "Updating Inventory Item");
            }
        }

        public void loadCategories()
        {
            try
            {
                this.query = "SELECT id, category FROM InventoryCategories WHERE type=@type";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", inventoryTypeID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select Inventory Category--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbInventoryCategory.DataSource = dt;
                            cbInventoryCategory.DisplayMember = "category";
                            cbInventoryCategory.ValueMember = "id";

                            cbInventoryCategory.SelectedIndex = cbInventoryCategory.FindStringExact(inventoryCategory);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory category: " + ex.Message, "Updating Inventory Item");
            }
        }

        private void cbInventoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //inventoryTypeID = Convert.ToInt32(cbInventoryType.SelectedValue);
        }
    }
}
