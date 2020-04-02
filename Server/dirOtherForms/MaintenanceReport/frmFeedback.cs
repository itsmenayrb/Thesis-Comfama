using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.MaintenanceReport
{
    public partial class frmFeedback : Form
    {
        public static frmFeedback mainInstance = null;
        public string query = string.Empty;
        public string connectionString = string.Empty;

        private string category { get; set; }
        private string select { get; set; }
        private int inventoryItemID { get; set; }
        public static string ticketID { get; set; }

        private bool hasError = false;

        public frmFeedback()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmFeedback_Load(object sender, EventArgs e)
        {
            startDesign();
            disableActionTaken();
            lblTicketID.Text = "TICKET ID: " + ticketID;
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void startDesign()
        {
            frmFeedback.mainInstance.Size = new Size(618, 695);
            gbActionTaken.Location = new Point(12, 255);
            gbFeedback.Location = new Point(12, 402);
            gbReportStatus.Location = new Point(12, 563);
            btnSubmitFeedback.Location = new Point(428, 636);
            btnCancel.Location = new Point(301, 636);
        }

        private void rbHardware_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHardware.Checked)
            {
                enableHardwareOptions();
                lblSelect.Text = "SELECT HARDWARE";
                enableActionTaken();
                resetReplacementOption();
            }
            else
            {
                disableHardwareOptions();
                showSelectOption();
                lblSelect.Text = "SELECT SOFTWARE";
                loadSoftware();
                enableActionTaken();
            }
        }

        private void rbSoftware_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbSoftware.Checked)
            {
                enableHardwareOptions();
                showSelectOption();
                rbReinstall.Enabled = false;
                rbReplace.Enabled = false;
                rbTroubleshoot.Enabled = false;
                lblSelect.Text = "SELECT HARDWARE";
                rbReinstall.Checked = false;
                resetReplacementOption();
            }
            else
            {
                disableHardwareOptions();
                showSelectOption();
                lblSelect.Text = "SELECT SOFTWARE";
                loadSoftware();
                rbReinstall.Enabled = true;
                rbReplace.Enabled = false;
                rbTroubleshoot.Enabled = true;
            }
            select = string.Empty;
            hideReplacement();
        }

        private void rbComputerUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComputerUnit.Checked)
            {
                lblSelect.Text = "SELECT COMPUTER UNIT";
                enableActionTaken();
                loadComputerUnits();
                hideReplacement();
                showSelectOption();
            }
            else
            {
                lblSelect.Text = "SELECT PERIPHERALS";
                loadInventoryPeripherals();
                enableActionTaken();
                showReplacement();
            }
            select = string.Empty;
        }

        private void rbOtherPeripherals_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbOtherPeripherals.Checked)
            {
                lblSelect.Text = "SELECT COMPUTER UNIT";
                loadComputerUnits();
                enableActionTaken();
                select = string.Empty;
                hideReplacement();
                gbStatusHardware.Visible = false;
            }
            else
            {
                lblSelect.Text = "SELECT PERIPHERALS";
                loadInventoryPeripherals();
                enableActionTaken();
                select = "Peripherals";
                showSelectOption();
                gbStatusHardware.Visible = true;
            }
        }

        private void loadComputerUnits()
        {
            try
            {
                this.query = "SELECT id, machineName FROM RemotePC WHERE remoteType!=@remoteType";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@remoteType", "Main Server");

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select Computer Unit--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbSelect.DataSource = dt;
                            cbSelect.DisplayMember = "machineName";
                            cbSelect.ValueMember = "id";

                            cbSelect.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading computer unit: " + ex.Message, "Send Feedback");
            }
        }

        private void loadInventoryPeripherals()
        {
            try
            {
                this.query = "SELECT a.id as id, CONCAT(a.item + ' (S/N ', a.serialNumber + ')') as item FROM InventoryItems a INNER JOIN InventoryTypes b ON a.inventoryType = b.id WHERE b.type!=@type AND status!=@status";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Software");
                        cmd.Parameters.AddWithValue("@status", "Condemned");
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select Peripherals--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbSelect.DataSource = dt;
                            cbSelect.DisplayMember = "item";
                            cbSelect.ValueMember = "id";

                            cbSelect.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading computer peripherals: " + ex.Message, "Send Feedback");
            }
        }

        private int getCategory(int id)
        {
            int category = 0;
            try
            {
                this.query = "SELECT category FROM InventoryItems WHERE id=@id";
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
                            category = Convert.ToInt32(reader["category"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on getting category: " + ex.Message, "Send Feedback");
            }
            return category;
        }

        private void loadSoftware()
        {
            try
            {
                this.query = "SELECT a.id as id, a.item as item FROM InventoryItems a INNER JOIN InventoryTypes b ON a.inventoryType = b.id WHERE b.type=@type AND status=@status";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@type", "Software");
                        cmd.Parameters.AddWithValue("@status", "Subscribed");
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select Software--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbSelect.DataSource = dt;
                            cbSelect.DisplayMember = "item";
                            cbSelect.ValueMember = "id";

                            cbSelect.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading software: " + ex.Message, "Send Feedback");
            }
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select == "Peripherals")
            {
                inventoryItemID = Convert.ToInt32(cbSelect.SelectedValue);
                loadPeripheralsForReplace(getCategory(Convert.ToInt32(cbSelect.SelectedValue)));
            }
        }

        public void loadPeripheralsForReplace(int category)
        {
            try
            {
                this.query = "SELECT id, item FROM InventoryItems WHERE category=@category AND id!=@id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@id", inventoryItemID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            //Insert the Default Item to DataTable.
                            DataRow row = dt.NewRow();
                            row[0] = 0;
                            row[1] = "--Select item to replace with--";
                            dt.Rows.InsertAt(row, 0);

                            //Assign DataTable as DataSource.
                            cbPeripherals.DataSource = dt;
                            cbPeripherals.DisplayMember = "item";
                            cbPeripherals.ValueMember = "id";

                            cbPeripherals.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading computer peripherals: " + ex.Message, "Send Feedback");
            }
        }

        private void rbReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReplace.Checked)
            {
                showReplacement();
            }
            else
            {
                hideReplacement();
            }
        }

        private void rbTroubleshoot_CheckedChanged(object sender, EventArgs e)
        {
            hideReplacement();
        }

        private void rbReinstall_CheckedChanged(object sender, EventArgs e)
        {
            hideReplacement();
        }

        private void enableHardwareOptions()
        {
            gbHardware.Enabled = true;
            rbOtherPeripherals.Checked = false;
            rbComputerUnit.Checked = false;
        }

        private void disableHardwareOptions()
        {
            gbHardware.Enabled = false;
            rbOtherPeripherals.Checked = false;
            rbComputerUnit.Checked = false;
        }

        private void showSelectOption()
        {
            frmFeedback.mainInstance.Size = new Size(618, 815);
            gbActionTaken.Location = new Point(12, 374);
            gbSelect.Visible = true;

            gbFeedback.Location = new Point(12, 521);
            gbReportStatus.Location = new Point(12, 682);
            btnSubmitFeedback.Location = new Point(428, 755);
            btnCancel.Location = new Point(301, 755);
        }

        private void enableActionTaken()
        {
            if (rbHardware.Checked)
            {
                disableActionTaken();
                if (rbComputerUnit.Checked)
                {
                    rbTroubleshoot.Enabled = true;
                }
                else
                {
                    rbReplace.Enabled = true;
                    rbTroubleshoot.Enabled = true;
                }
            }
            else
            {
                disableActionTaken();
                rbReinstall.Enabled = true;
                rbTroubleshoot.Enabled = true;
            }
        }

        private void disableActionTaken()
        {
            rbReinstall.Enabled = false;
            rbTroubleshoot.Enabled = false;
            rbReplace.Enabled = false;

            rbReinstall.Checked = false;
            rbTroubleshoot.Checked = false;
            rbReplace.Checked = false;
        }

        private void showReplacement()
        {
            lblWith.Visible = true;
            cbPeripherals.Visible = true;
            btnAddItem.Visible = true;
        }

        private void hideReplacement()
        {
            lblWith.Visible = false;
            cbPeripherals.Visible = false;
            btnAddItem.Visible = false;
        }

        private void resetReplacementOption()
        {
            cbPeripherals.DataSource = null;
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (rbHardware.Checked == false && rbSoftware.Checked == false)
            {
                hasError = true;
                MessageBox.Show("Please choose your findings if the problem is hardware or software related.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (rbHardware.Checked)
                {
                    if (rbComputerUnit.Checked == false && rbOtherPeripherals.Checked == false)
                    {
                        hasError = true;
                        MessageBox.Show("Please choose if the problem is on the computer unit itself or other peripherals", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (rbComputerUnit.Checked)
                        {
                            if (cbSelect.SelectedIndex == 0 || cbSelect.SelectedIndex == -1)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the computer unit that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if (!rbTroubleshoot.Checked)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please choose the action you took to respond to the problem.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtFeedback.Text))
                                    {
                                        hasError = true;
                                        MessageBox.Show("Please leave a feedback or comment.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtFeedback.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        if (rbCompleted.Checked == false && rbOngoing.Checked == false)
                                        {
                                            hasError = true;
                                            MessageBox.Show("Please choose what will be the status of this report.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        else
                                        {
                                            if (hasError == false)
                                            {
                                                string ticketNumber = ticketID;
                                                string findings = rbHardware.Text;
                                                string typeOfHardware = rbComputerUnit.Text;
                                                int selectedUnit = Convert.ToInt32(cbSelect.SelectedValue);
                                                string actionTaken = rbTroubleshoot.Text;
                                                string feedback = txtFeedback.Text;
                                                string status = rbCompleted.Checked ? rbCompleted.Text : rbOngoing.Text;

                                                dirClasses.SubmitFeedback submitFeedback = new dirClasses.SubmitFeedback();

                                                if (submitFeedback.hasSameReportForThisUnit(ticketNumber, selectedUnit) == 0)
                                                {
                                                    submitFeedback.addReportCountForThisUnit(selectedUnit);
                                                }

                                                if (submitFeedback.submitFeedbackForComputerUnit(ticketNumber, findings, typeOfHardware, selectedUnit, actionTaken, feedback))
                                                {
                                                    if (submitFeedback.updateReportStatus(ticketNumber, status))
                                                    {
                                                        MessageBox.Show("Feedback has been sent.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        frmViewReport.mainInstance.loadSelectedReportedIssue();
                                                        frmViewReport.mainInstance.enableButton();
                                                        dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadMaintenanceReportData();
                                                        dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadReportCount();
                                                        this.Close();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (rbOtherPeripherals.Checked)
                        {
                            if (cbSelect.SelectedIndex == 0 || cbSelect.SelectedIndex == -1)
                            {
                                hasError = true;
                                MessageBox.Show("Please select the item that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if (rdbWorking.Checked == false && rdbDefective.Checked == false && rdbCondemned.Checked == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please choose the new status of the item that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if (rbReplace.Checked == false && rbTroubleshoot.Checked == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Please choose the action you took to respond to the problem.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    else
                                    {
                                        if (rbReplace.Checked)
                                        {
                                            if (cbPeripherals.SelectedIndex == 0 || cbPeripherals.SelectedIndex == -1)
                                            {
                                                hasError = true;
                                                MessageBox.Show("Please select the new item to replace the old one.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(txtFeedback.Text))
                                                {
                                                    hasError = true;
                                                    MessageBox.Show("Please leave a feedback or comment.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtFeedback.Focus();
                                                    return;
                                                }
                                                else
                                                {
                                                    if (rbCompleted.Checked == false && rbOngoing.Checked == false)
                                                    {
                                                        hasError = true;
                                                        MessageBox.Show("Please choose what will be the status of this report.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        if (hasError == false)
                                                        {
                                                            string ticketNumber = ticketID;
                                                            string findings = rbHardware.Text;
                                                            string typeOfHardware = rbOtherPeripherals.Text;
                                                            int selectedItem = Convert.ToInt32(cbSelect.SelectedValue);
                                                            string selectedItemNewStatus = string.Empty;

                                                            foreach (Control c in gbStatusHardware.Controls)
                                                            {
                                                                if (c.GetType() == typeof(Guna.UI.WinForms.GunaRadioButton))
                                                                {
                                                                    Guna.UI.WinForms.GunaRadioButton rb = c as Guna.UI.WinForms.GunaRadioButton;
                                                                    if (rb.Checked)
                                                                    {
                                                                        selectedItemNewStatus = rb.Text;
                                                                    }
                                                                }
                                                            }

                                                            int replacedWithThisItem = Convert.ToInt32(cbPeripherals.SelectedValue);

                                                            string actionTaken = rbReplace.Text;
                                                            string feedback = txtFeedback.Text;
                                                            string status = rbCompleted.Checked ? rbCompleted.Text : rbOngoing.Text;

                                                            dirClasses.SubmitFeedback submitFeedback = new dirClasses.SubmitFeedback();

                                                            if (submitFeedback.hasSameReportForThisItem(ticketNumber, selectedItem) == 0)
                                                            {
                                                                submitFeedback.addReportCountForThisItem(selectedItem);
                                                            }

                                                            if (submitFeedback.submitFeedbackForItem(ticketNumber, findings, typeOfHardware, selectedItem, replacedWithThisItem, actionTaken, feedback))
                                                            {
                                                                if (submitFeedback.updateReportStatus(ticketNumber, status))
                                                                {
                                                                    if (submitFeedback.replaceItem(selectedItem, replacedWithThisItem))
                                                                    {
                                                                        if (submitFeedback.setNewStatusOFReplaceItem(selectedItem, selectedItemNewStatus))
                                                                        {

                                                                            MessageBox.Show("Feedback has been sent.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                            frmViewReport.mainInstance.loadSelectedReportedIssue();
                                                                            frmViewReport.mainInstance.enableButton();
                                                                            dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadMaintenanceReportData();
                                                                            dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadReportCount();
                                                                            dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemCount();
                                                                            dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemData();
                                                                            this.Close();
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (rbTroubleshoot.Checked)
                                        {
                                            if (string.IsNullOrEmpty(txtFeedback.Text))
                                            {
                                                hasError = true;
                                                MessageBox.Show("Please leave a feedback or comment.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtFeedback.Focus();
                                                return;
                                            }
                                            else
                                            {
                                                if (rbCompleted.Checked == false && rbOngoing.Checked == false)
                                                {
                                                    hasError = true;
                                                    MessageBox.Show("Please choose what will be the status of this report.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    return;
                                                }
                                                else
                                                {
                                                    if (hasError == false)
                                                    {
                                                        string ticketNumber = ticketID;
                                                        string findings = rbHardware.Text;
                                                        string typeOfHardware = rbOtherPeripherals.Text;
                                                        int selectedItem = Convert.ToInt32(cbSelect.SelectedValue);
                                                        string selectedItemNewStatus = string.Empty;

                                                        foreach (Control c in gbStatusHardware.Controls)
                                                        {
                                                            if (c.GetType() == typeof(Guna.UI.WinForms.GunaRadioButton))
                                                            {
                                                                Guna.UI.WinForms.GunaRadioButton rb = c as Guna.UI.WinForms.GunaRadioButton;
                                                                if (rb.Checked)
                                                                {
                                                                    selectedItemNewStatus = rb.Text;
                                                                }
                                                            }
                                                        }

                                                        string actionTaken = rbReplace.Text;
                                                        string feedback = txtFeedback.Text;
                                                        string status = rbCompleted.Checked ? rbCompleted.Text : rbOngoing.Text;

                                                        dirClasses.SubmitFeedback submitFeedback = new dirClasses.SubmitFeedback();

                                                        if (submitFeedback.hasSameReportForThisItem(ticketNumber, selectedItem) == 0)
                                                        {
                                                            submitFeedback.addReportCountForThisItem(selectedItem);
                                                        }

                                                        if (submitFeedback.submitFeedbackForItemTroubleshoot(ticketNumber, findings, typeOfHardware, selectedItem, actionTaken, feedback))
                                                        {
                                                            if (submitFeedback.updateReportStatus(ticketNumber, status))
                                                            {
                                                                if (submitFeedback.setNewStatusOFReplaceItem(selectedItem, selectedItemNewStatus))
                                                                {

                                                                    MessageBox.Show("Feedback has been sent.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    frmViewReport.mainInstance.loadSelectedReportedIssue();
                                                                    frmViewReport.mainInstance.enableButton();
                                                                    dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadMaintenanceReportData();
                                                                    dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadReportCount();
                                                                    dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemCount();
                                                                    dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemData();
                                                                    this.Close();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (rbSoftware.Checked)
                {
                    if (cbSelect.SelectedIndex == 0 || cbSelect.SelectedIndex == -1)
                    {
                        hasError = true;
                        MessageBox.Show("Please select the software that having issue with.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (rbReinstall.Checked == false && rbTroubleshoot.Checked == false)
                        {
                            hasError = true;
                            MessageBox.Show("Please choose the action you took to respond to the problem.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtFeedback.Text))
                            {
                                hasError = true;
                                MessageBox.Show("Please leave a feedback or comment.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtFeedback.Focus();
                                return;
                            }
                            else
                            {
                                if (rbCompleted.Checked == false && rbOngoing.Checked == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Please choose what will be the status of this report.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    if (hasError == false)
                                    {
                                        string ticketNumber = ticketID;
                                        string findings = rbSoftware.Text;
                                        int selectedItem = Convert.ToInt32(cbSelect.SelectedValue);
                                        string actionTaken = rbTroubleshoot.Checked ? rbTroubleshoot.Text : rbReinstall.Text;
                                        string feedback = txtFeedback.Text;
                                        string status = rbCompleted.Checked ? rbCompleted.Text : rbOngoing.Text;

                                        dirClasses.SubmitFeedback submitFeedback = new dirClasses.SubmitFeedback();

                                        if (submitFeedback.hasSameReportForThisItem(ticketNumber, selectedItem) == 0)
                                        {
                                            submitFeedback.addReportCountForThisItem(selectedItem);
                                        }

                                        if (submitFeedback.submitFeedbackForSoftware(ticketNumber, findings, actionTaken, feedback))
                                        {
                                            if (submitFeedback.updateReportStatus(ticketNumber, status))
                                            {
                                                MessageBox.Show("Feedback has been sent.", "Send Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                frmViewReport.mainInstance.loadSelectedReportedIssue();
                                                frmViewReport.mainInstance.enableButton();
                                                dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadMaintenanceReportData();
                                                dirUserControl.MaintenanceReport.ucMaintenanceReport.mainInstance.loadReportCount();
                                                dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemCount();
                                                dirUserControl.InventoryManagement.ucInventoryItems.mainInstance.loadItemData();
                                                this.Close();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            dirOtherForms.InventoryManagement.frmAddItems.request = "CameFromMaintenance";
            new dirOtherForms.InventoryManagement.frmAddItems().ShowDialog();
        }
    }
}
