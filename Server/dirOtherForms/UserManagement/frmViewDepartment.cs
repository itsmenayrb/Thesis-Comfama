﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirOtherForms.UserManagement
{
    public partial class frmViewDepartment : Form
    {
        public static frmViewDepartment mainInstance = null;

        public frmViewDepartment()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void frmViewDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbThesisComfamaDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.dbThesisComfamaDataSet.Departments);
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        public void loadDepartmentData()
        {
            // TODO: This line of code loads data into the 'dbThesisComfamaDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.dbThesisComfamaDataSet.Departments);
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddDepartment.request = "view";
            new dirOtherForms.UserManagement.frmAddDepartment().ShowDialog();
        }

        private void dgvDepartment_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.departmentsBindingSource.Filter = this.dgvDepartment.FilterString;
        }

        private void dgvDepartment_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.departmentsBindingSource.Sort = this.dgvDepartment.SortString;
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
