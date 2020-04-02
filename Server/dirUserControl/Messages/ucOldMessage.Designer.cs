namespace Server.dirUserControl.Messages
{
    partial class ucOldMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOldMessage));
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.txtMessage = new Guna.UI.WinForms.GunaTextBox();
            this.btnSend = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblEmployeeID = new Guna.UI.WinForms.GunaLabel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ucBubble1 = new Server.dirUserControl.Messages.ucBubble();
            this.gunaElipsePanel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "New Message";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Controls.Add(this.txtMessage);
            this.gunaElipsePanel1.Controls.Add(this.btnSend);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(23, 495);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(625, 61);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.BorderColor = System.Drawing.Color.Silver;
            this.txtMessage.BorderSize = 0;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMessage.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Gray;
            this.txtMessage.Location = new System.Drawing.Point(11, 8);
            this.txtMessage.MultiLine = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.Size = new System.Drawing.Size(542, 46);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "Type your message... (Press enter to send)";
            this.txtMessage.Enter += new System.EventHandler(this.txtMessage_Enter);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSend.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSend.CheckedForeColor = System.Drawing.Color.White;
            this.btnSend.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSend.CheckedImage")));
            this.btnSend.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSend.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSend.Location = new System.Drawing.Point(559, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSend.OnHoverImage")));
            this.btnSend.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Size = new System.Drawing.Size(61, 55);
            this.btnSend.TabIndex = 0;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeID.Location = new System.Drawing.Point(21, 39);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(78, 17);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "gunaLabel1";
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Controls.Add(this.ucBubble1);
            this.panelContainer.Location = new System.Drawing.Point(0, 72);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(671, 417);
            this.panelContainer.TabIndex = 5;
            this.panelContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelContainer_ControlAdded);
            // 
            // ucBubble1
            // 
            this.ucBubble1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(206)))), ((int)(((byte)(245)))));
            this.ucBubble1.Location = new System.Drawing.Point(23, 15);
            this.ucBubble1.Name = "ucBubble1";
            this.ucBubble1.Size = new System.Drawing.Size(283, 194);
            this.ucBubble1.TabIndex = 0;
            this.ucBubble1.Visible = false;
            // 
            // ucOldMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.lblName);
            this.Name = "ucOldMessage";
            this.Size = new System.Drawing.Size(671, 578);
            this.Load += new System.EventHandler(this.ucOldMessage_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaTextBox txtMessage;
        private Guna.UI.WinForms.GunaAdvenceButton btnSend;
        private Guna.UI.WinForms.GunaLabel lblEmployeeID;
        private System.Windows.Forms.Panel panelContainer;
        private ucBubble ucBubble1;
    }
}
