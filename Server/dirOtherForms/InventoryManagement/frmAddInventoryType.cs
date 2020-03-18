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
    public partial class frmAddInventoryType : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public frmAddInventoryType()
        {
            InitializeComponent();
        }

        private void btnAddInventoryType_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtInventoryType.Text == "Inventory Type" || string.IsNullOrEmpty(txtInventoryType.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the inventory type.", "Add Inventory Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInventoryType.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string type = txtInventoryType.Text;
                    dirClasses.InventoryType addType = new dirClasses.InventoryType();
                    if (addType.addType(type))
                    {
                        MessageBox.Show(type.ToUpper() + " has been added!", "Add Inventory Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {
                            dirUserControl.InventoryManagement.ucInventoryTypes.mainInstance.loadInventoryTypeData();
                        }
                        else
                        {
                            dirOtherForms.InventoryManagement.frmAddItems.mainInstance.loadInventoryType();
                        }
                        this.Close();
                    }
                    else
                    {
                        txtInventoryType.Focus();
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

        private void txtInventoryType_Enter(object sender, EventArgs e)
        {
            if (txtInventoryType.Text == "Inventory Type")
            {
                txtInventoryType.Text = "";
            }
        }

        private void txtInventoryType_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInventoryType.Text))
            {
                txtInventoryType.Text = "Inventory Type";
            }
        }

        private void frmAddInventoryType_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
