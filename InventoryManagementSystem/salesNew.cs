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
    public partial class SalesNew : Form
    {
        Global qry = new Global();
        int flag = 0;
        DateTime dt;
        public static string SalesInvoiceNo = "";
        string pid = null;
        string cid = null;
        decimal amt, netamt, grandtotal, cgstamt, sgstamt, igstamt, totalgst;

        public SalesNew()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                this.Close();
            }
            else
            {
                qry.con.Open();
                SqlCommand cmd = new SqlCommand("SalesMasterDelete", qry.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.Int16;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                qry.con.Close();

                qry.con.Open();
                SqlCommand cmd1 = new SqlCommand("SalesDetailAbort", qry.con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.Int16;
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                qry.con.Close();

                this.Close();
            }
        }

        private void dtpSalesDate_ValueChanged(object sender, EventArgs e)
        {
            dt = Convert.ToDateTime(dtpSalesDate.Text.Substring(3, 2) + "/" + dtpSalesDate.Text.Substring(0, 2) + "/" + dtpSalesDate.Text.Substring(6, 4));
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesComboBrand.SalesBrandComboProcedure' table. You can move, or remove it, as needed.
            this.salesBrandComboProcedureTableAdapter.Fill(this.salesComboBrand.SalesBrandComboProcedure);
            // TODO: This line of code loads data into the 'salesComboCustomerName.SalesCustomerComboProcedure' table. You can move, or remove it, as needed.
            this.salesCustomerComboProcedureTableAdapter.Fill(this.salesComboCustomerName.SalesCustomerComboProcedure);

            this.salesDetailItemSelectTableAdapter.Fill(this.sales.SalesDetailItemSelect,Convert.ToInt16(pid));
            cmbIsCash.SelectedValue= 0;
            cmbType.SelectedValue = 0;
            cmbBrandName.SelectedValue = 0;
            dt = Convert.ToDateTime(dtpSalesDate.Text.Substring(3, 2) + "/" + dtpSalesDate.Text.Substring(0, 2) + "/" + dtpSalesDate.Text.Substring(6, 4));
        }

        private void Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                if (flag == 0)
                {
                    this.Close();
                }
                else
                {
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("SalesMasterDelete", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.Int16;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    qry.con.Close();

                    qry.con.Open();
                    SqlCommand cmd1 = new SqlCommand("SalesDetailAbort", qry.con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.Int16;
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    qry.con.Close();

                    this.Close();
                }
            }

            if (e.KeyCode == Keys.F4)
            {

                if (panel4.Visible == false && cmbIsCash.SelectedIndex==0)
                {
                    //Entry in CustomerMaster
                    qry.con.Open();
                    SqlCommand cmd1 = new SqlCommand("CustomerMasterInsert", qry.con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@NAME", txtName.Text).DbType = DbType.String;
                    cmd1.Parameters.AddWithValue("@ADDRESS", txtAddress.Text).DbType = DbType.String;
                    cmd1.Parameters.AddWithValue("@CONTACTPERSON", txtName.Text).DbType = DbType.String;
                    cmd1.Parameters.AddWithValue("@CONTACTNO", txtContact.Text).DbType = DbType.String;
                    cmd1.Parameters.AddWithValue("@GSTNO", txtGSTNo.Text).DbType = DbType.String;
                    
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    
                    //taking id of customer
                    SqlCommand cmd3 = new SqlCommand("Select Ident_Current('CustomerMaster')", qry.con);
                    cid = cmd3.ExecuteScalar().ToString();
                    cmd3.Dispose();
                    qry.con.Close();

                    //Entry in SalesMaster
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("SalesMasterInsert", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SALESDATE", dt).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@INVOICENO", txtInvoiceNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ISCASH", "YES").DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CUSTOMERID", cid).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    SqlCommand cmd2 = new SqlCommand("Select Ident_Current('SalesMaster')", qry.con);
                    pid = cmd2.ExecuteScalar().ToString();
                    cmd2.Dispose();
                    qry.con.Close();

                    flag = 1;
                    panel4.Visible = true;
                    panel2.Enabled = false;

                }
                else if (panel4.Visible == false && cmbIsCash.SelectedIndex == 1)
                {
                    
                    //Entry in SalesMaster
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("SalesMasterInsert", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SALESDATE", dt).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@INVOICENO", txtInvoiceNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ISCASH", "NO").DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CUSTOMERID", cmbCustomerName.SelectedValue).DbType = DbType.String;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    SqlCommand cmd2 = new SqlCommand("Select Ident_Current('SalesMaster')", qry.con);
                    pid = cmd2.ExecuteScalar().ToString();
                    cmd2.Dispose();
                    qry.con.Close();

                    flag = 1;
                    panel4.Visible = true;
                    panel2.Enabled = false;

                }



                else if (panel4.Visible == true && panel2.Enabled == false)
                {
                    if (cmbBrandName.Tag == null)
                    {
                        qry.con.Open();
                        SqlCommand cmd = new SqlCommand("SalesDetailItemInsert", qry.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@ITEMID", cmbItemName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@CATEGORYID", cmbCategoryName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@BRANDID", cmbBrandName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@QUANTITY", txtQuantity.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@RATE", txtRate.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        qry.con.Close();
                        this.salesDetailItemSelectTableAdapter.Fill(this.sales.SalesDetailItemSelect, Convert.ToInt16(pid));

                        txtQuantity.Text = "0";
                        txtRate.Text = "0";
                        txtAmount.Text = "0";
                    }


                    else
                    {
                        qry.con.Open();
                        SqlCommand cmd = new SqlCommand("SalesDetailItemUpdate", qry.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SALESDETAILID", cmbBrandName.Tag).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@ITEMID", cmbItemName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@CATEGORYID", cmbCategoryName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@BRANDID", cmbBrandName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@QUANTITY", txtQuantity.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@RATE", txtRate.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        qry.con.Close();


                        this.salesDetailItemSelectTableAdapter.Fill(this.sales.SalesDetailItemSelect, Convert.ToInt16(pid));
                        txtQuantity.Text = "0";
                        txtRate.Text = "0";
                        txtAmount.Text = "0";

                    }
                }
            }

            else if (e.KeyCode == Keys.Escape)
            {

                amt = 0;
                cmbBrandName.Tag = null;
                txtAmount.Text = "0";
                txtQuantity.Text = "0";
                txtRate.Text = "0";
            }
            
            else if (e.KeyCode == Keys.Delete)
            {
                qry.con.Open();
                SqlCommand cmd = new SqlCommand("SalesDetailItemDelete", qry.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SAlESDETAILID", cmbBrandName.Tag).DbType = DbType.String;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                qry.con.Close();
                this.salesDetailItemSelectTableAdapter.Fill(this.sales.SalesDetailItemSelect, Convert.ToInt16(pid));
                amt = 0;
                txtQuantity.Text = "0";
                txtRate.Text = "0";
                txtAmount.Text = "0";
                cmbBrandName.Tag = null;
            }

            else if (e.KeyCode == Keys.F5)
            {
                if (panel4.Visible == true)
                {
                    panel5.Visible = true;
                    panel4.Enabled = false;

                    SqlCommand cmd = new SqlCommand("SalesItemTotalAmount", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SALESTOTALAMOUNTID", pid).DbType = DbType.Int16;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    netamt = Convert.ToDecimal(ds.Tables[0].Rows[0][0].ToString());
                    txtTaxableAmt.Text = Convert.ToString(netamt);
                }
            }

            else if (e.KeyCode == Keys.F6)
            {
                if (panel5.Visible == true)
                {
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("SalesMasterUpdate", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SALESID", pid).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@CGSTAMT", txtCGSTAmt.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CGSTRATE", txtCGSTRate.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SGSTRATE", txtSGSTRate.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SGSTAMT", txtSGSTAmt.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IGSTRATE", txtIGSTRate.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IGSTAMT", txtIGSTAmt.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TAXABLEAMT", txtTaxableAmt.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TOTALGST", txtTotalGST.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GRANDTOTAL", txtGrandTotal.Text).DbType = DbType.String;


                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    qry.con.Close();

                    flag = 0;
                    pid = null;

                    //ask for print invoice.
                    DialogResult dialogResult = MessageBox.Show("DO you want to Print Receipt?", "Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SalesInvoiceNo = txtInvoiceNo.Text;
                        PrintSalesInvoice frm = new PrintSalesInvoice();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }

                    /*txtQuantity.Text = "0";
                    txtRate.Text = "0";
                    txtAmount.Text = "0";
                    cmbBrandName.Tag = null;


                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel4.Enabled = true;
                    panel2.Enabled = true;
                    this.Close();*/
                }
            }

            else if (e.KeyCode == Keys.F3)
            {
                cmbBrandName.Tag = dgvSalesDetail.CurrentRow.Cells[0].Value.ToString();
                cmbBrandName.SelectedValue = dgvSalesDetail.CurrentRow.Cells[4].Value.ToString();
                cmbCategoryName.SelectedValue = dgvSalesDetail.CurrentRow.Cells[6].Value.ToString();
                cmbItemName.SelectedValue = dgvSalesDetail.CurrentRow.Cells[2].Value.ToString();
                txtQuantity.Text = dgvSalesDetail.CurrentRow.Cells[8].Value.ToString();
                txtRate.Text = dgvSalesDetail.CurrentRow.Cells[9].Value.ToString();
                txtAmount.Text = dgvSalesDetail.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryName.SelectedValue = 0;
            this.salesCategoryComboProcedureTableAdapter.Fill(this.salesComboCategory.SalesCategoryComboProcedure,Convert.ToInt16(cmbBrandName.SelectedValue));
        }

        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItemName.SelectedValue = 0;
            this.salesItemComboProcedureTableAdapter.Fill(this.salesComboItem.SalesItemComboProcedure, Convert.ToInt16(cmbBrandName.SelectedValue), Convert.ToInt16(cmbCategoryName.SelectedValue));
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text != "" && txtQuantity.Text!="")
            {
                amt = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                txtAmount.Text = Convert.ToString(amt);
            }
        }

        private void txtCGSTRate_TextChanged(object sender, EventArgs e)
        {
            if (txtCGSTRate.Text != "")
            {
                cgstamt = (Convert.ToDecimal(txtCGSTRate.Text) / Convert.ToDecimal(100)) * Convert.ToDecimal(netamt);
                txtCGSTAmt.Text = Convert.ToString(cgstamt);

                totalgst = Convert.ToDecimal(cgstamt) + Convert.ToDecimal(sgstamt) + Convert.ToDecimal(igstamt);
                txtTotalGST.Text = Convert.ToString(totalgst);


                grandtotal = Convert.ToDecimal(totalgst) + Convert.ToDecimal(netamt);
                txtGrandTotal.Text = Convert.ToString(grandtotal);
            }
        }

        private void txtSGSTRate_TextChanged(object sender, EventArgs e)
        {
            if (txtSGSTRate.Text != "")
            {
                sgstamt = (Convert.ToDecimal(txtSGSTRate.Text) / Convert.ToDecimal(100)) * Convert.ToDecimal(netamt);
                txtSGSTAmt.Text = Convert.ToString(sgstamt);

                totalgst = Convert.ToDecimal(cgstamt) + Convert.ToDecimal(sgstamt) + Convert.ToDecimal(igstamt);
                txtTotalGST.Text = Convert.ToString(totalgst);


                grandtotal = Convert.ToDecimal(totalgst) + Convert.ToDecimal(netamt);
                txtGrandTotal.Text = Convert.ToString(grandtotal);
            }
        }

        private void txtIGSTRate_TextChanged(object sender, EventArgs e)
        {
            if (txtIGSTRate.Text != "")
            {
                igstamt = (Convert.ToDecimal(txtIGSTRate.Text) / Convert.ToDecimal(100)) * Convert.ToDecimal(netamt);
                txtIGSTAmt.Text = Convert.ToString(igstamt);

                totalgst = Convert.ToDecimal(cgstamt) + Convert.ToDecimal(sgstamt) + Convert.ToDecimal(igstamt);
                txtTotalGST.Text = Convert.ToString(totalgst);


                grandtotal = Convert.ToDecimal(totalgst) + Convert.ToDecimal(netamt);
                txtGrandTotal.Text = Convert.ToString(grandtotal);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtRate.Text!="")
            {
                amt = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                txtAmount.Text = Convert.ToString(amt);
            }
        }

        private void cmbIsCash_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIsCash.SelectedIndex==0)
            {
                dtpSalesDate.Enabled = true;
                txtName.Enabled = true;
                txtContact.Enabled = true;
                txtAddress.Enabled = true;
                txtInvoiceNo.Enabled = true;
                cmbType.Enabled = false;
                txtGSTNo.Enabled = true;
            }
            else if(cmbIsCash.SelectedIndex==1)
            {
                cmbType.Enabled = true;
                dtpSalesDate.Enabled = false;
                txtName.Enabled = false;
                txtContact.Enabled = false;
                txtAddress.Enabled = false;
                txtInvoiceNo.Enabled = false;
                txtGSTNo.Enabled = false;
            }
        }

        private void cmbType_Leave(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 1)
            {
                CustomerMaster frm = new CustomerMaster();
                frm.ShowDialog();
                cmbType.SelectedIndex = 0;
            }
            else if (cmbType.SelectedIndex == 0)
            {
                txtName.Visible = false;
                cmbCustomerName.Visible = true;
                dtpSalesDate.Enabled = true;
                //txtName.Enabled = true;
                //txtContact.Enabled = true;
                //txtAddress.Enabled = true;
                txtInvoiceNo.Enabled = true;
                cmbIsCash.Enabled = false;

            }
        }
    }
}
