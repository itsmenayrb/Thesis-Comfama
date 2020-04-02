using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.AuditTrail
{
    public partial class ucAuditTrail : UserControl
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;
        public static ucAuditTrail mainInstance = null;

        public ucAuditTrail()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucAuditTrail_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            loadAuditTrailData();
        }

        public void loadAuditTrailData()
        {
            try
            {
                this.query = "SELECT AuditTrail.guid as guid, AuditTrail.actionTaken as actionTaken, AuditTrail.oldValue as oldValue, AuditTrail.newValue as newValue, AuditTrail.dateCreated as dateCreated, CONCAT(Employees.firstName + ' ', Employees.lastName) as fullName FROM AuditTrail " +
                             "INNER JOIN Employees ON AuditTrail.employeeID = Employees.employeeID " +
                             "ORDER BY AuditTrail.dateCreated ASC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvAuditTrail.DataSource = dt;
                            dgvAuditTrail.AutoGenerateColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading audit trail: " + ex.Message, "Audit Trail");
            }
        }
    }
}
