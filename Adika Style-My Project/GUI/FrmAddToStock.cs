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
    public partial class FrmAddToStock : Form
    {
        int code;
        private string p;
        public FrmAddToStock()
        {
            InitializeComponent();
        }
        public FrmAddToStock(int code)
        {
            this.code = code;
            InitializeComponent();
        }

        public FrmAddToStock(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
          //  מתנקה הכל
        }
    }
}
