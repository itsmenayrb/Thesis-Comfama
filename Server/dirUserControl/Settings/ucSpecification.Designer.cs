namespace Server.dirUserControl.Settings
{
    partial class ucSpecification
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
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnStartScan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnStartScan);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1365, 651);
            this.gunaLinePanel2.TabIndex = 10;
            // 
            // btnStartScan
            // 
            this.btnStartScan.AnimationHoverSpeed = 0.07F;
            this.btnStartScan.AnimationSpeed = 0.03F;
            this.btnStartScan.BaseColor = System.Drawing.Color.White;
            this.btnStartScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStartScan.BorderSize = 1;
            this.btnStartScan.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStartScan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStartScan.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStartScan.CheckedImage = null;
            this.btnStartScan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStartScan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStartScan.FocusedColor = System.Drawing.Color.Empty;
            this.btnStartScan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStartScan.Image = null;
            this.btnStartScan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStartScan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStartScan.Location = new System.Drawing.Point(119, 12);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStartScan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStartScan.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStartScan.OnHoverImage = null;
            this.btnStartScan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStartScan.OnPressedColor = System.Drawing.Color.Black;
            this.btnStartScan.Size = new System.Drawing.Size(146, 29);
            this.btnStartScan.TabIndex = 11;
            this.btnStartScan.Text = "Start scan";
            this.btnStartScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(97, 16);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "SPECIFICATION";
            // 
            // ucSpecification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Name = "ucSpecification";
            this.Size = new System.Drawing.Size(1365, 651);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnStartScan;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
