using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.Settings
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }
    }
}
