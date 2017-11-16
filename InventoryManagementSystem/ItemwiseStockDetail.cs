using Microsoft.Reporting.WinForms;
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
    public partial class ItemwiseStockDetail : Form
    {
        public ItemwiseStockDetail()
        {
            InitializeComponent();
        }

        private void ItemwiseStockDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemMasterComboBrand._ItemMasterComboBrand' table. You can move, or remove it, as needed.
            this.itemMasterComboBrandTableAdapter.Fill(this.itemMasterComboBrand._ItemMasterComboBrand);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemwiseStockDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.itemWiseStockTableAdapter.Fill(this.itemwiseStock.ItemWiseStock,Convert.ToInt16(cmbBrandName.SelectedValue));

            this.rptStockItemwise.RefreshReport();
        }
    }
}
