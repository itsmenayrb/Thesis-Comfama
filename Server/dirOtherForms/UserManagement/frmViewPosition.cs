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
    public partial class frmViewPosition : Form
    {
        public static frmViewPosition mainInstance = null;

        public frmViewPosition()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void frmViewPosition_Load(object sender, EventArgs e)
        {
            loadPositionData();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            dirOtherForms.UserManagement.frmAddPosition.request = "view";
            new dirOtherForms.UserManagement.frmAddPosition().ShowDialog();
        }

        private void dgvPosition_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.positionsBindingSource.Filter = this.dgvPosition.FilterString;
        }

        private void dgvPosition_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.positionsBindingSource.Sort = this.dgvPosition.SortString;
        }

        public void loadPositionData()
        {
            // TODO: This line of code loads data into the 'dbThesisComfamaDataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.dbThesisComfamaDataSet.Positions);
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
