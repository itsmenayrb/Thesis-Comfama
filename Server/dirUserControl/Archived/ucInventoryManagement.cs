using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.Archived
{
    public partial class ucInventoryManagement : UserControl
    {
        public static ucInventoryManagement mainInstance = null;
        public string query = string.Empty;
        public string connectionString = string.Empty;

        public ucInventoryManagement()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucInventoryManagement_Load(object sender, EventArgs e)
        {
            //loadAcademicInfo();
            //loadInventoryManagementData();
        }

        public void loadInventoryManagementData(int id)
        {
            try
            {
                this.query = "SELECT a.item as item, a.description as description, a.brand as brand, a.model as model, a.licenseKey as licenseKey, a.serialNumber as serialNumber, CONCAT(a.capacity + ' ', b.capacity) as capacity, " +
                             "CONCAT(a.quantity + ' ', c.unit) as unit, a.propertyNumber as propertyNumber, d.department as location, a.dateAcquired as dateAcquired, a.dateExpiry as dateExpiry, a.status as status " +
                             "FROM InventoryItems a " +
                             "INNER JOIN InventoryCapacities b ON a.measurement = b.id OR a.measurement is null OR a.measurement = 0 " +
                             "INNER JOIN InventoryUnits c ON a.unit = b.id " +
                             "INNER JOIN Departments d ON a.location = d.id " +
                             "WHERE academicYear=@academicYear";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@academicYear", id);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvInventoryManagement.DataSource = dt;
                            dgvInventoryManagement.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading inventory management: " + ex.Message, "Archived");
            }
        }

        public void loadAcademicInfo(int id)
        {
            try
            {
                this.query = "SELECT CONCAT(semester + ' ', academicYear) as acad FROM AcademicYear WHERE id=@id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblAcademicYear.Text = reader["acad"].ToString();
                        }
                        
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading academic year: " + ex.Message, "Archived");
            }
        }
    }
}
