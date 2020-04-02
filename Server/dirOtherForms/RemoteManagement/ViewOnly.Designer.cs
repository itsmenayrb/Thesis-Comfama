namespace Server.dirOtherForms.RemoteManagement
{
    partial class ViewOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOnly));
            this.panelTop = new System.Windows.Forms.Panel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.btnScreenshot = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btnInSession = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pbScreenImage = new System.Windows.Forms.PictureBox();
            this.timerDisplayScreenCapture = new System.Windows.Forms.Timer(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gunaControlBox2);
            this.panelTop.Controls.Add(this.btnScreenshot);
            this.panelTop.Controls.Add(this.gunaControlBox1);
            this.panelTop.Controls.Add(this.btnInSession);
            this.panelTop.Controls.Add(this.gunaLabel2);
            this.panelTop.Controls.Add(this.gunaLabel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1400, 60);
            this.panelTop.TabIndex = 5;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1301, 17);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 46;
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.AnimationHoverSpeed = 0.07F;
            this.btnScreenshot.AnimationSpeed = 0.03F;
            this.btnScreenshot.BaseColor = System.Drawing.Color.White;
            this.btnScreenshot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnScreenshot.BorderSize = 1;
            this.btnScreenshot.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnScreenshot.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnScreenshot.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnScreenshot.CheckedImage = null;
            this.btnScreenshot.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnScreenshot.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnScreenshot.FocusedColor = System.Drawing.Color.Empty;
            this.btnScreenshot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenshot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnScreenshot.Image = null;
            this.btnScreenshot.ImageSize = new System.Drawing.Size(30, 30);
            this.btnScreenshot.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnScreenshot.Location = new System.Drawing.Point(944, 17);
            this.btnScreenshot.Margin = new System.Windows.Forms.Padding(0);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnScreenshot.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnScreenshot.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnScreenshot.OnHoverImage = null;
            this.btnScreenshot.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnScreenshot.OnPressedColor = System.Drawing.Color.Black;
            this.btnScreenshot.Size = new System.Drawing.Size(146, 29);
            this.btnScreenshot.TabIndex = 45;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1352, 17);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 44;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // btnInSession
            // 
            this.btnInSession.AnimationHoverSpeed = 0.07F;
            this.btnInSession.AnimationSpeed = 0.03F;
            this.btnInSession.BackColor = System.Drawing.Color.Transparent;
            this.btnInSession.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnInSession.BorderColor = System.Drawing.Color.Black;
            this.btnInSession.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnInSession.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnInSession.CheckedForeColor = System.Drawing.Color.White;
            this.btnInSession.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnInSession.CheckedImage")));
            this.btnInSession.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnInSession.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInSession.FocusedColor = System.Drawing.Color.Empty;
            this.btnInSession.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSession.ForeColor = System.Drawing.Color.White;
            this.btnInSession.Image = ((System.Drawing.Image)(resources.GetObject("btnInSession.Image")));
            this.btnInSession.ImageOffsetX = 15;
            this.btnInSession.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInSession.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInSession.Location = new System.Drawing.Point(-13, 8);
            this.btnInSession.Name = "btnInSession";
            this.btnInSession.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnInSession.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInSession.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInSession.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnInSession.OnHoverImage")));
            this.btnInSession.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInSession.OnPressedColor = System.Drawing.Color.Black;
            this.btnInSession.Radius = 8;
            this.btnInSession.Size = new System.Drawing.Size(462, 46);
            this.btnInSession.TabIndex = 2;
            this.btnInSession.TextOffsetX = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(1221, 24);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 17);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "VIEW ONLY";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(1137, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "COMFAMA  >";
            // 
            // pbScreenImage
            // 
            this.pbScreenImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbScreenImage.Location = new System.Drawing.Point(0, 60);
            this.pbScreenImage.Name = "pbScreenImage";
            this.pbScreenImage.Size = new System.Drawing.Size(1400, 740);
            this.pbScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreenImage.TabIndex = 6;
            this.pbScreenImage.TabStop = false;
            // 
            // timerDisplayScreenCapture
            // 
            this.timerDisplayScreenCapture.Interval = 1000;
            this.timerDisplayScreenCapture.Tick += new System.EventHandler(this.timerDisplayScreenCapture_Tick);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // ViewOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pbScreenImage);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOnly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ViewOnly_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaAdvenceButton btnInSession;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnScreenshot;
        private System.Windows.Forms.PictureBox pbScreenImage;
        private System.Windows.Forms.Timer timerDisplayScreenCapture;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
    }
}