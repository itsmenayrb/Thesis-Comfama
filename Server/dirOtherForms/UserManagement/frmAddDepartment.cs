using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.UserManagement
{
    public partial class frmAddDepartment : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public frmAddDepartment()
        {
            InitializeComponent();
        }

        private void txtDepartment_Enter(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "Department")
            {
                txtDepartment.Text = "";
            }
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                txtDepartment.Text = "Department";
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtDepartment.Text == "Department" || string.IsNullOrEmpty(txtDepartment.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the name of department.", "Add Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartment.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string department = txtDepartment.Text;
                    dirClasses.Department addDepartment = new dirClasses.Department();
                    if (addDepartment.addDepartment(department))
                    {
                        MessageBox.Show(department.ToUpper() + " has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {
                            frmViewDepartment.mainInstance.loadDepartmentData();
                        }
                        else if (request == "add")
                        {
                            frmAddEmployee.mainInstance.loadDepartmentData();
                        }
                        else
                        {
                            dirUserControl.InventoryManagement.ucHardware.mainInstance.loadLocationData();
                        }
                        dirUserControl.UserManagement.ucEmployees.mainInstance.loadData();
                        this.Close();
                    }
                    else
                    {
                        txtDepartment.Focus();
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

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
