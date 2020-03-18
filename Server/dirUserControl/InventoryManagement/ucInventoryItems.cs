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
    public partial class ucInventoryItems : UserControl
    {
        public static ucInventoryItems mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public ucInventoryItems()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new dirOtherForms.InventoryManagement.frmAddItems().ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            
        }

        private void ucInventoryItems_Load(object sender, EventArgs e)
        {
            loadItemData();
        }

        public void loadItemData()
        {
            try
            {
                this.query = "SELECT InventoryItems.id as ID, InventoryItems.item as item, InventoryItems.description as description, InventoryItems.brand as brand, InventoryItems.model as model, CONCAT(InventoryItems.quantity, ' ', InventoryUnits.unit) as quantity, InventoryItems.propertyNumber as propertyNumber, Departments.department as location, InventoryItems.dateAcquired as dateAcquired, InventoryItems.status as status FROM InventoryItems " +
                             "INNER JOIN InventoryUnits ON InventoryItems.unit = InventoryUnits.id " +
                             "INNER JOIN Departments ON InventoryItems.location = Departments.id " +
                             "WHERE InventoryItems.academicYear=@academicYear";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", dirClasses.Session.academicYearID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvInventoryItems.DataSource = dt;
                            dgvInventoryItems.AutoGenerateColumns = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }
        }

        DataTable o = null;
        private void dgvInventoryItems_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            Zuby.ADGV.AdvancedDataGridView fdgv = dgvInventoryItems;
            DataTable dt = null;
            if (o == null)
            {
                o = (DataTable)fdgv.DataSource;
            }
            if (fdgv.FilterString.Length > 0)
            {
                dt = (DataTable)fdgv.DataSource;
            }
            else
            {
                dt = o;
            }

            fdgv.DataSource = dt.Select(fdgv.FilterString).CopyToDataTable();
        }

        private void dgvInventoryItems_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {

        }

        private void dgvInventoryItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventoryItems.Columns["action"].Index)
            {
                int inventoryItemID = Convert.ToInt32(dgvInventoryItems.Rows[dgvInventoryItems.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
                dirOtherForms.InventoryManagement.frmViewItem.inventoryItemID = inventoryItemID;
                new dirOtherForms.InventoryManagement.frmViewItem().ShowDialog();
            }
        }
    }
}
