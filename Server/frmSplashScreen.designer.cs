namespace Server
{
    partial class frmSplashScreen
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
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.progressBarSplashScreen = new Guna.UI.WinForms.GunaProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarSplashScreen
            // 
            this.progressBarSplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.progressBarSplashScreen.BorderColor = System.Drawing.Color.Black;
            this.progressBarSplashScreen.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaTransition1.SetDecoration(this.progressBarSplashScreen, Guna.UI.Animation.DecorationType.None);
            this.progressBarSplashScreen.IdleColor = System.Drawing.Color.White;
            this.progressBarSplashScreen.Location = new System.Drawing.Point(76, 412);
            this.progressBarSplashScreen.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarSplashScreen.Name = "progressBarSplashScreen";
            this.progressBarSplashScreen.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.progressBarSplashScreen.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBarSplashScreen.Radius = 5;
            this.progressBarSplashScreen.Size = new System.Drawing.Size(756, 10);
            this.progressBarSplashScreen.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
            this.progressBarSplashScreen.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(118, 277);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(668, 88);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "COMPUTER FACILITIES AND INVENTORY MANAGEMENT WITH DECISION SUPPORT SYSTEM FOR CAV" +
    "ITE STATE UNIVERSITY - IMUS";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox1.Image = global::Server.Resource1.kuya_logo_1_2_white;
            this.gunaPictureBox1.Location = new System.Drawing.Point(280, 61);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(355, 304);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 22;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.progressBarSplashScreen);
            this.Controls.Add(this.gunaPictureBox1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comfama";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaProgressBar progressBarSplashScreen;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}