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
    public partial class PurchaseReturnReportSupplierwise : Form
    {
        public PurchaseReturnReportSupplierwise()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseReturnReportSupplierwise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void PurchaseReturnReportSupplierwise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchaseComboSupplier.PurchaseSupplierComboProcedure' table. You can move, or remove it, as needed.
            this.purchaseSupplierComboProcedureTableAdapter.Fill(this.purchaseComboSupplier.PurchaseSupplierComboProcedure);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.rptSupplierwisePurchaseReturnTableAdapter.Fill(this.purchaseReturnSupplierwiseRpt.RptSupplierwisePurchaseReturn,Convert.ToInt16(cmbSupplierName.SelectedValue));
            this.rptPurchaseReturnSupplierwise.RefreshReport();
        }
    }
}
