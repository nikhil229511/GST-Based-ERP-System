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
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class ItemMaster : Form
    {
        Global query = new Global();
        public ItemMaster()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemMaster_Load(object sender, EventArgs e)
        {
            cmbBrandName.SelectedValue = 0;
            // TODO: This line of code loads data into the 'itemMaster1.ItemMasterSelect' table. You can move, or remove it, as needed.
            this.itemMasterSelectTableAdapter.Fill(this.itemMaster1.ItemMasterSelect);
            // TODO: This line of code loads data into the 'itemMasterComboBrand._ItemMasterComboBrand' table. You can move, or remove it, as needed.
            this.itemMasterComboBrandTableAdapter.Fill(this.itemMasterComboBrand._ItemMasterComboBrand);
           
        }

        private void ItemMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("ItemMasterInsert", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DIMENSION", txtDimension.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@BRANDID", cmbBrandName.SelectedValue).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@CATEGORYID", cmbCategoryName.SelectedValue).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@DESCRIPTION", txtDescription.Text).DbType = DbType.String;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.itemMasterSelectTableAdapter.Fill(this.itemMaster1.ItemMasterSelect);
            
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("ItemMasterUpdate", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ITEMID", txtDimension.Tag).DbType = DbType.Int16;
                cmd.Parameters.AddWithValue("@DIMENSION", txtDimension.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@BRANDID", cmbBrandName.SelectedValue).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@CATEGORYID", cmbCategoryName.SelectedValue).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@DESCRIPTION", txtDescription.Text).DbType = DbType.String;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.itemMasterSelectTableAdapter.Fill(this.itemMaster1.ItemMasterSelect);
            
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
                SqlCommand cmd = new SqlCommand("ItemMasterDelete", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ITEMID", txtDimension.Tag).DbType = DbType.Int16;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.itemMasterSelectTableAdapter.Fill(this.itemMaster1.ItemMasterSelect);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryName.SelectedValue = 0;
            this.itemMasterCategoryComboProcedureTableAdapter.Fill(this.itemMasterCategoryCombo.ItemMasterCategoryComboProcedure,Convert.ToInt16(cmbBrandName.SelectedValue));
        }

        private void dgvItemMaster_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDimension.Tag = dgvItemMaster.CurrentRow.Cells[0].Value.ToString();
            txtDimension.Text = dgvItemMaster.CurrentRow.Cells[1].Value.ToString();
            cmbBrandName.SelectedValue = dgvItemMaster.CurrentRow.Cells[2].Value.ToString();
            cmbCategoryName.SelectedValue = dgvItemMaster.CurrentRow.Cells[4].Value.ToString();
            txtDescription.Text = dgvItemMaster.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
