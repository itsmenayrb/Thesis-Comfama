using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.UserManagement
{
    public partial class frmAddCourse : Form
    {
        private bool hasError = false;
        public static string request { get; set; }

        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void txtCourse_Enter(object sender, EventArgs e)
        {
            if (txtCourse.Text == "Course")
            {
                txtCourse.Text = "";
            }
        }

        private void txtCourse_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                txtCourse.Text = "Course";
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            hasError = false;
            if (txtCourse.Text == "Department" || string.IsNullOrEmpty(txtCourse.Text))
            {
                hasError = true;
                MessageBox.Show("Please indicate the name of course.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourse.Focus();
            }
            else
            {
                if (hasError == false)
                {
                    string course = txtCourse.Text;
                    dirClasses.Course addCourse = new dirClasses.Course();
                    if (addCourse.addCourse(course))
                    {
                        MessageBox.Show(course.ToUpper() + " has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (request == "view")
                        {
                            frmViewCourse.mainInstance.loadCourseData();
                        }
                        else
                        {
                            frmAddStudent.mainInstance.loadCourseData();
                        }
                        dirUserControl.UserManagement.ucStudents.mainInstance.loadData();
                        this.Close();
                    }
                    else
                    {
                        txtCourse.Focus();
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
