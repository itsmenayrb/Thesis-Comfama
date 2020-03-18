using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarSplashScreen.Increment(2);
            if (progressBarSplashScreen.Value == 100)
            {
                timer1.Stop();   
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            progressBarSplashScreen.Value = 0;
            timer1.Start();
        }
    }
}
