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
    public partial class PrintSalesReturnInvoice : Form
    {
        public PrintSalesReturnInvoice()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintSalesReturnInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void PrintSalesReturnInvoice_Load(object sender, EventArgs e)
        {
            this.rptInvoicewiseSalesReturnTableAdapter.Fill(this.salesReturnInvoicewiseRpt.RptInvoicewiseSalesReturn, SalesReturn.SalesReturnInvoiceNo);

            this.rptSalesReturnInvoice.RefreshReport();
        }
    }
}
