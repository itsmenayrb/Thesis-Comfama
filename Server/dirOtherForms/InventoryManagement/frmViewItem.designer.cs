namespace Server.dirOtherForms.InventoryManagement
{
    partial class frmViewItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewItem));
            this.cbInventoryType = new Guna.UI.WinForms.GunaComboBox();
            this.cbInventoryCategory = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.cbSupplier = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel4 = new Guna.UI.WinForms.GunaLinePanel();
            this.dtpDateExpiry = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.txtLicenseKey = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel17 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.cbLocation = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txtPropertyNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.dtpDateAcquired = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.cbCapacity = new Guna.UI.WinForms.GunaComboBox();
            this.txtCapacity = new Guna.UI.WinForms.GunaTextBox();
            this.cbUnit = new Guna.UI.WinForms.GunaComboBox();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtSerialNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtModel = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtBrand = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.txtItem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel5 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnClear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pbImage = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel19 = new Guna.UI.WinForms.GunaLabel();
            this.gbStatus = new Guna.UI.WinForms.GunaLinePanel();
            this.rdbCondemned = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbDefective = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbWorking = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel20 = new Guna.UI.WinForms.GunaLabel();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSaveChanges = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdateThisItem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            this.gunaLinePanel4.SuspendLayout();
            this.gunaLinePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInventoryType
            // 
            this.cbInventoryType.BackColor = System.Drawing.Color.Transparent;
            this.cbInventoryType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbInventoryType.BorderColor = System.Drawing.Color.Silver;
            this.cbInventoryType.BorderSize = 1;
            this.cbInventoryType.DisplayMember = "businessType";
            this.cbInventoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInventoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryType.Enabled = false;
            this.cbInventoryType.FocusedColor = System.Drawing.Color.Empty;
            this.cbInventoryType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventoryType.ForeColor = System.Drawing.Color.Black;
            this.cbInventoryType.FormattingEnabled = true;
            this.cbInventoryType.ItemHeight = 25;
            this.cbInventoryType.Location = new System.Drawing.Point(193, 12);
            this.cbInventoryType.Name = "cbInventoryType";
            this.cbInventoryType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbInventoryType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbInventoryType.Size = new System.Drawing.Size(367, 31);
            this.cbInventoryType.TabIndex = 4;
            this.cbInventoryType.ValueMember = "id";
            this.cbInventoryType.SelectedIndexChanged += new System.EventHandler(this.cbInventoryType_SelectedIndexChanged);
            // 
            // cbInventoryCategory
            // 
            this.cbInventoryCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbInventoryCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbInventoryCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbInventoryCategory.BorderSize = 1;
            this.cbInventoryCategory.DisplayMember = "businessType";
            this.cbInventoryCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInventoryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryCategory.Enabled = false;
            this.cbInventoryCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbInventoryCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventoryCategory.ForeColor = System.Drawing.Color.Black;
            this.cbInventoryCategory.FormattingEnabled = true;
            this.cbInventoryCategory.ItemHeight = 25;
            this.cbInventoryCategory.Location = new System.Drawing.Point(193, 11);
            this.cbInventoryCategory.Name = "cbInventoryCategory";
            this.cbInventoryCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbInventoryCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbInventoryCategory.Size = new System.Drawing.Size(367, 31);
            this.cbInventoryCategory.TabIndex = 5;
            this.cbInventoryCategory.ValueMember = "id";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 60);
            this.panel1.TabIndex = 63;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageOffsetX = 15;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-9, 11);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(257, 46);
            this.gunaAdvenceButton1.TabIndex = 40;
            this.gunaAdvenceButton1.Text = "View Item";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(680, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(174, 17);
            this.gunaLabel1.TabIndex = 41;
            this.gunaLabel1.Text = "INVENTORY MANAGEMENT  >";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(852, 31);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 17);
            this.gunaLabel2.TabIndex = 42;
            this.gunaLabel2.Text = "VIEW ITEM";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(925, 24);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 43;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.cbInventoryType);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(15, 71);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(802, 55);
            this.gunaLinePanel1.TabIndex = 64;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(103, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "INVENTORY TYPE";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.cbInventoryCategory);
            this.gunaLinePanel2.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(15, 132);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(955, 55);
            this.gunaLinePanel2.TabIndex = 65;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(141, 16);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "INVENTORY CATEGORY";
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Controls.Add(this.cbSupplier);
            this.gunaLinePanel3.Controls.Add(this.gunaLabel5);
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel3.LineLeft = 1;
            this.gunaLinePanel3.LineRight = 1;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 1;
            this.gunaLinePanel3.Location = new System.Drawing.Point(15, 193);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(955, 55);
            this.gunaLinePanel3.TabIndex = 66;
            // 
            // cbSupplier
            // 
            this.cbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cbSupplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbSupplier.BorderColor = System.Drawing.Color.Silver;
            this.cbSupplier.BorderSize = 1;
            this.cbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Enabled = false;
            this.cbSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.cbSupplier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.ForeColor = System.Drawing.Color.Black;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.ItemHeight = 25;
            this.cbSupplier.Location = new System.Drawing.Point(192, 11);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbSupplier.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSupplier.Size = new System.Drawing.Size(367, 31);
            this.cbSupplier.TabIndex = 0;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(58, 16);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "SUPPLIER";
            // 
            // gunaLinePanel4
            // 
            this.gunaLinePanel4.Controls.Add(this.dtpDateExpiry);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel18);
            this.gunaLinePanel4.Controls.Add(this.txtLicenseKey);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel17);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel16);
            this.gunaLinePanel4.Controls.Add(this.cbLocation);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel11);
            this.gunaLinePanel4.Controls.Add(this.txtPropertyNumber);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel10);
            this.gunaLinePanel4.Controls.Add(this.dtpDateAcquired);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel9);
            this.gunaLinePanel4.Controls.Add(this.cbCapacity);
            this.gunaLinePanel4.Controls.Add(this.txtCapacity);
            this.gunaLinePanel4.Controls.Add(this.cbUnit);
            this.gunaLinePanel4.Controls.Add(this.txtQuantity);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel8);
            this.gunaLinePanel4.Controls.Add(this.txtSerialNumber);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel7);
            this.gunaLinePanel4.Controls.Add(this.txtModel);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel6);
            this.gunaLinePanel4.Controls.Add(this.txtBrand);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel12);
            this.gunaLinePanel4.Controls.Add(this.txtDescription);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel13);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel14);
            this.gunaLinePanel4.Controls.Add(this.txtItem);
            this.gunaLinePanel4.Controls.Add(this.gunaLabel15);
            this.gunaLinePanel4.LineBottom = 1;
            this.gunaLinePanel4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel4.LineLeft = 1;
            this.gunaLinePanel4.LineRight = 1;
            this.gunaLinePanel4.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel4.LineTop = 1;
            this.gunaLinePanel4.Location = new System.Drawing.Point(15, 254);
            this.gunaLinePanel4.Name = "gunaLinePanel4";
            this.gunaLinePanel4.Size = new System.Drawing.Size(705, 460);
            this.gunaLinePanel4.TabIndex = 121;
            // 
            // dtpDateExpiry
            // 
            this.dtpDateExpiry.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dtpDateExpiry.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateExpiry.BorderSize = 1;
            this.dtpDateExpiry.CustomFormat = null;
            this.dtpDateExpiry.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateExpiry.Enabled = false;
            this.dtpDateExpiry.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateExpiry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateExpiry.ForeColor = System.Drawing.Color.Black;
            this.dtpDateExpiry.Location = new System.Drawing.Point(359, 351);
            this.dtpDateExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateExpiry.Name = "dtpDateExpiry";
            this.dtpDateExpiry.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDateExpiry.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateExpiry.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateExpiry.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDateExpiry.Size = new System.Drawing.Size(322, 31);
            this.dtpDateExpiry.TabIndex = 32;
            this.dtpDateExpiry.Text = "Saturday, March 14, 2020";
            this.dtpDateExpiry.Value = new System.DateTime(2020, 3, 14, 22, 43, 39, 146);
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel18.Location = new System.Drawing.Point(356, 331);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(120, 17);
            this.gunaLabel18.TabIndex = 31;
            this.gunaLabel18.Text = "End of Subscription";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtLicenseKey.BorderColor = System.Drawing.Color.Silver;
            this.txtLicenseKey.BorderSize = 1;
            this.txtLicenseKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseKey.Enabled = false;
            this.txtLicenseKey.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLicenseKey.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLicenseKey.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLicenseKey.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseKey.Location = new System.Drawing.Point(22, 411);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.PasswordChar = '\0';
            this.txtLicenseKey.Size = new System.Drawing.Size(322, 31);
            this.txtLicenseKey.TabIndex = 30;
            this.txtLicenseKey.TextOffsetX = 5;
            // 
            // gunaLabel17
            // 
            this.gunaLabel17.AutoSize = true;
            this.gunaLabel17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel17.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel17.Location = new System.Drawing.Point(19, 388);
            this.gunaLabel17.Name = "gunaLabel17";
            this.gunaLabel17.Size = new System.Drawing.Size(91, 17);
            this.gunaLabel17.TabIndex = 29;
            this.gunaLabel17.Text = "Serial Number";
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel16.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel16.Location = new System.Drawing.Point(356, 103);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(63, 17);
            this.gunaLabel16.TabIndex = 28;
            this.gunaLabel16.Text = "Capacity";
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbLocation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbLocation.BorderColor = System.Drawing.Color.Silver;
            this.cbLocation.BorderSize = 1;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.Enabled = false;
            this.cbLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cbLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.ForeColor = System.Drawing.Color.Black;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 25;
            this.cbLocation.Location = new System.Drawing.Point(359, 294);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLocation.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLocation.Size = new System.Drawing.Size(322, 31);
            this.cbLocation.TabIndex = 11;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(356, 274);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(162, 17);
            this.gunaLabel11.TabIndex = 25;
            this.gunaLabel11.Text = "Room/Office/Department";
            // 
            // txtPropertyNumber
            // 
            this.txtPropertyNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtPropertyNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtPropertyNumber.BorderSize = 1;
            this.txtPropertyNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyNumber.Enabled = false;
            this.txtPropertyNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPropertyNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPropertyNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPropertyNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyNumber.Location = new System.Drawing.Point(359, 237);
            this.txtPropertyNumber.Name = "txtPropertyNumber";
            this.txtPropertyNumber.PasswordChar = '\0';
            this.txtPropertyNumber.Size = new System.Drawing.Size(322, 31);
            this.txtPropertyNumber.TabIndex = 10;
            this.txtPropertyNumber.TextOffsetX = 5;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.Location = new System.Drawing.Point(356, 217);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(108, 17);
            this.gunaLabel10.TabIndex = 23;
            this.gunaLabel10.Text = "Property Number";
            // 
            // dtpDateAcquired
            // 
            this.dtpDateAcquired.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dtpDateAcquired.BorderColor = System.Drawing.Color.Silver;
            this.dtpDateAcquired.BorderSize = 1;
            this.dtpDateAcquired.CustomFormat = null;
            this.dtpDateAcquired.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateAcquired.Enabled = false;
            this.dtpDateAcquired.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateAcquired.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAcquired.ForeColor = System.Drawing.Color.Black;
            this.dtpDateAcquired.Location = new System.Drawing.Point(359, 180);
            this.dtpDateAcquired.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateAcquired.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateAcquired.Name = "dtpDateAcquired";
            this.dtpDateAcquired.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDateAcquired.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateAcquired.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDateAcquired.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDateAcquired.Size = new System.Drawing.Size(322, 31);
            this.dtpDateAcquired.TabIndex = 9;
            this.dtpDateAcquired.Text = "Saturday, March 14, 2020";
            this.dtpDateAcquired.Value = new System.DateTime(2020, 3, 14, 22, 43, 39, 146);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.Location = new System.Drawing.Point(356, 160);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(96, 17);
            this.gunaLabel9.TabIndex = 21;
            this.gunaLabel9.Text = "Date Acquired";
            // 
            // cbCapacity
            // 
            this.cbCapacity.BackColor = System.Drawing.Color.Transparent;
            this.cbCapacity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbCapacity.BorderColor = System.Drawing.Color.Silver;
            this.cbCapacity.BorderSize = 1;
            this.cbCapacity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapacity.Enabled = false;
            this.cbCapacity.FocusedColor = System.Drawing.Color.Empty;
            this.cbCapacity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCapacity.ForeColor = System.Drawing.Color.Black;
            this.cbCapacity.FormattingEnabled = true;
            this.cbCapacity.ItemHeight = 25;
            this.cbCapacity.Location = new System.Drawing.Point(513, 123);
            this.cbCapacity.Name = "cbCapacity";
            this.cbCapacity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbCapacity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCapacity.Size = new System.Drawing.Size(168, 31);
            this.cbCapacity.TabIndex = 19;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtCapacity.BorderColor = System.Drawing.Color.Silver;
            this.txtCapacity.BorderSize = 1;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.Enabled = false;
            this.txtCapacity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCapacity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCapacity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(359, 123);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.Size = new System.Drawing.Size(148, 31);
            this.txtCapacity.TabIndex = 18;
            this.txtCapacity.TextOffsetX = 5;
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cbUnit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbUnit.BorderColor = System.Drawing.Color.Silver;
            this.cbUnit.BorderSize = 1;
            this.cbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Enabled = false;
            this.cbUnit.FocusedColor = System.Drawing.Color.Empty;
            this.cbUnit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.ForeColor = System.Drawing.Color.Black;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.ItemHeight = 25;
            this.cbUnit.Location = new System.Drawing.Point(513, 66);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbUnit.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbUnit.Size = new System.Drawing.Size(168, 31);
            this.cbUnit.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(359, 66);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Size = new System.Drawing.Size(148, 31);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextOffsetX = 5;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(356, 46);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(59, 17);
            this.gunaLabel8.TabIndex = 13;
            this.gunaLabel8.Text = "Quantity";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtSerialNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtSerialNumber.BorderSize = 1;
            this.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerialNumber.Enabled = false;
            this.txtSerialNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSerialNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSerialNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSerialNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(22, 351);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.PasswordChar = '\0';
            this.txtSerialNumber.Size = new System.Drawing.Size(322, 31);
            this.txtSerialNumber.TabIndex = 5;
            this.txtSerialNumber.TextOffsetX = 5;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(19, 331);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(91, 17);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "Serial Number";
            // 
            // txtModel
            // 
            this.txtModel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtModel.BorderColor = System.Drawing.Color.Silver;
            this.txtModel.BorderSize = 1;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.Enabled = false;
            this.txtModel.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(22, 294);
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.Size = new System.Drawing.Size(322, 31);
            this.txtModel.TabIndex = 4;
            this.txtModel.TextOffsetX = 5;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(19, 274);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(46, 17);
            this.gunaLabel6.TabIndex = 9;
            this.gunaLabel6.Text = "Model";
            // 
            // txtBrand
            // 
            this.txtBrand.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtBrand.BorderColor = System.Drawing.Color.Silver;
            this.txtBrand.BorderSize = 1;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.Enabled = false;
            this.txtBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBrand.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(22, 237);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.Size = new System.Drawing.Size(322, 31);
            this.txtBrand.TabIndex = 3;
            this.txtBrand.TextOffsetX = 5;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel12.Location = new System.Drawing.Point(19, 217);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(42, 17);
            this.gunaLabel12.TabIndex = 7;
            this.gunaLabel12.Text = "Brand";
            // 
            // txtDescription
            // 
            this.txtDescription.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Enabled = false;
            this.txtDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(22, 123);
            this.txtDescription.MultiLine = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Size = new System.Drawing.Size(322, 88);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextOffsetX = 5;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel13.Location = new System.Drawing.Point(19, 103);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(76, 17);
            this.gunaLabel13.TabIndex = 5;
            this.gunaLabel13.Text = "Description";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel14.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel14.Location = new System.Drawing.Point(19, 46);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(35, 17);
            this.gunaLabel14.TabIndex = 4;
            this.gunaLabel14.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtItem.BorderColor = System.Drawing.Color.Silver;
            this.txtItem.BorderSize = 1;
            this.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem.Enabled = false;
            this.txtItem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(22, 66);
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.Size = new System.Drawing.Size(322, 31);
            this.txtItem.TabIndex = 1;
            this.txtItem.TextOffsetX = 5;
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel15.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel15.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(148, 16);
            this.gunaLabel15.TabIndex = 2;
            this.gunaLabel15.Text = "GENERAL INFORMATION";
            // 
            // gunaLinePanel5
            // 
            this.gunaLinePanel5.Controls.Add(this.btnClear);
            this.gunaLinePanel5.Controls.Add(this.btnUpload);
            this.gunaLinePanel5.Controls.Add(this.pbImage);
            this.gunaLinePanel5.Controls.Add(this.gunaLabel19);
            this.gunaLinePanel5.LineBottom = 1;
            this.gunaLinePanel5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel5.LineLeft = 1;
            this.gunaLinePanel5.LineRight = 1;
            this.gunaLinePanel5.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel5.LineTop = 1;
            this.gunaLinePanel5.Location = new System.Drawing.Point(726, 254);
            this.gunaLinePanel5.Name = "gunaLinePanel5";
            this.gunaLinePanel5.Size = new System.Drawing.Size(244, 220);
            this.gunaLinePanel5.TabIndex = 122;
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BaseColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnClear.BorderSize = 1;
            this.btnClear.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnClear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClear.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnClear.CheckedImage = null;
            this.btnClear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.Enabled = false;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClear.Location = new System.Drawing.Point(160, 169);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Size = new System.Drawing.Size(63, 29);
            this.btnClear.TabIndex = 17;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AnimationHoverSpeed = 0.07F;
            this.btnUpload.AnimationSpeed = 0.03F;
            this.btnUpload.BaseColor = System.Drawing.Color.White;
            this.btnUpload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpload.BorderSize = 1;
            this.btnUpload.Checked = true;
            this.btnUpload.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpload.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpload.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.CheckedImage = null;
            this.btnUpload.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpload.Enabled = false;
            this.btnUpload.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.Image = null;
            this.btnUpload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpload.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpload.Location = new System.Drawing.Point(22, 169);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUpload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpload.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpload.OnHoverImage = null;
            this.btnUpload.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpload.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpload.Size = new System.Drawing.Size(138, 29);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.TabStop = false;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbImage
            // 
            this.pbImage.BaseColor = System.Drawing.Color.White;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(22, 46);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(201, 120);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel19.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel19.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(48, 16);
            this.gunaLabel19.TabIndex = 2;
            this.gunaLabel19.Text = "IMAGE";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rdbCondemned);
            this.gbStatus.Controls.Add(this.rdbDefective);
            this.gbStatus.Controls.Add(this.rdbWorking);
            this.gbStatus.Controls.Add(this.gunaLabel20);
            this.gbStatus.LineBottom = 1;
            this.gbStatus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gbStatus.LineLeft = 1;
            this.gbStatus.LineRight = 1;
            this.gbStatus.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gbStatus.LineTop = 1;
            this.gbStatus.Location = new System.Drawing.Point(726, 480);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(244, 135);
            this.gbStatus.TabIndex = 123;
            // 
            // rdbCondemned
            // 
            this.rdbCondemned.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbCondemned.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbCondemned.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbCondemned.Enabled = false;
            this.rdbCondemned.FillColor = System.Drawing.Color.White;
            this.rdbCondemned.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCondemned.Location = new System.Drawing.Point(22, 95);
            this.rdbCondemned.Name = "rdbCondemned";
            this.rdbCondemned.Size = new System.Drawing.Size(108, 20);
            this.rdbCondemned.TabIndex = 5;
            this.rdbCondemned.Text = "Condemned";
            // 
            // rdbDefective
            // 
            this.rdbDefective.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbDefective.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbDefective.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbDefective.Enabled = false;
            this.rdbDefective.FillColor = System.Drawing.Color.White;
            this.rdbDefective.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDefective.Location = new System.Drawing.Point(22, 69);
            this.rdbDefective.Name = "rdbDefective";
            this.rdbDefective.Size = new System.Drawing.Size(89, 20);
            this.rdbDefective.TabIndex = 4;
            this.rdbDefective.Text = "Defective";
            // 
            // rdbWorking
            // 
            this.rdbWorking.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbWorking.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbWorking.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbWorking.Enabled = false;
            this.rdbWorking.FillColor = System.Drawing.Color.White;
            this.rdbWorking.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWorking.Location = new System.Drawing.Point(22, 43);
            this.rdbWorking.Name = "rdbWorking";
            this.rdbWorking.Size = new System.Drawing.Size(78, 20);
            this.rdbWorking.TabIndex = 3;
            this.rdbWorking.Text = "Working";
            // 
            // gunaLabel20
            // 
            this.gunaLabel20.AutoSize = true;
            this.gunaLabel20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel20.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel20.Location = new System.Drawing.Point(19, 18);
            this.gunaLabel20.Name = "gunaLabel20";
            this.gunaLabel20.Size = new System.Drawing.Size(49, 16);
            this.gunaLabel20.TabIndex = 2;
            this.gunaLabel20.Text = "STATUS";
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnCancel.BorderSize = 1;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.Location = new System.Drawing.Point(761, 688);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(63, 29);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AnimationHoverSpeed = 0.07F;
            this.btnSaveChanges.AnimationSpeed = 0.03F;
            this.btnSaveChanges.BaseColor = System.Drawing.Color.White;
            this.btnSaveChanges.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSaveChanges.BorderSize = 1;
            this.btnSaveChanges.Checked = true;
            this.btnSaveChanges.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSaveChanges.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSaveChanges.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSaveChanges.CheckedImage = null;
            this.btnSaveChanges.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSaveChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveChanges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSaveChanges.Image = null;
            this.btnSaveChanges.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveChanges.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(824, 688);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSaveChanges.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveChanges.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnSaveChanges.OnHoverImage = null;
            this.btnSaveChanges.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSaveChanges.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Size = new System.Drawing.Size(146, 29);
            this.btnSaveChanges.TabIndex = 124;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateThisItem
            // 
            this.btnUpdateThisItem.AnimationHoverSpeed = 0.07F;
            this.btnUpdateThisItem.AnimationSpeed = 0.03F;
            this.btnUpdateThisItem.BaseColor = System.Drawing.Color.White;
            this.btnUpdateThisItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpdateThisItem.BorderSize = 1;
            this.btnUpdateThisItem.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnUpdateThisItem.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdateThisItem.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpdateThisItem.CheckedImage = null;
            this.btnUpdateThisItem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdateThisItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateThisItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateThisItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateThisItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpdateThisItem.Image = null;
            this.btnUpdateThisItem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateThisItem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdateThisItem.Location = new System.Drawing.Point(820, 71);
            this.btnUpdateThisItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateThisItem.Name = "btnUpdateThisItem";
            this.btnUpdateThisItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUpdateThisItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateThisItem.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnUpdateThisItem.OnHoverImage = null;
            this.btnUpdateThisItem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdateThisItem.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateThisItem.Size = new System.Drawing.Size(150, 55);
            this.btnUpdateThisItem.TabIndex = 126;
            this.btnUpdateThisItem.TabStop = false;
            this.btnUpdateThisItem.Text = "Update this item";
            this.btnUpdateThisItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateThisItem.Click += new System.EventHandler(this.btnUpdateThisItem_Click);
            // 
            // frmViewItem
            // 
            this.AcceptButton = this.btnSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(987, 748);
            this.Controls.Add(this.btnUpdateThisItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gunaLinePanel5);
            this.Controls.Add(this.gunaLinePanel4);
            this.Controls.Add(this.gunaLinePanel3);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewItem";
            this.Text = "View Item";
            this.Load += new System.EventHandler(this.frmViewItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            this.gunaLinePanel4.ResumeLayout(false);
            this.gunaLinePanel4.PerformLayout();
            this.gunaLinePanel5.ResumeLayout(false);
            this.gunaLinePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbInventoryType;
        private Guna.UI.WinForms.GunaComboBox cbInventoryCategory;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private Guna.UI.WinForms.GunaComboBox cbSupplier;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaComboBox cbLocation;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox txtPropertyNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDateAcquired;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaComboBox cbCapacity;
        private Guna.UI.WinForms.GunaTextBox txtCapacity;
        private Guna.UI.WinForms.GunaComboBox cbUnit;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtSerialNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtModel;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtBrand;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaTextBox txtItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDateExpiry;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaTextBox txtLicenseKey;
        private Guna.UI.WinForms.GunaLabel gunaLabel17;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel5;
        private Guna.UI.WinForms.GunaAdvenceButton btnClear;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpload;
        private Guna.UI.WinForms.GunaPictureBox pbImage;
        private Guna.UI.WinForms.GunaLabel gunaLabel19;
        private Guna.UI.WinForms.GunaLinePanel gbStatus;
        private Guna.UI.WinForms.GunaRadioButton rdbCondemned;
        private Guna.UI.WinForms.GunaRadioButton rdbDefective;
        private Guna.UI.WinForms.GunaRadioButton rdbWorking;
        private Guna.UI.WinForms.GunaLabel gunaLabel20;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaAdvenceButton btnSaveChanges;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdateThisItem;
    }
}