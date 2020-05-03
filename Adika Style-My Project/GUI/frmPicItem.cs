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
    public partial class frmPicItem : Form
    {
        public frmPicItem()
        {
            InitializeComponent();
        }
        public frmPicItem(int code)
        {
            InitializeComponent();
            lbl.Text = code.ToString(); ;
        }

        private void frmPicItem_Load(object sender, EventArgs e)
        {
            //pic.image=Load(Application.Get
        }
    }
}
