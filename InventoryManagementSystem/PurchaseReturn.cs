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
    public partial class PurchaseReturn : Form
    {
        Global qry = new Global();
        int flag = 0;
        DateTime dt;
        public static string PurchaseReturnInvoiceNo = "";
        string pid = null;
        decimal amt, netamt, grandtotal, cgstamt, sgstamt, igstamt, totalgst;

        public PurchaseReturn()
        {
            InitializeComponent();
        }

        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            dt = Convert.ToDateTime(dtpPurchaseReturnDate.Text.Substring(3, 2) + "/" + dtpPurchaseReturnDate.Text.Substring(0, 2) + "/" + dtpPurchaseReturnDate.Text.Substring(6, 4));
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
                SqlCommand cmd = new SqlCommand("PurchaseReturnMasterDelete", qry.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PURCHASERETURNID", pid).DbType = DbType.Int16;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                qry.con.Close();

                qry.con.Open();
                SqlCommand cmd1 = new SqlCommand("PurchaseReturnDetailAbort", qry.con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@ID", pid).DbType = DbType.Int16;
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                qry.con.Close();

                this.Close();
            }
        }

        private void PurchaseReturn_KeyDown(object sender, KeyEventArgs e)
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
                    SqlCommand cmd = new SqlCommand("PurchaseReturnMasterDelete", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PURCHASERETURNID", pid).DbType = DbType.Int16;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    qry.con.Close();

                    qry.con.Open();
                    SqlCommand cmd1 = new SqlCommand("PurchaseReturnDetailAbort", qry.con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@ID", pid).DbType = DbType.Int16;
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    qry.con.Close();

                    this.Close();
                }
            }
            if (e.KeyCode == Keys.F4)
            {

                if (panel4.Visible == false)
                {
                    qry.con.Open();
                    SqlCommand cmd = new SqlCommand("PurchaseReturnMasterInsert", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PURCHASERETURNDATE", dt).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@INVOICENO", txtInvoiceNo.Text).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SUPPLIERID", cmbSupplierName.SelectedValue).DbType = DbType.Int16;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    SqlCommand cmd1 = new SqlCommand("Select Ident_Current('PurchaseReturnMaster')", qry.con);
                    pid = cmd1.ExecuteScalar().ToString();
                    cmd1.Dispose();
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
                        SqlCommand cmd = new SqlCommand("PurchaseReturnItemDetailInsert", qry.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PURCHASERETURNID", pid).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@ITEMID", cmbItemName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@CATEGORYID", cmbCategoryName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@BRANDID", cmbBrandName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@QUANTITY", txtQuantity.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@RATE", txtRate.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        qry.con.Close();
                        this.purchaseReturnItemDetailSelectTableAdapter.Fill(this.purchaseReturn1.PurchaseReturnItemDetailSelect, Convert.ToInt16(pid));

                        txtQuantity.Text = "0";
                        txtRate.Text = "0";
                        txtAmount.Text = "0";
                    }


                    else
                    {
                        qry.con.Open();
                        SqlCommand cmd = new SqlCommand("PurchaseReturnItemDetailUpdate", qry.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PURCHASERETURNDETAILID", cmbBrandName.Tag).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@PURCHASERETURNID", pid).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@ITEMID", cmbItemName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@CATEGORYID", cmbCategoryName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@BRANDID", cmbBrandName.SelectedValue).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@QUANTITY", txtQuantity.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@RATE", txtRate.Text).DbType = DbType.String;
                        cmd.Parameters.AddWithValue("@AMOUNT", txtAmount.Text).DbType = DbType.String;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        qry.con.Close();


                        this.purchaseReturnItemDetailSelectTableAdapter.Fill(this.purchaseReturn1.PurchaseReturnItemDetailSelect, Convert.ToInt16(pid));
                        txtQuantity.Text = "0";
                        txtRate.Text = "0";
                        txtAmount.Text = "0";

                    }
                }
            }

            else if (e.KeyCode == Keys.Escape)
            {

                amt = 0;
                //cbBrandName.SelectedValue = "";
                //cbCategoryName.SelectedValue = "";
                //cbItemName.SelectedValue = "";
                cmbBrandName.Tag = null;
                txtAmount.Text = "0";
                txtQuantity.Text = "0";
                txtRate.Text = "0";
            }
            else if (e.KeyCode == Keys.Delete)
            {
                qry.con.Open();
                SqlCommand cmd = new SqlCommand("PurchaseReturnItemDetailDelete", qry.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PURCHASERETURNID", cmbBrandName.Tag).DbType = DbType.String;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                qry.con.Close();
                this.purchaseReturnItemDetailSelectTableAdapter.Fill(this.purchaseReturn1.PurchaseReturnItemDetailSelect, Convert.ToInt16(pid));
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

                    SqlCommand cmd = new SqlCommand("PurchaseReturnItemTotalAmount", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PURCHASERETURNTOTALAMOUNTID", pid).DbType = DbType.Int16;

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
                    SqlCommand cmd = new SqlCommand("PurchaseReturnMasterUpdate", qry.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PURCHASERETURNID", pid).DbType = DbType.Int16;
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

                    //ask for print invoice.
                    DialogResult dialogResult = MessageBox.Show("DO you want to Print Receipt?", "Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PurchaseReturnInvoiceNo = txtInvoiceNo.Text;
                        PrintPurchaseReturnInvoice frm = new PrintPurchaseReturnInvoice();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }

                    /*flag = 0;
                    pid = "0";

                    txtQuantity.Text = "0";
                    txtRate.Text = "0";
                    txtAmount.Text = "0";
                    cmbBrandName.Tag = null;


                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel4.Enabled = true;
                    panel2.Enabled = true;
                    */
                }
            }

            else if (e.KeyCode == Keys.F3)
            {
                cmbBrandName.Tag = dgvPurchaseReturnDetail.CurrentRow.Cells[0].Value.ToString();
                cmbBrandName.SelectedValue = dgvPurchaseReturnDetail.CurrentRow.Cells[4].Value.ToString();
                cmbCategoryName.SelectedValue = dgvPurchaseReturnDetail.CurrentRow.Cells[6].Value.ToString();
                cmbItemName.SelectedValue = dgvPurchaseReturnDetail.CurrentRow.Cells[2].Value.ToString();
                txtQuantity.Text = dgvPurchaseReturnDetail.CurrentRow.Cells[8].Value.ToString();
                txtRate.Text = dgvPurchaseReturnDetail.CurrentRow.Cells[9].Value.ToString();
                txtAmount.Text = dgvPurchaseReturnDetail.CurrentRow.Cells[10].Value.ToString();
            }

        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            cmbSupplierName.SelectedValue = 0;
            cmbBrandName.SelectedValue = 0;
            // TODO: This line of code loads data into the 'purchaseReturnComboBrand.PurchaseReturnBrandComboProcedure' table. You can move, or remove it, as needed.
            this.purchaseReturnBrandComboProcedureTableAdapter.Fill(this.purchaseReturnComboBrand.PurchaseReturnBrandComboProcedure);
            // TODO: This line of code loads data into the 'purchaseReturnComboSupplier.PurchaseReturnSupplierComboProcedure' table. You can move, or remove it, as needed.
            this.purchaseReturnSupplierComboProcedureTableAdapter.Fill(this.purchaseReturnComboSupplier.PurchaseReturnSupplierComboProcedure);

            dt = Convert.ToDateTime(dtpPurchaseReturnDate.Text.Substring(3, 2) + "/" + dtpPurchaseReturnDate.Text.Substring(0, 2) + "/" + dtpPurchaseReturnDate.Text.Substring(6, 4));

            this.purchaseReturnItemDetailSelectTableAdapter.Fill(this.purchaseReturn1.PurchaseReturnItemDetailSelect, Convert.ToInt16(pid));
        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryName.SelectedValue = 0;
            this.purchaseReturnCategoryComboProcedureTableAdapter.Fill(this.purchaseReturnComboCategory.PurchaseReturnCategoryComboProcedure,Convert.ToInt16(cmbBrandName.SelectedValue));
        }

        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItemName.SelectedValue = 0;
            this.purchaseReturnItemComboProcedureTableAdapter.Fill(this.purchaseReturnComboItem.PurchaseReturnItemComboProcedure, Convert.ToInt16(cmbBrandName.SelectedValue), Convert.ToInt16(cmbCategoryName.SelectedValue));
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtRate.Text !="")
            {
                amt = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtRate.Text);
                txtAmount.Text = Convert.ToString(amt);
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text != "" && txtRate.Text!="")
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
    }
}
