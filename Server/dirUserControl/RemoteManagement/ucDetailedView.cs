using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Server.dirUserControl.RemoteManagement
{
    public partial class ucDetailedView : UserControl
    {
        public static ucDetailedView mainInstance = null;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        private string selectedMachineName { get; set; }

        public ucDetailedView()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucDetailedView_Load(object sender, EventArgs e)
        {
            loadDetailedView();
        }

        public void loadDetailedView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT id as ID, machineName as 'MACHINE NAME', serverLocation as 'ROOM/OFFICE/DEPARTMENT', ipAddress as 'IP ADDRESS', portNumber as 'PORT NUMBER', macAddress as 'MAC ADDRESS', currentUser as 'CURRENT USER', status as 'STATUS' FROM RemotePC WHERE machineName!=@machineName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@machineName", Environment.MachineName.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Fill the DataTable with records from Table.
                            DataTable dt = new DataTable();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                DataRow row = dt.Rows[i];
                                ListViewItem item = new ListViewItem(row["ID"].ToString());
                                item.Font = new Font("Century Gothic", 9, FontStyle.Regular);
                                item.SubItems.Add(row["MACHINE NAME"].ToString());
                                item.SubItems.Add(row["ROOM/OFFICE/DEPARTMENT"].ToString());
                                item.SubItems.Add(row["IP ADDRESS"].ToString());
                                item.SubItems.Add(row["PORT NUMBER"].ToString());
                                item.SubItems.Add(row["MAC ADDRESS"].ToString());
                                item.SubItems.Add(row["CURRENT USER"].ToString());
                                item.SubItems.Add(row["STATUS"].ToString());
                                listViewDetailedView.Items.Add(item);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading remote pc on detailed view: " + ex.Message, "Remote Management");
            }
        }

        private void listViewDetailedView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (listViewDetailedView.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsRemoteManagement.Show(Cursor.Position);
                    selectedMachineName = listViewDetailedView.SelectedItems[0].SubItems[1].Text;
                }
            }
        }

        private void viewOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRemoteManagement.mainInstance.loadSelectedMachineInformation(selectedMachineName);
            ucRemoteManagement.mainInstance.performViewOnly();
        }

        private void fullControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRemoteManagement.mainInstance.loadSelectedMachineInformation(selectedMachineName);
            ucRemoteManagement.mainInstance.performFullControl();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRemoteManagement.mainInstance.loadSelectedMachineInformation(selectedMachineName);
            ucRemoteManagement.mainInstance.performRestart();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRemoteManagement.mainInstance.loadSelectedMachineInformation(selectedMachineName);
            ucRemoteManagement.mainInstance.performShutdown();
        }
    }
}
