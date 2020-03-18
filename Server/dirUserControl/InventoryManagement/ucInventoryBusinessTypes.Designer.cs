namespace Server.dirUserControl.InventoryManagement
{
    partial class ucInventoryBusinessTypes
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
            this.btnAddBusinessType = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvInventoryBusinessType = new Zuby.ADGV.AdvancedDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.inventoryBusinessTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBusinessTypesTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.InventoryBusinessTypesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryBusinessType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBusinessTypesBindingSource)).BeginInit();
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
            this.gunaLinePanel1.TabIndex = 8;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(141, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "TOTAL BUSINESS TYPE";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnAddBusinessType);
            this.gunaLinePanel2.Controls.Add(this.dgvInventoryBusinessType);
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
            this.gunaLinePanel2.TabIndex = 9;
            // 
            // btnAddBusinessType
            // 
            this.btnAddBusinessType.AnimationHoverSpeed = 0.07F;
            this.btnAddBusinessType.AnimationSpeed = 0.03F;
            this.btnAddBusinessType.BaseColor = System.Drawing.Color.White;
            this.btnAddBusinessType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddBusinessType.BorderSize = 1;
            this.btnAddBusinessType.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddBusinessType.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddBusinessType.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddBusinessType.CheckedImage = null;
            this.btnAddBusinessType.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddBusinessType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBusinessType.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBusinessType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBusinessType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddBusinessType.Image = null;
            this.btnAddBusinessType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddBusinessType.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddBusinessType.Location = new System.Drawing.Point(120, 11);
            this.btnAddBusinessType.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddBusinessType.Name = "btnAddBusinessType";
            this.btnAddBusinessType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddBusinessType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBusinessType.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddBusinessType.OnHoverImage = null;
            this.btnAddBusinessType.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddBusinessType.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBusinessType.Size = new System.Drawing.Size(146, 29);
            this.btnAddBusinessType.TabIndex = 8;
            this.btnAddBusinessType.Text = "Add Business Type";
            this.btnAddBusinessType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddBusinessType.Click += new System.EventHandler(this.btnAddBusinessType_Click);
            // 
            // dgvInventoryBusinessType
            // 
            this.dgvInventoryBusinessType.AllowUserToAddRows = false;
            this.dgvInventoryBusinessType.AllowUserToDeleteRows = false;
            this.dgvInventoryBusinessType.AutoGenerateColumns = false;
            this.dgvInventoryBusinessType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInventoryBusinessType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventoryBusinessType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryBusinessType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryBusinessType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryBusinessType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.businessTypeDataGridViewTextBoxColumn,
            this.action});
            this.dgvInventoryBusinessType.DataSource = this.inventoryBusinessTypesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryBusinessType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryBusinessType.FilterAndSortEnabled = true;
            this.dgvInventoryBusinessType.Location = new System.Drawing.Point(22, 57);
            this.dgvInventoryBusinessType.MultiSelect = false;
            this.dgvInventoryBusinessType.Name = "dgvInventoryBusinessType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryBusinessType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryBusinessType.Size = new System.Drawing.Size(1057, 517);
            this.dgvInventoryBusinessType.TabIndex = 5;
            this.dgvInventoryBusinessType.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvInventoryBusinessType_SortStringChanged);
            this.dgvInventoryBusinessType.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvInventoryBusinessType_FilterStringChanged);
            this.dgvInventoryBusinessType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryBusinessType_CellClick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(98, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "BUSINESS TYPE";
            // 
            // dbThesisComfamaDataSet
            // 
            this.dbThesisComfamaDataSet.DataSetName = "dbThesisComfamaDataSet";
            this.dbThesisComfamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBusinessTypesBindingSource
            // 
            this.inventoryBusinessTypesBindingSource.DataMember = "InventoryBusinessTypes";
            this.inventoryBusinessTypesBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // inventoryBusinessTypesTableAdapter
            // 
            this.inventoryBusinessTypesTableAdapter.ClearBeforeFill = true;
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
            this.businessTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.businessTypeDataGridViewTextBoxColumn.DataPropertyName = "businessType";
            this.businessTypeDataGridViewTextBoxColumn.HeaderText = "BUSINESS TYPE";
            this.businessTypeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.businessTypeDataGridViewTextBoxColumn.Name = "businessTypeDataGridViewTextBoxColumn";
            this.businessTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // ucInventoryBusinessTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventoryBusinessTypes";
            this.Size = new System.Drawing.Size(1365, 596);
            this.Load += new System.EventHandler(this.ucInventoryBusinessTypes_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryBusinessType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBusinessTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddBusinessType;
        private Zuby.ADGV.AdvancedDataGridView dgvInventoryBusinessType;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.BindingSource inventoryBusinessTypesBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private dbThesisComfamaDataSetTableAdapters.InventoryBusinessTypesTableAdapter inventoryBusinessTypesTableAdapter;
    }
}
