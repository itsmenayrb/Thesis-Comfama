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
    public partial class frmViewCourse : Form
    {
        public static frmViewCourse mainInstance = null;

        public frmViewCourse()
        {
            InitializeComponent();
            mainInstance = this;
        }

        private void frmViewCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbThesisComfamaDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dbThesisComfamaDataSet.Courses);
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void loadCourseData()
        {
            // TODO: This line of code loads data into the 'dbThesisComfamaDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dbThesisComfamaDataSet.Courses);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddCourse.request = "view";
            new dirOtherForms.UserManagement.frmAddCourse().ShowDialog();
        }

        private void dgvCourse_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.coursesBindingSource.Filter = this.dgvCourse.FilterString;
        }

        private void dgvCourse_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.coursesBindingSource.Sort = this.dgvCourse.SortString;
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
