namespace Server.dirOtherForms.InventoryManagement
{
    partial class frmAddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItems));
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnAddInventoryType = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbInventoryType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnAddCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbInventoryCategory = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.ucSoftware1 = new Server.dirUserControl.InventoryManagement.ucSoftware();
            this.ucHardware1 = new Server.dirUserControl.InventoryManagement.ucHardware();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.gunaAdvenceButton1.TabIndex = 3;
            this.gunaAdvenceButton1.Text = "Add Item";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(852, 31);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(63, 17);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "ADD ITEM";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(681, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(174, 17);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "INVENTORY MANAGEMENT  >";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.btnAddInventoryType);
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
            this.gunaLinePanel1.Size = new System.Drawing.Size(955, 55);
            this.gunaLinePanel1.TabIndex = 6;
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
            this.btnAddInventoryType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventoryType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryType.Image = null;
            this.btnAddInventoryType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddInventoryType.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInventoryType.Location = new System.Drawing.Point(562, 13);
            this.btnAddInventoryType.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddInventoryType.Name = "btnAddInventoryType";
            this.btnAddInventoryType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddInventoryType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddInventoryType.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryType.OnHoverImage = null;
            this.btnAddInventoryType.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInventoryType.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddInventoryType.Size = new System.Drawing.Size(93, 29);
            this.btnAddInventoryType.TabIndex = 8;
            this.btnAddInventoryType.Text = "Add Type";
            this.btnAddInventoryType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddInventoryType.Click += new System.EventHandler(this.btnAddInventoryType_Click);
            // 
            // cbInventoryType
            // 
            this.cbInventoryType.BackColor = System.Drawing.Color.Transparent;
            this.cbInventoryType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbInventoryType.BorderColor = System.Drawing.Color.Silver;
            this.cbInventoryType.BorderSize = 1;
            this.cbInventoryType.DisplayMember = "type";
            this.cbInventoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInventoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryType.FocusedColor = System.Drawing.Color.Empty;
            this.cbInventoryType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventoryType.ForeColor = System.Drawing.Color.Black;
            this.cbInventoryType.FormattingEnabled = true;
            this.cbInventoryType.ItemHeight = 25;
            this.cbInventoryType.Location = new System.Drawing.Point(192, 12);
            this.cbInventoryType.Name = "cbInventoryType";
            this.cbInventoryType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbInventoryType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbInventoryType.Size = new System.Drawing.Size(367, 31);
            this.cbInventoryType.TabIndex = 3;
            this.cbInventoryType.ValueMember = "id";
            this.cbInventoryType.SelectedIndexChanged += new System.EventHandler(this.cbInventoryType_SelectedIndexChanged);
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
            this.gunaLinePanel2.Controls.Add(this.btnAddCategory);
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
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.Image = null;
            this.btnAddCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.Location = new System.Drawing.Point(562, 12);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddCategory.OnHoverImage = null;
            this.btnAddCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCategory.Size = new System.Drawing.Size(93, 29);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // cbInventoryCategory
            // 
            this.cbInventoryCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbInventoryCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbInventoryCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbInventoryCategory.BorderSize = 1;
            this.cbInventoryCategory.DisplayMember = "category";
            this.cbInventoryCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInventoryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbInventoryCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventoryCategory.ForeColor = System.Drawing.Color.Black;
            this.cbInventoryCategory.FormattingEnabled = true;
            this.cbInventoryCategory.ItemHeight = 25;
            this.cbInventoryCategory.Location = new System.Drawing.Point(192, 11);
            this.cbInventoryCategory.Name = "cbInventoryCategory";
            this.cbInventoryCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbInventoryCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbInventoryCategory.Size = new System.Drawing.Size(367, 31);
            this.cbInventoryCategory.TabIndex = 4;
            this.cbInventoryCategory.ValueMember = "id";
            this.cbInventoryCategory.SelectedIndexChanged += new System.EventHandler(this.cbInventoryCategory_SelectedIndexChanged);
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
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSoftware1);
            this.panel1.Controls.Add(this.ucHardware1);
            this.panel1.Location = new System.Drawing.Point(15, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 479);
            this.panel1.TabIndex = 8;
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
            this.gunaControlBox1.TabIndex = 9;
            // 
            // ucSoftware1
            // 
            this.ucSoftware1.BackColor = System.Drawing.Color.White;
            this.ucSoftware1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSoftware1.Location = new System.Drawing.Point(0, 0);
            this.ucSoftware1.Name = "ucSoftware1";
            this.ucSoftware1.Size = new System.Drawing.Size(955, 479);
            this.ucSoftware1.TabIndex = 1;
            this.ucSoftware1.Visible = false;
            // 
            // ucHardware1
            // 
            this.ucHardware1.BackColor = System.Drawing.Color.White;
            this.ucHardware1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHardware1.Location = new System.Drawing.Point(0, 0);
            this.ucHardware1.Name = "ucHardware1";
            this.ucHardware1.Size = new System.Drawing.Size(955, 479);
            this.ucHardware1.TabIndex = 0;
            this.ucHardware1.Visible = false;
            // 
            // frmAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 697);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddItems";
            this.Load += new System.EventHandler(this.frmAddItems_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaComboBox cbInventoryType;
        private Guna.UI.WinForms.GunaComboBox cbInventoryCategory;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private dirUserControl.InventoryManagement.ucHardware ucHardware1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddInventoryType;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddCategory;
        private dirUserControl.InventoryManagement.ucSoftware ucSoftware1;
    }
}