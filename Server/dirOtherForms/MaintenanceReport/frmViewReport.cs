using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.MaintenanceReport
{
    public partial class frmViewReport : Form
    {
        public static frmViewReport mainInstance = null;
        public string query = string.Empty;
        public string connectionString = string.Empty;

        public static int RequestAssistanceID { get; set; }
        private static string ticketID { get; set; }

        public frmViewReport()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmViewReport_Load(object sender, EventArgs e)
        {
            loadSelectedReportedIssue();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            enableButton();
            
        }

        private void btnAcknowledge_Click(object sender, EventArgs e)
        {
            acknowledgeThisReport();
            loadSelectedReportedIssue();
            enableButton();
            DialogResult res = MessageBox.Show("Report with " + lblTicketID.Text + " has been acknowledged. Do you want to leave a feedback?", "Request Assistance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                frmFeedback.ticketID = ticketID;
                new frmFeedback().ShowDialog();
            }
        }

        private void btnViewHistoryOfThisReport_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAllReports_Click(object sender, EventArgs e)
        {

        }

        private void linkViewAttachments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadSelectedReportedIssue()
        {
            try
            {
                this.query = "SELECT RequestAssistance.ticketNumber as ticketNumber, RequestAssistance.employeeID as employeeID, RequestAssistance.title as problem, RequestAssistance.description as description, RequestAssistance.location as location, RequestAssistance.dateRequest as dateReported, RequestAssistance.status as status, " +
                                "CONCAT(Employees.firstName + ' ', Employees.lastName) as fullName, Employees.profilePicture as profilePicture " +
                             "FROM RequestAssistance INNER JOIN Employees ON RequestAssistance.employeeID = Employees.employeeID " +
                             "WHERE RequestAssistance.id=@id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", RequestAssistanceID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblFullName.Text = reader["fullName"].ToString();
                            lblEmployeeID.Text = reader["employeeID"].ToString();
                            lblLocation.Text = reader["location"].ToString();
                            pbProfilePicture.Image = Image.FromStream(new MemoryStream((Byte[])reader["profilePicture"]));

                            lblTicketID.Text = "TICKET ID: " + reader["ticketNumber"].ToString();
                            ticketID = reader["ticketNumber"].ToString();
                            lblDateReported.Text = reader["dateReported"].ToString();
                            lblStatus.Text = reader["status"].ToString();

                            txtProblem.Text = reader["problem"].ToString();
                            txtDescription.Text = reader["description"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading selected report: " + ex.Message, "View Report");
            }
        }

        private void acknowledgeThisReport()
        {
            try
            {
                this.query = "UPDATE RequestAssistance SET status=@status WHERE id=@id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", RequestAssistanceID);
                        cmd.Parameters.AddWithValue("@status", "Ongoing");
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading acknowledging report: " + ex.Message, "View Report");
            }
        }

        public void enableButton()
        {
            btnAcknowledge.Enabled = lblStatus.Text == "Pending" ? true : false;
            btnSendFeedback.Enabled = lblStatus.Text == "Completed" ? false : true;
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            frmFeedback.ticketID = ticketID;
            new frmFeedback().ShowDialog();
        }
    }
}
