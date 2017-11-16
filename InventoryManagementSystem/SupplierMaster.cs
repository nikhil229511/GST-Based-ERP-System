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
    public partial class SupplierMaster : Form
    {
        Global query = new Global();
        public SupplierMaster()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierMaster1.SupplierMasterSelect' table. You can move, or remove it, as needed.
            this.supplierMasterSelectTableAdapter.Fill(this.supplierMaster1.SupplierMasterSelect);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("SupplierMasterInsert", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SUPPLIERNAME", txtSupplierName.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@SUPPLIERADDRESS", txtAddress.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@CONTACTPERSON", txtContactPerson.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@CONTACTNO", txtContactNo.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@GSTNO", txtGSTNo.Text).DbType = DbType.String;


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.supplierMasterSelectTableAdapter.Fill(this.supplierMaster1.SupplierMasterSelect);
           
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void SupplierMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("SupplierMasterUpdate", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SUPPLIERID", txtSupplierName.Tag).DbType = DbType.Int16;
                cmd.Parameters.AddWithValue("@SUPPLIERNAME", txtSupplierName.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@SUPPLIERADDRESS", txtAddress.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@CONTACTPERSON", txtContactPerson.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@CONTACTNO", txtContactNo.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@GSTNO", txtGSTNo.Text).DbType = DbType.String;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.supplierMasterSelectTableAdapter.Fill(this.supplierMaster1.SupplierMasterSelect);
            
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("SupplierMasterDelete", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SUPPLIERID", txtSupplierName.Tag).DbType = DbType.Int16;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.supplierMasterSelectTableAdapter.Fill(this.supplierMaster1.SupplierMasterSelect);
            
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

       

        private void dgvSupplierMaster_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSupplierName.Tag = dgvSupplierMaster.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = dgvSupplierMaster.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvSupplierMaster.CurrentRow.Cells[2].Value.ToString();
            txtContactPerson.Text = dgvSupplierMaster.CurrentRow.Cells[3].Value.ToString();
            txtContactNo.Text = dgvSupplierMaster.CurrentRow.Cells[4].Value.ToString();
            txtGSTNo.Text = dgvSupplierMaster.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
