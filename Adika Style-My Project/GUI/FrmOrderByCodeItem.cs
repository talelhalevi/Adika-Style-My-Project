using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adika_Style_My_Project.BLL;

namespace Adika_Style_My_Project.GUI
{
    public partial class FrmOrderByCodeItem : Form
    {
        private StatusKind statusKind;
        public FrmOrderByCodeItem()
        {
            InitializeComponent();
        }

        public FrmOrderByCodeItem(StatusKind statusKind)
        {
            this.statusKind = statusKind;
              
         }
             private void btnOrder_Click(object sender, EventArgs e)
        {
            OrdersTable c = new OrdersTable();
            DataRow dr = c.Find("CodeOrder", txtCodeOrder.Text);
            Orders ord = new Orders(dr);
            FrmOrder f = new FrmOrder(ord, statusKind);
            f.Show();
        }

             private void FrmOrderByCodeItem_Load(object sender, EventArgs e)
             {

             }
    }
}
