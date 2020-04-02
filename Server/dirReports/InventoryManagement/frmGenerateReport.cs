using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirReports.InventoryManagement
{
    public partial class frmGenerateReport : Form
    {
        public static int academicYearID { get; set; }

        public frmGenerateReport()
        {
            InitializeComponent();
        }

        private void frmGenerateReport_Load(object sender, EventArgs e)
        {
            
           this.rvGenerateReport.RefreshReport();
        }
    }
}
