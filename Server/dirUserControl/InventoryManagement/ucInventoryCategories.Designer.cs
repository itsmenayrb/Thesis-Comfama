namespace Server.dirUserControl.InventoryManagement
{
    partial class ucInventoryCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnAddCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvInventoryCategories = new Zuby.ADGV.AdvancedDataGridView();
            this.inventoryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.inventoryCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.inventoryCategoriesTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.InventoryCategoriesTableAdapter();
            this.inventoryTypesTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.InventoryTypesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
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
            this.gunaLinePanel1.TabIndex = 6;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(199, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "TOTAL INVENTORY CATEGORY";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnAddCategory);
            this.gunaLinePanel2.Controls.Add(this.dgvInventoryCategories);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(264, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1101, 651);
            this.gunaLinePanel2.TabIndex = 7;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AnimationHoverSpeed = 0.07F;
            this.btnAddCategory.AnimationSpeed = 0.03F;
            this.btnAddCategory.BaseColor = System.Drawing.Color.White;
            this.btnAddCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddCategory.BorderSize = 1;
            this.btnAddCategory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.CheckedImage = null;
            this.btnAddCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.Image = null;
            this.btnAddCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.Location = new System.Drawing.Point(178, 13);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.OnHoverImage = null;
            this.btnAddCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCategory.Size = new System.Drawing.Size(182, 29);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Add Inventory Category";
            this.btnAddCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvInventoryCategories
            // 
            this.dgvInventoryCategories.AllowUserToAddRows = false;
            this.dgvInventoryCategories.AllowUserToDeleteRows = false;
            this.dgvInventoryCategories.AutoGenerateColumns = false;
            this.dgvInventoryCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventoryCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.action});
            this.dgvInventoryCategories.DataSource = this.inventoryCategoriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryCategories.FilterAndSortEnabled = true;
            this.dgvInventoryCategories.Location = new System.Drawing.Point(22, 57);
            this.dgvInventoryCategories.MultiSelect = false;
            this.dgvInventoryCategories.Name = "dgvInventoryCategories";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryCategories.Size = new System.Drawing.Size(1057, 571);
            this.dgvInventoryCategories.TabIndex = 5;
            this.dgvInventoryCategories.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvInventoryCategory_SortStringChanged);
            this.dgvInventoryCategories.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvInventoryCategory_FilterStringChanged);
            this.dgvInventoryCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryCategories_CellClick);
            // 
            // inventoryTypesBindingSource
            // 
            this.inventoryTypesBindingSource.DataMember = "InventoryTypes";
            this.inventoryTypesBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // dbThesisComfamaDataSet
            // 
            this.dbThesisComfamaDataSet.DataSetName = "dbThesisComfamaDataSet";
            this.dbThesisComfamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryCategoriesBindingSource
            // 
            this.inventoryCategoriesBindingSource.DataMember = "InventoryCategories";
            this.inventoryCategoriesBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(156, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "INVENTORY CATEGORY";
            // 
            // inventoryCategoriesTableAdapter
            // 
            this.inventoryCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTypesTableAdapter
            // 
            this.inventoryTypesTableAdapter.ClearBeforeFill = true;
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
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.inventoryTypesBindingSource;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "id";
            this.typeDataGridViewTextBoxColumn.Width = 150;
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
            // ucInventoryCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventoryCategories";
            this.Size = new System.Drawing.Size(1365, 651);
            this.Load += new System.EventHandler(this.ucInventoryCategories_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddCategory;
        private Zuby.ADGV.AdvancedDataGridView dgvInventoryCategories;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.BindingSource inventoryCategoriesBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private dbThesisComfamaDataSetTableAdapters.InventoryCategoriesTableAdapter inventoryCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource inventoryTypesBindingSource;
        private dbThesisComfamaDataSetTableAdapters.InventoryTypesTableAdapter inventoryTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
