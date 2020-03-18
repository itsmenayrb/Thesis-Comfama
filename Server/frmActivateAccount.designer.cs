namespace Server
{
    partial class frmActivateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivateAccount));
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.lblSpecialRule = new Guna.UI.WinForms.GunaLabel();
            this.lblUpperRule = new Guna.UI.WinForms.GunaLabel();
            this.lblDecimalRule = new Guna.UI.WinForms.GunaLabel();
            this.lblLowerRule = new Guna.UI.WinForms.GunaLabel();
            this.txtConfirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaWinSwitch1 = new Guna.UI.WinForms.GunaWinSwitch();
            this.txtNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblEightRule = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnActivate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel10.Location = new System.Drawing.Point(372, 217);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(250, 42);
            this.gunaLabel10.TabIndex = 55;
            this.gunaLabel10.Text = "The text will turn green once the password requirement has been met.";
            // 
            // lblSpecialRule
            // 
            this.lblSpecialRule.AutoSize = true;
            this.lblSpecialRule.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialRule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialRule.ForeColor = System.Drawing.Color.Orange;
            this.lblSpecialRule.Location = new System.Drawing.Point(381, 185);
            this.lblSpecialRule.Name = "lblSpecialRule";
            this.lblSpecialRule.Size = new System.Drawing.Size(233, 16);
            this.lblSpecialRule.TabIndex = 54;
            this.lblSpecialRule.Text = "1 special characters such as .,~!@#$%^&&*";
            // 
            // lblUpperRule
            // 
            this.lblUpperRule.AutoSize = true;
            this.lblUpperRule.BackColor = System.Drawing.Color.Transparent;
            this.lblUpperRule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperRule.ForeColor = System.Drawing.Color.Orange;
            this.lblUpperRule.Location = new System.Drawing.Point(381, 153);
            this.lblUpperRule.Name = "lblUpperRule";
            this.lblUpperRule.Size = new System.Drawing.Size(232, 16);
            this.lblUpperRule.TabIndex = 53;
            this.lblUpperRule.Text = "1 english alphabet UPPERCASE letter (A-Z)";
            // 
            // lblDecimalRule
            // 
            this.lblDecimalRule.AutoSize = true;
            this.lblDecimalRule.BackColor = System.Drawing.Color.Transparent;
            this.lblDecimalRule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalRule.ForeColor = System.Drawing.Color.Orange;
            this.lblDecimalRule.Location = new System.Drawing.Point(381, 169);
            this.lblDecimalRule.Name = "lblDecimalRule";
            this.lblDecimalRule.Size = new System.Drawing.Size(133, 16);
            this.lblDecimalRule.TabIndex = 52;
            this.lblDecimalRule.Text = "1 decimal number (0-9)";
            // 
            // lblLowerRule
            // 
            this.lblLowerRule.AutoSize = true;
            this.lblLowerRule.BackColor = System.Drawing.Color.Transparent;
            this.lblLowerRule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerRule.ForeColor = System.Drawing.Color.Orange;
            this.lblLowerRule.Location = new System.Drawing.Point(381, 137);
            this.lblLowerRule.Name = "lblLowerRule";
            this.lblLowerRule.Size = new System.Drawing.Size(236, 16);
            this.lblLowerRule.TabIndex = 51;
            this.lblLowerRule.Text = "1 english alphabet LOWERCASE letter (a-z)";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.BorderSize = 1;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConfirmPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.txtConfirmPassword.FocusedForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Location = new System.Drawing.Point(38, 134);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.Size = new System.Drawing.Size(305, 34);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.TextOffsetX = 5;
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(84, 179);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(43, 16);
            this.gunaLabel1.TabIndex = 48;
            this.gunaLabel1.Text = "SHOW";
            // 
            // gunaWinSwitch1
            // 
            this.gunaWinSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.gunaWinSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaWinSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaWinSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaWinSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaWinSwitch1.Location = new System.Drawing.Point(38, 174);
            this.gunaWinSwitch1.Name = "gunaWinSwitch1";
            this.gunaWinSwitch1.Size = new System.Drawing.Size(40, 22);
            this.gunaWinSwitch1.TabIndex = 47;
            this.gunaWinSwitch1.TabStop = false;
            this.gunaWinSwitch1.CheckedChanged += new System.EventHandler(this.gunaWinSwitch1_CheckedChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtNewPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPassword.BorderSize = 1;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.txtNewPassword.FocusedForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(38, 94);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.Size = new System.Drawing.Size(305, 34);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.Text = "New Password";
            this.txtNewPassword.TextOffsetX = 5;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.Enter += new System.EventHandler(this.txtNewPassword_Enter);
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel4.Location = new System.Drawing.Point(372, 94);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(226, 16);
            this.gunaLabel4.TabIndex = 42;
            this.gunaLabel4.Text = "The new password should have at least:";
            // 
            // lblEightRule
            // 
            this.lblEightRule.AutoSize = true;
            this.lblEightRule.BackColor = System.Drawing.Color.Transparent;
            this.lblEightRule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEightRule.ForeColor = System.Drawing.Color.Orange;
            this.lblEightRule.Location = new System.Drawing.Point(381, 121);
            this.lblEightRule.Name = "lblEightRule";
            this.lblEightRule.Size = new System.Drawing.Size(120, 16);
            this.lblEightRule.TabIndex = 41;
            this.lblEightRule.Text = "8-32 characters long.";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelContainer;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btnCancel);
            this.panelContainer.Controls.Add(this.btnActivate);
            this.panelContainer.Controls.Add(this.gunaLabel10);
            this.panelContainer.Controls.Add(this.gunaControlBox1);
            this.panelContainer.Controls.Add(this.lblSpecialRule);
            this.panelContainer.Controls.Add(this.txtNewPassword);
            this.panelContainer.Controls.Add(this.lblUpperRule);
            this.panelContainer.Controls.Add(this.lblEightRule);
            this.panelContainer.Controls.Add(this.gunaLabel2);
            this.panelContainer.Controls.Add(this.lblDecimalRule);
            this.panelContainer.Controls.Add(this.gunaLabel3);
            this.panelContainer.Controls.Add(this.gunaLabel4);
            this.panelContainer.Controls.Add(this.txtConfirmPassword);
            this.panelContainer.Controls.Add(this.lblLowerRule);
            this.panelContainer.Controls.Add(this.gunaAdvenceButton1);
            this.panelContainer.Controls.Add(this.gunaWinSwitch1);
            this.panelContainer.Controls.Add(this.gunaLabel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(219, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(661, 286);
            this.panelContainer.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnCancel.BorderSize = 1;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.Location = new System.Drawing.Point(38, 214);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.AnimationHoverSpeed = 0.07F;
            this.btnActivate.AnimationSpeed = 0.03F;
            this.btnActivate.BaseColor = System.Drawing.Color.White;
            this.btnActivate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnActivate.BorderSize = 1;
            this.btnActivate.Checked = true;
            this.btnActivate.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnActivate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnActivate.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnActivate.CheckedImage = null;
            this.btnActivate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnActivate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActivate.FocusedColor = System.Drawing.Color.Empty;
            this.btnActivate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnActivate.Image = null;
            this.btnActivate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnActivate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnActivate.Location = new System.Drawing.Point(165, 214);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(0);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnActivate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActivate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnActivate.OnHoverImage = null;
            this.btnActivate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnActivate.OnPressedColor = System.Drawing.Color.Black;
            this.btnActivate.Size = new System.Drawing.Size(178, 35);
            this.btnActivate.TabIndex = 56;
            this.btnActivate.Text = "Activate";
            this.btnActivate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(604, 29);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 25;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(473, 36);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(125, 17);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "ACTIVATE ACCOUNT";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(391, 36);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "COMFAMA  >";
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-13, 20);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(257, 46);
            this.gunaAdvenceButton1.TabIndex = 20;
            this.gunaAdvenceButton1.Text = "Activate Account";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server.Resource1.comfama_logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(219, 286);
            this.panelSide.TabIndex = 16;
            // 
            // frmActivateAccount
            // 
            this.AcceptButton = this.btnActivate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(880, 286);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActivateAccount";
            this.Load += new System.EventHandler(this.frmActivateAccount_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaWinSwitch gunaWinSwitch1;
        private Guna.UI.WinForms.GunaTextBox txtNewPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblEightRule;
        private Guna.UI.WinForms.GunaLabel lblUpperRule;
        private Guna.UI.WinForms.GunaLabel lblDecimalRule;
        private Guna.UI.WinForms.GunaLabel lblLowerRule;
        private Guna.UI.WinForms.GunaTextBox txtConfirmPassword;
        private Guna.UI.WinForms.GunaLabel lblSpecialRule;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnActivate;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
    }
}