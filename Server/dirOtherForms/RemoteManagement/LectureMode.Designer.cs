namespace Server.dirOtherForms.RemoteManagement
{
    partial class LectureMode
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.clbClient = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnForceStart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.timerWaitingToClientToAccept = new System.Windows.Forms.Timer(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel1.Controls.Add(this.clbClient);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(23, 27);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(758, 339);
            this.gunaLinePanel1.TabIndex = 6;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(18, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(532, 17);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Please wait until all connected clients accepts your request. Otherwise, press fo" +
    "rce start.";
            // 
            // clbClient
            // 
            this.clbClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbClient.ColumnWidth = 200;
            this.clbClient.Enabled = false;
            this.clbClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbClient.FormattingEnabled = true;
            this.clbClient.Location = new System.Drawing.Point(21, 61);
            this.clbClient.Name = "clbClient";
            this.clbClient.Size = new System.Drawing.Size(714, 234);
            this.clbClient.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(23, 380);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.AnimationHoverSpeed = 0.07F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BaseColor = System.Drawing.Color.White;
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStart.BorderSize = 1;
            this.btnStart.Checked = true;
            this.btnStart.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnStart.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStart.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStart.CheckedImage = null;
            this.btnStart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.Enabled = false;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStart.Image = null;
            this.btnStart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStart.Location = new System.Drawing.Point(654, 380);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Size = new System.Drawing.Size(127, 35);
            this.btnStart.TabIndex = 66;
            this.btnStart.Text = "Start (F5)";
            this.btnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnForceStart
            // 
            this.btnForceStart.AnimationHoverSpeed = 0.07F;
            this.btnForceStart.AnimationSpeed = 0.03F;
            this.btnForceStart.BaseColor = System.Drawing.Color.White;
            this.btnForceStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnForceStart.BorderSize = 1;
            this.btnForceStart.Checked = true;
            this.btnForceStart.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnForceStart.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnForceStart.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnForceStart.CheckedImage = null;
            this.btnForceStart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnForceStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForceStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnForceStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForceStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnForceStart.Image = null;
            this.btnForceStart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnForceStart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnForceStart.Location = new System.Drawing.Point(150, 380);
            this.btnForceStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnForceStart.Name = "btnForceStart";
            this.btnForceStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnForceStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnForceStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(97)))), ((int)(((byte)(72)))));
            this.btnForceStart.OnHoverImage = null;
            this.btnForceStart.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnForceStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnForceStart.Size = new System.Drawing.Size(133, 35);
            this.btnForceStart.TabIndex = 68;
            this.btnForceStart.Text = "Force Start (F9)";
            this.btnForceStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerWaitingToClientToAccept
            // 
            this.timerWaitingToClientToAccept.Interval = 1000;
            this.timerWaitingToClientToAccept.Tick += new System.EventHandler(this.timerWaitingToClientToAccept_Tick);
            // 
            // LectureMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(808, 443);
            this.Controls.Add(this.btnForceStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gunaLinePanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lecture Mode";
            this.Load += new System.EventHandler(this.LectureMode_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.CheckedListBox clbClient;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaAdvenceButton btnStart;
        private Guna.UI.WinForms.GunaAdvenceButton btnForceStart;
        private System.Windows.Forms.Timer timerWaitingToClientToAccept;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}