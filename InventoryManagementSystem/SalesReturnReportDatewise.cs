using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class SalesReturnReportDatewise : Form
    {
        public SalesReturnReportDatewise()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesReturnReportDatewise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime fd = Convert.ToDateTime(dtpFromDate.Text.Substring(3, 2) + "/" + dtpFromDate.Text.Substring(0, 2) + "/" + dtpFromDate.Text.Substring(6, 4));
            DateTime td = Convert.ToDateTime(dtpToDate.Text.Substring(3, 2) + "/" + dtpToDate.Text.Substring(0, 2) + "/" + dtpToDate.Text.Substring(6, 4));
            this.rptDatewiseSalesReturnTableAdapter.Fill(this.salesReturnDatewiseRpt.RptDatewiseSalesReturn, fd, td);

            ReportParameter rp1 = new ReportParameter("FromDate", dtpFromDate.Text);
            ReportParameter rp2 = new ReportParameter("ToDate", dtpToDate.Text);
            this.rptSalesReturnDatewise.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            this.rptSalesReturnDatewise.RefreshReport();
        }
    }
}
