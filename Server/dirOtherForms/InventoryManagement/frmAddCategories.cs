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
    public partial class frmAddCategories : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public static frmAddCategories mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public frmAddCategories()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void btnAddInventoryCategory_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (cbInventoryTypes.SelectedIndex == -1 || string.IsNullOrEmpty(cbInventoryTypes.Text) || cbInventoryTypes.SelectedIndex == 0)
            {
                hasError = true;
                MessageBox.Show("Please select the Inventory Type for the Category.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbInventoryTypes.Focus();
            }
            else
            {
                if (txtInventoryCategory.Text == "Inventory Category" || string.IsNullOrEmpty(txtInventoryCategory.Text))
                {
                    hasError = true;
                    MessageBox.Show("Please indicate the Inventory Category.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInventoryCategory.Focus();
                }
                else
                {
                    if (hasError == false)
                    {
                        string category = txtInventoryCategory.Text;
                        int type = Convert.ToInt32(cbInventoryTypes.SelectedValue);

                        dirClasses.InventoryCategory addCategory = new dirClasses.InventoryCategory();
                        if (addCategory.addCategory(category, type))
                        {
                            MessageBox.Show(category.ToUpper() + " has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (request == "view")
                            {
                                dirUserControl.InventoryManagement.ucInventoryCategories.mainInstance.loadData();
                            }
                            else
                            {
                                dirOtherForms.InventoryManagement.frmAddItems.mainInstance.loadInventoryType();
                            }
                            this.Close();
                        }
                        else
                        {
                            txtInventoryCategory.Focus();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInventoryCategory_Enter(object sender, EventArgs e)
        {
            if (txtInventoryCategory.Text == "Inventory Category")
            {
                txtInventoryCategory.Text = "";
            }
        }

        private void txtInventoryCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInventoryCategory.Text))
            {
                txtInventoryCategory.Text = "Inventory Category";
            }
        }

        private void loadInventoryTypeData()
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
                        cbInventoryTypes.DataSource = dt;
                        cbInventoryTypes.DisplayMember = "type";
                        cbInventoryTypes.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Inventory Category");
            }
        }

        private void frmAddCategories_Load(object sender, EventArgs e)
        {
            loadInventoryTypeData();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
