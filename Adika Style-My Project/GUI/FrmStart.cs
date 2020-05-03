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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
            DAL.DAL.ConnectToDB();
            btnExit.Click += new EventHandler(btnExit_Click);
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            FrmPurchase fp = new FrmPurchase();
            fp.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCode.Text=="208611814")
            {
                Form1 f1 = new Form1();
                f1.Show();
                txtCode.Text = "";
            }
            
        }


           

        private void btnShop_Click(object sender, EventArgs e)
        {
            FrmToShop fs = new FrmToShop();
            fs.Show();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
