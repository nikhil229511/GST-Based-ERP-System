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
    public partial class SalesReturnReportInvociewise : Form
    {
        public SalesReturnReportInvociewise()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesReturnReportInvociewise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.rptInvoicewiseSalesReturnTableAdapter.Fill(this.salesReturnInvoicewiseRpt.RptInvoicewiseSalesReturn,txtInvoiceNo.Text);

            this.rptSalesReturnInvoicewise.RefreshReport();
        }
    }
}
