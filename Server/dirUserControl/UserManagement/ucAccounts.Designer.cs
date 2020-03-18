namespace Server.dirUserControl.UserManagement
{
    partial class ucAccounts
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
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvAccounts = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isloggedinDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lastloggedinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.accountsTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.AccountsTableAdapter();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel2.Controls.Add(this.dgvAccounts);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1101, 651);
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
            this.btnGenerateReport.Location = new System.Drawing.Point(102, 13);
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
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoGenerateColumns = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.isloggedinDataGridViewCheckBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.lastloggedinDataGridViewTextBoxColumn,
            this.action});
            this.dgvAccounts.DataSource = this.accountsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.FilterAndSortEnabled = true;
            this.dgvAccounts.Location = new System.Drawing.Point(22, 57);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.Size = new System.Drawing.Size(1057, 571);
            this.dgvAccounts.TabIndex = 5;
            this.dgvAccounts.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvAccounts_SortStringChanged);
            this.dgvAccounts.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvAccounts_FilterStringChanged);
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "USER TYPE";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // isloggedinDataGridViewCheckBoxColumn
            // 
            this.isloggedinDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isloggedinDataGridViewCheckBoxColumn.DataPropertyName = "is_logged_in";
            this.isloggedinDataGridViewCheckBoxColumn.HeaderText = "CURRENTLY LOGGED IN";
            this.isloggedinDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.isloggedinDataGridViewCheckBoxColumn.Name = "isloggedinDataGridViewCheckBoxColumn";
            this.isloggedinDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.statusDataGridViewCheckBoxColumn.Width = 74;
            // 
            // lastloggedinDataGridViewTextBoxColumn
            // 
            this.lastloggedinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastloggedinDataGridViewTextBoxColumn.DataPropertyName = "last_logged_in";
            this.lastloggedinDataGridViewTextBoxColumn.HeaderText = "LAST LOGIN DATE";
            this.lastloggedinDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lastloggedinDataGridViewTextBoxColumn.Name = "lastloggedinDataGridViewTextBoxColumn";
            this.lastloggedinDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastloggedinDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dbThesisComfamaDataSet;
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
            this.gunaLabel1.Size = new System.Drawing.Size(80, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "ACCOUNTS";
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // ucAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Name = "ucAccounts";
            this.Size = new System.Drawing.Size(1101, 651);
            this.Load += new System.EventHandler(this.ucAccounts_Load);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Zuby.ADGV.AdvancedDataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isloggedinDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastloggedinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private dbThesisComfamaDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
    }
}
