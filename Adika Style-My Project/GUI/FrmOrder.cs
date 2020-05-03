using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adika_Style_My_Project.BLL;
using Adika_Style_My_Project.DAL;


namespace Adika_Style_My_Project.GUI
{
    public partial class FrmOrder : Form
    {

        private StatusKind statusFrm;
        private Orders o;
        Orders myord;
        private Orders ord;
        private StatusKind statusKind;
        public FrmOrder()
        {
            InitializeComponent();
        }
        public FrmOrder(Orders o)
        {
            InitializeComponent();
            myord = o;
            FillFild(myord);
        }

        public FrmOrder(Orders ord, StatusKind statusKind)
        {
            // TODO: Complete member initialization
            this.ord = ord;
            this.statusKind = statusKind;
        }

        public void FillFild(Orders aToWork)
        {
            //txtBID.Text = aToWork.CodeOrder.ToString();
            //txtBFirst.Text = aToWork..ToString();
            //txtBLust.Text = aToWork.LustNameCust1.ToString();
            //txtBPhon.Text = aToWork.PhoneCust1.ToString();
            //txtBPost.Text = aToWork.PostCode1.ToString();
            //txtBSity.Text = aToWork.SityCust1.ToString();
            //txtBTel.Text = aToWork.TPhoneCust1.ToString();
            //txtBStreet.Text = aToWork.StreetCust1.ToString();
            //txtBHome.Text = aToWork.HomeNum1.ToString();
           
        }

        private void txtBFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
