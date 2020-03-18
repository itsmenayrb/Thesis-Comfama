namespace Server.dirUserControl.InventoryManagement
{
    partial class ucInventoryItems
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
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddItem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvInventoryItems = new Zuby.ADGV.AdvancedDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel4 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel5 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAcquired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryItems)).BeginInit();
            this.gunaLinePanel3.SuspendLayout();
            this.gunaLinePanel4.SuspendLayout();
            this.gunaLinePanel5.SuspendLayout();
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
            this.gunaLinePanel1.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(87, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "TOTAL ITEMS";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel2.Controls.Add(this.btnAddItem);
            this.gunaLinePanel2.Controls.Add(this.dgvInventoryItems);
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
            this.gunaLinePanel2.TabIndex = 5;
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
            this.btnGenerateReport.Location = new System.Drawing.Point(304, 13);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnGenerateReport.OnHoverImage = null;
            this.btnGenerateReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Size = new System.Drawing.Size(146, 29);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.AnimationHoverSpeed = 0.07F;
            this.btnAddItem.AnimationSpeed = 0.03F;
            this.btnAddItem.BaseColor = System.Drawing.Color.White;
            this.btnAddItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddItem.BorderSize = 1;
            this.btnAddItem.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddItem.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddItem.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddItem.CheckedImage = null;
            this.btnAddItem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddItem.Image = null;
            this.btnAddItem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddItem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddItem.Location = new System.Drawing.Point(158, 13);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItem.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddItem.OnHoverImage = null;
            this.btnAddItem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddItem.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItem.Size = new System.Drawing.Size(146, 29);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvInventoryItems
            // 
            this.dgvInventoryItems.AllowUserToAddRows = false;
            this.dgvInventoryItems.AllowUserToDeleteRows = false;
            this.dgvInventoryItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInventoryItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvInventoryItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item,
            this.description,
            this.brand,
            this.model,
            this.quantity,
            this.propertyNumber,
            this.location,
            this.dateAcquired,
            this.status,
            this.action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryItems.FilterAndSortEnabled = true;
            this.dgvInventoryItems.Location = new System.Drawing.Point(22, 57);
            this.dgvInventoryItems.MultiSelect = false;
            this.dgvInventoryItems.Name = "dgvInventoryItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryItems.Size = new System.Drawing.Size(1057, 571);
            this.dgvInventoryItems.TabIndex = 5;
            this.dgvInventoryItems.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvInventoryItems_SortStringChanged);
            this.dgvInventoryItems.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvInventoryItems_FilterStringChanged);
            this.dgvInventoryItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryItems_CellClick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(121, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "INVENTORY ITEMS";
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel3.LineLeft = 1;
            this.gunaLinePanel3.LineRight = 1;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 1;
            this.gunaLinePanel3.Location = new System.Drawing.Point(0, 164);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(258, 158);
            this.gunaLinePanel3.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(112, 16);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "WORKING ITEMS";
            // 
            // gunaLinePanel4
            // 
            this.gunaLinePanel4.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel4.LineBottom = 1;
            this.gunaLinePanel4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel4.LineLeft = 1;
            this.gunaLinePanel4.LineRight = 1;
            this.gunaLinePanel4.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel4.LineTop = 1;
            this.gunaLinePanel4.Location = new System.Drawing.Point(0, 328);
            this.gunaLinePanel4.Name = "gunaLinePanel4";
            this.gunaLinePanel4.Size = new System.Drawing.Size(258, 158);
            this.gunaLinePanel4.TabIndex = 7;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(113, 16);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "DEFECTIVE ITEMS";
            // 
            // gunaLinePanel5
            // 
            this.gunaLinePanel5.Controls.Add(this.gunaLabel5);
            this.gunaLinePanel5.LineBottom = 1;
            this.gunaLinePanel5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel5.LineLeft = 1;
            this.gunaLinePanel5.LineRight = 1;
            this.gunaLinePanel5.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel5.LineTop = 1;
            this.gunaLinePanel5.Location = new System.Drawing.Point(0, 492);
            this.gunaLinePanel5.Name = "gunaLinePanel5";
            this.gunaLinePanel5.Size = new System.Drawing.Size(258, 158);
            this.gunaLinePanel5.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(133, 16);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "CONDEMNED ITEMS";
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 22;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Visible = false;
            this.id.Width = 45;
            // 
            // item
            // 
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "ITEM";
            this.item.MinimumWidth = 22;
            this.item.Name = "item";
            this.item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.item.Width = 60;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 22;
            this.description.Name = "description";
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.description.Width = 109;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "BRAND";
            this.brand.MinimumWidth = 22;
            this.brand.Name = "brand";
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.brand.Width = 73;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "MODEL";
            this.model.MinimumWidth = 22;
            this.model.Name = "model";
            this.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.model.Width = 73;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.MinimumWidth = 22;
            this.quantity.Name = "quantity";
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.quantity.Width = 92;
            // 
            // propertyNumber
            // 
            this.propertyNumber.DataPropertyName = "propertyNumber";
            this.propertyNumber.HeaderText = "PROPERTY NUMBER";
            this.propertyNumber.MinimumWidth = 22;
            this.propertyNumber.Name = "propertyNumber";
            this.propertyNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.propertyNumber.Width = 129;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "RM/OFFICE/DEPARTMENT";
            this.location.MinimumWidth = 22;
            this.location.Name = "location";
            this.location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.location.Width = 179;
            // 
            // dateAcquired
            // 
            this.dateAcquired.DataPropertyName = "dateAcquired";
            this.dateAcquired.HeaderText = "DATE ACQUIRED";
            this.dateAcquired.MinimumWidth = 22;
            this.dateAcquired.Name = "dateAcquired";
            this.dateAcquired.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dateAcquired.Width = 115;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 22;
            this.status.Name = "status";
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.status.Width = 74;
            // 
            // action
            // 
            this.action.HeaderText = "ACTION";
            this.action.MinimumWidth = 22;
            this.action.Name = "action";
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.action.Text = "VIEW ITEM";
            this.action.UseColumnTextForButtonValue = true;
            this.action.Width = 80;
            // 
            // ucInventoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel5);
            this.Controls.Add(this.gunaLinePanel4);
            this.Controls.Add(this.gunaLinePanel3);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventoryItems";
            this.Size = new System.Drawing.Size(1365, 651);
            this.Load += new System.EventHandler(this.ucInventoryItems_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryItems)).EndInit();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            this.gunaLinePanel4.ResumeLayout(false);
            this.gunaLinePanel4.PerformLayout();
            this.gunaLinePanel5.ResumeLayout(false);
            this.gunaLinePanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Zuby.ADGV.AdvancedDataGridView dgvInventoryItems;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddItem;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquired;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
