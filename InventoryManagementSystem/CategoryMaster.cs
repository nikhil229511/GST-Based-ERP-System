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
    public partial class CategoryMaster : Form
    {
        Global query = new Global();
        public CategoryMaster()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryMaster_Load(object sender, EventArgs e)
        {
            cmbBrand.SelectedValue = 0;
            // TODO: This line of code loads data into the 'categoryComboBrand._CategoryComboBrand' table. You can move, or remove it, as needed.
            this.categoryComboBrandTableAdapter.Fill(this.categoryComboBrand._CategoryComboBrand);
            // TODO: This line of code loads data into the 'categoryMaster1.CategoryMasterSelect' table. You can move, or remove it, as needed.
            this.categoryMasterSelectTableAdapter.Fill(this.categoryMaster1.CategoryMasterSelect);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("CategoryMasterInsert", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CATEGORYNAME", txtCategoryName.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@BRANDID", cmbBrand.SelectedValue).DbType = DbType.Int16;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.categoryMasterSelectTableAdapter.Fill(this.categoryMaster1.CategoryMasterSelect);
                query.insertMessage();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void dgvCategoryMaster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCategoryName.Tag = dgvCategoryMaster.CurrentRow.Cells[2].Value.ToString();
            txtCategoryName.Text = dgvCategoryMaster.CurrentRow.Cells[3].Value.ToString();
            cmbBrand.SelectedValue = dgvCategoryMaster.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query.con.Open();
                SqlCommand cmd = new SqlCommand("CategoryMasterUpdate", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CATEGORYID", txtCategoryName.Tag).DbType = DbType.Int16;
                cmd.Parameters.AddWithValue("@CATEGORYNAME", txtCategoryName.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@BRANDID", cmbBrand.SelectedValue).DbType = DbType.Int16;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.categoryMasterSelectTableAdapter.Fill(this.categoryMaster1.CategoryMasterSelect);
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
                SqlCommand cmd = new SqlCommand("CategoryMasterDelete", query.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CATEGORYID", txtCategoryName.Tag).DbType = DbType.Int16;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                query.con.Close();
                this.categoryMasterSelectTableAdapter.Fill(this.categoryMaster1.CategoryMasterSelect);
                query.deleteMessage();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void CategoryMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
            }
        }
    }
}
