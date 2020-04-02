namespace Server.dirOtherForms.RemoteManagement
{
    partial class LectureModePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectureModePlayer));
            this.btnShowHide = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.timerToggle = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStop = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // btnShowHide
            // 
            this.btnShowHide.AnimationHoverSpeed = 0.07F;
            this.btnShowHide.AnimationSpeed = 0.03F;
            this.btnShowHide.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnShowHide.BorderColor = System.Drawing.Color.Black;
            this.btnShowHide.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShowHide.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShowHide.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowHide.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnShowHide.CheckedImage")));
            this.btnShowHide.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShowHide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowHide.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowHide.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHide.ForeColor = System.Drawing.Color.White;
            this.btnShowHide.Image = global::Server.Resource1.chevron_right_50px_white;
            this.btnShowHide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowHide.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowHide.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShowHide.Location = new System.Drawing.Point(0, 0);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnShowHide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShowHide.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowHide.OnHoverImage = global::Server.Resource1.chevron_right_50px_white;
            this.btnShowHide.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShowHide.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowHide.Size = new System.Drawing.Size(40, 45);
            this.btnShowHide.TabIndex = 0;
            this.btnShowHide.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(95, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Broadcasting...";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(52, 13);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 16);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Status:";
            // 
            // timerToggle
            // 
            this.timerToggle.Interval = 30;
            this.timerToggle.Tick += new System.EventHandler(this.timerToggle_Tick);
            // 
            // btnPause
            // 
            this.btnPause.AnimationHoverSpeed = 0.07F;
            this.btnPause.AnimationSpeed = 0.03F;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnPause.BorderColor = System.Drawing.Color.Black;
            this.btnPause.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPause.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPause.CheckedForeColor = System.Drawing.Color.White;
            this.btnPause.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPause.CheckedImage")));
            this.btnPause.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPause.FocusedColor = System.Drawing.Color.Empty;
            this.btnPause.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Image = global::Server.Resource1.pause_50px;
            this.btnPause.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPause.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPause.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPause.Location = new System.Drawing.Point(203, 6);
            this.btnPause.Name = "btnPause";
            this.btnPause.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnPause.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPause.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPause.OnHoverImage = global::Server.Resource1.pause_50px;
            this.btnPause.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPause.OnPressedColor = System.Drawing.Color.Black;
            this.btnPause.Radius = 15;
            this.btnPause.Size = new System.Drawing.Size(30, 30);
            this.btnPause.TabIndex = 3;
            this.btnPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.AnimationHoverSpeed = 0.07F;
            this.btnStop.AnimationSpeed = 0.03F;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStop.BorderColor = System.Drawing.Color.Black;
            this.btnStop.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnStop.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStop.CheckedForeColor = System.Drawing.Color.White;
            this.btnStop.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnStop.CheckedImage")));
            this.btnStop.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStop.FocusedColor = System.Drawing.Color.Empty;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Image = global::Server.Resource1.stop_50px;
            this.btnStop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStop.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStop.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStop.Location = new System.Drawing.Point(239, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStop.OnHoverImage = global::Server.Resource1.stop_50px;
            this.btnStop.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStop.OnPressedColor = System.Drawing.Color.Black;
            this.btnStop.Radius = 15;
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // LectureModePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 45);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnShowHide);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LectureModePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LectureModePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnShowHide;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Timer timerToggle;
        private Guna.UI.WinForms.GunaAdvenceButton btnPause;
        private Guna.UI.WinForms.GunaAdvenceButton btnStop;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}