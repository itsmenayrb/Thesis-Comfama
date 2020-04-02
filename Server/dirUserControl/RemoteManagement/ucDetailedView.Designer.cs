namespace Server.dirUserControl.RemoteManagement
{
    partial class ucDetailedView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewDetailedView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.machineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.portNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsRemoteManagement = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.viewOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSpecificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemoteManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDetailedView
            // 
            this.listViewDetailedView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDetailedView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.machineName,
            this.location,
            this.ipAddress,
            this.portNumber,
            this.macAddress,
            this.currentUser,
            this.status});
            this.listViewDetailedView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDetailedView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDetailedView.FullRowSelect = true;
            this.listViewDetailedView.GridLines = true;
            this.listViewDetailedView.Location = new System.Drawing.Point(0, 0);
            this.listViewDetailedView.Name = "listViewDetailedView";
            this.listViewDetailedView.Size = new System.Drawing.Size(1321, 310);
            this.listViewDetailedView.TabIndex = 0;
            this.listViewDetailedView.UseCompatibleStateImageBehavior = false;
            this.listViewDetailedView.View = System.Windows.Forms.View.Details;
            this.listViewDetailedView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewDetailedView_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // machineName
            // 
            this.machineName.Text = "Machine Name";
            this.machineName.Width = 150;
            // 
            // location
            // 
            this.location.Text = "Room/Office/Department";
            this.location.Width = 200;
            // 
            // ipAddress
            // 
            this.ipAddress.Text = "Ip Address";
            this.ipAddress.Width = 150;
            // 
            // portNumber
            // 
            this.portNumber.Text = "Port Number";
            this.portNumber.Width = 150;
            // 
            // macAddress
            // 
            this.macAddress.Text = "Mac Address";
            this.macAddress.Width = 200;
            // 
            // currentUser
            // 
            this.currentUser.Text = "Current User";
            this.currentUser.Width = 200;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // cmsRemoteManagement
            // 
            this.cmsRemoteManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsRemoteManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOnlyToolStripMenuItem,
            this.fullControlToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.cmsRemoteManagement.Name = "cmsEmployee";
            this.cmsRemoteManagement.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsRemoteManagement.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsRemoteManagement.RenderStyle.ColorTable = null;
            this.cmsRemoteManagement.RenderStyle.RoundedEdges = true;
            this.cmsRemoteManagement.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsRemoteManagement.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsRemoteManagement.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsRemoteManagement.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsRemoteManagement.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cmsRemoteManagement.Size = new System.Drawing.Size(143, 114);
            // 
            // viewOnlyToolStripMenuItem
            // 
            this.viewOnlyToolStripMenuItem.Name = "viewOnlyToolStripMenuItem";
            this.viewOnlyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewOnlyToolStripMenuItem.Text = "View Only";
            this.viewOnlyToolStripMenuItem.Click += new System.EventHandler(this.viewOnlyToolStripMenuItem_Click);
            // 
            // fullControlToolStripMenuItem
            // 
            this.fullControlToolStripMenuItem.Name = "fullControlToolStripMenuItem";
            this.fullControlToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fullControlToolStripMenuItem.Text = "Full Control";
            this.fullControlToolStripMenuItem.Click += new System.EventHandler(this.fullControlToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingToolStripMenuItem,
            this.viewSpecificationToolStripMenuItem});
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            // 
            // viewSpecificationToolStripMenuItem
            // 
            this.viewSpecificationToolStripMenuItem.Name = "viewSpecificationToolStripMenuItem";
            this.viewSpecificationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.viewSpecificationToolStripMenuItem.Text = "View Specification";
            // 
            // ucDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listViewDetailedView);
            this.Name = "ucDetailedView";
            this.Size = new System.Drawing.Size(1321, 310);
            this.Load += new System.EventHandler(this.ucDetailedView_Load);
            this.cmsRemoteManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDetailedView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader machineName;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader ipAddress;
        private System.Windows.Forms.ColumnHeader portNumber;
        private System.Windows.Forms.ColumnHeader macAddress;
        private System.Windows.Forms.ColumnHeader currentUser;
        private System.Windows.Forms.ColumnHeader status;
        private Guna.UI.WinForms.GunaContextMenuStrip cmsRemoteManagement;
        private System.Windows.Forms.ToolStripMenuItem viewOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSpecificationToolStripMenuItem;
    }
}
