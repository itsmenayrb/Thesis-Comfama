namespace Server.dirUserControl.Messages
{
    partial class ucBubble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBubble));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(10, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(458, 66);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = resources.GetString("lblMessage.Text");
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTime.Location = new System.Drawing.Point(10, 74);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(458, 20);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            // 
            // ucBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(206)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMessage);
            this.Name = "ucBubble";
            this.Size = new System.Drawing.Size(480, 104);
            this.Resize += new System.EventHandler(this.ucBubble_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTime;
    }
}
