using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.UserManagement
{
    public partial class ucUserManagement : UserControl
    {
        public ucUserManagement()
        {
            InitializeComponent();
        }

        private void ucUserManagement_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            ucEmployees1.Visible = true;
            ucStudents1.Visible = false;
            ucAccounts1.Visible = false;
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ucEmployees1.Visible = false;
            ucStudents1.Visible = true;
            ucAccounts1.Visible = false;
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            ucEmployees1.Visible = false;
            ucStudents1.Visible = false;
            ucAccounts1.Visible = true;
        }
    }
}
