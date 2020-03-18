using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Server.dirUserControl.BackupRestore
{
    public partial class ucBackupRestore : UserControl
    {
        public static ucBackupRestore mainInstance = null;
        private bool hasError = false;

        public string query = string.Empty;
        public string connectionString = string.Empty;

        private string _path = string.Empty;
        private string _filename = string.Empty;
        private DateTime _time;

        public ucBackupRestore()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucBackupRestore_Load(object sender, EventArgs e)
        {
            displayAppliedSettings();
            loadBackupRestoreLogs();

            string remainingTime = _time.ToLongTimeString();
            DateTime rTime = DateTime.Parse(remainingTime);
            TimeSpan ts = rTime.Subtract(DateTime.Now);

            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void chkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoBackup.Checked)
            {
                panelAutoBackup.Enabled = true;
                dtpTime.Format = DateTimePickerFormat.Time;
            }
            else
            {
                panelAutoBackup.Enabled = false;
                dtpTime.Format = DateTimePickerFormat.Custom;
                dtpTime.CustomFormat = " ";
            }
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtCustomFilename.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the filename for the backup file.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomFilename.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPath.Text))
                {
                    hasError = true;
                    MessageBox.Show("Please browse the folder path you want to save your backup.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPath.Focus();
                    return;
                }
                else
                {
                    if (chkAutoBackup.Checked)
                    {
                        if (cbDay.SelectedIndex == 0 || cbDay.SelectedIndex == -1 || string.IsNullOrEmpty(cbDay.Text))
                        {
                            hasError = true;
                            MessageBox.Show("Please select the day you want to perform automatic backup.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (hasError == false)
                    {
                        string filename = txtCustomFilename.Text;
                        string path = txtPath.Text;
                        string day = string.Empty;
                        DateTime time = DateTime.Now;

                        dirClasses.BackupRestore applySettings = new dirClasses.BackupRestore();

                        if (chkAutoBackup.Checked)
                        {
                            time = dtpTime.Value;
                            day = cbDay.Text;

                            if (applySettings.applyFullSettings(filename, path, day, time))
                            {
                                MessageBox.Show("Settings has been saved.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayAppliedSettings();
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (applySettings.applyPartialSettings(filename, path))
                            {
                                MessageBox.Show("Settings has been saved.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayAppliedSettings();
                                return;
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

        private void dtpTime_Enter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 500;
            tooltip.ReshowDelay = 500;
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.SetToolTip(dtpTime, "Note: The automatic backup will only process if the application is open.");
        }

        private void backUpEntireDatabase(string path, string filename)
        {
            try
            {
                this.query = "ALTER DATABASE dbThesisComfama SET MULTI_USER WITH ROLLBACK IMMEDIATE";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                SqlConnection.ClearAllPools();

                this.query = @"BACKUP DATABASE dbThesisComfama TO DISK=" + "'" + path + @"\" + filename + "'";
                //MessageBox.Show(this.query);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error on backup database: " + ex.Message);
            }

        }

        private void notifyIfDontHaveSettingsYet()
        {
            if (!new dirClasses.BackupRestore().hasSettingsApplied())
            {
                MessageBox.Show("You do not currently have a saved settings to perform a backup. Please make a new one.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void displayAppliedSettings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT * FROM BackupRestoreSettings";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            _filename = reader["filename"].ToString();
                            txtCustomFilename.Text = _filename;
                            _path = reader["path"].ToString();
                            txtPath.Text = _path;
                            cbDay.SelectedIndex = string.IsNullOrEmpty(reader["day"].ToString()) ? 0 : cbDay.FindStringExact(reader["day"].ToString());

                            if (string.IsNullOrEmpty(reader["time"].ToString()))
                            {
                                dtpTime.Format = DateTimePickerFormat.Custom;
                                dtpTime.CustomFormat = " ";
                                chkAutoBackup.Checked = false;
                            }
                            else
                            {
                                dtpTime.Value = Convert.ToDateTime(reader["time"]);
                                _time = dtpTime.Value;
                                chkAutoBackup.Checked = true;
                            }

                        }
                        gbSettings.Enabled = false;
                        chkSettings.Checked = false;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void chkSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSettings.Checked)
            {
                gbSettings.Enabled = true;
            }
            else
            {
                gbSettings.Enabled = false;
            }
        }

        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Backup database?", "Backup and Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string filename = "Backup-" + _filename + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";
                backUpEntireDatabase(_path, filename);
                new dirClasses.BackupRestore().logDatabaseAction(1, 0);
                Notification toastNotification = new Notification("success", "Backup and Restore", filename + " has been saved to " + _path, 30, dirClasses.FormAnimator.AnimationMethod.Slide, dirClasses.FormAnimator.AnimationDirection.Left);
                toastNotification.Show();
                dirClasses.Configuration.PlayNotificationSound("garden");
                loadBackupRestoreLogs();
                Process.Start("explorer.exe", "/select, " + _path + @"\" + filename);
            }
            else
            {
                MessageBox.Show("Operation cancelled.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Restore database?", "Backup and Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select database file";
                    ofd.Filter = "Bak files (*.bak) | *.bak";
                    ofd.InitialDirectory = _path;
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != null)
                    {
                        string filename = ofd.FileName;
                        DialogResult r = MessageBox.Show("Restore " + Path.GetFileName(filename) + "?\nYou may lose data for performing this action. Do still want to proceed?", "Backup and Restore", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (r == DialogResult.Yes)
                        {
                            restoreEntireDatabase(filename);
                            new dirClasses.BackupRestore().logDatabaseAction(0, 0);
                            DialogResult s = MessageBox.Show("Database has been restored successfull!\n\nPress OK to restart the application.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (s == DialogResult.OK)
                            {
                                ((Form)this.TopLevelControl).Close();
                                new frmLogin().ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Operation cancelled.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a database file.", "Backup and Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void restoreEntireDatabase(string filename)
        {
            try
            {
                this.query = "ALTER DATABASE dbThesisComfama SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                SqlConnection.ClearAllPools();

                this.query = @"USE MASTER RESTORE DATABASE dbThesisComfama FROM DISK=" + "'" + filename + "' WITH REPLACE";
                //MessageBox.Show(this.query);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                SqlConnection.ClearAllPools();

                this.query = "ALTER DATABASE dbThesisComfama SET MULTI_USER";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error on restore database: " + ex.Message);
            }
        }

        private void loadBackupRestoreLogs()
        {
            try
            {
                this.query = "SELECT CASE WHEN action = 1 THEN 'Backup' ELSE 'Restore' END as ACTION, actionDateTime as DATE, CASE WHEN actionType = 0 THEN 'Manual' ELSE 'Automatic' END as PROCESS FROM BackupRestoreLogs ORDER BY actionDateTime DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);
                            dgvBackupAndRestore.DataSource = dt;
                            dgvBackupAndRestore.AutoGenerateColumns = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading backup and restore logs: " + ex.Message, "Backup and Restore");
            }
        }

        private void timerAutoBackupRemaining_Tick(object sender, EventArgs e)
        {
            string remainingTime = _time.ToLongTimeString();
            DateTime rTime = DateTime.Parse(remainingTime);
            TimeSpan ts = rTime.Subtract(DateTime.Now);
            lblRemainingTime.Text = ts.ToString("h' hrs 'm' mins 's' secs remaining to perform automatic backup'");

            if (Math.Abs(ts.TotalSeconds) < .5)
            {
                string filename = "Backup-" + _filename + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";
                backUpEntireDatabase(_path, filename);
                new dirClasses.BackupRestore().logDatabaseAction(1, 1);
                Notification toastNotification = new Notification("success", "Backup and Restore", filename + " has been saved to " + _path, 30, dirClasses.FormAnimator.AnimationMethod.Slide, dirClasses.FormAnimator.AnimationDirection.Left);
                toastNotification.Show();
                dirClasses.Configuration.PlayNotificationSound("garden");
                loadBackupRestoreLogs();
                Process.Start("explorer.exe", "/select, " + _path + @"\" + filename);
            }
        }
    }
}
