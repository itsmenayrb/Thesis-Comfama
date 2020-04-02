using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.RemoteManagement
{
    public partial class LectureModePlayer : Form
    {
        public static LectureModePlayer mainInstance = null;
        private bool showForm = true;
        private bool playing = true;
        public LectureModePlayer()
        {
            mainInstance = this;
            InitializeComponent();
            setFormLocation();
        }

        private void LectureModePlayer_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            timerToggle.Start();
        }

        private void setFormLocation()
        {
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(screen.Bounds.Right - this.Width, screen.Bounds.Top + this.Height);
                    return;
                }
            }
        }

        private void timerToggle_Tick(object sender, EventArgs e)
        {
            if (showForm)
            {
                btnShowHide.Image = Resource1.chevron_left_50px_white;
                btnShowHide.OnHoverImage = Resource1.chevron_left_50px_white;
                this.Width = this.Width - 10;
                setFormLocation();
                if (this.Width == 40)
                {
                    timerToggle.Stop();
                    showForm = false;
                    this.Refresh();
                }
                
            }
            else
            {
                btnShowHide.Image = Resource1.chevron_right_50px_white;
                btnShowHide.OnHoverImage = Resource1.chevron_right_50px_white;
                this.Width = this.Width + 10;
                setFormLocation();
                if (this.Width == 290)
                {
                    timerToggle.Stop();
                    showForm = true;
                    this.Refresh();
                }

            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                lblStatus.Text = "Paused.";
                btnPause.Image = Resource1.resume_button_50px;
                btnPause.OnHoverImage = Resource1.resume_button_50px;
                frmMain.mainInstance.stopScreenCast();
                playing = false;
            }
            else
            {
                lblStatus.Text = "Broadcasting...";
                btnPause.Image = Resource1.pause_50px;
                btnPause.OnHoverImage = Resource1.pause_50px;
                frmMain.mainInstance.startScreenCast();
                playing = true;
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("End your lecture?", "Lecture Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                LectureMode.mainInstance.endLectureModeSession();
                frmMain.mainInstance.stopScreenCast();
                LectureMode.mainInstance.dispose();
                this.Close();
            }
        }
    }
}
