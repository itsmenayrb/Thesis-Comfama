namespace Server.dirUserControl.AuditTrail
{
    partial class ucAuditTrail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAuditTrail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel6 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvAuditTrail = new Zuby.ADGV.AdvancedDataGridView();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.gunaLinePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditTrail)).BeginInit();
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
            this.panelTop.TabIndex = 7;
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
            this.gunaAdvenceButton1.Text = "Audit Trail";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(1316, 59);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 17);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "AUDIT TRAIL";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(1232, 59);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "COMFAMA  >";
            // 
            // gunaLinePanel6
            // 
            this.gunaLinePanel6.Controls.Add(this.dgvAuditTrail);
            this.gunaLinePanel6.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel6.Controls.Add(this.gunaLabel10);
            this.gunaLinePanel6.LineBottom = 1;
            this.gunaLinePanel6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel6.LineLeft = 1;
            this.gunaLinePanel6.LineRight = 1;
            this.gunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel6.LineTop = 1;
            this.gunaLinePanel6.Location = new System.Drawing.Point(25, 102);
            this.gunaLinePanel6.Name = "gunaLinePanel6";
            this.gunaLinePanel6.Size = new System.Drawing.Size(1366, 724);
            this.gunaLinePanel6.TabIndex = 13;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(83, 16);
            this.gunaLabel10.TabIndex = 2;
            this.gunaLabel10.Text = "AUDIT TRAIL";
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
            this.btnGenerateReport.Location = new System.Drawing.Point(105, 12);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.OnHoverImage = null;
            this.btnGenerateReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Size = new System.Drawing.Size(146, 29);
            this.btnGenerateReport.TabIndex = 9;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvAuditTrail
            // 
            this.dgvAuditTrail.AllowUserToAddRows = false;
            this.dgvAuditTrail.AllowUserToDeleteRows = false;
            this.dgvAuditTrail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditTrail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvAuditTrail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuditTrail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditTrail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditTrail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guid,
            this.fullName,
            this.actionTaken,
            this.oldValue,
            this.newValue,
            this.dateCreated});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditTrail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditTrail.FilterAndSortEnabled = true;
            this.dgvAuditTrail.Location = new System.Drawing.Point(22, 58);
            this.dgvAuditTrail.MultiSelect = false;
            this.dgvAuditTrail.Name = "dgvAuditTrail";
            this.dgvAuditTrail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuditTrail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditTrail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditTrail.Size = new System.Drawing.Size(1321, 639);
            this.dgvAuditTrail.TabIndex = 11;
            // 
            // guid
            // 
            this.guid.DataPropertyName = "guid";
            this.guid.HeaderText = "GUID";
            this.guid.MinimumWidth = 22;
            this.guid.Name = "guid";
            this.guid.ReadOnly = true;
            this.guid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "FULL NAME";
            this.fullName.MinimumWidth = 22;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // actionTaken
            // 
            this.actionTaken.DataPropertyName = "actionTaken";
            this.actionTaken.HeaderText = "ACTION TAKEN";
            this.actionTaken.MinimumWidth = 22;
            this.actionTaken.Name = "actionTaken";
            this.actionTaken.ReadOnly = true;
            this.actionTaken.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // oldValue
            // 
            this.oldValue.DataPropertyName = "oldValue";
            this.oldValue.HeaderText = "OLD VALUE";
            this.oldValue.MinimumWidth = 22;
            this.oldValue.Name = "oldValue";
            this.oldValue.ReadOnly = true;
            this.oldValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // newValue
            // 
            this.newValue.DataPropertyName = "newValue";
            this.newValue.HeaderText = "NEW VALUE";
            this.newValue.MinimumWidth = 22;
            this.newValue.Name = "newValue";
            this.newValue.ReadOnly = true;
            this.newValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dateCreated
            // 
            this.dateCreated.DataPropertyName = "dateCreated";
            this.dateCreated.HeaderText = "DATE";
            this.dateCreated.MinimumWidth = 22;
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.ReadOnly = true;
            this.dateCreated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ucAuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel6);
            this.Controls.Add(this.panelTop);
            this.Name = "ucAuditTrail";
            this.Size = new System.Drawing.Size(1417, 848);
            this.Load += new System.EventHandler(this.ucAuditTrail_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.gunaLinePanel6.ResumeLayout(false);
            this.gunaLinePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditTrail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Zuby.ADGV.AdvancedDataGridView dgvAuditTrail;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn newValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;



    }
}
