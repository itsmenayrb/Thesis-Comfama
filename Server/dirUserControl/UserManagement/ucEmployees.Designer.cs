namespace Server.dirUserControl.UserManagement
{
    partial class ucEmployees
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
            this.btnViewPosition = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnViewDepartment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddEmployee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvEmployees = new Zuby.ADGV.AdvancedDataGridView();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.departmentsTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.DepartmentsTableAdapter();
            this.positionsTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.PositionsTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnViewPosition);
            this.gunaLinePanel2.Controls.Add(this.btnViewDepartment);
            this.gunaLinePanel2.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel2.Controls.Add(this.btnAddEmployee);
            this.gunaLinePanel2.Controls.Add(this.dgvEmployees);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1101, 651);
            this.gunaLinePanel2.TabIndex = 6;
            // 
            // btnViewPosition
            // 
            this.btnViewPosition.AnimationHoverSpeed = 0.07F;
            this.btnViewPosition.AnimationSpeed = 0.03F;
            this.btnViewPosition.BaseColor = System.Drawing.Color.White;
            this.btnViewPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewPosition.BorderSize = 1;
            this.btnViewPosition.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewPosition.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewPosition.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewPosition.CheckedImage = null;
            this.btnViewPosition.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewPosition.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewPosition.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewPosition.Image = null;
            this.btnViewPosition.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewPosition.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewPosition.Location = new System.Drawing.Point(394, 13);
            this.btnViewPosition.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewPosition.Name = "btnViewPosition";
            this.btnViewPosition.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewPosition.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewPosition.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewPosition.OnHoverImage = null;
            this.btnViewPosition.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewPosition.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewPosition.Size = new System.Drawing.Size(146, 29);
            this.btnViewPosition.TabIndex = 9;
            this.btnViewPosition.Text = "View Position";
            this.btnViewPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewPosition.Click += new System.EventHandler(this.btnViewPosition_Click);
            // 
            // btnViewDepartment
            // 
            this.btnViewDepartment.AnimationHoverSpeed = 0.07F;
            this.btnViewDepartment.AnimationSpeed = 0.03F;
            this.btnViewDepartment.BaseColor = System.Drawing.Color.White;
            this.btnViewDepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewDepartment.BorderSize = 1;
            this.btnViewDepartment.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewDepartment.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewDepartment.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewDepartment.CheckedImage = null;
            this.btnViewDepartment.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewDepartment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewDepartment.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewDepartment.Image = null;
            this.btnViewDepartment.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewDepartment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewDepartment.Location = new System.Drawing.Point(248, 13);
            this.btnViewDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewDepartment.Name = "btnViewDepartment";
            this.btnViewDepartment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewDepartment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewDepartment.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewDepartment.OnHoverImage = null;
            this.btnViewDepartment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewDepartment.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewDepartment.Size = new System.Drawing.Size(146, 29);
            this.btnViewDepartment.TabIndex = 8;
            this.btnViewDepartment.Text = "View Department";
            this.btnViewDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewDepartment.Click += new System.EventHandler(this.btnViewDepartment_Click);
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
            this.btnGenerateReport.Location = new System.Drawing.Point(540, 13);
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
            // btnAddEmployee
            // 
            this.btnAddEmployee.AnimationHoverSpeed = 0.07F;
            this.btnAddEmployee.AnimationSpeed = 0.03F;
            this.btnAddEmployee.BaseColor = System.Drawing.Color.White;
            this.btnAddEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.BorderSize = 1;
            this.btnAddEmployee.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddEmployee.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddEmployee.CheckedImage = null;
            this.btnAddEmployee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddEmployee.Image = null;
            this.btnAddEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddEmployee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(102, 13);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddEmployee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddEmployee.OnHoverImage = null;
            this.btnAddEmployee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Size = new System.Drawing.Size(146, 29);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.employeeID,
            this.firstName,
            this.middleName,
            this.lastName,
            this.department,
            this.position,
            this.action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.FilterAndSortEnabled = true;
            this.dgvEmployees.Location = new System.Drawing.Point(22, 57);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.Size = new System.Drawing.Size(1057, 571);
            this.dgvEmployees.TabIndex = 5;
            this.dgvEmployees.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvEmployees_SortStringChanged);
            this.dgvEmployees.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvEmployees_FilterStringChanged);
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // dbThesisComfamaDataSet
            // 
            this.dbThesisComfamaDataSet.DataSetName = "dbThesisComfamaDataSet";
            this.dbThesisComfamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.dbThesisComfamaDataSet;
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
            this.gunaLabel1.Text = "EMPLOYEES";
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 22;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Visible = false;
            this.id.Width = 45;
            // 
            // employeeID
            // 
            this.employeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeID.DataPropertyName = "employeeID";
            this.employeeID.HeaderText = "EMPLOYEE ID";
            this.employeeID.MinimumWidth = 22;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "FIRST NAME";
            this.firstName.MinimumWidth = 22;
            this.firstName.Name = "firstName";
            this.firstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // middleName
            // 
            this.middleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middleName.DataPropertyName = "middleName";
            this.middleName.HeaderText = "MIDDLE NAME";
            this.middleName.MinimumWidth = 22;
            this.middleName.Name = "middleName";
            this.middleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "LAST NAME";
            this.lastName.MinimumWidth = 22;
            this.lastName.Name = "lastName";
            this.lastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.DataSource = this.departmentsBindingSource;
            this.department.DisplayMember = "department";
            this.department.HeaderText = "DEPARTMENT";
            this.department.MinimumWidth = 22;
            this.department.Name = "department";
            this.department.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.department.ValueMember = "id";
            this.department.Width = 108;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.DataSource = this.positionsBindingSource;
            this.position.DisplayMember = "position";
            this.position.HeaderText = "POSITION";
            this.position.MinimumWidth = 22;
            this.position.Name = "position";
            this.position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.position.ValueMember = "id";
            this.position.Width = 120;
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
            // ucEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Name = "ucEmployees";
            this.Size = new System.Drawing.Size(1101, 651);
            this.Load += new System.EventHandler(this.ucEmployees_Load);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddEmployee;
        private Zuby.ADGV.AdvancedDataGridView dgvEmployees;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewPosition;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewDepartment;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private dbThesisComfamaDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private dbThesisComfamaDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewComboBoxColumn department;
        private System.Windows.Forms.DataGridViewComboBoxColumn position;
        private System.Windows.Forms.DataGridViewButtonColumn action;

    }
}
