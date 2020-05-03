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
    public partial class FrmCustomerByID : Form
    {
        private StatusKind statusKind;

        public FrmCustomerByID()
        {
            InitializeComponent();
        }

        public FrmCustomerByID(StatusKind statusKind)
        {
            // TODO: Complete member initialization
            this.statusKind = statusKind;
        }

        private void btnOpenCust_Click(object sender, EventArgs e)
        {
            CustomersTable c = new CustomersTable();
            DataRow dr = c.Find("IDCust", txtBId.Text);
            Customers cust = new Customers(dr);
            FrmCustomers f = new FrmCustomers(cust,statusKind);
            f.Show();
        }

        private void FrmCustomerByID_Load(object sender, EventArgs e)
        {

        }

        private void txtBId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
