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
    public partial class ucInventorySuppliers : UserControl
    {
        public ucInventorySuppliers()
        {
            InitializeComponent();
        }

        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            ucInventorySupplierList1.Visible = true;
            ucInventoryBusinessTypes1.Visible = false;
        }

        private void btnViewBusinessType_Click(object sender, EventArgs e)
        {
            ucInventorySupplierList1.Visible = false;
            ucInventoryBusinessTypes1.Visible = true;
        }
    }
}
