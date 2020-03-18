namespace Server.dirUserControl.UserManagement
{
    partial class ucStudents
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
            this.btnViewCourse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGenerateReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddStudent = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvStudents = new Zuby.ADGV.AdvancedDataGridView();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.coursesTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.CoursesTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.yearLevel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnViewCourse);
            this.gunaLinePanel2.Controls.Add(this.btnGenerateReport);
            this.gunaLinePanel2.Controls.Add(this.btnAddStudent);
            this.gunaLinePanel2.Controls.Add(this.dgvStudents);
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
            this.gunaLinePanel2.TabIndex = 7;
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.AnimationHoverSpeed = 0.07F;
            this.btnViewCourse.AnimationSpeed = 0.03F;
            this.btnViewCourse.BaseColor = System.Drawing.Color.White;
            this.btnViewCourse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewCourse.BorderSize = 1;
            this.btnViewCourse.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewCourse.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewCourse.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewCourse.CheckedImage = null;
            this.btnViewCourse.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewCourse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewCourse.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewCourse.Image = null;
            this.btnViewCourse.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewCourse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewCourse.Location = new System.Drawing.Point(236, 13);
            this.btnViewCourse.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewCourse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewCourse.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewCourse.OnHoverImage = null;
            this.btnViewCourse.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewCourse.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewCourse.Size = new System.Drawing.Size(146, 29);
            this.btnViewCourse.TabIndex = 8;
            this.btnViewCourse.Text = "View Course";
            this.btnViewCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
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
            this.btnGenerateReport.Location = new System.Drawing.Point(382, 13);
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
            // btnAddStudent
            // 
            this.btnAddStudent.AnimationHoverSpeed = 0.07F;
            this.btnAddStudent.AnimationSpeed = 0.03F;
            this.btnAddStudent.BaseColor = System.Drawing.Color.White;
            this.btnAddStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddStudent.BorderSize = 1;
            this.btnAddStudent.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddStudent.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddStudent.CheckedImage = null;
            this.btnAddStudent.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddStudent.Image = null;
            this.btnAddStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddStudent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddStudent.Location = new System.Drawing.Point(90, 13);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddStudent.OnHoverImage = null;
            this.btnAddStudent.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddStudent.Size = new System.Drawing.Size(146, 29);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.employeeID,
            this.firstName,
            this.middleName,
            this.lastName,
            this.course,
            this.yearLevel,
            this.status,
            this.action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.FilterAndSortEnabled = true;
            this.dgvStudents.Location = new System.Drawing.Point(22, 57);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.Size = new System.Drawing.Size(1057, 571);
            this.dgvStudents.TabIndex = 5;
            this.dgvStudents.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvStudents_SortStringChanged);
            this.dgvStudents.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvStudents_FilterStringChanged);
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dbThesisComfamaDataSet;
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
            this.gunaLabel1.Size = new System.Drawing.Size(68, 16);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "STUDENTS";
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
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
            this.employeeID.DataPropertyName = "studentNumber";
            this.employeeID.HeaderText = "STUDENT NUMBER";
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
            // course
            // 
            this.course.DataPropertyName = "course";
            this.course.DataSource = this.coursesBindingSource;
            this.course.DisplayMember = "course";
            this.course.HeaderText = "COURSE";
            this.course.MinimumWidth = 22;
            this.course.Name = "course";
            this.course.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.course.ValueMember = "id";
            this.course.Width = 79;
            // 
            // yearLevel
            // 
            this.yearLevel.DataPropertyName = "yearLevel";
            this.yearLevel.HeaderText = "YEAR LEVEL";
            this.yearLevel.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year",
            "Fifth Year"});
            this.yearLevel.MinimumWidth = 22;
            this.yearLevel.Name = "yearLevel";
            this.yearLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.yearLevel.Width = 95;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "STATUS";
            this.status.Items.AddRange(new object[] {
            "Regular",
            "Irregular"});
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
            this.action.Text = "UPDATE";
            this.action.UseColumnTextForButtonValue = true;
            // 
            // ucStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Name = "ucStudents";
            this.Size = new System.Drawing.Size(1101, 651);
            this.Load += new System.EventHandler(this.ucStudents_Load);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewCourse;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddStudent;
        private Zuby.ADGV.AdvancedDataGridView dgvStudents;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private dbThesisComfamaDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewComboBoxColumn course;
        private System.Windows.Forms.DataGridViewComboBoxColumn yearLevel;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
