using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.Dashboard
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);

            lblDay.Text = DateTime.Now.DayOfWeek.ToString().ToUpper();
            lblDateTime.Text = DateTime.Now.ToString().ToUpper();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString().ToUpper();
            new dirClasses.Configuration().displayCurrentAcademicYear();
            lblAcademicYear.Text = "A.Y " + dirClasses.Session.semester + " " + dirClasses.Session.academicYear;
        }
    }
}
