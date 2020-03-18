namespace Server
{
    partial class frmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.lblErrorMessage = new Guna.UI.WinForms.GunaLabel();
            this.pbPasswordHelp = new Guna.UI.WinForms.GunaPictureBox();
            this.pbUsernameHelp = new Guna.UI.WinForms.GunaPictureBox();
            this.pbLocationHelp = new Guna.UI.WinForms.GunaPictureBox();
            this.pbMACAddressHelp = new Guna.UI.WinForms.GunaPictureBox();
            this.pbIPAddressHelp = new Guna.UI.WinForms.GunaPictureBox();
            this.pbMachineNameHelp = new Guna.UI.WinForms.GunaPictureBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtLocation = new Guna.UI.WinForms.GunaTextBox();
            this.txtMACAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtIPAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtMachineName = new Guna.UI.WinForms.GunaTextBox();
            this.progressBarSetup = new Guna.UI.WinForms.GunaProgressBar();
            this.lblProgressBarText = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btnFinish = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocationHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMACAddressHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIPAddressHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMachineNameHelp)).BeginInit();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorMessage.Location = new System.Drawing.Point(244, 150);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(90, 17);
            this.lblErrorMessage.TabIndex = 32;
            this.lblErrorMessage.Text = "Error Message";
            // 
            // pbPasswordHelp
            // 
            this.pbPasswordHelp.BaseColor = System.Drawing.Color.White;
            this.pbPasswordHelp.Image = global::Server.Resource1.help_30px;
            this.pbPasswordHelp.Location = new System.Drawing.Point(556, 413);
            this.pbPasswordHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pbPasswordHelp.Name = "pbPasswordHelp";
            this.pbPasswordHelp.Size = new System.Drawing.Size(30, 30);
            this.pbPasswordHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPasswordHelp.TabIndex = 31;
            this.pbPasswordHelp.TabStop = false;
            // 
            // pbUsernameHelp
            // 
            this.pbUsernameHelp.BaseColor = System.Drawing.Color.White;
            this.pbUsernameHelp.Image = global::Server.Resource1.help_30px;
            this.pbUsernameHelp.Location = new System.Drawing.Point(556, 374);
            this.pbUsernameHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pbUsernameHelp.Name = "pbUsernameHelp";
            this.pbUsernameHelp.Size = new System.Drawing.Size(30, 30);
            this.pbUsernameHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsernameHelp.TabIndex = 30;
            this.pbUsernameHelp.TabStop = false;
            // 
            // pbLocationHelp
            // 
            this.pbLocationHelp.BaseColor = System.Drawing.Color.White;
            this.pbLocationHelp.Image = global::Server.Resource1.help_30px;
            this.pbLocationHelp.Location = new System.Drawing.Point(556, 335);
            this.pbLocationHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pbLocationHelp.Name = "pbLocationHelp";
            this.pbLocationHelp.Size = new System.Drawing.Size(30, 30);
            this.pbLocationHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLocationHelp.TabIndex = 29;
            this.pbLocationHelp.TabStop = false;
            // 
            // pbMACAddressHelp
            // 
            this.pbMACAddressHelp.BaseColor = System.Drawing.Color.White;
            this.pbMACAddressHelp.Image = global::Server.Resource1.help_30px;
            this.pbMACAddressHelp.Location = new System.Drawing.Point(556, 271);
            this.pbMACAddressHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pbMACAddressHelp.Name = "pbMACAddressHelp";
            this.pbMACAddressHelp.Size = new System.Drawing.Size(30, 30);
            this.pbMACAddressHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMACAddressHelp.TabIndex = 28;
            this.pbMACAddressHelp.TabStop = false;
            // 
            // pbIPAddressHelp
            // 
            this.pbIPAddressHelp.BaseColor = System.Drawing.Color.White;
            this.pbIPAddressHelp.Image = global::Server.Resource1.help_30px;
            this.pbIPAddressHelp.Location = new System.Drawing.Point(556, 232);
            this.pbIPAddressHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pbIPAddressHelp.Name = "pbIPAddressHelp";
            this.pbIPAddressHelp.Size = new System.Drawing.Size(30, 30);
            this.pbIPAddressHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIPAddressHelp.TabIndex = 27;
            this.pbIPAddressHelp.TabStop = false;
            // 
            // pbMachineNameHelp
            // 
            this.pbMachineNameHelp.BaseColor = System.Drawing.Color.White;
            this.pbMachineNameHelp.Image = global::Server.Resource1.help_30px;
            this.pbMachineNameHelp.Location = new System.Drawing.Point(556, 193);
            this.pbMachineNameHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pbMachineNameHelp.Name = "pbMachineNameHelp";
            this.pbMachineNameHelp.Size = new System.Drawing.Size(30, 30);
            this.pbMachineNameHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMachineNameHelp.TabIndex = 26;
            this.pbMachineNameHelp.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Enabled = false;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(247, 411);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Size = new System.Drawing.Size(305, 34);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextOffsetX = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Enabled = false;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(247, 372);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Size = new System.Drawing.Size(305, 34);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextOffsetX = 5;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtLocation.BorderColor = System.Drawing.Color.Silver;
            this.txtLocation.BorderSize = 1;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.Enabled = false;
            this.txtLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(247, 333);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.Size = new System.Drawing.Size(305, 34);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "Location";
            this.txtLocation.TextOffsetX = 5;
            this.txtLocation.Enter += new System.EventHandler(this.txtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // txtMACAddress
            // 
            this.txtMACAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtMACAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtMACAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtMACAddress.BorderSize = 1;
            this.txtMACAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMACAddress.Enabled = false;
            this.txtMACAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMACAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtMACAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMACAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACAddress.Location = new System.Drawing.Point(247, 269);
            this.txtMACAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtMACAddress.Name = "txtMACAddress";
            this.txtMACAddress.PasswordChar = '\0';
            this.txtMACAddress.Size = new System.Drawing.Size(305, 34);
            this.txtMACAddress.TabIndex = 21;
            this.txtMACAddress.Text = "MAC Address";
            this.txtMACAddress.TextOffsetX = 5;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtIPAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtIPAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtIPAddress.BorderSize = 1;
            this.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAddress.Enabled = false;
            this.txtIPAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIPAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtIPAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIPAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(247, 230);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.PasswordChar = '\0';
            this.txtIPAddress.Size = new System.Drawing.Size(305, 34);
            this.txtIPAddress.TabIndex = 20;
            this.txtIPAddress.Text = "IP Address";
            this.txtIPAddress.TextOffsetX = 5;
            // 
            // txtMachineName
            // 
            this.txtMachineName.BackColor = System.Drawing.Color.Transparent;
            this.txtMachineName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtMachineName.BorderColor = System.Drawing.Color.Silver;
            this.txtMachineName.BorderSize = 1;
            this.txtMachineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachineName.Enabled = false;
            this.txtMachineName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMachineName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtMachineName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMachineName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.Location = new System.Drawing.Point(247, 191);
            this.txtMachineName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.PasswordChar = '\0';
            this.txtMachineName.Size = new System.Drawing.Size(305, 34);
            this.txtMachineName.TabIndex = 19;
            this.txtMachineName.Text = "Machine Name";
            this.txtMachineName.TextOffsetX = 5;
            // 
            // progressBarSetup
            // 
            this.progressBarSetup.BackColor = System.Drawing.Color.Transparent;
            this.progressBarSetup.BorderColor = System.Drawing.Color.Black;
            this.progressBarSetup.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBarSetup.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressBarSetup.Location = new System.Drawing.Point(247, 122);
            this.progressBarSetup.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarSetup.Name = "progressBarSetup";
            this.progressBarSetup.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.progressBarSetup.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBarSetup.Size = new System.Drawing.Size(177, 8);
            this.progressBarSetup.TabIndex = 18;
            // 
            // lblProgressBarText
            // 
            this.lblProgressBarText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBarText.ForeColor = System.Drawing.Color.Gray;
            this.lblProgressBarText.Location = new System.Drawing.Point(244, 83);
            this.lblProgressBarText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgressBarText.Name = "lblProgressBarText";
            this.lblProgressBarText.Size = new System.Drawing.Size(404, 42);
            this.lblProgressBarText.TabIndex = 17;
            this.lblProgressBarText.Text = "Please wait while we prepare to scan your machine.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(219, 564);
            this.panelSide.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server.Resource1.comfama_logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaAdvenceButton1);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.gunaControlBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 60);
            this.panel2.TabIndex = 69;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageOffsetX = 15;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-9, 12);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(257, 46);
            this.gunaAdvenceButton1.TabIndex = 40;
            this.gunaAdvenceButton1.Text = "Setup";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(298, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel1.TabIndex = 41;
            this.gunaLabel1.Text = "COMFAMA  >";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(382, 27);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(41, 17);
            this.gunaLabel2.TabIndex = 42;
            this.gunaLabel2.Text = "SETUP";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(429, 20);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 43;
            // 
            // btnFinish
            // 
            this.btnFinish.AnimationHoverSpeed = 0.07F;
            this.btnFinish.AnimationSpeed = 0.03F;
            this.btnFinish.BaseColor = System.Drawing.Color.White;
            this.btnFinish.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnFinish.BorderSize = 1;
            this.btnFinish.Checked = true;
            this.btnFinish.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnFinish.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFinish.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnFinish.CheckedImage = null;
            this.btnFinish.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinish.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnFinish.Image = null;
            this.btnFinish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFinish.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFinish.Location = new System.Drawing.Point(246, 471);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnFinish.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinish.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnFinish.OnHoverImage = null;
            this.btnFinish.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFinish.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinish.Size = new System.Drawing.Size(178, 35);
            this.btnFinish.TabIndex = 70;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // frmSetup
            // 
            this.AcceptButton = this.btnFinish;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 564);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.pbPasswordHelp);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.pbUsernameHelp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbLocationHelp);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.pbMACAddressHelp);
            this.Controls.Add(this.pbIPAddressHelp);
            this.Controls.Add(this.lblProgressBarText);
            this.Controls.Add(this.pbMachineNameHelp);
            this.Controls.Add(this.progressBarSetup);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtMACAddress);
            this.Controls.Add(this.txtLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.frmSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocationHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMACAddressHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIPAddressHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMachineNameHelp)).EndInit();
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblProgressBarText;
        private Guna.UI.WinForms.GunaProgressBar progressBarSetup;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtLocation;
        private Guna.UI.WinForms.GunaTextBox txtMACAddress;
        private Guna.UI.WinForms.GunaTextBox txtIPAddress;
        private Guna.UI.WinForms.GunaTextBox txtMachineName;
        private Guna.UI.WinForms.GunaPictureBox pbPasswordHelp;
        private Guna.UI.WinForms.GunaPictureBox pbUsernameHelp;
        private Guna.UI.WinForms.GunaPictureBox pbLocationHelp;
        private Guna.UI.WinForms.GunaPictureBox pbMACAddressHelp;
        private Guna.UI.WinForms.GunaPictureBox pbIPAddressHelp;
        private Guna.UI.WinForms.GunaPictureBox pbMachineNameHelp;
        private Guna.UI.WinForms.GunaLabel lblErrorMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnFinish;
    }
}