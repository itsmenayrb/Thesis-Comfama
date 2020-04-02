using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Server.dirUserControl.InventoryManagement
{
    public partial class ucInventoryItems : UserControl
    {
        public static ucInventoryItems mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        ReportDataSource rs = new ReportDataSource();

        private int numberToDisplay = 0;

        public ucInventoryItems()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddItems.request = "CameFromInventory";
            new dirOtherForms.InventoryManagement.frmAddItems().ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            //BindingSource bs = (BindingSource)dgvInventoryItems.DataSource;
            //DataTable d = (DataTable)bs.DataSource;
            //dirReports.InventoryManagement.frmGenerateReport.dt = d;
            //dirReports.InventoryManagement.frmGenerateReport gr = new dirReports.InventoryManagement.frmGenerateReport();
            //gr.ShowDialog();
        }

        private void ucInventoryItems_Load(object sender, EventArgs e)
        {
            loadItemData();
            loadItemCount();
            loadAllReportCount();
        }

        public void loadAllReportCount()
        {
            cbMostReportedItem.SelectedIndex = 0;
            cbNumberOfItemsPerDepartment.SelectedIndex = 0;

            int a = 5;
            loadMostReportedItem(a);
            loadItemsPerDepartment(a);
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
                    conn.Open();
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


                            if (dgvInventoryItems.Columns.Contains("action") && dgvInventoryItems.Columns["action"].Visible)
                            {

                            }
                            else
                            {
                                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                                {
                                    button.Name = "action";
                                    button.HeaderText = "ACTION";
                                    button.Text = "VIEW ITEM";
                                    button.UseColumnTextForButtonValue = true;
                                    this.dgvInventoryItems.Columns.Add(button);
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading items: " + ex.Message, "Inventory Management");
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

        public void loadItemCount()
        {
            try
            {
                this.query = "SELECT " +
                                "(SELECT COUNT(*) FROM InventoryItems WHERE status=@working OR status=@subscribed) as workingCount, " +
                                "(SELECT COUNT(*) FROM InventoryItems WHERE status=@defective OR status=@expired) as defectiveCount, " +
                                "(SELECT COUNT(*) FROM InventoryItems WHERE status=@condemned) as condemnedCount, " +
                                "(SELECT COUNT(*) FROM InventoryItems) as totalItemCount";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@working", "Working");
                        cmd.Parameters.AddWithValue("@defective", "Defective");
                        cmd.Parameters.AddWithValue("@condemned", "Condemned");
                        cmd.Parameters.AddWithValue("@subscribed", "Subscribed");
                        cmd.Parameters.AddWithValue("@expired", "Expired");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblTotalItemsCount.Text = reader["totalItemCount"].ToString();
                            lblWorkingItemsCount.Text = reader["workingCount"].ToString();
                            lblDefectiveItemsCount.Text = reader["defectiveCount"].ToString();
                            lblCondemnedItemsCount.Text = reader["condemnedCount"].ToString();
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

        public void loadItemsPerDepartment(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " b.department as Department, COUNT(a.item) as NumberOfItems " +
                             "FROM InventoryItems a " +
                             "INNER JOIN Departments b ON a.location = b.id " +
                             "WHERE a.academicYear=@academicYear " +
                             "GROUP BY a.location, b.department " +
                             "ORDER BY NumberOfItems DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
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
                            dgvItemsPerDepartment.DataSource = dt;
                            dgvItemsPerDepartment.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading items per department: " + ex.Message, "Inventory Management");
            }
        }

        public void loadMostReportedItem(int num)
        {
            try
            {
                this.query = "SELECT TOP " + num + " item, reportCount " +
                             "FROM InventoryItems " +
                             "WHERE reportCount is not null AND academicYear=@academicYear " +
                             "ORDER BY reportCount DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
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
                            dgvMostReportedItem.DataSource = dt;
                            dgvMostReportedItem.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading most reported item: " + ex.Message, "Inventory Management");
            }
        }

        private void cbNumberOfItemsPerDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberToDisplay = Convert.ToInt32(cbNumberOfItemsPerDepartment.Text);
            loadItemsPerDepartment(numberToDisplay);
        }

        private void cbMostReportedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberToDisplay = Convert.ToInt32(cbMostReportedItem.Text);
            loadMostReportedItem(numberToDisplay);
        }

        private void dgvInventoryItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvInventoryItems.Rows)
            {
                string status = row.Cells["status"].Value.ToString();

                if (status == "Working" || status == "Subscribed")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(92, 184, 92);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
                else if (status == "Defective" || status == "Expired")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(240, 173, 78);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
                else if (status == "Condemned")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(217, 83, 79);
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
            }
        }
    }
}
