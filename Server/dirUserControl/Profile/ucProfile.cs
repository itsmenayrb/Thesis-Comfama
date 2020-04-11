using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.Profile
{
    public partial class ucProfile : UserControl
    {
        Font bold = new Font("Century Gothic", 9, FontStyle.Bold);
        Font regular = new Font("Century Gothic", 9, FontStyle.Regular);

        public ucProfile()
        {
            InitializeComponent();
        }

        private void ucProfile_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelTop, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(this, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
        }

        private void lblPersonalInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Guna.UI.WinForms.GunaLinkLabel label in sidePanel.Controls)
            {
                if (label.Name == "lblPersonalInformation")
                {
                    isClicked(label);
                    ucPersonalInformation1.Visible = true;
                    ucPersonalInformation1.loadPersonalData();
                }
                else
                {
                    isNotClicked(label);
                    ucAccountInformation1.Visible = false;
                    ucWelcomeMessage1.Visible = false;
                }
            }
        }

        private void lblAccountInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Guna.UI.WinForms.GunaLinkLabel label in sidePanel.Controls)
            {
                if (label.Name == "lblAccountInformation")
                {
                    isClicked(label);
                    ucAccountInformation1.Visible = true;
                }
                else
                {
                    isNotClicked(label);
                    ucWelcomeMessage1.Visible = false;
                    ucPersonalInformation1.Visible = false;
                }
            }
        }

        private void lblWelcomeMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Guna.UI.WinForms.GunaLinkLabel label in sidePanel.Controls)
            {
                if (label.Name == "lblWelcomeMessage")
                {
                    isClicked(label);
                    ucWelcomeMessage1.Visible = true;
                }
                else
                {
                    isNotClicked(label);
                    ucAccountInformation1.Visible = false;
                    ucPersonalInformation1.Visible = false;
                }
            }
        }

        private void lblTodo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Guna.UI.WinForms.GunaLinkLabel label in sidePanel.Controls)
            {
                if (label.Name == "lblTodo")
                {
                    isClicked(label);
                }
                else
                {
                    isNotClicked(label);
                }
            }
        }

        private void isClicked(Guna.UI.WinForms.GunaLinkLabel label)
        {
            label.Font = bold;
            label.LinkColor = Color.Black;
        }

        private void isNotClicked(Guna.UI.WinForms.GunaLinkLabel label)
        {
            label.Font = regular;
            label.LinkColor = Color.Silver;
        }
    }
}
