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
    public partial class frmAddUnit : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public frmAddUnit()
        {
            InitializeComponent();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtUnit.Text == "Unit of Measurement" || string.IsNullOrEmpty(txtUnit.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the unit of measurement.", "Add Unit of Measurement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string unit = txtUnit.Text;
                    dirClasses.Unit addUnit = new dirClasses.Unit();
                    if (addUnit.addUnit(unit))
                    {
                        MessageBox.Show(unit.ToUpper() + " has been added!", "Add Unit of Measurement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {
                            
                        }
                        else
                        {
                           //dirUserControl.InventoryManagement.ucHardware.mainInstance.loadUnitData();
                        }
                        this.Close();
                    }
                    else
                    {
                        txtUnit.Focus();
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

        private void txtUnit_Enter(object sender, EventArgs e)
        {
            if (txtUnit.Text == "Unit of Measurement")
            {
                txtUnit.Text = "";
            }
        }

        private void txtUnit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnit.Text))
            {
                txtUnit.Text = "Unit of Measurement";
            }
        }

        private void frmAddUnit_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
