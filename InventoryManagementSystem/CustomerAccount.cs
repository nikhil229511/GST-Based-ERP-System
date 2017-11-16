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
    public partial class CustomerAccount : Form
    {
        public CustomerAccount()
        {
            InitializeComponent();
        }
        Global qry = new Global();
        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listAllCreditors.ListAllCreditCustomer' table. You can move, or remove it, as needed.
            this.listAllCreditCustomerTableAdapter.Fill(this.listAllCreditors.ListAllCreditCustomer);
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.customerSalesEntriesTableAdapter.Fill(this.customerSalesEntries._CustomerSalesEntries, Convert.ToInt16(cmbCustomerName.SelectedValue));
            this.customerPaymentEntriesTableAdapter.Fill(this.customerPaymentEntries._CustomerPaymentEntries, Convert.ToInt16(cmbCustomerName.SelectedValue));

            //Total Sales
            SqlCommand cmd = new SqlCommand("CustomerTotalSalesAmount", qry.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUSTOMERID", cmbCustomerName.SelectedValue).DbType = DbType.String;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                lblTotalSales.Text = ds.Tables[0].Rows[0]["TotalSales"].ToString();
            }
            else
            {
                lblTotalSales.Text = "0";
            }

            //Total  Paid by customer
            SqlCommand cmd1 = new SqlCommand("CustomerTotalPaidAmount", qry.con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@CUSTOMERID", cmbCustomerName.SelectedValue).DbType = DbType.String;

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
            decimal totsales=Convert.ToDecimal(lblTotalSales.Text);
            decimal totpaid = Convert.ToDecimal(lblTotalPaid.Text);
            decimal diff;
            if (totsales > totpaid)
            {
                diff = totsales - totpaid;
                lblTotalDue.Text = diff.ToString();
                lblAdvance.Text = "0";
            }
            else
            {
                diff = totpaid - totsales;
                lblTotalDue.Text = "0";
                lblAdvance.Text = diff.ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }
    }
}
