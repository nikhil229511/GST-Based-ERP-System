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
    public partial class CashTransaction : Form
    {
        public CashTransaction()
        {
            InitializeComponent();
        }
        DateTime dt;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Global qry = new Global();
        private void CashTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtAmount.Text = "0";
                txtDescription.Text = "";
                txtVoucherNo.Text = "";
            }
            if (e.KeyCode == Keys.F4)
            {
                if(cmbType.SelectedIndex==0)
                {
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("CashMasterInsert", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VOUCHERNO", txtVoucherNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NATURE", cmbType.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DATE", dt).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CUSTOMERID", cmbCustomerName.SelectedValue).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SUPPLIERID", "0").DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@DESCRIPTION", txtDescription.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    qry.con.Close();

                    qry.insertMessage();
                    this.Close();
                }
                else if (cmbType.SelectedIndex == 1)
                {
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("CashMasterInsert", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VOUCHERNO", txtVoucherNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NATURE", cmbType.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DATE", dt).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CUSTOMERID", "0").DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SUPPLIERID", cmbSupplierName.SelectedValue).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@DESCRIPTION", txtDescription.Text).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    qry.con.Close();

                    qry.insertMessage();
                    this.Close();
                }
                
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                cmbSupplierName.Visible = false;
                cmbCustomerName.Visible = true;
            }
            else if (cmbType.SelectedIndex == 1)
            {
                cmbSupplierName.Visible = true;
                cmbCustomerName.Visible = false;
            }
        }

        private void CashTransaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listAllDebtors.ListAllDebitSupplier' table. You can move, or remove it, as needed.
            this.listAllDebitSupplierTableAdapter.Fill(this.listAllDebtors.ListAllDebitSupplier);
            // TODO: This line of code loads data into the 'listAllCreditors.ListAllCreditCustomer' table. You can move, or remove it, as needed.
            this.listAllCreditCustomerTableAdapter.Fill(this.listAllCreditors.ListAllCreditCustomer);
            dt = Convert.ToDateTime(dtpDate.Text.Substring(3, 2) + "/" + dtpDate.Text.Substring(0, 2) + "/" + dtpDate.Text.Substring(6, 4));
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dt = Convert.ToDateTime(dtpDate.Text.Substring(3, 2) + "/" + dtpDate.Text.Substring(0, 2) + "/" + dtpDate.Text.Substring(6, 4));
        }

        
    }
}
