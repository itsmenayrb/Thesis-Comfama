using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.Settings
{
    public partial class ucAcademicYear : UserControl
    {
        public static ucAcademicYear mainInstance = null;
        public ucAcademicYear()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void ucAcademicYear_Load(object sender, EventArgs e)
        {
            loadAcademicYearData();
        }

        private void btnAddAcademicYear_Click(object sender, EventArgs e)
        {
            new dirOtherForms.Settings.frmAddAcademicYear().ShowDialog();
        }

        public void loadAcademicYearData()
        {
            this.academicYearTableAdapter.Fill(this.dbThesisComfamaDataSet.AcademicYear);
        }

        private void dgvAcademicYear_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.academicYearBindingSource.Filter = this.dgvAcademicYear.FilterString;
        }

        private void dgvAcademicYear_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.academicYearBindingSource.Sort = this.dgvAcademicYear.SortString;
        }

        private void dgvAcademicYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAcademicYear.Columns["action"].Index)
            {
                int academicYearID = Convert.ToInt32(dgvAcademicYear.Rows[dgvAcademicYear.SelectedCells[0].RowIndex].Cells[0].Value);
                string semester = dgvAcademicYear.Rows[dgvAcademicYear.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                string academicYear = dgvAcademicYear.Rows[dgvAcademicYear.SelectedCells[0].RowIndex].Cells[3].Value.ToString();

                DialogResult result = MessageBox.Show("Set academic year: " + semester + " " + academicYear + " as the current academic year?", "Academic Year", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dirClasses.AcademicYear setAcademicYear = new dirClasses.AcademicYear();
                    if (setAcademicYear.checkIfAcademicYearHasBeenSet(academicYearID))
                    {
                        DialogResult result1 = MessageBox.Show("This has been previously set as current academic year. Do you still wish to proceed?", "Academic Year", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                            if (setAcademicYear.setAcademicYear(academicYearID))
                            {
                                MessageBox.Show("Current Academic Year has been set to " + semester + " " + academicYear, "Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadAcademicYearData();
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (setAcademicYear.setAcademicYear(academicYearID))
                        {
                            MessageBox.Show("Current Academic Year has been set to " + semester + " " + academicYear, "Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadAcademicYearData();
                            return;
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
