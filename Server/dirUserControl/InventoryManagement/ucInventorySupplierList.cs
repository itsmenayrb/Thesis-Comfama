﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.InventoryManagement
{
    public partial class ucInventorySupplierList : UserControl
    {
        public static ucInventorySupplierList mainInstance = null;
        public ucInventorySupplierList()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void ucInventorySupplierList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddSupplier.request = "view";
            new dirOtherForms.InventoryManagement.frmAddSupplier().ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            this.inventoryBusinessTypesTableAdapter.Fill(this.dbThesisComfamaDataSet.InventoryBusinessTypes);
            this.inventorySuppliersTableAdapter.Fill(this.dbThesisComfamaDataSet.InventorySuppliers);
        }

        private void dgvInventorySupplier_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.inventorySuppliersBindingSource.Filter = this.dgvInventorySupplier.FilterString;
        }

        private void dgvInventorySupplier_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.inventorySuppliersBindingSource.Sort = this.dgvInventorySupplier.SortString;
        }

        private void dgvInventorySupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventorySupplier.Columns["action"].Index)
            {
                string businessName = dgvInventorySupplier.Rows[dgvInventorySupplier.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                string supplierID = dgvInventorySupplier.Rows[dgvInventorySupplier.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                string address = dgvInventorySupplier.Rows[dgvInventorySupplier.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                string phoneNumber = dgvInventorySupplier.Rows[dgvInventorySupplier.SelectedCells[0].RowIndex].Cells[6].Value.ToString();

                DialogResult result = MessageBox.Show("Update " + businessName + "?", "Update Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(businessName) || string.IsNullOrEmpty(supplierID) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber))
                    {
                        MessageBox.Show("Please make sure that all the field is not empty.", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadData();
                    }
                    else
                    {
                        inventorySuppliersBindingSource.EndEdit();
                        this.inventorySuppliersTableAdapter.Update(this.dbThesisComfamaDataSet.InventorySuppliers);
                        dgvInventorySupplier.Refresh();
                        MessageBox.Show("Inventory Supplier Updated!", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


    }
}
