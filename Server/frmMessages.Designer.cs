namespace Server
{
    partial class frmMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessages));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnComposeMessage = new Guna.UI.WinForms.GunaCircleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timerUpcomingMessages = new System.Windows.Forms.Timer(this.components);
            this.ucNewMessage1 = new Server.dirUserControl.Messages.ucNewMessage();
            this.ucOldMessage1 = new Server.dirUserControl.Messages.ucOldMessage();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.gunaLabel1);
            this.panelLeft.Controls.Add(this.btnComposeMessage);
            this.panelLeft.Controls.Add(this.flowLayoutPanel1);
            this.panelLeft.Controls.Add(this.panel10);
            this.panelLeft.Controls.Add(this.txtSearch);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.gunaCirclePictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(307, 612);
            this.panelLeft.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(72, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 19);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Comfama-Message";
            // 
            // btnComposeMessage
            // 
            this.btnComposeMessage.AnimationHoverSpeed = 0.07F;
            this.btnComposeMessage.AnimationSpeed = 0.03F;
            this.btnComposeMessage.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnComposeMessage.BorderColor = System.Drawing.Color.Black;
            this.btnComposeMessage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComposeMessage.FocusedColor = System.Drawing.Color.Empty;
            this.btnComposeMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComposeMessage.ForeColor = System.Drawing.Color.White;
            this.btnComposeMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnComposeMessage.Image")));
            this.btnComposeMessage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnComposeMessage.Location = new System.Drawing.Point(246, 52);
            this.btnComposeMessage.Name = "btnComposeMessage";
            this.btnComposeMessage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnComposeMessage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnComposeMessage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnComposeMessage.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnComposeMessage.OnHoverImage")));
            this.btnComposeMessage.OnPressedColor = System.Drawing.Color.Black;
            this.btnComposeMessage.Size = new System.Drawing.Size(40, 40);
            this.btnComposeMessage.TabIndex = 0;
            this.btnComposeMessage.Click += new System.EventHandler(this.btnComposeMessage_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 482);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel10.Location = new System.Drawing.Point(0, 130);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(307, 482);
            this.panel10.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(18, 98);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 35);
            this.panel1.TabIndex = 1;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.Image = global::Server.Resource1.Portrait_Placeholder;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(18, 50);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gunaControlBox3);
            this.panelTop.Controls.Add(this.gunaControlBox2);
            this.panelTop.Controls.Add(this.gunaControlBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(307, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(671, 34);
            this.panelTop.TabIndex = 1;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(536, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 34);
            this.gunaControlBox3.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(581, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 34);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(626, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(30)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 34);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panel1;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucNewMessage1);
            this.panelContainer.Controls.Add(this.ucOldMessage1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(307, 34);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(671, 578);
            this.panelContainer.TabIndex = 2;
            // 
            // timerUpcomingMessages
            // 
            this.timerUpcomingMessages.Interval = 1000;
            this.timerUpcomingMessages.Tick += new System.EventHandler(this.timerUpcomingMessages_Tick);
            // 
            // ucNewMessage1
            // 
            this.ucNewMessage1.BackColor = System.Drawing.Color.White;
            this.ucNewMessage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNewMessage1.Location = new System.Drawing.Point(0, 0);
            this.ucNewMessage1.Name = "ucNewMessage1";
            this.ucNewMessage1.Size = new System.Drawing.Size(671, 578);
            this.ucNewMessage1.TabIndex = 0;
            this.ucNewMessage1.Visible = false;
            // 
            // ucOldMessage1
            // 
            this.ucOldMessage1.BackColor = System.Drawing.Color.White;
            this.ucOldMessage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOldMessage1.employeeID = "gunaLabel1";
            this.ucOldMessage1.fullName = "New Message";
            this.ucOldMessage1.Location = new System.Drawing.Point(0, 0);
            this.ucOldMessage1.Name = "ucOldMessage1";
            this.ucOldMessage1.Size = new System.Drawing.Size(671, 578);
            this.ucOldMessage1.TabIndex = 1;
            this.ucOldMessage1.Visible = false;
            // 
            // frmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 612);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessages";
            this.Text = "Messages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMessages_FormClosing);
            this.Load += new System.EventHandler(this.frmMessages_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Panel panelContainer;
        private dirUserControl.Messages.ucNewMessage ucNewMessage1;
        private dirUserControl.Messages.ucOldMessage ucOldMessage1;
        private Guna.UI.WinForms.GunaCircleButton btnComposeMessage;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer timerUpcomingMessages;
    }
}