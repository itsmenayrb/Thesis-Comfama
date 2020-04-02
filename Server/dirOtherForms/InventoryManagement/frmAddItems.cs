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
    public partial class frmAddItems : Form
    {
        public static frmAddItems mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public static string request { get; set; }

        public frmAddItems()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmAddItems_Load(object sender, EventArgs e)
        {
            loadInventoryType();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
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

                        cbInventoryType.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory type: " + ex.Message, "Add Item");
            }
        }

        public void loadCategories(int inventoryTypeID)
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory category: " + ex.Message, "Add Item");
            }
        }

        private void cbInventoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inventoryTypeID = Convert.ToInt32(cbInventoryType.SelectedValue);
            string type = cbInventoryType.Text;
            loadCategories(inventoryTypeID);

            if (type == "Software")
            {
                ucHardware1.Visible = false;
                ucSoftware1.Visible = true;
                dirUserControl.InventoryManagement.ucSoftware.inventoryType = inventoryTypeID;
            }
            else if (type == "--Select Inventory Type--")
            {
                ucHardware1.Visible = false;
                ucSoftware1.Visible = false;
            }
            else
            {
                ucHardware1.Visible = true;
                ucSoftware1.Visible = false;
                dirUserControl.InventoryManagement.ucHardware.inventoryType = inventoryTypeID;
            }
        }

        private void cbInventoryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirUserControl.InventoryManagement.ucHardware.category = Convert.ToInt32(cbInventoryCategory.SelectedValue);
            dirUserControl.InventoryManagement.ucSoftware.category = Convert.ToInt32(cbInventoryCategory.SelectedValue);
        }

        private void btnAddInventoryType_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddInventoryType.request = "add";
            new dirOtherForms.InventoryManagement.frmAddInventoryType().ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddCategories.request = "add";
            new dirOtherForms.InventoryManagement.frmAddCategories().ShowDialog();
        }
    }
}
