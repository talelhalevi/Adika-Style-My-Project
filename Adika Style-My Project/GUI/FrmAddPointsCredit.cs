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
    public partial class FrmAddPointsCredit : Form
    {   
        private AddPointsCredit pcredit;
        private StatusKind statusFrm;
        

        public FrmAddPointsCredit()
        {
            InitializeComponent();
        }
        public FrmAddPointsCredit(StatusKind sta)
        {
            InitializeComponent();
            this.statusFrm = sta;
        }
          public AddPointsCredit BuildObjedtByField()
        {
            errorProvider1.Clear();
            pcredit = new AddPointsCredit();
            bool ok = true;
            try
            {
                 
                pcredit.CodeAddPoint = Convert.ToInt32(txtBcodeP.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBcodeP, ex.Message);
                ok = false;


            }
          
            try
            {
                pcredit.NumOfPoint = Convert.ToInt32(txtBNumP.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBNumP, ex.Message);
                ok = false;

            }
           
           
                pcredit.Status = true;
            

            if (ok)
                return pcredit;
            return null;
         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             pcredit = BuildObjedtByField();
             if (pcredit != null)
             {
                 DataRow dr = pcredit.BuildRow();
                 AddPointsCreditTable prodacts = new AddPointsCreditTable();
                 if (prodacts.Add(dr) == false)
                     MessageBox.Show("קיים במאגר");
                 else
                     MessageBox.Show("התווסף בהצלחה");


             
            }
        }
        private void FrmAddPointsCredit_Load(object sender, EventArgs e)
        {

        
        
        }

        private void FrmAddPointsCredit_Load_1(object sender, EventArgs e)
        {

            txtBcodeP.Text = new AddPointsCreditTable().GetNextCode().ToString();
        }

        private void txtBNumP_TextChanged(object sender, EventArgs e)
        {
     
           
        }

        private void txtBNumP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtBNumP.Text.Length > 4 && e.KeyChar != 8) e.Handled = true;
        }

        private void txtBcodeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
