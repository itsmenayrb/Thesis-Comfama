namespace Server.dirOtherForms.InventoryManagement
{
    partial class frmAddCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategories));
            this.cbInventoryTypes = new Guna.UI.WinForms.GunaComboBox();
            this.txtInventoryCategory = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddInventoryCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInventoryTypes
            // 
            this.cbInventoryTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbInventoryTypes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbInventoryTypes.BorderColor = System.Drawing.Color.Silver;
            this.cbInventoryTypes.BorderSize = 1;
            this.cbInventoryTypes.DisplayMember = "businessType";
            this.cbInventoryTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInventoryTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryTypes.FocusedColor = System.Drawing.Color.Empty;
            this.cbInventoryTypes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventoryTypes.ForeColor = System.Drawing.Color.Black;
            this.cbInventoryTypes.FormattingEnabled = true;
            this.cbInventoryTypes.ItemHeight = 27;
            this.cbInventoryTypes.Location = new System.Drawing.Point(184, 104);
            this.cbInventoryTypes.Name = "cbInventoryTypes";
            this.cbInventoryTypes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbInventoryTypes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbInventoryTypes.Size = new System.Drawing.Size(305, 33);
            this.cbInventoryTypes.TabIndex = 40;
            this.cbInventoryTypes.ValueMember = "id";
            // 
            // txtInventoryCategory
            // 
            this.txtInventoryCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtInventoryCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txtInventoryCategory.BorderColor = System.Drawing.Color.Silver;
            this.txtInventoryCategory.BorderSize = 1;
            this.txtInventoryCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInventoryCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.txtInventoryCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.txtInventoryCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInventoryCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryCategory.Location = new System.Drawing.Point(184, 164);
            this.txtInventoryCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtInventoryCategory.Name = "txtInventoryCategory";
            this.txtInventoryCategory.PasswordChar = '\0';
            this.txtInventoryCategory.Size = new System.Drawing.Size(305, 34);
            this.txtInventoryCategory.TabIndex = 1;
            this.txtInventoryCategory.Text = "Inventory Category";
            this.txtInventoryCategory.TextOffsetX = 5;
            this.txtInventoryCategory.Enter += new System.EventHandler(this.txtInventoryCategory_Enter);
            this.txtInventoryCategory.Leave += new System.EventHandler(this.txtInventoryCategory_Leave);
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
            this.panel1.Size = new System.Drawing.Size(656, 60);
            this.panel1.TabIndex = 62;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(-9, 12);
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
            this.gunaAdvenceButton1.Text = "Add Inventory Category";
            this.gunaAdvenceButton1.TextOffsetX = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(254, 28);
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
            this.gunaLabel2.Location = new System.Drawing.Point(424, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(169, 17);
            this.gunaLabel2.TabIndex = 42;
            this.gunaLabel2.Text = "ADD INVENTORY CATEGORY";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(599, 22);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 43;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(181, 82);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(103, 16);
            this.gunaLabel3.TabIndex = 63;
            this.gunaLabel3.Text = "INVENTORY TYPE";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(181, 143);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(141, 16);
            this.gunaLabel4.TabIndex = 64;
            this.gunaLabel4.Text = "INVENTORY CATEGORY";
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.Location = new System.Drawing.Point(184, 212);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddInventoryCategory
            // 
            this.btnAddInventoryCategory.AnimationHoverSpeed = 0.07F;
            this.btnAddInventoryCategory.AnimationSpeed = 0.03F;
            this.btnAddInventoryCategory.BaseColor = System.Drawing.Color.White;
            this.btnAddInventoryCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddInventoryCategory.BorderSize = 1;
            this.btnAddInventoryCategory.Checked = true;
            this.btnAddInventoryCategory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnAddInventoryCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddInventoryCategory.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryCategory.CheckedImage = null;
            this.btnAddInventoryCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddInventoryCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddInventoryCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddInventoryCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventoryCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryCategory.Image = null;
            this.btnAddInventoryCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddInventoryCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInventoryCategory.Location = new System.Drawing.Point(311, 212);
            this.btnAddInventoryCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddInventoryCategory.Name = "btnAddInventoryCategory";
            this.btnAddInventoryCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddInventoryCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddInventoryCategory.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnAddInventoryCategory.OnHoverImage = null;
            this.btnAddInventoryCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInventoryCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddInventoryCategory.Size = new System.Drawing.Size(178, 35);
            this.btnAddInventoryCategory.TabIndex = 65;
            this.btnAddInventoryCategory.Text = "Add Inventory Category";
            this.btnAddInventoryCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddInventoryCategory.Click += new System.EventHandler(this.btnAddInventoryCategory_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // frmAddCategories
            // 
            this.AcceptButton = this.btnAddInventoryCategory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 282);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddInventoryCategory);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbInventoryTypes);
            this.Controls.Add(this.txtInventoryCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCategories";
            this.Text = "frmAddCategories";
            this.Load += new System.EventHandler(this.frmAddCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtInventoryCategory;
        private Guna.UI.WinForms.GunaComboBox cbInventoryTypes;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddInventoryCategory;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}