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
    public partial class SUPERMain : Form
    {
        public SUPERMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SUPERGenerate frm = new SUPERGenerate();
            frm.ShowDialog();
        }

        

        private void btnAbout_Click(object sender, EventArgs e)
        {
            SUPERAbout frm = new SUPERAbout();
            frm.ShowDialog();
        }
    }
}
