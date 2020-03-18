namespace Server.dirUserControl.Settings
{
    partial class ucSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSettings));
            this.panelTop = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnNetwork = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSpecification = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAcademicYear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ucAcademicYear1 = new Server.dirUserControl.Settings.ucAcademicYear();
            this.panelTop.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
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
            this.panelTop.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(1329, 59);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(60, 17);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "SETTINGS";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(1245, 59);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "COMFAMA  >";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.btnNetwork);
            this.gunaLinePanel1.Controls.Add(this.btnSpecification);
            this.gunaLinePanel1.Controls.Add(this.btnAcademicYear);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(25, 102);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1364, 55);
            this.gunaLinePanel1.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "NAVIGATION";
            // 
            // btnNetwork
            // 
            this.btnNetwork.AnimationHoverSpeed = 0.07F;
            this.btnNetwork.AnimationSpeed = 0.03F;
            this.btnNetwork.BaseColor = System.Drawing.Color.White;
            this.btnNetwork.BorderColor = System.Drawing.Color.Black;
            this.btnNetwork.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnNetwork.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnNetwork.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNetwork.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnNetwork.CheckedImage = null;
            this.btnNetwork.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNetwork.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNetwork.FocusedColor = System.Drawing.Color.Empty;
            this.btnNetwork.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnNetwork.Image = null;
            this.btnNetwork.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNetwork.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNetwork.Location = new System.Drawing.Point(464, 13);
            this.btnNetwork.Margin = new System.Windows.Forms.Padding(0);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnNetwork.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNetwork.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnNetwork.OnHoverImage = null;
            this.btnNetwork.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNetwork.OnPressedColor = System.Drawing.Color.Black;
            this.btnNetwork.Size = new System.Drawing.Size(146, 29);
            this.btnNetwork.TabIndex = 8;
            this.btnNetwork.Text = "Network";
            this.btnNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpecification
            // 
            this.btnSpecification.AnimationHoverSpeed = 0.07F;
            this.btnSpecification.AnimationSpeed = 0.03F;
            this.btnSpecification.BaseColor = System.Drawing.Color.White;
            this.btnSpecification.BorderColor = System.Drawing.Color.Black;
            this.btnSpecification.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnSpecification.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSpecification.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSpecification.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSpecification.CheckedImage = null;
            this.btnSpecification.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSpecification.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSpecification.FocusedColor = System.Drawing.Color.Empty;
            this.btnSpecification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSpecification.Image = null;
            this.btnSpecification.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSpecification.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSpecification.Location = new System.Drawing.Point(318, 13);
            this.btnSpecification.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpecification.Name = "btnSpecification";
            this.btnSpecification.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSpecification.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSpecification.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSpecification.OnHoverImage = null;
            this.btnSpecification.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSpecification.OnPressedColor = System.Drawing.Color.Black;
            this.btnSpecification.Size = new System.Drawing.Size(146, 29);
            this.btnSpecification.TabIndex = 7;
            this.btnSpecification.Text = "Specification";
            this.btnSpecification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAcademicYear
            // 
            this.btnAcademicYear.AnimationHoverSpeed = 0.07F;
            this.btnAcademicYear.AnimationSpeed = 0.03F;
            this.btnAcademicYear.BaseColor = System.Drawing.Color.White;
            this.btnAcademicYear.BorderColor = System.Drawing.Color.Black;
            this.btnAcademicYear.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAcademicYear.Checked = true;
            this.btnAcademicYear.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAcademicYear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAcademicYear.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAcademicYear.CheckedImage = null;
            this.btnAcademicYear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAcademicYear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAcademicYear.FocusedColor = System.Drawing.Color.Empty;
            this.btnAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAcademicYear.Image = null;
            this.btnAcademicYear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAcademicYear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAcademicYear.Location = new System.Drawing.Point(172, 13);
            this.btnAcademicYear.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcademicYear.Name = "btnAcademicYear";
            this.btnAcademicYear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAcademicYear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAcademicYear.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAcademicYear.OnHoverImage = null;
            this.btnAcademicYear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAcademicYear.OnPressedColor = System.Drawing.Color.Black;
            this.btnAcademicYear.Size = new System.Drawing.Size(146, 29);
            this.btnAcademicYear.TabIndex = 6;
            this.btnAcademicYear.Text = "Academic Year";
            this.btnAcademicYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucAcademicYear1);
            this.panel1.Location = new System.Drawing.Point(25, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 651);
            this.panel1.TabIndex = 8;
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
            this.gunaAdvenceButton1.Text = "Settings";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // ucAcademicYear1
            // 
            this.ucAcademicYear1.BackColor = System.Drawing.Color.White;
            this.ucAcademicYear1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAcademicYear1.Location = new System.Drawing.Point(0, 0);
            this.ucAcademicYear1.Name = "ucAcademicYear1";
            this.ucAcademicYear1.Size = new System.Drawing.Size(1365, 651);
            this.ucAcademicYear1.TabIndex = 0;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.panelTop);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(1417, 848);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnNetwork;
        private Guna.UI.WinForms.GunaAdvenceButton btnSpecification;
        private Guna.UI.WinForms.GunaAdvenceButton btnAcademicYear;
        private System.Windows.Forms.Panel panel1;
        private ucAcademicYear ucAcademicYear1;
    }
}
