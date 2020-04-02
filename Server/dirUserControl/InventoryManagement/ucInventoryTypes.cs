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
    public partial class ucInventoryTypes : UserControl
    {
        public static ucInventoryTypes mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ucInventoryTypes()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucInventoryTypes_Load(object sender, EventArgs e)
        {
            loadInventoryTypeData();
            loadInventoryTypeCount();
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

        public void loadInventoryTypeCount()
        {
            try
            {
                this.query = "SELECT COUNT(*) as typeCount FROM InventoryTypes";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblTotalTypesCount.Text = reader["typeCount"].ToString();
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
