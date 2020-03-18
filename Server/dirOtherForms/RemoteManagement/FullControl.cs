using MSTSCLib;
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
    public partial class FullControl : Form
    {
        public static FullControl mainInstance = null;

        public static string ipAddress { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }

        public FullControl()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void FullControl_Load(object sender, EventArgs e)
        {
            try
            {
                rdp.Server = ipAddress;
                rdp.UserName = username;
                MsRdpClient8NotSafeForScripting secured = (MsRdpClient8NotSafeForScripting)rdp.GetOcx();
                secured.AdvancedSettings8.ClearTextPassword = password;
                secured.AdvancedSettings8.EnableCredSspSupport = true;
                secured.ColorDepth = 24;
                secured.AdvancedSettings8.SmartSizing = true;
                secured.DesktopHeight = Screen.PrimaryScreen.Bounds.Height;
                secured.DesktopWidth = Screen.PrimaryScreen.Bounds.Width;
                rdp.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
