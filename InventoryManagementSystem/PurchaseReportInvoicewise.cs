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
    public partial class PurchaseReportInvoicewise : Form
    {
        public PurchaseReportInvoicewise()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.rptInvoicewisePurchaseTableAdapter.Fill(this.purchaseInvoicewiseRpt.RptInvoicewisePurchase,txtInvoiceNo.Text);

            this.rptPurchaseInvoicewise.RefreshReport();
        }

        private void PurchaseReportInvoicewise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }
    }
}
