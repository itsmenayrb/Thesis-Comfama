using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class Inventory
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public Inventory()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool addHardware(int inventoryType, int category, int supplier, string itemName, string description, string brand, string model, string serialNumber, int capacity, int capacityMeasurement, int quantity, int unit, string propertyNumber, int location, string dateAcquired, string status, byte[] byteImage)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingPropertyNumber(propertyNumber))
                    {
                        MessageBox.Show("There's already an item having a Property Number of " + propertyNumber + ".Please check your input.", "Adding of Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        if (checkExistingSerialNumber(serialNumber))
                        {
                            MessageBox.Show("There's already an item having a Serial Number of " + serialNumber + ".Please check your input.", "Adding of Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return false;
                        }
                        else
                        {

                            this.query = "INSERT INTO InventoryItems (academicYear, inventoryType, category, supplier, item, description, brand, model, serialNumber, capacity, measurement, quantity, unit, propertyNumber, location, dateAcquired, status, picture) VALUES (@academicYear, @inventoryType, @category, @supplier, @itemName, @description, @brand, @model, @serialNumber, @capacity, @capacityMeasurement, @quantity, @unit, @propertyNumber, @location, @dateAcquired, @status, @picture)";
                            using (SqlCommand cmd = new SqlCommand(this.query, conn))
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                                cmd.Parameters.AddWithValue("@inventoryType", inventoryType);
                                cmd.Parameters.AddWithValue("@category", category);
                                cmd.Parameters.AddWithValue("@supplier", supplier);
                                cmd.Parameters.AddWithValue("@itemName", itemName);
                                cmd.Parameters.AddWithValue("@description", description);
                                cmd.Parameters.AddWithValue("@brand", brand);
                                cmd.Parameters.AddWithValue("@model", model);
                                cmd.Parameters.AddWithValue("@serialNumber", serialNumber);
                                cmd.Parameters.AddWithValue("@capacity", capacity);
                                cmd.Parameters.AddWithValue("@capacityMeasurement", capacityMeasurement);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@unit", unit);
                                cmd.Parameters.AddWithValue("@propertyNumber", propertyNumber);
                                cmd.Parameters.AddWithValue("@location", location);
                                cmd.Parameters.AddWithValue("@dateAcquired", dateAcquired);
                                cmd.Parameters.AddWithValue("@status", status);
                                cmd.Parameters.AddWithValue("@picture", byteImage);
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        private bool checkExistingPropertyNumber(string propertyNumber)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT propertyNumber FROM InventoryItems WHERE propertyNumber=@propertyNumber";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@propertyNumber", propertyNumber);
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

        private bool checkExistingSerialNumber(string serialNumber)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT serialNumber FROM InventoryItems WHERE serialNumber=@serialNumber";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@serialNumber", serialNumber);
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

        private bool checkExistingLicenseKey(string licenseKey)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT licenseKey FROM InventoryItems WHERE licenseKey=@licenseKey";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@licenseKey", licenseKey);
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

        internal bool addSoftware(int inventoryType, int category, int supplier, string itemName, string description, string brand, string model, string licenseKey, int quantity, int unit, string propertyNumber, int location, string dateAcquired, string dateExpire, string status, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingPropertyNumber(propertyNumber))
                    {
                        MessageBox.Show("There's already an item having a Property Number of " + propertyNumber + ".Please check your input.", "Adding of Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        if (checkExistingLicenseKey(licenseKey))
                        {
                            MessageBox.Show("There's already an item having a License Key of " + licenseKey + ".Please check your input.", "Adding of Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return false;
                        }
                        else
                        {

                            this.query = "INSERT INTO InventoryItems (academicYear, inventoryType, category, supplier, item, description, brand, model, licenseKey, quantity, unit, propertyNumber, location, dateAcquired, dateExpiry, status, picture) VALUES (@academicYear, @inventoryType, @category, @supplier, @itemName, @description, @brand, @model, @licenseKey, @quantity, @unit, @propertyNumber, @location, @dateAcquired, @dateExpiry, @status, @picture)";
                            using (SqlCommand cmd = new SqlCommand(this.query, conn))
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);
                                cmd.Parameters.AddWithValue("@inventoryType", inventoryType);
                                cmd.Parameters.AddWithValue("@category", category);
                                cmd.Parameters.AddWithValue("@supplier", supplier);
                                cmd.Parameters.AddWithValue("@itemName", itemName);
                                cmd.Parameters.AddWithValue("@description", description);
                                cmd.Parameters.AddWithValue("@brand", brand);
                                cmd.Parameters.AddWithValue("@model", model);
                                cmd.Parameters.AddWithValue("@licenseKey", licenseKey);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@unit", unit);
                                cmd.Parameters.AddWithValue("@propertyNumber", propertyNumber);
                                cmd.Parameters.AddWithValue("@location", location);
                                cmd.Parameters.AddWithValue("@dateAcquired", dateAcquired);
                                cmd.Parameters.AddWithValue("@dateExpiry", dateExpire);
                                cmd.Parameters.AddWithValue("@status", status);
                                cmd.Parameters.AddWithValue("@picture", byteImage);
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        internal bool updateSoftware(int inventoryItemID, int itID, int icID, int supplier, string itemName, string description, string brand, string model, string licenseKey, int quantity, int unit, string propertyNumber, int location, string dateAcquired, string dateExpire, string status, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "UPDATE InventoryItems SET inventoryType=@inventoryType, category=@category, supplier=@supplier, item=@itemName, description=@description, brand=@brand, model=@model, licenseKey=@licenseKey, quantity=@quantity, unit=@unit, propertyNumber=@propertyNumber, location=@location, dateAcquired=@dateAcquired, dateExpiry=@dateExpiry, status=@status, picture=@picture WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@inventoryType", itID);
                        cmd.Parameters.AddWithValue("@category", icID);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@licenseKey", licenseKey);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        cmd.Parameters.AddWithValue("@propertyNumber", propertyNumber);
                        cmd.Parameters.AddWithValue("@location", location);
                        cmd.Parameters.AddWithValue("@dateAcquired", dateAcquired);
                        cmd.Parameters.AddWithValue("@dateExpiry", dateExpire);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@picture", byteImage);
                        cmd.Parameters.AddWithValue("@id", inventoryItemID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        internal bool updateHardware(int inventoryItemID, int itID, int icID, int supplier, string itemName, string description, string brand, string model, string serialNumber, int capacity, int capacityMeasurement, int quantity, int unit, string propertyNumber, int location, string dateAcquired, string status, byte[] byteImage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "UPDATE InventoryItems SET inventoryType=@inventoryType, category=@category, supplier=@supplier, item=@itemName, description=@description, brand=@brand, model=@model, serialNumber=@serialNumber, capacity=@capacity, measurement=@capacityMeasurement, quantity=@quantity, unit=@unit, propertyNumber=@propertyNumber, location=@location, dateAcquired=@dateAcquired, status=@status, picture=@picture WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@inventoryType", itID);
                        cmd.Parameters.AddWithValue("@category", icID);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@serialNumber", serialNumber);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@capacityMeasurement", capacityMeasurement);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        cmd.Parameters.AddWithValue("@propertyNumber", propertyNumber);
                        cmd.Parameters.AddWithValue("@location", location);
                        cmd.Parameters.AddWithValue("@dateAcquired", dateAcquired);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@picture", byteImage);
                        cmd.Parameters.AddWithValue("@id", inventoryItemID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }

    class InventoryType : Inventory
    {
        internal bool addType(string type)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingType(type))
                    {
                        MessageBox.Show(type.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO InventoryTypes (type) VALUES (@type)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@type", type);
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

        private bool checkExistingType(string type)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT type FROM InventoryTypes WHERE type=@type";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@type", type);
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

        internal bool updateType(string type, int _inventoryTypeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingType(type))
                    {
                        MessageBox.Show(type.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "UPDATE InventoryTypes SET type=@type WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", _inventoryTypeID);
                            cmd.Parameters.AddWithValue("@type", type);
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

        internal bool deleteType(int inventoryTypeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "DELETE FROM InventoryTypes WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", inventoryTypeID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }

    class InventoryCategory : Inventory
    {
        internal bool addCategory(string category, int inventoryTypeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingCategory(category))
                    {
                        MessageBox.Show(category.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO InventoryCategories (type, category) VALUES (@type, @category)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@type", inventoryTypeID);
                            cmd.Parameters.AddWithValue("@category", category);
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

        private bool checkExistingCategory(string category)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT category FROM InventoryCategories WHERE category=@category";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", category);
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

        internal bool updateCategory(string category, int _inventoryCategoryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingCategory(category))
                    {
                        MessageBox.Show(category.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "UPDATE InventoryCategories SET category=@category WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", _inventoryCategoryID);
                            cmd.Parameters.AddWithValue("@category", category);
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

        internal bool deleteCategory(int inventoryCategoryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "DELETE FROM InventoryCategories WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", inventoryCategoryID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        internal bool changeType(int inventoryTypeID, int _inventoryCategoryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "UPDATE InventoryCategories SET type=@type WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", _inventoryCategoryID);
                        cmd.Parameters.AddWithValue("@type", inventoryTypeID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }

    class Supplier : Inventory
    {
        internal bool addSupplier(string _supplierCode, string _supplierID, string _businessName, int _businessType, string _businessAddress, string _businessContactNumber, string _contactPerson, string _contactNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingSupplier(_businessName))
                    {
                        MessageBox.Show(_businessName.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        if (checkExistingSupplierCode(_supplierCode))
                        {
                            MessageBox.Show(_supplierCode + " is already used. Please click refresh button to change.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return false;
                        }
                        else
                        {
                            if (checkExistingSupplierID(_supplierID))
                            {
                                MessageBox.Show(_supplierID + " is already used.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                conn.Close();
                                return false;
                            }
                            else
                            {
                                this.query = "INSERT INTO InventorySuppliers (supplierCode, supplierID, businessName, businessType, businessAddress, businessContactNumber, contactPerson, contactNumber) VALUES (@supplierCode, @supplierID, @businessName, @businessType, @businessAddress, @businessContactNumber, @contactPerson, @contactNumber)";
                                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                                {
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@supplierCode", _supplierCode);
                                    cmd.Parameters.AddWithValue("@supplierID", _supplierID);
                                    cmd.Parameters.AddWithValue("@businessName", _businessName);
                                    cmd.Parameters.AddWithValue("@businessType", _businessType);
                                    cmd.Parameters.AddWithValue("@businessAddress", _businessAddress);
                                    cmd.Parameters.AddWithValue("@businessContactNumber", _businessContactNumber);
                                    cmd.Parameters.AddWithValue("@contactPerson", _contactPerson);
                                    cmd.Parameters.AddWithValue("@contactNumber", _contactNumber);
                                    cmd.ExecuteNonQuery();
                                }
                                conn.Close();
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        private bool checkExistingSupplier(string _businessName)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT businessName FROM InventorySuppliers WHERE businessName=@businessName";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@businessName", _businessName);
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

        private bool checkExistingSupplierCode(string _supplierCode)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT supplierCode FROM InventorySuppliers WHERE supplierCode=@supplierCode";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplierCode", _supplierCode);
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

        private bool checkExistingSupplierID(string _supplierID)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT supplierID FROM InventorySuppliers WHERE supplierID=@supplierID";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@supplierID", _supplierID);
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

        internal bool updateSupplier(string _supplierID, string _businessName, string _businessAddress, string _businessContactNumber, string _contactPerson, string _contactNumber, int inventorySupplierIDPK)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    this.query = "UPDATE InventorySuppliers SET supplierID=@supplierID, businessName=@businessName, businessAddress=@businessAddress, businessContactNumber=@businessContactNumber, contactPerson=@contactPerson, contactNumber=@contactNumber WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@supplierID", _supplierID);
                        cmd.Parameters.AddWithValue("@businessName", _businessName);
                        cmd.Parameters.AddWithValue("@businessAddress", _businessAddress);
                        cmd.Parameters.AddWithValue("@businessContactNumber", _businessContactNumber);
                        cmd.Parameters.AddWithValue("@contactPerson", _contactPerson);
                        cmd.Parameters.AddWithValue("@contactNumber", _contactNumber);
                        cmd.Parameters.AddWithValue("@id", inventorySupplierIDPK);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }

    class BusinessType : Inventory
    {
        internal bool addBusinessType(string businessType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingBusinessType(businessType))
                    {
                        MessageBox.Show(businessType.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO InventoryBusinessTypes (businessType) VALUES (@businessType)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@businessType", businessType);
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

        private bool checkExistingBusinessType(string businessType)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT businessType FROM InventoryBusinessTypes WHERE businessType=@businessType";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@businessType", businessType);
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

        internal bool updateBusinessType(string businessType, int _inventoryBusinessTypeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingBusinessType(businessType))
                    {
                        MessageBox.Show(businessType.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "UPDATE InventoryBusinessTypes SET businessType=@businessType WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", _inventoryBusinessTypeID);
                            cmd.Parameters.AddWithValue("@businessType", businessType);
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

        internal bool deleteBusinessType(int inventoryBusinessTypeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "DELETE FROM InventoryBusinessTypes WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", inventoryBusinessTypeID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }

    class Capacity : Inventory
    {

        internal bool addCapacity(string capacity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingCapacity(capacity))
                    {
                        MessageBox.Show(capacity.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO InventoryCapacities (capacity) VALUES (@capacity)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@capacity", capacity);
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

        private bool checkExistingCapacity(string capacity)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT capacity FROM InventoryCapacities WHERE capacity=@capacity";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@capacity", capacity);
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
    }

    class Unit : Inventory
    {
        private bool checkExistingUnit(string unit)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                this.query = "SELECT unit FROM InventoryUnits WHERE unit=@unit";
                using (SqlCommand cmd = new SqlCommand(this.query, conn))
                {
                    cmd.Parameters.AddWithValue("@unit", unit);
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

        internal bool addUnit(string unit)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    if (checkExistingUnit(unit))
                    {
                        MessageBox.Show(unit.ToUpper() + " is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        this.query = "INSERT INTO InventoryUnits (unit) VALUES (@unit)";
                        using (SqlCommand cmd = new SqlCommand(this.query, conn))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@unit", unit);
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
