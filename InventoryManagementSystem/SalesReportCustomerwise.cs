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
    public partial class SalesReportCustomerwise : Form
    {
        public SalesReportCustomerwise()
        {
            InitializeComponent();
        }

        private void SalesReportCustomerwise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesComboCustomerName.SalesCustomerComboProcedure' table. You can move, or remove it, as needed.
            this.salesCustomerComboProcedureTableAdapter.Fill(this.salesComboCustomerName.SalesCustomerComboProcedure);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.rptCustomerwiseSalesTableAdapter.Fill(this.salesCustomerwiseRpt.RptCustomerwiseSales, Convert.ToInt16(cmbCustomerName.SelectedValue));

            this.rptCustomerwiseSales.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesReportCustomerwise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }
    }
}
