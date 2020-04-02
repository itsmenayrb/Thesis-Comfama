using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.InventoryManagement
{
    public partial class ucInventoryCategories : UserControl
    {
        public static ucInventoryCategories mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ucInventoryCategories()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucInventoryCategories_Load(object sender, EventArgs e)
        {
            loadData();
            loadInventoryCategoryCount();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddCategories.request = "view";
            new dirOtherForms.InventoryManagement.frmAddCategories().ShowDialog();
        }

        public void loadData()
        {
            this.inventoryCategoriesTableAdapter.Fill(this.dbThesisComfamaDataSet.InventoryCategories);
            this.inventoryTypesTableAdapter.Fill(this.dbThesisComfamaDataSet.InventoryTypes);
        }

        private void dgvInventoryCategory_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.inventoryCategoriesBindingSource.Filter = this.dgvInventoryCategories.FilterString;
        }

        private void dgvInventoryCategory_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.inventoryCategoriesBindingSource.Sort = this.dgvInventoryCategories.SortString;
        }

        private void dgvInventoryCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventoryCategories.Columns["action"].Index)
            {
                string category = dgvInventoryCategories.Rows[dgvInventoryCategories.SelectedCells[0].RowIndex].Cells[2].Value.ToString();

                DialogResult result = MessageBox.Show("Update " + category + "?", "Update Inventory Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show("Please make sure that the field is not empty.", "Update Inventory Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadData();
                    }
                    else
                    {
                        inventoryCategoriesBindingSource.EndEdit();
                        this.inventoryCategoriesTableAdapter.Update(this.dbThesisComfamaDataSet.InventoryCategories);
                        dgvInventoryCategories.Refresh();
                        MessageBox.Show("Inventory Category Updated!", "Update Inventory Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void loadInventoryCategoryCount()
        {
            try
            {
                this.query = "SELECT COUNT(*) as categoryCount FROM InventoryCategories";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblTotalCategoryCount.Text = reader["categoryCount"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }
        }
    }
}
