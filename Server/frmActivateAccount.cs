using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Server
{
    public partial class frmActivateAccount : Form
    {
        private bool hasError = false;
        public static string employeeID { get; set; }

        public Guna.UI.WinForms.GunaTextBox txtbox
        {
            set { txtNewPassword = value; }
            get { return txtNewPassword; }
        }
        
        public frmActivateAccount()
        {
            InitializeComponent();
        }

        private void frmActivateAccount_Load(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            new dirClasses.Configuration().displayCurrentAcademicYear();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtNewPassword.Text == "New Password" || string.IsNullOrEmpty(txtNewPassword.Text))
            {
                hasError = true;
                MessageBox.Show("Please enter your new password.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return;
            }
            else
            {
                if (txtConfirmPassword.Text == "Confirm Password" || string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    hasError = true;
                    MessageBox.Show("Please confirm your password.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Focus();
                    return;
                }
                else
                {
                    if (checkCharacterLength(txtNewPassword.Text) == false)
                    {
                        hasError = true;
                        MessageBox.Show("Password must be at least 8-32 characters long.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPassword.Focus();
                        return;
                    }
                    else
                    {
                        if (checkLowercase(txtNewPassword.Text) == false)
                        {
                            hasError = true;
                            MessageBox.Show("Password must have at least 1 lowercase letter.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPassword.Focus();
                            return;
                        }
                        else
                        {
                            if (checkUppercase(txtNewPassword.Text) == false)
                            {
                                hasError = true;
                                MessageBox.Show("Password must have at least 1 uppercase letter.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNewPassword.Focus();
                                return;
                            }
                            else
                            {
                                if (checkDigit(txtNewPassword.Text) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Password must have at least 1 numeric value.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtNewPassword.Focus();
                                    return;
                                }
                                else
                                {
                                    if (checkSymbol(txtNewPassword.Text) == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Password must have at least 1 special characters.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtNewPassword.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        if (txtNewPassword.Text != txtConfirmPassword.Text)
                                        {
                                            hasError = true;
                                            MessageBox.Show("Password did not match.", "Activate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtConfirmPassword.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            if (hasError == false)
                                            {
                                                string password = txtNewPassword.Text;
                                                dirClasses.ActivateAccount activate = new dirClasses.ActivateAccount();
                                                if (activate.activateAccount(employeeID, password))
                                                {
                                                    MessageBox.Show("You have successully activated your account! Please log-in using your new password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.Close();
                                                    frmLogin login = new frmLogin();
                                                    login.Show();
                                                    login.TopMost = true;
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
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You cannot log-in without your account activated.\nAre you sure you want to cancel this set-up?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "New Password")
            {
                txtNewPassword.Text = "";
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.Text = "New Password";
                txtNewPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Text = "Confirm Password";
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            string text = txtNewPassword.Text;
            lblEightRule.ForeColor = checkCharacterLength(text) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblLowerRule.ForeColor = checkLowercase(text) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblUpperRule.ForeColor = checkUppercase(text) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblDecimalRule.ForeColor = checkDigit(text) ? Color.FromArgb(47, 97, 72) : Color.Orange;
            lblSpecialRule.ForeColor = checkSymbol(text) ? Color.FromArgb(47, 97, 72) : Color.Orange;
        }

        private bool checkCharacterLength(string text)
        {
            if (text.Length >= 8 && text.Length <= 32 && text != "New Password")
            {
                return true;
            }
            return false;
        }

        private bool checkLowercase(string text)
        {
            if (new Regex(@"[a-z]+").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        private bool checkUppercase(string text)
        {
            if (new Regex(@"[A-Z]+").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        private bool checkDigit(string text)
        {
            if (new Regex(@"[0-9]+").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        private bool checkSymbol(string text)
        {
            if (new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]").IsMatch(text) && text != "New Password")
            {
                return true;
            }
            return false;
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != "New Password" || !string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.UseSystemPasswordChar = gunaWinSwitch1.Checked ? false : true;
                txtConfirmPassword.UseSystemPasswordChar = gunaWinSwitch1.Checked ? false : true;
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }

            if (e.Control == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                    case Keys.V:
                    case Keys.X:
                        e.Handled = true;
                        break;
                }
            }
        }
    }
}
