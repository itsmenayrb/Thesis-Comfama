namespace Server.dirUserControl.InventoryManagement
{
    partial class ucInventorySuppliers
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnViewBusinessType = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnViewSupplier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ucInventoryBusinessTypes1 = new Server.dirUserControl.InventoryManagement.ucInventoryBusinessTypes();
            this.ucInventorySupplierList1 = new Server.dirUserControl.InventoryManagement.ucInventorySupplierList();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.btnViewBusinessType);
            this.gunaLinePanel1.Controls.Add(this.btnViewSupplier);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1365, 55);
            this.gunaLinePanel1.TabIndex = 4;
            // 
            // btnViewBusinessType
            // 
            this.btnViewBusinessType.AnimationHoverSpeed = 0.07F;
            this.btnViewBusinessType.AnimationSpeed = 0.03F;
            this.btnViewBusinessType.BaseColor = System.Drawing.Color.White;
            this.btnViewBusinessType.BorderColor = System.Drawing.Color.Black;
            this.btnViewBusinessType.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnViewBusinessType.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewBusinessType.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewBusinessType.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewBusinessType.CheckedImage = null;
            this.btnViewBusinessType.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewBusinessType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewBusinessType.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewBusinessType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBusinessType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewBusinessType.Image = null;
            this.btnViewBusinessType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewBusinessType.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewBusinessType.Location = new System.Drawing.Point(1191, 13);
            this.btnViewBusinessType.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewBusinessType.Name = "btnViewBusinessType";
            this.btnViewBusinessType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewBusinessType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewBusinessType.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewBusinessType.OnHoverImage = null;
            this.btnViewBusinessType.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewBusinessType.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewBusinessType.Size = new System.Drawing.Size(146, 29);
            this.btnViewBusinessType.TabIndex = 7;
            this.btnViewBusinessType.Text = "Business Type";
            this.btnViewBusinessType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewBusinessType.Click += new System.EventHandler(this.btnViewBusinessType_Click);
            // 
            // btnViewSupplier
            // 
            this.btnViewSupplier.AnimationHoverSpeed = 0.07F;
            this.btnViewSupplier.AnimationSpeed = 0.03F;
            this.btnViewSupplier.BaseColor = System.Drawing.Color.White;
            this.btnViewSupplier.BorderColor = System.Drawing.Color.Black;
            this.btnViewSupplier.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnViewSupplier.Checked = true;
            this.btnViewSupplier.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnViewSupplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewSupplier.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewSupplier.CheckedImage = null;
            this.btnViewSupplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewSupplier.Image = null;
            this.btnViewSupplier.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewSupplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewSupplier.Location = new System.Drawing.Point(1045, 13);
            this.btnViewSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewSupplier.Name = "btnViewSupplier";
            this.btnViewSupplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewSupplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewSupplier.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnViewSupplier.OnHoverImage = null;
            this.btnViewSupplier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewSupplier.Size = new System.Drawing.Size(146, 29);
            this.btnViewSupplier.TabIndex = 6;
            this.btnViewSupplier.Text = "Supplier";
            this.btnViewSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewSupplier.Click += new System.EventHandler(this.btnViewSupplier_Click);
            // 
            // ucInventoryBusinessTypes1
            // 
            this.ucInventoryBusinessTypes1.BackColor = System.Drawing.Color.White;
            this.ucInventoryBusinessTypes1.Location = new System.Drawing.Point(0, 61);
            this.ucInventoryBusinessTypes1.Name = "ucInventoryBusinessTypes1";
            this.ucInventoryBusinessTypes1.Size = new System.Drawing.Size(1365, 590);
            this.ucInventoryBusinessTypes1.TabIndex = 6;
            this.ucInventoryBusinessTypes1.Visible = false;
            // 
            // ucInventorySupplierList1
            // 
            this.ucInventorySupplierList1.BackColor = System.Drawing.Color.White;
            this.ucInventorySupplierList1.Location = new System.Drawing.Point(0, 61);
            this.ucInventorySupplierList1.Name = "ucInventorySupplierList1";
            this.ucInventorySupplierList1.Size = new System.Drawing.Size(1365, 590);
            this.ucInventorySupplierList1.TabIndex = 5;
            // 
            // ucInventorySuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucInventoryBusinessTypes1);
            this.Controls.Add(this.ucInventorySupplierList1);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ucInventorySuppliers";
            this.Size = new System.Drawing.Size(1365, 651);
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewBusinessType;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewSupplier;
        private ucInventorySupplierList ucInventorySupplierList1;
        private ucInventoryBusinessTypes ucInventoryBusinessTypes1;
    }
}
