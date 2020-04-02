using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.InventoryManagement
{
    public partial class frmAddBusinessType : Form
    {
        public static frmAddBusinessType mainInstance = null;
        private bool hasError = false;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public static string request { get; set; }

        public frmAddBusinessType()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmAddBusinessType_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void txtBusinessType_Enter(object sender, EventArgs e)
        {
            if (txtBusinessType.Text == "Business Type")
            {
                txtBusinessType.Text = "";
            }
        }

        private void txtBusinessType_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusinessType.Text))
            {
                txtBusinessType.Text = "Business Type";
            }
        }

        private void btnAddBusinessType_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtBusinessType.Text == "Business Type" || string.IsNullOrEmpty(txtBusinessType.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the Business Type.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusinessType.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string type = txtBusinessType.Text;
                    dirClasses.BusinessType addType = new dirClasses.BusinessType();
                    if (addType.addBusinessType(type))
                    {
                        MessageBox.Show(type.ToUpper() + " has been added!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {
                            dirUserControl.InventoryManagement.ucInventoryBusinessTypes.mainInstance.loadData();
                            dirUserControl.InventoryManagement.ucInventoryBusinessTypes.mainInstance.loadInventoryBusinessTypeCount();
                        }
                        else
                        {
                            dirOtherForms.InventoryManagement.frmAddSupplier.mainInstance.loadBusinessType();
                        }

                        this.Close();
                    }
                    else
                    {
                        txtBusinessType.Focus();
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
