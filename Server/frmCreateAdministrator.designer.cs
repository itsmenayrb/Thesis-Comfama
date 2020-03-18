namespace Server
{
    partial class frmCreateAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAdministrator));
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.lblSpecialRule = new Guna.UI.WinForms.GunaLabel();
            this.lblUpperRule = new Guna.UI.WinForms.GunaLabel();
            this.lblDecimalRule = new Guna.UI.WinForms.GunaLabel();
            this.lblLowerRule = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblEightRule = new Guna.UI.WinForms.GunaLabel();
            this.txtConfirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCreateAdministrator = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
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
            this.gunaLabel10.TabIndex = 64;
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
            this.lblSpecialRule.TabIndex = 63;
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
            this.lblUpperRule.TabIndex = 62;
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
            this.lblDecimalRule.TabIndex = 61;
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
            this.lblLowerRule.TabIndex = 60;
            this.lblLowerRule.Text = "1 english alphabet LOWERCASE letter (a-z)";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel4.Location = new System.Drawing.Point(372, 94);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(199, 16);
            this.gunaLabel4.TabIndex = 59;
            this.gunaLabel4.Text = "The password should have at least:";
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
            this.lblEightRule.TabIndex = 58;
            this.lblEightRule.Text = "8-32 characters long.";
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(38, 174);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.Size = new System.Drawing.Size(305, 34);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.TextOffsetX = 5;
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.txtPassword.FocusedForeColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(38, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Size = new System.Drawing.Size(305, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextOffsetX = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
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
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.txtUsername.FocusedForeColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(38, 94);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Size = new System.Drawing.Size(305, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextOffsetX = 5;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(219, 286);
            this.panelSide.TabIndex = 15;
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
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.gunaControlBox1);
            this.panelContainer.Controls.Add(this.gunaLabel2);
            this.panelContainer.Controls.Add(this.gunaLabel3);
            this.panelContainer.Controls.Add(this.btnCreateAdministrator);
            this.panelContainer.Controls.Add(this.gunaLabel10);
            this.panelContainer.Controls.Add(this.gunaAdvenceButton1);
            this.panelContainer.Controls.Add(this.txtUsername);
            this.panelContainer.Controls.Add(this.txtConfirmPassword);
            this.panelContainer.Controls.Add(this.lblEightRule);
            this.panelContainer.Controls.Add(this.lblSpecialRule);
            this.panelContainer.Controls.Add(this.lblDecimalRule);
            this.panelContainer.Controls.Add(this.gunaLabel4);
            this.panelContainer.Controls.Add(this.lblUpperRule);
            this.panelContainer.Controls.Add(this.lblLowerRule);
            this.panelContainer.Controls.Add(this.txtPassword);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(219, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(661, 286);
            this.panelContainer.TabIndex = 16;
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
            this.gunaAdvenceButton1.TabIndex = 21;
            this.gunaAdvenceButton1.Text = "Create Administrator";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // btnCreateAdministrator
            // 
            this.btnCreateAdministrator.AnimationHoverSpeed = 0.07F;
            this.btnCreateAdministrator.AnimationSpeed = 0.03F;
            this.btnCreateAdministrator.BaseColor = System.Drawing.Color.White;
            this.btnCreateAdministrator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnCreateAdministrator.BorderSize = 1;
            this.btnCreateAdministrator.Checked = true;
            this.btnCreateAdministrator.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnCreateAdministrator.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCreateAdministrator.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCreateAdministrator.CheckedImage = null;
            this.btnCreateAdministrator.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCreateAdministrator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateAdministrator.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreateAdministrator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCreateAdministrator.Image = null;
            this.btnCreateAdministrator.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCreateAdministrator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCreateAdministrator.Location = new System.Drawing.Point(38, 214);
            this.btnCreateAdministrator.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateAdministrator.Name = "btnCreateAdministrator";
            this.btnCreateAdministrator.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCreateAdministrator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCreateAdministrator.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCreateAdministrator.OnHoverImage = null;
            this.btnCreateAdministrator.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCreateAdministrator.OnPressedColor = System.Drawing.Color.Black;
            this.btnCreateAdministrator.Size = new System.Drawing.Size(178, 35);
            this.btnCreateAdministrator.TabIndex = 65;
            this.btnCreateAdministrator.Text = "Create Administrator";
            this.btnCreateAdministrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateAdministrator.Click += new System.EventHandler(this.btnCreateAdministrator_Click);
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
            this.gunaControlBox1.TabIndex = 68;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(451, 36);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(147, 17);
            this.gunaLabel2.TabIndex = 67;
            this.gunaLabel2.Text = "CREATE ADMINISTRATOR";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(369, 36);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel3.TabIndex = 66;
            this.gunaLabel3.Text = "COMFAMA  >";
            // 
            // frmCreateAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 286);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateAdministrator";
            this.Load += new System.EventHandler(this.frmCreateAdministrator_Load);
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtConfirmPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel lblSpecialRule;
        private Guna.UI.WinForms.GunaLabel lblUpperRule;
        private Guna.UI.WinForms.GunaLabel lblDecimalRule;
        private Guna.UI.WinForms.GunaLabel lblLowerRule;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblEightRule;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnCreateAdministrator;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}