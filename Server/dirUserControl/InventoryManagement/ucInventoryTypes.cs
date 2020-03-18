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
    public partial class ucInventoryTypes : UserControl
    {
        public static ucInventoryTypes mainInstance = null;

        public ucInventoryTypes()
        {
            InitializeComponent();
            mainInstance = this;
        }

        private void ucInventoryTypes_Load(object sender, EventArgs e)
        {
            loadInventoryTypeData();
        }

        private void dgvInventoryTypes_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.inventoryTypesBindingSource.Filter = this.dgvInventoryTypes.FilterString;
        }

        private void dgvInventoryTypes_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.inventoryTypesBindingSource.Sort = this.dgvInventoryTypes.SortString;
        }

        public void loadInventoryTypeData()
        {
            this.inventoryTypesTableAdapter.Fill(this.dbThesisComfamaDataSet.InventoryTypes);
        }

        private void btnAddInventoryType_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddInventoryType.request = "view";
            new dirOtherForms.InventoryManagement.frmAddInventoryType().ShowDialog();
        }
    }
}
