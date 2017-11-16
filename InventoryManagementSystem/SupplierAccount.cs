using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class SupplierAccount : Form
    {
        public SupplierAccount()
        {
            InitializeComponent();
        }
        Global qry = new Global();

        private void SupplierAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listAllDebtors.ListAllDebitSupplier' table. You can move, or remove it, as needed.
            this.listAllDebitSupplierTableAdapter.Fill(this.listAllDebtors.ListAllDebitSupplier);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.supplierPurchaseEntriesTableAdapter.Fill(this.supplierPurchaseEntries._SupplierPurchaseEntries, Convert.ToInt16(cmbSupplierName.SelectedValue));
            this.supplierReceiptEntriesTableAdapter.Fill(this.supplierReceiptEntries ._SupplierReceiptEntries, Convert.ToInt16(cmbSupplierName.SelectedValue));

            //Total purchase
            SqlCommand cmd = new SqlCommand("SupplierTotalPurchaseAmount", qry.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUPPLIERID", cmbSupplierName.SelectedValue).DbType = DbType.String;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                lblTotalPurchase.Text = ds.Tables[0].Rows[0]["TotalPurchase"].ToString();
            }
            else
            {
                lblTotalPurchase.Text = "0";
            }

            //Total  Paid by us
            SqlCommand cmd1 = new SqlCommand("SupplierTotalPaidAmount", qry.con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@SUPPLIERID", cmbSupplierName.SelectedValue).DbType = DbType.String;

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count > 0)
            {
                lblTotalPaid.Text = ds1.Tables[0].Rows[0]["TotalPaid"].ToString();
            }
            else
            {
                lblTotalPaid.Text = "0";
            }

            //Total Due or Advance
            decimal totPurchase = Convert.ToDecimal(lblTotalPurchase.Text);
            decimal totpaid = Convert.ToDecimal(lblTotalPaid.Text);
            decimal diff;
            if (totPurchase> totpaid)
            {
                diff = totPurchase- totpaid;
                lblTotalDue.Text = diff.ToString();
                lblAdvance.Text = "0";
            }
            else
            {
                diff = totpaid - totPurchase;
                lblTotalDue.Text = "0";
                lblAdvance.Text = diff.ToString();
            }

        }
    }
}
