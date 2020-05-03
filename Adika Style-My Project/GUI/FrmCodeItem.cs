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
    public partial class FrmCodeItem : Form
    {
        public FrmCodeItem()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FrmAddItem f = new FrmAddItem();
            f.Show();
        }
    }
}
