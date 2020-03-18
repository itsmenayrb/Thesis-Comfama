using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.Settings
{
    public partial class frmAddAcademicYear : Form
    {
        private bool hasError = false;

        public frmAddAcademicYear()
        {
            InitializeComponent();
        }

        private void frmAddAcademicYear_Load(object sender, EventArgs e)
        {
            loadAcademicYear();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnAddAcademicYear_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (cbSemester.SelectedIndex == 0 || cbSemester.SelectedIndex == -1)
            {
                hasError = true;
                MessageBox.Show("Please select the semester.", "Add Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSemester.Focus();
            }
            else
            {
                if (cbAcademicYear.SelectedIndex == 0 || cbAcademicYear.SelectedIndex == -1)
                {
                    hasError = true;
                    MessageBox.Show("Please select the academic year.", "Add Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbAcademicYear.Focus();
                }
                else
                {
                    if (hasError == false)
                    {
                        string semester = cbSemester.Text;
                        string academicYear = cbAcademicYear.Text;

                        dirClasses.AcademicYear addAcademicYear = new dirClasses.AcademicYear();
                        if (addAcademicYear.addAcademicYear(semester, academicYear))
                        {
                            MessageBox.Show("The " + semester + " of Academic Year " + academicYear + " has been added", "Add Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dirUserControl.Settings.ucAcademicYear.mainInstance.loadAcademicYearData();
                            this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadAcademicYear()
        {
            string firstAcademicYear = DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString();
            string secondAcademicYear = (DateTime.Now.Year + 1).ToString() + " - " + (DateTime.Now.Year + 2).ToString();

            cbAcademicYear.Items.Insert(0, "--Select Academic Year--");
            cbAcademicYear.Items.Insert(1, firstAcademicYear);
            cbAcademicYear.Items.Insert(2, secondAcademicYear);
            cbAcademicYear.StartIndex = 0;
        }
    }
}
