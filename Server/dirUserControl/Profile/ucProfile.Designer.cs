namespace Server.dirUserControl.Profile
{
    partial class ucProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProfile));
            this.panelTop = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblPersonalInformation = new Guna.UI.WinForms.GunaLinkLabel();
            this.sidePanel = new Guna.UI.WinForms.GunaLinePanel();
            this.lblAccountInformation = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblWelcomeMessage = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblTodo = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucWelcomeMessage1 = new Server.dirUserControl.Profile.ucWelcomeMessage();
            this.ucAccountInformation1 = new Server.dirUserControl.Profile.ucAccountInformation();
            this.ucPersonalInformation1 = new Server.dirUserControl.Profile.ucPersonalInformation();
            this.panelTop.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gunaAdvenceButton1);
            this.panelTop.Controls.Add(this.gunaLabel2);
            this.panelTop.Controls.Add(this.gunaLabel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1417, 96);
            this.panelTop.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(1337, 59);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "PROFILE";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(1253, 59);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "COMFAMA  >";
            // 
            // lblPersonalInformation
            // 
            this.lblPersonalInformation.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblPersonalInformation.AutoSize = true;
            this.lblPersonalInformation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblPersonalInformation.LinkColor = System.Drawing.Color.Black;
            this.lblPersonalInformation.Location = new System.Drawing.Point(46, 57);
            this.lblPersonalInformation.Name = "lblPersonalInformation";
            this.lblPersonalInformation.Size = new System.Drawing.Size(127, 16);
            this.lblPersonalInformation.TabIndex = 54;
            this.lblPersonalInformation.TabStop = true;
            this.lblPersonalInformation.Text = "Personal Information";
            this.lblPersonalInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPersonalInformation_LinkClicked);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.lblTodo);
            this.sidePanel.Controls.Add(this.lblWelcomeMessage);
            this.sidePanel.Controls.Add(this.lblAccountInformation);
            this.sidePanel.Controls.Add(this.lblPersonalInformation);
            this.sidePanel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.sidePanel.LineRight = 1;
            this.sidePanel.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.sidePanel.Location = new System.Drawing.Point(111, 102);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(201, 714);
            this.sidePanel.TabIndex = 55;
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAccountInformation.LinkColor = System.Drawing.Color.Silver;
            this.lblAccountInformation.Location = new System.Drawing.Point(46, 83);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(127, 16);
            this.lblAccountInformation.TabIndex = 55;
            this.lblAccountInformation.TabStop = true;
            this.lblAccountInformation.Text = "Account Information";
            this.lblAccountInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAccountInformation_LinkClicked);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblWelcomeMessage.LinkColor = System.Drawing.Color.Silver;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(46, 109);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(121, 16);
            this.lblWelcomeMessage.TabIndex = 56;
            this.lblWelcomeMessage.TabStop = true;
            this.lblWelcomeMessage.Text = "Welcome Message";
            this.lblWelcomeMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWelcomeMessage_LinkClicked);
            // 
            // lblTodo
            // 
            this.lblTodo.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblTodo.AutoSize = true;
            this.lblTodo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblTodo.LinkColor = System.Drawing.Color.Silver;
            this.lblTodo.Location = new System.Drawing.Point(46, 135);
            this.lblTodo.Name = "lblTodo";
            this.lblTodo.Size = new System.Drawing.Size(38, 16);
            this.lblTodo.TabIndex = 57;
            this.lblTodo.TabStop = true;
            this.lblTodo.Text = "Todo";
            this.lblTodo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTodo_LinkClicked);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-10, 38);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(257, 46);
            this.gunaAdvenceButton1.TabIndex = 2;
            this.gunaAdvenceButton1.Text = "Profile";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucWelcomeMessage1);
            this.panel1.Controls.Add(this.ucAccountInformation1);
            this.panel1.Controls.Add(this.ucPersonalInformation1);
            this.panel1.Location = new System.Drawing.Point(318, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 714);
            this.panel1.TabIndex = 56;
            // 
            // ucWelcomeMessage1
            // 
            this.ucWelcomeMessage1.BackColor = System.Drawing.Color.White;
            this.ucWelcomeMessage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWelcomeMessage1.Location = new System.Drawing.Point(0, 0);
            this.ucWelcomeMessage1.Name = "ucWelcomeMessage1";
            this.ucWelcomeMessage1.Size = new System.Drawing.Size(1021, 714);
            this.ucWelcomeMessage1.TabIndex = 2;
            this.ucWelcomeMessage1.Visible = false;
            // 
            // ucAccountInformation1
            // 
            this.ucAccountInformation1.BackColor = System.Drawing.Color.White;
            this.ucAccountInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAccountInformation1.Location = new System.Drawing.Point(0, 0);
            this.ucAccountInformation1.Name = "ucAccountInformation1";
            this.ucAccountInformation1.Size = new System.Drawing.Size(1021, 714);
            this.ucAccountInformation1.TabIndex = 1;
            this.ucAccountInformation1.Visible = false;
            // 
            // ucPersonalInformation1
            // 
            this.ucPersonalInformation1.BackColor = System.Drawing.Color.White;
            this.ucPersonalInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPersonalInformation1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonalInformation1.Name = "ucPersonalInformation1";
            this.ucPersonalInformation1.Size = new System.Drawing.Size(1021, 714);
            this.ucPersonalInformation1.TabIndex = 0;
            // 
            // ucProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panelTop);
            this.Name = "ucProfile";
            this.Size = new System.Drawing.Size(1417, 848);
            this.Load += new System.EventHandler(this.ucProfile_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinkLabel lblPersonalInformation;
        private Guna.UI.WinForms.GunaLinePanel sidePanel;
        private Guna.UI.WinForms.GunaLinkLabel lblAccountInformation;
        private Guna.UI.WinForms.GunaLinkLabel lblTodo;
        private Guna.UI.WinForms.GunaLinkLabel lblWelcomeMessage;
        private System.Windows.Forms.Panel panel1;
        private ucPersonalInformation ucPersonalInformation1;
        private ucAccountInformation ucAccountInformation1;
        private ucWelcomeMessage ucWelcomeMessage1;
    }
}
