namespace Server
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMessages = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShutdown = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnAuditTrail = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblEmployeeID = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.pbProfilePicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnAbout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnArchived = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBackupAndRestore = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnManageUsers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLoginHistory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMaintenanceReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnInventoryManagement = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnRemoteManagement = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ucAuditTrail1 = new Server.dirUserControl.AuditTrail.ucAuditTrail();
            this.ucArchived1 = new Server.dirUserControl.Archived.ucArchived();
            this.ucLoginHistory1 = new Server.dirUserControl.LoginHistory.ucLoginHistory();
            this.ucMaintenanceReport1 = new Server.dirUserControl.MaintenanceReport.ucMaintenanceReport();
            this.ucSettings1 = new Server.dirUserControl.Settings.ucSettings();
            this.ucBackupRestore1 = new Server.dirUserControl.BackupRestore.ucBackupRestore();
            this.ucRemoteManagement1 = new Server.dirUserControl.RemoteManagement.ucRemoteManagement();
            this.ucUserManagement1 = new Server.dirUserControl.UserManagement.ucUserManagement();
            this.ucInventoryManagement1 = new Server.dirUserControl.InventoryManagement.ucInventoryManagement();
            this.ucDashboard1 = new Server.dirUserControl.Dashboard.ucDashboard();
            this.cmsMain = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerIncomingRequest = new System.Windows.Forms.Timer(this.components);
            this.timerCastScreenToClient = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.gunaLabel2);
            this.panelTop.Controls.Add(this.gunaLabel1);
            this.panelTop.Controls.Add(this.gunaPictureBox1);
            this.panelTop.Controls.Add(this.btnMessages);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnShutdown);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(283, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1417, 102);
            this.panelTop.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(28, 78);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(757, 21);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "A Network-Based Computer Facilities and Inventory Management with Decision Suppor" +
    "t System";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(20, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(218, 44);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "COMFAMA";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = global::Server.Resource1.kuya_logo_1_2_white;
            this.gunaPictureBox1.Location = new System.Drawing.Point(180, 1);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(155, 153);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 20;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnMessages
            // 
            this.btnMessages.AnimationHoverSpeed = 0.07F;
            this.btnMessages.AnimationSpeed = 0.03F;
            this.btnMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnMessages.BaseColor = System.Drawing.Color.Transparent;
            this.btnMessages.BorderColor = System.Drawing.Color.Black;
            this.btnMessages.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnMessages.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMessages.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMessages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMessages.CheckedImage")));
            this.btnMessages.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMessages.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMessages.FocusedColor = System.Drawing.Color.Empty;
            this.btnMessages.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMessages.Image = ((System.Drawing.Image)(resources.GetObject("btnMessages.Image")));
            this.btnMessages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMessages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMessages.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMessages.Location = new System.Drawing.Point(1308, 37);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(0);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnMessages.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMessages.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMessages.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnMessages.OnHoverImage")));
            this.btnMessages.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMessages.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMessages.Size = new System.Drawing.Size(38, 41);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.TextOffsetX = 10;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(934, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 12;
            this.txtSearch.Size = new System.Drawing.Size(333, 29);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(1270, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSearch.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.OnHoverImage")));
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnSearch.Size = new System.Drawing.Size(38, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextOffsetX = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.AnimationHoverSpeed = 0.07F;
            this.btnShutdown.AnimationSpeed = 0.03F;
            this.btnShutdown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutdown.BaseColor = System.Drawing.Color.Transparent;
            this.btnShutdown.BorderColor = System.Drawing.Color.Black;
            this.btnShutdown.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnShutdown.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShutdown.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnShutdown.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnShutdown.CheckedImage")));
            this.btnShutdown.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShutdown.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShutdown.FocusedColor = System.Drawing.Color.Empty;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShutdown.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShutdown.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShutdown.Location = new System.Drawing.Point(1346, 37);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnShutdown.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShutdown.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnShutdown.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnShutdown.OnHoverImage")));
            this.btnShutdown.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShutdown.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnShutdown.Size = new System.Drawing.Size(38, 41);
            this.btnShutdown.TabIndex = 2;
            this.btnShutdown.TextOffsetX = 10;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.BackgroundImage = global::Server.Resource1.sidebar;
            this.panelSide.Controls.Add(this.btnAuditTrail);
            this.panelSide.Controls.Add(this.lblEmployeeID);
            this.panelSide.Controls.Add(this.lblName);
            this.panelSide.Controls.Add(this.pbProfilePicture);
            this.panelSide.Controls.Add(this.btnAbout);
            this.panelSide.Controls.Add(this.btnArchived);
            this.panelSide.Controls.Add(this.btnBackupAndRestore);
            this.panelSide.Controls.Add(this.btnManageUsers);
            this.panelSide.Controls.Add(this.btnLoginHistory);
            this.panelSide.Controls.Add(this.btnMaintenanceReport);
            this.panelSide.Controls.Add(this.btnInventoryManagement);
            this.panelSide.Controls.Add(this.btnRemoteManagement);
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(283, 950);
            this.panelSide.TabIndex = 0;
            // 
            // btnAuditTrail
            // 
            this.btnAuditTrail.AnimationHoverSpeed = 0.07F;
            this.btnAuditTrail.AnimationSpeed = 0.03F;
            this.btnAuditTrail.BaseColor = System.Drawing.Color.White;
            this.btnAuditTrail.BorderColor = System.Drawing.Color.Black;
            this.btnAuditTrail.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAuditTrail.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAuditTrail.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAuditTrail.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAuditTrail.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAuditTrail.CheckedImage")));
            this.btnAuditTrail.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAuditTrail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAuditTrail.FocusedColor = System.Drawing.Color.Empty;
            this.btnAuditTrail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditTrail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAuditTrail.Image = ((System.Drawing.Image)(resources.GetObject("btnAuditTrail.Image")));
            this.btnAuditTrail.ImageOffsetX = 20;
            this.btnAuditTrail.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAuditTrail.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAuditTrail.Location = new System.Drawing.Point(0, 693);
            this.btnAuditTrail.Margin = new System.Windows.Forms.Padding(0);
            this.btnAuditTrail.Name = "btnAuditTrail";
            this.btnAuditTrail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAuditTrail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAuditTrail.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAuditTrail.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAuditTrail.OnHoverImage")));
            this.btnAuditTrail.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAuditTrail.OnPressedColor = System.Drawing.Color.Black;
            this.btnAuditTrail.Size = new System.Drawing.Size(283, 67);
            this.btnAuditTrail.TabIndex = 20;
            this.btnAuditTrail.Text = "Audit Trail";
            this.btnAuditTrail.TextOffsetX = 10;
            this.btnAuditTrail.Click += new System.EventHandler(this.btnAuditTrail_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeID.Location = new System.Drawing.Point(18, 142);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(45, 17);
            this.lblEmployeeID.TabIndex = 19;
            this.lblEmployeeID.Text = "A1234";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(18, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 17);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Philip Andrew Ersando";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pbProfilePicture.BaseColor = System.Drawing.Color.Transparent;
            this.pbProfilePicture.Image = global::Server.Resource1.Portrait_Placeholder;
            this.pbProfilePicture.Location = new System.Drawing.Point(21, 28);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(99, 94);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 17;
            this.pbProfilePicture.TabStop = false;
            this.pbProfilePicture.UseTransfarantBackground = false;
            // 
            // btnAbout
            // 
            this.btnAbout.AnimationHoverSpeed = 0.07F;
            this.btnAbout.AnimationSpeed = 0.03F;
            this.btnAbout.BaseColor = System.Drawing.Color.White;
            this.btnAbout.BorderColor = System.Drawing.Color.Black;
            this.btnAbout.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAbout.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAbout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAbout.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAbout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.CheckedImage")));
            this.btnAbout.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbout.FocusedColor = System.Drawing.Color.Empty;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageOffsetX = 20;
            this.btnAbout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAbout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAbout.Location = new System.Drawing.Point(0, 827);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAbout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAbout.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAbout.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.OnHoverImage")));
            this.btnAbout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAbout.OnPressedColor = System.Drawing.Color.Black;
            this.btnAbout.Size = new System.Drawing.Size(283, 67);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "About";
            this.btnAbout.TextOffsetX = 10;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnArchived
            // 
            this.btnArchived.AnimationHoverSpeed = 0.07F;
            this.btnArchived.AnimationSpeed = 0.03F;
            this.btnArchived.BaseColor = System.Drawing.Color.White;
            this.btnArchived.BorderColor = System.Drawing.Color.Black;
            this.btnArchived.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnArchived.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnArchived.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnArchived.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnArchived.CheckedImage")));
            this.btnArchived.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArchived.FocusedColor = System.Drawing.Color.Empty;
            this.btnArchived.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.Image = ((System.Drawing.Image)(resources.GetObject("btnArchived.Image")));
            this.btnArchived.ImageOffsetX = 20;
            this.btnArchived.ImageSize = new System.Drawing.Size(30, 30);
            this.btnArchived.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnArchived.Location = new System.Drawing.Point(0, 760);
            this.btnArchived.Margin = new System.Windows.Forms.Padding(0);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnArchived.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnArchived.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnArchived.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnArchived.OnHoverImage")));
            this.btnArchived.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnArchived.OnPressedColor = System.Drawing.Color.Black;
            this.btnArchived.Size = new System.Drawing.Size(283, 67);
            this.btnArchived.TabIndex = 15;
            this.btnArchived.Text = "Archived";
            this.btnArchived.TextOffsetX = 10;
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // btnBackupAndRestore
            // 
            this.btnBackupAndRestore.AnimationHoverSpeed = 0.07F;
            this.btnBackupAndRestore.AnimationSpeed = 0.03F;
            this.btnBackupAndRestore.BaseColor = System.Drawing.Color.White;
            this.btnBackupAndRestore.BorderColor = System.Drawing.Color.Black;
            this.btnBackupAndRestore.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnBackupAndRestore.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnBackupAndRestore.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackupAndRestore.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBackupAndRestore.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBackupAndRestore.CheckedImage")));
            this.btnBackupAndRestore.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBackupAndRestore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackupAndRestore.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackupAndRestore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupAndRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBackupAndRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupAndRestore.Image")));
            this.btnBackupAndRestore.ImageOffsetX = 20;
            this.btnBackupAndRestore.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBackupAndRestore.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBackupAndRestore.Location = new System.Drawing.Point(0, 626);
            this.btnBackupAndRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackupAndRestore.Name = "btnBackupAndRestore";
            this.btnBackupAndRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnBackupAndRestore.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackupAndRestore.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnBackupAndRestore.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnBackupAndRestore.OnHoverImage")));
            this.btnBackupAndRestore.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBackupAndRestore.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackupAndRestore.Size = new System.Drawing.Size(283, 67);
            this.btnBackupAndRestore.TabIndex = 14;
            this.btnBackupAndRestore.Text = "Backup & Restore";
            this.btnBackupAndRestore.TextOffsetX = 10;
            this.btnBackupAndRestore.Click += new System.EventHandler(this.btnBackupAndRestore_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.AnimationHoverSpeed = 0.07F;
            this.btnManageUsers.AnimationSpeed = 0.03F;
            this.btnManageUsers.BaseColor = System.Drawing.Color.White;
            this.btnManageUsers.BorderColor = System.Drawing.Color.Black;
            this.btnManageUsers.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnManageUsers.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnManageUsers.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnManageUsers.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnManageUsers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.CheckedImage")));
            this.btnManageUsers.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnManageUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManageUsers.FocusedColor = System.Drawing.Color.Empty;
            this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageOffsetX = 20;
            this.btnManageUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnManageUsers.Location = new System.Drawing.Point(0, 559);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnManageUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManageUsers.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnManageUsers.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.OnHoverImage")));
            this.btnManageUsers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnManageUsers.OnPressedColor = System.Drawing.Color.Black;
            this.btnManageUsers.Size = new System.Drawing.Size(283, 67);
            this.btnManageUsers.TabIndex = 13;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextOffsetX = 10;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnLoginHistory
            // 
            this.btnLoginHistory.AnimationHoverSpeed = 0.07F;
            this.btnLoginHistory.AnimationSpeed = 0.03F;
            this.btnLoginHistory.BaseColor = System.Drawing.Color.White;
            this.btnLoginHistory.BorderColor = System.Drawing.Color.Black;
            this.btnLoginHistory.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnLoginHistory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnLoginHistory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLoginHistory.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnLoginHistory.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLoginHistory.CheckedImage")));
            this.btnLoginHistory.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnLoginHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoginHistory.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoginHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnLoginHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginHistory.Image")));
            this.btnLoginHistory.ImageOffsetX = 20;
            this.btnLoginHistory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoginHistory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLoginHistory.Location = new System.Drawing.Point(0, 492);
            this.btnLoginHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoginHistory.Name = "btnLoginHistory";
            this.btnLoginHistory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLoginHistory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoginHistory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnLoginHistory.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLoginHistory.OnHoverImage")));
            this.btnLoginHistory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLoginHistory.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoginHistory.Size = new System.Drawing.Size(283, 67);
            this.btnLoginHistory.TabIndex = 12;
            this.btnLoginHistory.Text = "Login History";
            this.btnLoginHistory.TextOffsetX = 10;
            this.btnLoginHistory.Click += new System.EventHandler(this.btnLoginHistory_Click);
            // 
            // btnMaintenanceReport
            // 
            this.btnMaintenanceReport.AnimationHoverSpeed = 0.07F;
            this.btnMaintenanceReport.AnimationSpeed = 0.03F;
            this.btnMaintenanceReport.BaseColor = System.Drawing.Color.White;
            this.btnMaintenanceReport.BorderColor = System.Drawing.Color.Black;
            this.btnMaintenanceReport.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnMaintenanceReport.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnMaintenanceReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMaintenanceReport.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMaintenanceReport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMaintenanceReport.CheckedImage")));
            this.btnMaintenanceReport.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMaintenanceReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaintenanceReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnMaintenanceReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMaintenanceReport.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintenanceReport.Image")));
            this.btnMaintenanceReport.ImageOffsetX = 20;
            this.btnMaintenanceReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMaintenanceReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMaintenanceReport.Location = new System.Drawing.Point(0, 425);
            this.btnMaintenanceReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaintenanceReport.Name = "btnMaintenanceReport";
            this.btnMaintenanceReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMaintenanceReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMaintenanceReport.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnMaintenanceReport.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnMaintenanceReport.OnHoverImage")));
            this.btnMaintenanceReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMaintenanceReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaintenanceReport.Size = new System.Drawing.Size(283, 67);
            this.btnMaintenanceReport.TabIndex = 11;
            this.btnMaintenanceReport.Text = "Maintenance Report";
            this.btnMaintenanceReport.TextOffsetX = 10;
            this.btnMaintenanceReport.Click += new System.EventHandler(this.btnMaintenanceReport_Click);
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.AnimationHoverSpeed = 0.07F;
            this.btnInventoryManagement.AnimationSpeed = 0.03F;
            this.btnInventoryManagement.BaseColor = System.Drawing.Color.White;
            this.btnInventoryManagement.BorderColor = System.Drawing.Color.Black;
            this.btnInventoryManagement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnInventoryManagement.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnInventoryManagement.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnInventoryManagement.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnInventoryManagement.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnInventoryManagement.CheckedImage")));
            this.btnInventoryManagement.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnInventoryManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInventoryManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnInventoryManagement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnInventoryManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnInventoryManagement.Image")));
            this.btnInventoryManagement.ImageOffsetX = 20;
            this.btnInventoryManagement.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInventoryManagement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInventoryManagement.Location = new System.Drawing.Point(0, 358);
            this.btnInventoryManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnInventoryManagement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInventoryManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnInventoryManagement.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnInventoryManagement.OnHoverImage")));
            this.btnInventoryManagement.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInventoryManagement.OnPressedColor = System.Drawing.Color.Black;
            this.btnInventoryManagement.Size = new System.Drawing.Size(283, 67);
            this.btnInventoryManagement.TabIndex = 10;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.TextOffsetX = 10;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // btnRemoteManagement
            // 
            this.btnRemoteManagement.AnimationHoverSpeed = 0.07F;
            this.btnRemoteManagement.AnimationSpeed = 0.03F;
            this.btnRemoteManagement.BaseColor = System.Drawing.Color.White;
            this.btnRemoteManagement.BorderColor = System.Drawing.Color.Black;
            this.btnRemoteManagement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnRemoteManagement.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnRemoteManagement.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRemoteManagement.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnRemoteManagement.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRemoteManagement.CheckedImage")));
            this.btnRemoteManagement.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnRemoteManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoteManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemoteManagement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoteManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnRemoteManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoteManagement.Image")));
            this.btnRemoteManagement.ImageOffsetX = 20;
            this.btnRemoteManagement.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRemoteManagement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRemoteManagement.Location = new System.Drawing.Point(0, 291);
            this.btnRemoteManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoteManagement.Name = "btnRemoteManagement";
            this.btnRemoteManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnRemoteManagement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemoteManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnRemoteManagement.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnRemoteManagement.OnHoverImage")));
            this.btnRemoteManagement.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRemoteManagement.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemoteManagement.Size = new System.Drawing.Size(283, 67);
            this.btnRemoteManagement.TabIndex = 9;
            this.btnRemoteManagement.Text = "Remote Management";
            this.btnRemoteManagement.TextOffsetX = 10;
            this.btnRemoteManagement.Click += new System.EventHandler(this.btnRemoteManagement_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.White;
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageOffsetX = 20;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDashboard.LineLeft = 10;
            this.btnDashboard.Location = new System.Drawing.Point(0, 224);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnDashboard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.OnHoverImage")));
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Size = new System.Drawing.Size(283, 67);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffsetX = 10;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucAuditTrail1);
            this.panelContainer.Controls.Add(this.ucArchived1);
            this.panelContainer.Controls.Add(this.ucLoginHistory1);
            this.panelContainer.Controls.Add(this.ucMaintenanceReport1);
            this.panelContainer.Controls.Add(this.ucSettings1);
            this.panelContainer.Controls.Add(this.ucBackupRestore1);
            this.panelContainer.Controls.Add(this.ucRemoteManagement1);
            this.panelContainer.Controls.Add(this.ucUserManagement1);
            this.panelContainer.Controls.Add(this.ucInventoryManagement1);
            this.panelContainer.Controls.Add(this.ucDashboard1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(283, 102);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1417, 848);
            this.panelContainer.TabIndex = 2;
            // 
            // ucAuditTrail1
            // 
            this.ucAuditTrail1.BackColor = System.Drawing.Color.White;
            this.ucAuditTrail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAuditTrail1.Location = new System.Drawing.Point(0, 0);
            this.ucAuditTrail1.Name = "ucAuditTrail1";
            this.ucAuditTrail1.Size = new System.Drawing.Size(1417, 848);
            this.ucAuditTrail1.TabIndex = 9;
            this.ucAuditTrail1.Visible = false;
            // 
            // ucArchived1
            // 
            this.ucArchived1.BackColor = System.Drawing.Color.White;
            this.ucArchived1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucArchived1.Location = new System.Drawing.Point(0, 0);
            this.ucArchived1.Name = "ucArchived1";
            this.ucArchived1.Size = new System.Drawing.Size(1417, 848);
            this.ucArchived1.TabIndex = 8;
            this.ucArchived1.Visible = false;
            // 
            // ucLoginHistory1
            // 
            this.ucLoginHistory1.BackColor = System.Drawing.Color.White;
            this.ucLoginHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoginHistory1.Location = new System.Drawing.Point(0, 0);
            this.ucLoginHistory1.Name = "ucLoginHistory1";
            this.ucLoginHistory1.Size = new System.Drawing.Size(1417, 848);
            this.ucLoginHistory1.TabIndex = 7;
            this.ucLoginHistory1.Visible = false;
            // 
            // ucMaintenanceReport1
            // 
            this.ucMaintenanceReport1.BackColor = System.Drawing.Color.White;
            this.ucMaintenanceReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMaintenanceReport1.Location = new System.Drawing.Point(0, 0);
            this.ucMaintenanceReport1.Name = "ucMaintenanceReport1";
            this.ucMaintenanceReport1.Size = new System.Drawing.Size(1417, 848);
            this.ucMaintenanceReport1.TabIndex = 6;
            this.ucMaintenanceReport1.Visible = false;
            // 
            // ucSettings1
            // 
            this.ucSettings1.BackColor = System.Drawing.Color.White;
            this.ucSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSettings1.Location = new System.Drawing.Point(0, 0);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(1417, 848);
            this.ucSettings1.TabIndex = 5;
            this.ucSettings1.Visible = false;
            this.ucSettings1.Load += new System.EventHandler(this.ucSettings1_Load);
            // 
            // ucBackupRestore1
            // 
            this.ucBackupRestore1.BackColor = System.Drawing.Color.White;
            this.ucBackupRestore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBackupRestore1.Location = new System.Drawing.Point(0, 0);
            this.ucBackupRestore1.Name = "ucBackupRestore1";
            this.ucBackupRestore1.Size = new System.Drawing.Size(1417, 848);
            this.ucBackupRestore1.TabIndex = 4;
            this.ucBackupRestore1.Visible = false;
            // 
            // ucRemoteManagement1
            // 
            this.ucRemoteManagement1.BackColor = System.Drawing.Color.White;
            this.ucRemoteManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRemoteManagement1.Location = new System.Drawing.Point(0, 0);
            this.ucRemoteManagement1.Name = "ucRemoteManagement1";
            this.ucRemoteManagement1.Size = new System.Drawing.Size(1417, 848);
            this.ucRemoteManagement1.TabIndex = 3;
            this.ucRemoteManagement1.Visible = false;
            // 
            // ucUserManagement1
            // 
            this.ucUserManagement1.BackColor = System.Drawing.Color.White;
            this.ucUserManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserManagement1.Location = new System.Drawing.Point(0, 0);
            this.ucUserManagement1.Name = "ucUserManagement1";
            this.ucUserManagement1.Size = new System.Drawing.Size(1417, 848);
            this.ucUserManagement1.TabIndex = 2;
            this.ucUserManagement1.Visible = false;
            // 
            // ucInventoryManagement1
            // 
            this.ucInventoryManagement1.BackColor = System.Drawing.Color.White;
            this.ucInventoryManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventoryManagement1.Location = new System.Drawing.Point(0, 0);
            this.ucInventoryManagement1.Name = "ucInventoryManagement1";
            this.ucInventoryManagement1.Size = new System.Drawing.Size(1417, 848);
            this.ucInventoryManagement1.TabIndex = 1;
            this.ucInventoryManagement1.Visible = false;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.BackColor = System.Drawing.Color.White;
            this.ucDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(1417, 848);
            this.ucDashboard1.TabIndex = 0;
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMain.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsMain.RenderStyle.ColorTable = null;
            this.cmsMain.RenderStyle.RoundedEdges = true;
            this.cmsMain.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMain.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMain.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMain.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMain.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cmsMain.Size = new System.Drawing.Size(125, 76);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerIncomingRequest
            // 
            this.timerIncomingRequest.Interval = 1000;
            this.timerIncomingRequest.Tick += new System.EventHandler(this.timerIncomingRequest_Tick);
            // 
            // timerCastScreenToClient
            // 
            this.timerCastScreenToClient.Interval = 1000;
            this.timerCastScreenToClient.Tick += new System.EventHandler(this.timerCastScreenToClient_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1700, 950);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comfama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI.WinForms.GunaAdvenceButton btnRemoteManagement;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton btnAbout;
        private Guna.UI.WinForms.GunaAdvenceButton btnArchived;
        private Guna.UI.WinForms.GunaAdvenceButton btnBackupAndRestore;
        private Guna.UI.WinForms.GunaAdvenceButton btnManageUsers;
        private Guna.UI.WinForms.GunaAdvenceButton btnLoginHistory;
        private Guna.UI.WinForms.GunaAdvenceButton btnMaintenanceReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnInventoryManagement;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnShutdown;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private dirUserControl.Dashboard.ucDashboard ucDashboard1;
        private dirUserControl.InventoryManagement.ucInventoryManagement ucInventoryManagement1;
        private Guna.UI.WinForms.GunaLabel lblEmployeeID;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaCirclePictureBox pbProfilePicture;
        private dirUserControl.UserManagement.ucUserManagement ucUserManagement1;
        private dirUserControl.RemoteManagement.ucRemoteManagement ucRemoteManagement1;
        private Guna.UI.WinForms.GunaAdvenceButton btnMessages;
        private dirUserControl.BackupRestore.ucBackupRestore ucBackupRestore1;
        private dirUserControl.Settings.ucSettings ucSettings1;
        private System.Windows.Forms.Timer timerIncomingRequest;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Timer timerCastScreenToClient;
        private dirUserControl.MaintenanceReport.ucMaintenanceReport ucMaintenanceReport1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAuditTrail;
        private dirUserControl.LoginHistory.ucLoginHistory ucLoginHistory1;
        private dirUserControl.Archived.ucArchived ucArchived1;
        private dirUserControl.AuditTrail.ucAuditTrail ucAuditTrail1;
    }
}

