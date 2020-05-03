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
    public partial class FrmToShop : FrmBasic
    {
        public FrmToShop()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //check id validity
            if (Helper.isId(txtCustId.Text) == false)
            {
                MessageBox.Show("תז לא תקינה");
                return;
            }  
            //check if customer exist
            CustomersTable cust = new CustomersTable();
            string name=cust.GetCustomerFullNameById(txtCustId.Text);
            if (name == null)
            {
                MessageBox.Show("לקוח לא קיים במאגר");
            }
            else
            {
                FrmShop1 shop = new FrmShop1(txtCustId.Text, name);
                shop.Show();
                this.Close();
            }
           
        }
        //add customer
        private void button2_Click(object sender, EventArgs e)
        {
            FrmCustomers addCust = new FrmCustomers();
            addCust.FormClosed += new FormClosedEventHandler(addCust_FormClosed);
            addCust.Show();
            this.Enabled = false;
        }
        //event of FrmCustomers closing
        void addCust_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCustomers form = sender as FrmCustomers;
            if (form != null)
            {
                if (form.ClosingOption == 1 || form.ClosingOption == 3)
                    this.Close();
                else
                {
                    this.Enabled = true;
                }
            }
        }
        //enable only 9 numbers in txtCustId
        private void txtCustId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtCustId.Text.Length > 8 && e.KeyChar != 8) e.Handled = true;
        }

        private void FrmToShop_Load(object sender, EventArgs e)
        {

        }
    }
}
