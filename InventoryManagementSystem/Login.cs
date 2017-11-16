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
using FoxLearn.License;

namespace InventoryManagementSystem
{
    public partial class Login : Form
    {
        Global query = new Global();
        String ProductID=null;
        Microsoft.Win32.RegistryKey Key;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //EXPIRY
            DateTime today = DateTime.Now;
            DateTime ExpiryDate = Convert.ToDateTime(Key.GetValue("ExpiryDate").ToString());
            if (ExpiryDate <= today)
            {
                MessageBox.Show("Your Yearly contract has been expired. Please Contact the Software provider.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }




            Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("FireSide\\MyProductKey",false);
            
            SqlCommand cmd = new SqlCommand("LoginMasterProcedure", query.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text).DbType = DbType.String;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                /*superuser*/
                if ((ds.Tables[0].Rows[0]["Username"].ToString().Equals("SuperUser")) && (ds.Tables[0].Rows[0]["Password"].ToString().Equals("SuperUser")))
                {
                    SUPERMain frm = new SUPERMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                /*Normal User*/
                else if (ds.Tables[0].Rows.Count > 0)
                {
                    try
                    {
                        //check product key
                        if (Key.GetValue("ProductID").ToString() == ProductID)
                        {
                            MainTerminal frm = new MainTerminal();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Fatal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Fatal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Login Credential.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Login Credential.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ProductID = ComputerInfo.GetComputerId();
            Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("FireSide\\MyProductKey", false);
            

            
        }
    }
}
