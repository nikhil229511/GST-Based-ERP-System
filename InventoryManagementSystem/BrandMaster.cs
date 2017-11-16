using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class BrandMaster : Form
    {
        Global query = new Global();
        public BrandMaster()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("BrandMasterInsert", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BRANDNAME", txtBrandName.Text).DbType = DbType.String;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.brandMasterSelectTableAdapter.Fill(this.brandMaster1.BrandMasterSelect);
                query.insertMessage();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }       
        }

        private void BrandMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brandMaster1.BrandMasterSelect' table. You can move, or remove it, as needed.
            this.brandMasterSelectTableAdapter.Fill(this.brandMaster1.BrandMasterSelect);
            
        }

        private void dgvBrandMaster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBrandName.Text = dgvBrandMaster.CurrentRow.Cells[1].Value.ToString();
            txtBrandName.Tag = dgvBrandMaster.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("BrandMasterUpdate", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BRANDID", txtBrandName.Tag).DbType = DbType.Int16;
                cmd.Parameters.AddWithValue("@BRANDNAME", txtBrandName.Text).DbType = DbType.String;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.brandMasterSelectTableAdapter.Fill(this.brandMaster1.BrandMasterSelect);
                query.updateMessage();

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
                SqlCommand cmd = new SqlCommand("BrandMasterDelete", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BRANDID", txtBrandName.Tag).DbType = DbType.Int16;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.brandMasterSelectTableAdapter.Fill(this.brandMaster1.BrandMasterSelect);
                query.deleteMessage();
            
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
                
        }

        private void BrandMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

    }
}
