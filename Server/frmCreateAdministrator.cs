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
    public partial class frmCreateAdministrator : Form
    {
        private bool hasError = false;

        public frmCreateAdministrator()
        {
            InitializeComponent();
        }

        private void frmCreateAdministrator_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(panelContainer, Color.Black, 10, 10, Guna.UI.WinForms.VerHorAlign.VerticalLeft, Guna.UI.WinForms.AddOrRemove.Add);
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
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

        private void btnCreateAdministrator_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text == "Username")
            {
                hasError = true;
                MessageBox.Show("Please enter your username.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == "Password")
                {
                    hasError = true;
                   MessageBox.Show("Please enter your password.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtConfirmPassword.Text) || txtConfirmPassword.Text == "Confirm Password")
                    {
                        hasError = true;
                       MessageBox.Show("Please confirm your password.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmPassword.Focus();
                        return;
                    }
                    else
                    {
                        if (checkCharacterLength(txtPassword.Text) == false)
                        {
                            hasError = true;
                            MessageBox.Show("Password must be at least 8-32 characters long.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Focus();
                            return;
                        }
                        else
                        {
                            if (checkLowercase(txtPassword.Text) == false)
                            {
                                hasError = true;
                                MessageBox.Show("Password must have at least 1 lowercase letter.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Focus();
                                return;
                            }
                            else
                            {
                                if (checkUppercase(txtPassword.Text) == false)
                                {
                                    hasError = true;
                                    MessageBox.Show("Password must have at least 1 uppercase letter.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPassword.Focus();
                                    return;
                                }
                                else
                                {
                                    if (checkDigit(txtPassword.Text) == false)
                                    {
                                        hasError = true;
                                        MessageBox.Show("Password must have at least 1 numeric value.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtPassword.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        if (checkSymbol(txtPassword.Text) == false)
                                        {
                                            hasError = true;
                                            MessageBox.Show("Password must have at least 1 special characters.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtPassword.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            if (txtPassword.Text != txtConfirmPassword.Text)
                                            {
                                                hasError = true;
                                                MessageBox.Show("Password did not match.", "Create Administrator Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtConfirmPassword.Focus();
                                                return;
                                            }
                                            else
                                            {
                                                if (hasError == false)
                                                {
                                                    string username = txtUsername.Text;
                                                    string password = txtPassword.Text;
                                                    dirClasses.Administrator addAdministrator = new dirClasses.Administrator();
                                                    if (addAdministrator.addAdministrator(username, password))
                                                    {
                                                        MessageBox.Show("You have successully created an Administrator Account.\nPress OK to login.", "Create Administrator account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                        new frmLogin().Show();
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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string text = txtPassword.Text;
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
    }
}
