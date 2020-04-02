namespace Server.dirUserControl.Archived
{
    partial class ucLoginHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblAcademicYear = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.dgvLoginHistory = new Zuby.ADGV.AdvancedDataGridView();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.loginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appsUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblAcademicYear);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1047, 55);
            this.gunaLinePanel1.TabIndex = 8;
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicYear.Location = new System.Drawing.Point(170, 18);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(240, 17);
            this.lblAcademicYear.TabIndex = 7;
            this.lblAcademicYear.Text = "You have not setup automatic backup.";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(101, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Academic Year";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.dgvLoginHistory);
            this.gunaLinePanel2.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 61);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1047, 659);
            this.gunaLinePanel2.TabIndex = 10;
            // 
            // dgvLoginHistory
            // 
            this.dgvLoginHistory.AllowUserToAddRows = false;
            this.dgvLoginHistory.AllowUserToDeleteRows = false;
            this.dgvLoginHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoginHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoginHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvLoginHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDate,
            this.fullName,
            this.startTime,
            this.endTime,
            this.duration,
            this.location,
            this.machineName,
            this.appsUsed,
            this.remarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoginHistory.FilterAndSortEnabled = true;
            this.dgvLoginHistory.Location = new System.Drawing.Point(22, 56);
            this.dgvLoginHistory.MultiSelect = false;
            this.dgvLoginHistory.Name = "dgvLoginHistory";
            this.dgvLoginHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoginHistory.Size = new System.Drawing.Size(1002, 578);
            this.dgvLoginHistory.TabIndex = 11;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.AnimationHoverSpeed = 0.07F;
            this.btnGenerateReport.AnimationSpeed = 0.03F;
            this.btnGenerateReport.BaseColor = System.Drawing.Color.White;
            this.btnGenerateReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnGenerateReport.BorderSize = 1;
            this.btnGenerateReport.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnGenerateReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.CheckedImage = null;
            this.btnGenerateReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGenerateReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.Image = null;
            this.btnGenerateReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateReport.Location = new System.Drawing.Point(172, 13);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.OnHoverImage = null;
            this.btnGenerateReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Size = new System.Drawing.Size(146, 29);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 16);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Login History";
            // 
            // loginDate
            // 
            this.loginDate.DataPropertyName = "loginDate";
            this.loginDate.HeaderText = "Date";
            this.loginDate.MinimumWidth = 22;
            this.loginDate.Name = "loginDate";
            this.loginDate.ReadOnly = true;
            this.loginDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.loginDate.Width = 60;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 22;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fullName.Width = 91;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.HeaderText = "Start";
            this.startTime.MinimumWidth = 22;
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.startTime.Width = 57;
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "endTime";
            this.endTime.HeaderText = "End";
            this.endTime.MinimumWidth = 22;
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.endTime.Width = 54;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "Duration";
            this.duration.MinimumWidth = 22;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.duration.Width = 81;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Room/Office/Department";
            this.location.MinimumWidth = 22;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.location.Width = 182;
            // 
            // machineName
            // 
            this.machineName.DataPropertyName = "machineName";
            this.machineName.HeaderText = "Computer Name";
            this.machineName.MinimumWidth = 22;
            this.machineName.Name = "machineName";
            this.machineName.ReadOnly = true;
            this.machineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.machineName.Width = 119;
            // 
            // appsUsed
            // 
            this.appsUsed.DataPropertyName = "appsUsed";
            this.appsUsed.HeaderText = "Application Used";
            this.appsUsed.MinimumWidth = 22;
            this.appsUsed.Name = "appsUsed";
            this.appsUsed.ReadOnly = true;
            this.appsUsed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.appsUsed.Width = 122;
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "Remarks";
            this.remarks.MinimumWidth = 22;
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            this.remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.remarks.Width = 83;
            // 
            // ucLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucLoginHistory";
            this.Size = new System.Drawing.Size(1047, 720);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lblAcademicYear;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Zuby.ADGV.AdvancedDataGridView dgvLoginHistory;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appsUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}
