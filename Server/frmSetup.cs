using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class frmSetup : Form
    {
        public static frmSetup mainInstance = null;
        private bool hasError = false;
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public frmSetup()
        {
            mainInstance = this;
            InitializeComponent();
            dirClasses.Database database = new dirClasses.Database();
            this.connectionString = database.dbConnection();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 500;
            tooltip.ReshowDelay = 500;

            tooltip.SetToolTip(pbMachineNameHelp, "The system will automatically detect the name of your machine.\nThis will use to uniquely identify the machine in the system.");
            tooltip.SetToolTip(pbIPAddressHelp, "The system will automatically detect the IP Address of your machine.\nWe recommend to set your IP Address settings to static to avoid IP conflict.\n\nPlease ask your Network Administrator for further assistance.");
            tooltip.SetToolTip(pbMACAddressHelp, "The system will automatically detect the MAC Address of your machine.\nThis will use to remotely power on your machine if it supports it settings.");
            tooltip.SetToolTip(pbLocationHelp, "Please indicate the location where you want to install this application.");
            tooltip.SetToolTip(pbUsernameHelp, "This refer to the local account or username of this machine. This will use to remotely control this machine.\nYou can change this in the settings anytime.");
            tooltip.SetToolTip(pbPasswordHelp, "This refer to the local account or password of this machine. This will use to remotely control this machine.\nYou can change this in the settings anytime.");
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            hasError = false;
            lblErrorMessage.Text = "";
            if (string.IsNullOrEmpty(txtLocation.Text) || txtLocation.Text == "Location")
            {
                hasError = true;
                lblErrorMessage.Text = "Please indicate the location you want to install this application.";
                txtLocation.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == "Username")
                {
                    hasError = true;
                    lblErrorMessage.Text = "Please indicate the username of this machine.";
                    txtUsername.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                    {
                        hasError = true;
                        lblErrorMessage.Text = "Please indicate the password of this machine.";
                        txtPassword.Focus();
                    }
                    else
                    {
                        if (hasError == false)
                        {
                            string _machineName = txtMachineName.Text;
                            string _ipAddress = txtIPAddress.Text;
                            string _macAddress = txtMACAddress.Text;
                            string _location = txtLocation.Text;
                            string _username = txtUsername.Text;
                            string _password = txtPassword.Text;

                            int _port = 8888;
                            string _status = "Idle";
                            string _serverType = "Main Server";
                            string _personalKey = personalKey();

                            dirClasses.Configuration configuration = new dirClasses.Configuration();
                            if (configuration.saveConfiguration(_machineName, _personalKey, _serverType, _location, _ipAddress, _port, _macAddress, _username, _password, _status))
                            {
                                MessageBox.Show("Configuration has been saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string directory = @"C:\Comfama";
                                Directory.CreateDirectory(directory);

                                if (!File.Exists(directory + "\\key.txt"))
                                {
                                    File.Create(directory + "\\key.txt").Close();
                                    using (StreamWriter sw = File.AppendText(directory + "\\key.txt"))
                                    {
                                        sw.WriteLine(_personalKey);
                                    }
                                }
                                else
                                {
                                    using (StreamWriter sw = File.AppendText(directory + "\\key.txt"))
                                    {
                                        sw.WriteLine(_personalKey);
                                    }
                                }
                                File.Create(directory + "\\Unlock.bat").Close();
                                using (StreamWriter s = File.AppendText(directory + "\\Unlock.bat"))
                                {
                                    s.WriteLine("tscon 1 /dest:console");
                                }
                                this.Hide();
                                new frmSplashScreen().Show();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarSetup.Value = e.ProgressPercentage;
            if (progressBarSetup.Value == 25)
            {
                lblProgressBarText.Text = "Getting Machine Name information...";
            }
            else if (progressBarSetup.Value == 50)
            {
                txtMachineName.Text = Environment.MachineName.ToString();
                lblProgressBarText.Text = "Capturing IP Address...";
            }
            else if (progressBarSetup.Value == 75)
            {
                txtIPAddress.Text = GetLocalIPv4();
                lblProgressBarText.Text = "Capturing MAC Address...";
            }
            else if (progressBarSetup.Value == 100)
            {
                txtMACAddress.Text = GetMacAddress().ToString();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProgressBarText.Text = "All necessary information was captured. Please fill-up remaining required fields.";
            txtLocation.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            btnFinish.Enabled = true;

            txtLocation.Focus();
        }

        private static string GetLocalIPv4()
        {
            UnicastIPAddressInformation _mostSuitableIp = null;

            var _networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var _network in _networkInterfaces)
            {
                if (_network.OperationalStatus != OperationalStatus.Up)
                    continue;

                var properties = _network.GetIPProperties();

                if (properties.GatewayAddresses.Count == 0)
                    continue;

                foreach (var _address in properties.UnicastAddresses)
                {
                    if (_address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(_address.Address))
                        continue;

                    if (!_address.IsDnsEligible)
                    {
                        if (_mostSuitableIp == null)
                            _mostSuitableIp = _address;
                        continue;
                    }

                    // The best IP is the IP got from DHCP server
                    if (_address.PrefixOrigin != PrefixOrigin.Dhcp)
                    {
                        if (_mostSuitableIp == null || !_mostSuitableIp.IsDnsEligible)
                            _mostSuitableIp = _address;
                        continue;
                    }

                    return _address.Address.ToString();
                }
            }

            return _mostSuitableIp != null
                ? _mostSuitableIp.Address.ToString()
                : "";
        }

        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        private string personalKey()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] chars = new char[15];
            Random rd = new Random();

            for (int i = 0; i < 15; i++)
            {
                chars[i] = characters[rd.Next(0, characters.Length)];
            }

            return new string(chars);
        }

        private void txtLocation_Enter(object sender, EventArgs e)
        {
            if (txtLocation.Text == "Location")
            {
                txtLocation.Text = "";
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                txtLocation.Text = "Location";
            }
            else
            {
                txtLocation.Text = txtLocation.Text.ToUpper();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
