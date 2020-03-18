namespace Server.dirUserControl.Settings
{
    partial class ucAcademicYear
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
            this.lblCurrentAcademicYear = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dgvAcademicYear = new Zuby.ADGV.AdvancedDataGridView();
            this.btnAddAcademicYear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dbThesisComfamaDataSet = new Server.dbThesisComfamaDataSet();
            this.academicYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicYearTableAdapter = new Server.dbThesisComfamaDataSetTableAdapters.AcademicYearTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblCurrentAcademicYear);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1365, 55);
            this.gunaLinePanel1.TabIndex = 8;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(163, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "CURRENT ACADEMIC YEAR:";
            // 
            // lblCurrentAcademicYear
            // 
            this.lblCurrentAcademicYear.AutoSize = true;
            this.lblCurrentAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAcademicYear.Location = new System.Drawing.Point(227, 18);
            this.lblCurrentAcademicYear.Name = "lblCurrentAcademicYear";
            this.lblCurrentAcademicYear.Size = new System.Drawing.Size(240, 17);
            this.lblCurrentAcademicYear.TabIndex = 8;
            this.lblCurrentAcademicYear.Text = "You have not setup automatic backup.";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnAddAcademicYear);
            this.gunaLinePanel2.Controls.Add(this.dgvAcademicYear);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 61);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1365, 590);
            this.gunaLinePanel2.TabIndex = 9;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(105, 16);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "ACADEMIC YEAR";
            // 
            // dgvAcademicYear
            // 
            this.dgvAcademicYear.AllowUserToAddRows = false;
            this.dgvAcademicYear.AllowUserToDeleteRows = false;
            this.dgvAcademicYear.AutoGenerateColumns = false;
            this.dgvAcademicYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademicYear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvAcademicYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcademicYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcademicYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.academicYearDataGridViewTextBoxColumn,
            this.action});
            this.dgvAcademicYear.DataSource = this.academicYearBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcademicYear.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAcademicYear.FilterAndSortEnabled = true;
            this.dgvAcademicYear.Location = new System.Drawing.Point(22, 61);
            this.dgvAcademicYear.MultiSelect = false;
            this.dgvAcademicYear.Name = "dgvAcademicYear";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcademicYear.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAcademicYear.Size = new System.Drawing.Size(1320, 506);
            this.dgvAcademicYear.TabIndex = 10;
            this.dgvAcademicYear.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvAcademicYear_SortStringChanged);
            this.dgvAcademicYear.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgvAcademicYear_FilterStringChanged);
            this.dgvAcademicYear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcademicYear_CellClick);
            // 
            // btnAddAcademicYear
            // 
            this.btnAddAcademicYear.AnimationHoverSpeed = 0.07F;
            this.btnAddAcademicYear.AnimationSpeed = 0.03F;
            this.btnAddAcademicYear.BaseColor = System.Drawing.Color.White;
            this.btnAddAcademicYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddAcademicYear.BorderSize = 1;
            this.btnAddAcademicYear.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddAcademicYear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddAcademicYear.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAcademicYear.CheckedImage = null;
            this.btnAddAcademicYear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddAcademicYear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAcademicYear.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddAcademicYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAcademicYear.Image = null;
            this.btnAddAcademicYear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAcademicYear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAcademicYear.Location = new System.Drawing.Point(127, 12);
            this.btnAddAcademicYear.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAcademicYear.Name = "btnAddAcademicYear";
            this.btnAddAcademicYear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddAcademicYear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddAcademicYear.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddAcademicYear.OnHoverImage = null;
            this.btnAddAcademicYear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAcademicYear.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddAcademicYear.Size = new System.Drawing.Size(146, 29);
            this.btnAddAcademicYear.TabIndex = 11;
            this.btnAddAcademicYear.Text = "Add Academic Year";
            this.btnAddAcademicYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAcademicYear.Click += new System.EventHandler(this.btnAddAcademicYear_Click);
            // 
            // dbThesisComfamaDataSet
            // 
            this.dbThesisComfamaDataSet.DataSetName = "dbThesisComfamaDataSet";
            this.dbThesisComfamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicYearBindingSource
            // 
            this.academicYearBindingSource.DataMember = "AcademicYear";
            this.academicYearBindingSource.DataSource = this.dbThesisComfamaDataSet;
            // 
            // academicYearTableAdapter
            // 
            this.academicYearTableAdapter.ClearBeforeFill = true;
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
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "SEMESTER";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // academicYearDataGridViewTextBoxColumn
            // 
            this.academicYearDataGridViewTextBoxColumn.DataPropertyName = "academicYear";
            this.academicYearDataGridViewTextBoxColumn.HeaderText = "ACADEMIC YEAR";
            this.academicYearDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.academicYearDataGridViewTextBoxColumn.Name = "academicYearDataGridViewTextBoxColumn";
            this.academicYearDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // action
            // 
            this.action.HeaderText = "ACTION";
            this.action.MinimumWidth = 22;
            this.action.Name = "action";
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.action.Text = "SET AS ACADEMIC YEAR";
            this.action.UseColumnTextForButtonValue = true;
            // 
            // ucAcademicYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucAcademicYear";
            this.Size = new System.Drawing.Size(1365, 651);
            this.Load += new System.EventHandler(this.ucAcademicYear_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThesisComfamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicYearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblCurrentAcademicYear;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Zuby.ADGV.AdvancedDataGridView dgvAcademicYear;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddAcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn action;
        private System.Windows.Forms.BindingSource academicYearBindingSource;
        private dbThesisComfamaDataSet dbThesisComfamaDataSet;
        private dbThesisComfamaDataSetTableAdapters.AcademicYearTableAdapter academicYearTableAdapter;
    }
}
