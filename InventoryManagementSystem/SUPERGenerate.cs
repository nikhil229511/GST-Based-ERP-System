using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class SUPERGenerate : Form
    {
        public SUPERGenerate()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;
        Microsoft.Win32.RegistryKey Key;
        
        private void SUPERGenerate_Load(object sender, EventArgs e)
        {
            txtProductID.Text = ComputerInfo.GetComputerId();
            cmbTime.SelectedIndex = 0;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime theDate = DateTime.Now;
            DateTime ExpiryDate = theDate.AddYears(cmbTime.SelectedIndex);

            


            Key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("FireSide\\MyProductKey");
            Key.SetValue("ProductID", txtProductID.Text);
            Key.SetValue("ExpiryDate", ExpiryDate.ToString("MM/dd/yyyy"));
            Key.Close();
            this.Close();
        }
    }
}
