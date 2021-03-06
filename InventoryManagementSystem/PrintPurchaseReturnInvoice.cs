﻿using System;
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
    public partial class PrintPurchaseReturnInvoice : Form
    {
        public PrintPurchaseReturnInvoice()
        {
            InitializeComponent();
        }

        private void PrintPurchaseReturnInvoice_KeyDown(object sender, KeyEventArgs e)
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

        private void PrintPurchaseReturnInvoice_Load(object sender, EventArgs e)
        {
            this.rptInvoicewisePurchaseReturnTableAdapter.Fill(this.purchaseReturnInvoicewiseRpt.RptInvoicewisePurchaseReturn, PurchaseReturn.PurchaseReturnInvoiceNo);

            this.rptPurchaseReturnInvoice.RefreshReport();
        }
    }
}
