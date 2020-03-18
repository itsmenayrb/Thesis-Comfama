namespace Server.dirOtherForms.Settings
{
    partial class frmAddAcademicYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAcademicYear));
            this.cbAcademicYear = new Guna.UI.WinForms.GunaComboBox();
            this.cbSemester = new Guna.UI.WinForms.GunaComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddAcademicYear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAcademicYear
            // 
            this.cbAcademicYear.BackColor = System.Drawing.Color.Transparent;
            this.cbAcademicYear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbAcademicYear.BorderColor = System.Drawing.Color.Silver;
            this.cbAcademicYear.BorderSize = 1;
            this.cbAcademicYear.DisplayMember = "id";
            this.cbAcademicYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcademicYear.FocusedColor = System.Drawing.Color.Empty;
            this.cbAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcademicYear.ForeColor = System.Drawing.Color.Black;
            this.cbAcademicYear.FormattingEnabled = true;
            this.cbAcademicYear.ItemHeight = 27;
            this.cbAcademicYear.Location = new System.Drawing.Point(184, 164);
            this.cbAcademicYear.Name = "cbAcademicYear";
            this.cbAcademicYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbAcademicYear.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbAcademicYear.Size = new System.Drawing.Size(305, 33);
            this.cbAcademicYear.TabIndex = 41;
            this.cbAcademicYear.ValueMember = "id";
            // 
            // cbSemester
            // 
            this.cbSemester.BackColor = System.Drawing.Color.Transparent;
            this.cbSemester.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbSemester.BorderColor = System.Drawing.Color.Silver;
            this.cbSemester.BorderSize = 1;
            this.cbSemester.DisplayMember = "id";
            this.cbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FocusedColor = System.Drawing.Color.Empty;
            this.cbSemester.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemester.ForeColor = System.Drawing.Color.Black;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.ItemHeight = 27;
            this.cbSemester.Items.AddRange(new object[] {
            "--Select Semester--",
            "First Semester",
            "Second Semester",
            "Third Semester",
            "Summer"});
            this.cbSemester.Location = new System.Drawing.Point(184, 104);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbSemester.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSemester.Size = new System.Drawing.Size(305, 33);
            this.cbSemester.StartIndex = 0;
            this.cbSemester.TabIndex = 40;
            this.cbSemester.ValueMember = "id";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaAdvenceButton1);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.gunaControlBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 60);
            this.panel2.TabIndex = 63;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-9, 12);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(257, 46);
            this.gunaAdvenceButton1.TabIndex = 40;
            this.gunaAdvenceButton1.Text = "Add Academic Year";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(286, 28);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(174, 17);
            this.gunaLabel1.TabIndex = 41;
            this.gunaLabel1.Text = "INVENTORY MANAGEMENT  >";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(458, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(135, 17);
            this.gunaLabel2.TabIndex = 42;
            this.gunaLabel2.Text = "ADD ACADEMIC YEAR";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(599, 22);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 43;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(181, 82);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(62, 16);
            this.gunaLabel3.TabIndex = 64;
            this.gunaLabel3.Text = "SEMESTER";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(181, 143);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(105, 16);
            this.gunaLabel4.TabIndex = 65;
            this.gunaLabel4.Text = "ACADEMIC YEAR";
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
            this.btnCancel.Location = new System.Drawing.Point(184, 212);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddAcademicYear
            // 
            this.btnAddAcademicYear.AnimationHoverSpeed = 0.07F;
            this.btnAddAcademicYear.AnimationSpeed = 0.03F;
            this.btnAddAcademicYear.BaseColor = System.Drawing.Color.White;
            this.btnAddAcademicYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddAcademicYear.BorderSize = 1;
            this.btnAddAcademicYear.Checked = true;
            this.btnAddAcademicYear.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddAcademicYear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddAcademicYear.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAcademicYear.CheckedImage = null;
            this.btnAddAcademicYear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddAcademicYear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAcademicYear.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAcademicYear.Image = null;
            this.btnAddAcademicYear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAcademicYear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAcademicYear.Location = new System.Drawing.Point(311, 212);
            this.btnAddAcademicYear.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAcademicYear.Name = "btnAddAcademicYear";
            this.btnAddAcademicYear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddAcademicYear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddAcademicYear.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAcademicYear.OnHoverImage = null;
            this.btnAddAcademicYear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAcademicYear.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddAcademicYear.Size = new System.Drawing.Size(178, 35);
            this.btnAddAcademicYear.TabIndex = 67;
            this.btnAddAcademicYear.Text = "Add Academic Year";
            this.btnAddAcademicYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAcademicYear.Click += new System.EventHandler(this.btnAddAcademicYear_Click);
            // 
            // frmAddAcademicYear
            // 
            this.AcceptButton = this.btnAddAcademicYear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 282);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAcademicYear);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbAcademicYear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbSemester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAcademicYear";
            this.Text = "Add AcademicYear";
            this.Load += new System.EventHandler(this.frmAddAcademicYear_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbAcademicYear;
        private Guna.UI.WinForms.GunaComboBox cbSemester;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddAcademicYear;
    }
}