using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirUserControl.UserManagement
{
    public partial class ucAccounts : UserControl
    {
        public static ucAccounts mainInstance = null;

        public ucAccounts()
        {
            mainInstance = this;
            InitializeComponent();
        }

        private void ucAccounts_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.dbThesisComfamaDataSet.Accounts);
        }

        public void loadData()
        {
            this.accountsTableAdapter.Fill(this.dbThesisComfamaDataSet.Accounts);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void dgvAccounts_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.accountsBindingSource.Filter = this.dgvAccounts.FilterString;
        }

        private void dgvAccounts_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.accountsBindingSource.Sort = this.dgvAccounts.SortString;
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAccounts.Columns["action"].Index)
            {
                string username = dgvAccounts.Rows[dgvAccounts.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Update " + username + "?", "Update Account Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Please make sure that the field is not empty.", "Update Account Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadData();
                    }
                    else
                    {
                        accountsBindingSource.EndEdit();
                        this.accountsTableAdapter.Update(this.dbThesisComfamaDataSet.Accounts);
                        dgvAccounts.Refresh();
                        MessageBox.Show("Account has been updated!", "Update Account Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
