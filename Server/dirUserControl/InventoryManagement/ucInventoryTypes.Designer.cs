namespace Server.dirUserControl.InventoryManagement
{
    partial class ucInventoryTypes
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
            this.btnAddInventoryType = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvInventoryTypes = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inventoryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.inventoryTypesTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.InventoryTypesTableAdapter();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
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
            this.gunaLinePanel1.TabIndex = 5;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(163, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "TOTAL INVENTORY TYPES";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnAddInventoryType);
            this.gunaLinePanel2.Controls.Add(this.dgvInventoryTypes);
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
            this.gunaLinePanel2.TabIndex = 6;
            // 
            // btnAddInventoryType
            // 
            this.btnAddInventoryType.AnimationHoverSpeed = 0.07F;
            this.btnAddInventoryType.AnimationSpeed = 0.03F;
            this.btnAddInventoryType.BaseColor = System.Drawing.Color.White;
            this.btnAddInventoryType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddInventoryType.BorderSize = 1;
            this.btnAddInventoryType.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddInventoryType.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddInventoryType.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryType.CheckedImage = null;
            this.btnAddInventoryType.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddInventoryType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddInventoryType.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddInventoryType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventoryType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryType.Image = null;
            this.btnAddInventoryType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddInventoryType.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInventoryType.Location = new System.Drawing.Point(158, 13);
            this.btnAddInventoryType.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddInventoryType.Name = "btnAddInventoryType";
            this.btnAddInventoryType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddInventoryType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddInventoryType.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryType.OnHoverImage = null;
            this.btnAddInventoryType.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInventoryType.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddInventoryType.Size = new System.Drawing.Size(146, 29);
            this.btnAddInventoryType.TabIndex = 6;
            this.btnAddInventoryType.Text = "Add Inventory Type";
            this.btnAddInventoryType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddInventoryType.Click += new System.EventHandler(this.btnAddInventoryType_Click);
            // 
            // dgvInventoryTypes
            // 
            this.dgvInventoryTypes.AllowUserToAddRows = false;
            this.dgvInventoryTypes.AllowUserToDeleteRows = false;
            this.dgvInventoryTypes.AutoGenerateColumns = false;
            this.dgvInventoryTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInventoryTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventoryTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.action});
            this.dgvInventoryTypes.DataSource = this.inventoryTypesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryTypes.FilterAndSortEnabled = true;
            this.dgvInventoryTypes.Location = new System.Drawing.Point(22, 57);
            this.dgvInventoryTypes.MultiSelect = false;
            this.dgvInventoryTypes.Name = "dgvInventoryTypes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryTypes.Size = new System.Drawing.Size(1057, 571);
            this.dgvInventoryTypes.TabIndex = 5;
            this.dgvInventoryTypes.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvInventoryTypes_SortStringChanged);
            this.dgvInventoryTypes.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvInventoryTypes_FilterStringChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 45;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "INVENTORY TYPE";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "INVENTORY TYPES";
            // 
            // inventoryTypesTableAdapter
            // 
            this.inventoryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // ucInventoryTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventoryTypes";
            this.Size = new System.Drawing.Size(1365, 651);
            this.Load += new System.EventHandler(this.ucInventoryTypes_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddInventoryType;
        private Zuby.ADGV.AdvancedDataGridView dgvInventoryTypes;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.BindingSource inventoryTypesBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private dbThesisComfamaDataSetTableAdapters.InventoryTypesTableAdapter inventoryTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
