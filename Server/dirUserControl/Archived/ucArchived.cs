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
    public partial class ucArchived : UserControl
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;
        public static ucArchived mainInstance = null;

        public ucArchived()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void ucArchived_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            loadTreeView();
        }

        private void loadTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("Comfama");
            string academicYear = string.Empty;

            try
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                this.query = "SELECT DISTINCT academicYear FROM AcademicYear WHERE hasBeenSet=@hasBeenSet";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@hasBeenSet", 1);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                academicYear = row["academicYear"].ToString();
                                TreeNode parent = new TreeNode(academicYear);
                                root.Nodes.Add(parent);

                                this.query = "SELECT id, semester FROM AcademicYear WHERE academicYear=@academicYear";
                                using (SqlCommand cmd1 = new SqlCommand(this.query, conn))
                                {
                                    cmd1.Parameters.Clear();
                                    cmd1.Parameters.AddWithValue("@academicYear", academicYear);
                                    using (SqlDataAdapter adapter1 = new SqlDataAdapter())
                                    {
                                        adapter1.SelectCommand = cmd1;
                                        adapter1.Fill(dt1);

                                        foreach (DataRow row1 in dt1.Rows)
                                        {
                                            TreeNode child = new TreeNode
                                            {
                                                Text = row1["semester"].ToString(),
                                                Tag = row1["id"].ToString()
                                            };
                                            parent.Nodes.Add(child);

                                            child.Nodes.Add("Inventory Management");
                                            child.Nodes.Add("Maintenance Report");
                                            child.Nodes.Add("Login History");
                                        }
                                    }
                                }
                            }
                            
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on loading supplier: " + ex.Message, "Add Item");
            }

            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNode = treeView1.SelectedNode.Text;
            int id = 0;
            if (selectedNode == "Inventory Management")
            {
                id = Convert.ToInt32(treeView1.SelectedNode.Parent.Tag);
                ucInventoryManagement1.loadAcademicInfo(id);
                ucInventoryManagement1.loadInventoryManagementData(id);

                ucInventoryManagement1.Visible = true;
                ucMaintenanceReport1.Visible = false;
                ucLoginHistory1.Visible = false;
            }
            else if (selectedNode == "Maintenance Report")
            {
                id = Convert.ToInt32(treeView1.SelectedNode.Parent.Tag);
                ucMaintenanceReport1.loadAcademicInfo(id);
                ucMaintenanceReport1.loadMaintenanceReportData(1);

                ucInventoryManagement1.Visible = false;
                ucMaintenanceReport1.Visible = true;
                ucLoginHistory1.Visible = false;
            }
            else if (selectedNode == "Login History")
            {
                id = Convert.ToInt32(treeView1.SelectedNode.Parent.Tag);
                ucLoginHistory1.loadAcademicInfo(id);
                ucLoginHistory1.loadLoginHistoryData(id);

                ucInventoryManagement1.Visible = false;
                ucMaintenanceReport1.Visible = false;
                ucLoginHistory1.Visible = true;
            }
        }
    }
}
