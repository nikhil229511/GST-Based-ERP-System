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
    public partial class PrintPurchaseInvoice : Form
    {
        public PrintPurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PrintPurchaseInvoice_Load(object sender, EventArgs e)
        {
            this.rptInvoicewisePurchaseTableAdapter .Fill(this.purchaseInvoicewiseRpt.RptInvoicewisePurchase,Purchase.invoiceNo);

            this.rptPurchaseInvoice.RefreshReport();
        }

        private void PrintPurchaseInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
