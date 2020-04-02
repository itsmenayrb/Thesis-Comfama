namespace Server.dirUserControl.Archived
{
    partial class ucInventoryManagement
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
            this.dgvInventoryManagement = new Zuby.ADGV.AdvancedDataGridView();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAcquired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryManagement)).BeginInit();
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
            this.gunaLinePanel1.TabIndex = 7;
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
            this.gunaLinePanel2.Controls.Add(this.dgvInventoryManagement);
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
            this.gunaLinePanel2.TabIndex = 8;
            // 
            // dgvInventoryManagement
            // 
            this.dgvInventoryManagement.AllowUserToAddRows = false;
            this.dgvInventoryManagement.AllowUserToDeleteRows = false;
            this.dgvInventoryManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventoryManagement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventoryManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventoryManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.description,
            this.brand,
            this.model,
            this.serialNumber,
            this.licenseKey,
            this.capacity,
            this.quantity,
            this.propertyNumber,
            this.location,
            this.dateAcquired,
            this.dateExpiry,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryManagement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryManagement.FilterAndSortEnabled = true;
            this.dgvInventoryManagement.Location = new System.Drawing.Point(22, 56);
            this.dgvInventoryManagement.MultiSelect = false;
            this.dgvInventoryManagement.Name = "dgvInventoryManagement";
            this.dgvInventoryManagement.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryManagement.Size = new System.Drawing.Size(1002, 578);
            this.dgvInventoryManagement.TabIndex = 11;
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
            this.gunaLabel2.Size = new System.Drawing.Size(145, 16);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Inventory Management";
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "item";
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 22;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.itemName.Width = 98;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 22;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.description.Width = 98;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 22;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.brand.Width = 67;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 22;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.model.Width = 71;
            // 
            // serialNumber
            // 
            this.serialNumber.DataPropertyName = "serialNumber";
            this.serialNumber.HeaderText = "Serial Number";
            this.serialNumber.MinimumWidth = 22;
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            this.serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.serialNumber.Width = 115;
            // 
            // licenseKey
            // 
            this.licenseKey.DataPropertyName = "licenseKey";
            this.licenseKey.HeaderText = "License Key";
            this.licenseKey.MinimumWidth = 22;
            this.licenseKey.Name = "licenseKey";
            this.licenseKey.ReadOnly = true;
            this.licenseKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.licenseKey.Width = 102;
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Capacity";
            this.capacity.MinimumWidth = 22;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.capacity.Width = 87;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "unit";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 22;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.quantity.Width = 81;
            // 
            // propertyNumber
            // 
            this.propertyNumber.DataPropertyName = "propertyNumber";
            this.propertyNumber.HeaderText = "Property Number";
            this.propertyNumber.MinimumWidth = 22;
            this.propertyNumber.Name = "propertyNumber";
            this.propertyNumber.ReadOnly = true;
            this.propertyNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.propertyNumber.Width = 121;
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
            // dateAcquired
            // 
            this.dateAcquired.DataPropertyName = "dateAcquired";
            this.dateAcquired.HeaderText = "Date Acquired";
            this.dateAcquired.MinimumWidth = 22;
            this.dateAcquired.Name = "dateAcquired";
            this.dateAcquired.ReadOnly = true;
            this.dateAcquired.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dateAcquired.Width = 108;
            // 
            // dateExpiry
            // 
            this.dateExpiry.DataPropertyName = "dateExpiry";
            this.dateExpiry.HeaderText = "End of Subscription";
            this.dateExpiry.MinimumWidth = 22;
            this.dateExpiry.Name = "dateExpiry";
            this.dateExpiry.ReadOnly = true;
            this.dateExpiry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dateExpiry.Width = 129;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 22;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.status.Width = 65;
            // 
            // ucInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventoryManagement";
            this.Size = new System.Drawing.Size(1047, 720);
            this.Load += new System.EventHandler(this.ucInventoryManagement_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lblAcademicYear;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Zuby.ADGV.AdvancedDataGridView dgvInventoryManagement;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
