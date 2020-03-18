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
    public partial class frmAddCapacity : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public frmAddCapacity()
        {
            InitializeComponent();
        }

        private void btnAddCapacity_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtCapacity.Text == "Capacity" || string.IsNullOrEmpty(txtCapacity.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the capacity.", "Add Capacity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacity.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string capacity = txtCapacity.Text;
                    dirClasses.Capacity addCapacity = new dirClasses.Capacity();
                    if (addCapacity.addCapacity(capacity))
                    {
                        MessageBox.Show(capacity.ToUpper() + " has been added!", "Add Capacity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {

                        }
                        else
                        {
                            //dirUserControl.InventoryManagement.ucHardware.mainInstance.loadCapacityData();
                        }
                        this.Close();
                    }
                    else
                    {
                        txtCapacity.Focus();
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

        private void txtCapacity_Enter(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "Capacity")
            {
                txtCapacity.Text = "";
            }
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCapacity.Text))
            {
                txtCapacity.Text = "Capacity";
            }
        }

        private void frmAddCapacity_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
