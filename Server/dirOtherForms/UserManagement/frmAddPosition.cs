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
    public partial class frmAddPosition : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public frmAddPosition()
        {
            InitializeComponent();
        }

        private void txtPosition_Enter(object sender, EventArgs e)
        {
            if (txtPosition.Text == "Position")
            {
                txtPosition.Text = "";
            }
        }

        private void txtPosition_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPosition.Text))
            {
                txtPosition.Text = "Position";
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtPosition.Text == "Position" || string.IsNullOrEmpty(txtPosition.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the name of position.", "Add Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPosition.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string position = txtPosition.Text;
                    dirClasses.Position addPosition = new dirClasses.Position();
                    if (addPosition.addPosition(position))
                    {
                        MessageBox.Show(position.ToUpper() + " has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {
                            frmViewPosition.mainInstance.loadPositionData();
                        }
                        else
                        {
                            frmAddEmployee.mainInstance.loadPositionData();
                        }
                        dirUserControl.UserManagement.ucEmployees.mainInstance.loadData();
                        this.Close();
                    }
                    else
                    {
                        txtPosition.Focus();
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

        private void frmAddPosition_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
