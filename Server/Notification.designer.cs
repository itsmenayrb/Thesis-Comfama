namespace Server
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.labelBody = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // labelBody
            // 
            this.labelBody.BackColor = System.Drawing.Color.Goldenrod;
            this.labelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBody.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.ForeColor = System.Drawing.Color.Black;
            this.labelBody.Location = new System.Drawing.Point(0, 34);
            this.labelBody.Name = "labelBody";
            this.labelBody.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.labelBody.Size = new System.Drawing.Size(318, 77);
            this.labelBody.TabIndex = 0;
            this.labelBody.Text = "Body goes here and here and here and here and here";
            this.labelBody.Click += new System.EventHandler(this.labelRO_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(318, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title goes here";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.labelBody);
            this.gunaShadowPanel1.Controls.Add(this.labelTitle);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 255;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(318, 111);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 111);
            this.ControlBox = false;
            this.Controls.Add(this.gunaShadowPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Notification";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Notification_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notification_FormClosed);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.Click += new System.EventHandler(this.Notification_Click);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}