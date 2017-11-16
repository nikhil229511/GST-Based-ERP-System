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
    public partial class PurchaseReturnReportInvoicewise : Form
    {
        public PurchaseReturnReportInvoicewise()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.rptInvoicewisePurchaseReturnTableAdapter.Fill(this.purchaseReturnInvoicewiseRpt.RptInvoicewisePurchaseReturn,txtInvoiceNo.Text);

            this.rptPurchaseReturnInvoicewise.RefreshReport();
        }
    }
}
