using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.InventoryManagement
{
    public partial class ucInventoryManagement : UserControl
    {
        public ucInventoryManagement()
        {
            InitializeComponent();
        }

        private void ucInventoryManagement_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            ucInventoryTypes1.Visible = false;
            ucInventoryCategories1.Visible = false;
            ucInventorySuppliers1.Visible = false;
            ucInventoryItems1.Visible = true;
        }

        private void btnViewTypes_Click(object sender, EventArgs e)
        {
            ucInventoryTypes1.Visible = true;
            ucInventoryCategories1.Visible = false;
            ucInventorySuppliers1.Visible = false;
            ucInventoryItems1.Visible = false;
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            ucInventoryTypes1.Visible = false;
            ucInventoryCategories1.Visible = true;
            ucInventorySuppliers1.Visible = false;
            ucInventoryItems1.Visible = false;
        }

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
            ucInventoryTypes1.Visible = false;
            ucInventoryCategories1.Visible = false;
            ucInventorySuppliers1.Visible = true;
            ucInventoryItems1.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
