namespace Server.dirUserControl.InventoryManagement
{
    partial class ucInventorySupplierList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalBusinessTypeCount = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddSupplier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvInventorySupplier = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inventoryBusinessTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inventorySuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.inventorySuppliersTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.InventorySuppliersTableAdapter();
            this.inventoryBusinessTypesTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.InventoryBusinessTypesTableAdapter();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventorySupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBusinessTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.pictureBox1);
            this.gunaLinePanel1.Controls.Add(this.lblTotalBusinessTypeCount);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(258, 158);
            this.gunaLinePanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server.Resource1.google_analytics_logo_50px;
            this.pictureBox1.Location = new System.Drawing.Point(184, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalBusinessTypeCount
            // 
            this.lblTotalBusinessTypeCount.AutoSize = true;
            this.lblTotalBusinessTypeCount.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBusinessTypeCount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBusinessTypeCount.Location = new System.Drawing.Point(9, 48);
            this.lblTotalBusinessTypeCount.Name = "lblTotalBusinessTypeCount";
            this.lblTotalBusinessTypeCount.Size = new System.Drawing.Size(68, 78);
            this.lblTotalBusinessTypeCount.TabIndex = 13;
            this.lblTotalBusinessTypeCount.Text = "0";
            this.lblTotalBusinessTypeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(105, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "TOTAL SUPPLIER";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel2.Controls.Add(this.btnAddSupplier);
            this.gunaLinePanel2.Controls.Add(this.dgvInventorySupplier);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(264, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1101, 596);
            this.gunaLinePanel2.TabIndex = 8;
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
            this.btnGenerateReport.Location = new System.Drawing.Point(230, 12);
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
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.AnimationHoverSpeed = 0.07F;
            this.btnAddSupplier.AnimationSpeed = 0.03F;
            this.btnAddSupplier.BaseColor = System.Drawing.Color.White;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddSupplier.BorderSize = 1;
            this.btnAddSupplier.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddSupplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddSupplier.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddSupplier.CheckedImage = null;
            this.btnAddSupplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddSupplier.Image = null;
            this.btnAddSupplier.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddSupplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddSupplier.Location = new System.Drawing.Point(84, 12);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddSupplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddSupplier.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddSupplier.OnHoverImage = null;
            this.btnAddSupplier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddSupplier.Size = new System.Drawing.Size(146, 29);
            this.btnAddSupplier.TabIndex = 8;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // dgvInventorySupplier
            // 
            this.dgvInventorySupplier.AllowUserToAddRows = false;
            this.dgvInventorySupplier.AllowUserToDeleteRows = false;
            this.dgvInventorySupplier.AutoGenerateColumns = false;
            this.dgvInventorySupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInventorySupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventorySupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventorySupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventorySupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventorySupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.businessTypeDataGridViewTextBoxColumn,
            this.businessNameDataGridViewTextBoxColumn,
            this.supplierCode,
            this.supplierIDDataGridViewTextBoxColumn,
            this.businessAddressDataGridViewTextBoxColumn,
            this.businessContactNumberDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.action});
            this.dgvInventorySupplier.DataSource = this.inventorySuppliersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventorySupplier.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventorySupplier.FilterAndSortEnabled = true;
            this.dgvInventorySupplier.Location = new System.Drawing.Point(22, 57);
            this.dgvInventorySupplier.MultiSelect = false;
            this.dgvInventorySupplier.Name = "dgvInventorySupplier";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventorySupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventorySupplier.Size = new System.Drawing.Size(1057, 517);
            this.dgvInventorySupplier.TabIndex = 5;
            this.dgvInventorySupplier.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvInventorySupplier_SortStringChanged);
            this.dgvInventorySupplier.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvInventorySupplier_FilterStringChanged);
            this.dgvInventorySupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventorySupplier_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 45;
            // 
            // businessTypeDataGridViewTextBoxColumn
            // 
            this.businessTypeDataGridViewTextBoxColumn.DataPropertyName = "businessType";
            this.businessTypeDataGridViewTextBoxColumn.DataSource = this.inventoryBusinessTypesBindingSource;
            this.businessTypeDataGridViewTextBoxColumn.DisplayMember = "businessType";
            this.businessTypeDataGridViewTextBoxColumn.HeaderText = "BUSINESS TYPE";
            this.businessTypeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.businessTypeDataGridViewTextBoxColumn.Name = "businessTypeDataGridViewTextBoxColumn";
            this.businessTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.businessTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.businessTypeDataGridViewTextBoxColumn.ValueMember = "id";
            this.businessTypeDataGridViewTextBoxColumn.Width = 105;
            // 
            // inventoryBusinessTypesBindingSource
            // 
            this.inventoryBusinessTypesBindingSource.DataMember = "InventoryBusinessTypes";
            this.inventoryBusinessTypesBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // dbThesisComfamaDataSet
            // 
            this.dbThesisComfamaDataSet.DataSetName = "dbThesisComfamaDataSet";
            this.dbThesisComfamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "businessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "COMPANY/BUSINESS NAME";
            this.businessNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            this.businessNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.businessNameDataGridViewTextBoxColumn.Width = 174;
            // 
            // supplierCode
            // 
            this.supplierCode.DataPropertyName = "supplierCode";
            this.supplierCode.HeaderText = "SUPPLIER CODE";
            this.supplierCode.MinimumWidth = 22;
            this.supplierCode.Name = "supplierCode";
            this.supplierCode.ReadOnly = true;
            this.supplierCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.supplierCode.Width = 109;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SUPPLIER ID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.supplierIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // businessAddressDataGridViewTextBoxColumn
            // 
            this.businessAddressDataGridViewTextBoxColumn.DataPropertyName = "businessAddress";
            this.businessAddressDataGridViewTextBoxColumn.HeaderText = "BUSINESS ADDRESS";
            this.businessAddressDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.businessAddressDataGridViewTextBoxColumn.Name = "businessAddressDataGridViewTextBoxColumn";
            this.businessAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.businessAddressDataGridViewTextBoxColumn.Width = 126;
            // 
            // businessContactNumberDataGridViewTextBoxColumn
            // 
            this.businessContactNumberDataGridViewTextBoxColumn.DataPropertyName = "businessContactNumber";
            this.businessContactNumberDataGridViewTextBoxColumn.HeaderText = "BUSINESS NUMBER";
            this.businessContactNumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.businessContactNumberDataGridViewTextBoxColumn.Name = "businessContactNumberDataGridViewTextBoxColumn";
            this.businessContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.businessContactNumberDataGridViewTextBoxColumn.Width = 124;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "contactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "CONTACT PERSON";
            this.contactPersonDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.contactPersonDataGridViewTextBoxColumn.Width = 127;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "CONTACT NUMBER";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.contactNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // action
            // 
            this.action.HeaderText = "ACTION";
            this.action.MinimumWidth = 22;
            this.action.Name = "action";
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.action.Text = "UPDATE";
            this.action.UseColumnTextForButtonValue = true;
            this.action.Width = 80;
            // 
            // inventorySuppliersBindingSource
            // 
            this.inventorySuppliersBindingSource.DataMember = "InventorySuppliers";
            this.inventorySuppliersBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "SUPPLIER";
            // 
            // inventorySuppliersTableAdapter
            // 
            this.inventorySuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryBusinessTypesTableAdapter
            // 
            this.inventoryBusinessTypesTableAdapter.ClearBeforeFill = true;
            // 
            // ucInventorySupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventorySupplierList";
            this.Size = new System.Drawing.Size(1365, 596);
            this.Load += new System.EventHandler(this.ucInventorySupplierList_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventorySupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBusinessTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Zuby.ADGV.AdvancedDataGridView dgvInventorySupplier;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddSupplier;
        private System.Windows.Forms.BindingSource inventoryBusinessTypesBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private System.Windows.Forms.BindingSource inventorySuppliersBindingSource;
        private dbThesisComfamaDataSetTableAdapters.InventorySuppliersTableAdapter inventorySuppliersTableAdapter;
        private dbThesisComfamaDataSetTableAdapters.InventoryBusinessTypesTableAdapter inventoryBusinessTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn businessTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTotalBusinessTypeCount;
    }
}
