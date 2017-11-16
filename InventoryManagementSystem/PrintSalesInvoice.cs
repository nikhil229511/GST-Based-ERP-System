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
    public partial class PrintSalesInvoice : Form
    {
        public PrintSalesInvoice()
        {
            InitializeComponent();
        }

        private void PrintSalesInvoice_Load(object sender, EventArgs e)
        {
            this.rptInvoicewiseSalesTableAdapter.Fill(this.salesInvoicewiseRpt.RptInvoicewiseSales, SalesNew.SalesInvoiceNo);

            this.rptSalesInvoice.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintSalesInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }
    }
}
