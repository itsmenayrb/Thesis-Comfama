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
    public partial class ucInventoryBusinessTypes : UserControl
    {
        public static ucInventoryBusinessTypes mainInstance = null;
        public ucInventoryBusinessTypes()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void ucInventoryBusinessTypes_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddBusinessType_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddBusinessType.request = "view";
            new dirOtherForms.InventoryManagement.frmAddBusinessType().ShowDialog();
        }

        private void dgvInventoryBusinessType_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.inventoryBusinessTypesBindingSource.Filter = this.dgvInventoryBusinessType.FilterString;
        }

        private void dgvInventoryBusinessType_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.inventoryBusinessTypesBindingSource.Sort = this.dgvInventoryBusinessType.SortString;
        }

        private void dgvInventoryBusinessType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventoryBusinessType.Columns["action"].Index)
            {
                string businessType = dgvInventoryBusinessType.Rows[dgvInventoryBusinessType.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Update " + businessType + "?", "Update Business Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(businessType))
                    {
                        MessageBox.Show("Please make sure that the field is not empty.", "Update Business Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadData();
                    }
                    else
                    {
                        inventoryBusinessTypesBindingSource.EndEdit();
                        this.inventoryBusinessTypesTableAdapter.Update(this.dbThesisComfamaDataSet.InventoryBusinessTypes);
                        dgvInventoryBusinessType.Refresh();
                        MessageBox.Show("Inventory Business Type Updated!", "Update Business Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void loadData()
        {
            this.inventoryBusinessTypesTableAdapter.Fill(this.dbThesisComfamaDataSet.InventoryBusinessTypes);
        }
    }
}
