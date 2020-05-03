using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adika_Style_My_Project.GUI
{
    public partial class FrmShop1 : Form
    {
        public FrmShop1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            FrmPurchase fp = new FrmPurchase();
            fp.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmShop_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
