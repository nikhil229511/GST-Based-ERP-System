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
    public partial class MainTerminal : Form
    {
        

        public MainTerminal()
        {
            InitializeComponent();
        }

        private void brandMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandMaster frm = new BrandMaster();
            frm.ShowDialog();
        }

        private void categoryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryMaster frm = new CategoryMaster();
            frm.ShowDialog();
        }

        private void supplierMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierMaster frm = new SupplierMaster();
            frm.ShowDialog();

        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemMaster frm = new ItemMaster();
            frm.ShowDialog();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase frm = new Purchase();
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesNew frm = new SalesNew();
            frm.ShowDialog();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReturn frm = new PurchaseReturn();
            frm.ShowDialog();
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturn frm = new SalesReturn();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportDatewise frm = new PurchaseReportDatewise();
            frm.ShowDialog();
        }

        private void dateWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReturnReportDatewise frm = new PurchaseReturnReportDatewise();
            frm.ShowDialog();
        }

        private void dateWiseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SalesReportDatewise frm = new SalesReportDatewise();
            frm.ShowDialog();
        }

        private void dateWiseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SalesReturnReportDatewise frm = new SalesReturnReportDatewise();
            frm.ShowDialog();
        }

        private void shortcutKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShortcutKeys frm = new ShortcutKeys();
            frm.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs frm = new AboutUs();
            frm.ShowDialog();
        }

        private void stockDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemwiseStockDetail frm = new ItemwiseStockDetail();
            frm.ShowDialog();
        }

        private void supplierWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportSupplierwise frm = new PurchaseReportSupplierwise();
            frm.ShowDialog();
        }

        private void invoiceNoWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportInvoicewise frm = new PurchaseReportInvoicewise();
            frm.ShowDialog();
        }

        private void supplierWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReturnReportSupplierwise frm = new PurchaseReturnReportSupplierwise();
            frm.ShowDialog();
        }

        private void invoiceNoWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReturnReportInvoicewise frm = new PurchaseReturnReportInvoicewise();
            frm.ShowDialog();
        }

        private void invoiceNoWiseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SalesReportInvoicewise frm = new SalesReportInvoicewise();
            frm.ShowDialog();
        }

        private void invoiceNoWiseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SalesReturnReportInvociewise frm = new SalesReturnReportInvociewise();
            frm.ShowDialog();
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerMaster frm = new CustomerMaster();
            frm.ShowDialog();
        }

        private void customerAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAccount frm = new CustomerAccount();
            frm.ShowDialog();
        }

        private void cashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashTransaction frm = new CashTransaction();
            frm.ShowDialog();
        }

        private void suppliersAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierAccount frm = new SupplierAccount();
            frm.ShowDialog();
        }

        private void ccustomerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportCustomerwise frm = new SalesReportCustomerwise();
            frm.ShowDialog();
        }

        private void customerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturnCustomerwise frm = new SalesReturnCustomerwise();
            frm.ShowDialog();
        }
    }
}
