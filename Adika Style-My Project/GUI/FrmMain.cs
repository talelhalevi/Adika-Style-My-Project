using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adika_Style_My_Project.GUI;

namespace Adika_Style_My_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

       
        

        private void btnCreditCard_Click(object sender, EventArgs e)
        {

            FrmCreditCardOfCustomers f = new FrmCreditCardOfCustomers();
            f.Show();
        }

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void הוספתפריטToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddItem faddi = new FrmAddItem();
            faddi.Show();
        }

        private void הוספתזיכויToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddPointsCredit frm = new FrmAddPointsCredit(StatusKind.add);
            frm.Show();
        }

        private void לקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void הצגתרשימתפריטיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewItems f = new FrmViewItems();
            f.Show();
        }

        private void הצגתפרטיפריטToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewAllItems f = new FrmViewAllItems();
            f.Show();
        }

        private void הצגתרשימתצבעיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewColors fvc = new FrmViewColors();
            fvc.Show();
        }

        private void פריטיםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.DAL.DealWithReport("Report", "Orders.DateOrder='" + DateTime.Today.ToString() + "'");


        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void איתורפרטילקוחעיתזToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCustomerByID f = new FrmCustomerByID();
            f.Show();
            
        }

        private void הוספתלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomers f = new FrmCustomers();
            f.Show();
        }

        private void עידכוןפרטילקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmCustomerByID f = new FrmCustomerByID();
            f.Show();
        }

        private void מחיקתפריטToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewAllItems f = new FrmViewAllItems();
            f.Show();
          
        }

        private void הוספתצבעToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColors f = new FrmColors();
            f.Show();
        }

        private void הוספהלמלאיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddItemStock f = new FrmAddItemStock();
            f.Show();
        }

        private void עדכוןפרטיפריטToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmAddItem f = new FrmAddItem(StatusKind.update);
            f.Show();

        }

        private void קובץToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
