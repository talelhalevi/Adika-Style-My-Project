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
    public partial class FrmCustomers : Form
    {
        private Customers cust;
        private StatusKind statusFrm;
        private Customers c;
        Customers myCust;
        public int ClosingOption { get; set; }
        public FrmCustomers()
        {
            InitializeComponent();
        }
        public FrmCustomers(Customers c)
        {
            InitializeComponent();
            myCust = c;
            FillFild(myCust);
        }

        public FrmCustomers(StatusKind sta)
        {
            InitializeComponent();
            this.statusFrm = sta;
        }
        public FrmCustomers( Customers c,StatusKind sta)
        {
            InitializeComponent();
            this.statusFrm = sta;
            myCust = c;
            FillFild(myCust);
        }


        public Customers BuildObjedtByField()
        {
            errorProvider1.Clear();
            cust = new Customers();
            bool ok = true;
            try
            {

                cust.IDCust1 = txtBID.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBID, ex.Message);
                ok = false;


            }
            try
            {
                cust.FirstNameCust1 = txtBFirst.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBFirst, ex.Message);
                ok = false;
            }
            try
            {
                cust.LustNameCust1 = txtBLust.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBPhon, ex.Message);
                ok = false;

            }
            try
            {
                cust.TPhoneCust1 = txtBTel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBTel, ex.Message);
                ok = false;

            }
            try
            {
                cust.PhoneCust1 = txtBPhon.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBPhon, ex.Message);
                ok = false;

            }
            try
            {
                cust.SityCust1 = txtBSity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBSity, ex.Message);
                ok = false;

            }
            try
            {
                cust.StreetCust1 = txtBStreet.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBStreet, ex.Message);
                ok = false;

            }
            try
            {
                cust.PostCode1 = txtBPost.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBPost, ex.Message);
                ok = false;

            }
            try
            {
                cust.HomeNum1 = txtBHome.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBHome, ex.Message);
                ok = false;

            }



            if (ok)
                return cust;
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            cust = BuildObjedtByField();
            if (cust != null)
            {
                DataRow dr = cust.BuildRow();
                CustomersTable prodacts = new CustomersTable();
                if (prodacts.Add(dr) == false)
                    MessageBox.Show("קיים במאגר");
                else
                {
                    MessageBox.Show("התווסף בהצלחה");
                    FrmShop1 shop = new FrmShop1(cust.IDCust1,cust.FirstNameCust1+cust.LustNameCust1);
                    shop.Show();
                    ClosingOption = 3;
                    this.Close();
                }
           
            
          //   bool isDetailsValid = true;
          ////check details validity
          //errorProvider1.Clear();
          ////check card number
          //if (txtNumCard.Text.Length < 9 )
          //{
          //    errorProvider1.SetError(txtNumCard, "מספר כרטיס לא תקין");
          //    isDetailsValid = false;
          //}  
          ////check owner id
          //if (txtBID.Text.Length < 9 || Helper.isId(txtBID.Text) == false)
          //{
          //    errorProvider1.SetError(txtBID, "תז לא תקינה");
          //    isDetailsValid = false;
          //}  
          ////check three card digits
          //if (txtBThree.Text.Length < 3 )
          //{
          //    errorProvider1.SetError(txtBThree, "עליך להקיש 3 ספרות");
          //    isDetailsValid = false;
          //}
          ////check card expire date
          //if (dtpValidate.Value.AddMonths(-Convert.ToInt32(nudNumOfPayments.Value-1)) < (DateTime.Now))
          //{
          //    errorProvider1.SetError(dtpValidate, "כרטיס אשראי לא בתוקף לעסקה המבוקשת");
          //    isDetailsValid = false;
          //}
          //if (isDetailsValid == true)
          //{
          //  bool b=  addOrderDetails();
          //  if (b == true)
          //  {
          //      MessageBox.Show("התשלום התבצע בהצלחה\n"+"סך הכל שולם:"+lblPaymentSum.Text);
          //      ClosingOption = 3;
          //      this.Close();
          //  }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            }


        }
        //cancel
        private void btnExit_Click(object sender, EventArgs e)
        {
            ClosingOption = 1;
            this.Close();
        }
        //תקינות תז
        private void txtBID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
            if (txtBID.Text.Length > 8 && e.KeyChar != 8) e.Handled = true;

        }
       //הכנסת אותיות בלבד
        private void txtBLust_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            this.c = BuildObjedtByField();
            if (c != null)
            {
                DataRow dr = c.BuildRow();
                CustomersTable customers = new CustomersTable();
                if (customers.Update(dr))
                {
                    MessageBox.Show("העידכון הושלם");
                }
                else
                    MessageBox.Show("הפעולה נכשלה");
            }
        }
        //back to prev form
        private void btnBack_Click(object sender, EventArgs e)
        {
            ClosingOption = 2;
            this.Close();
        }

        private void txtBLust_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtBSity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtBStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBTel_TextChanged(object sender, EventArgs e)
        {

        }
        //מספרים בלבד
        private void txtBTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtBTel.Text.Length > 15 && e.KeyChar != 8) e.Handled = true;

        }

        private void txtBPhon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtBPhon.Text.Length > 15 && e.KeyChar != 8) e.Handled = true;
        }

        private void txtBPost_KeyPress(object sender, KeyPressEventArgs e)
        {
                 
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtBPost.Text.Length > 7 && e.KeyChar != 8) e.Handled = true;
        }

        private void txtBHome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtBHome.Text.Length > 9 && e.KeyChar != 8) e.Handled = true;
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            if (statusFrm==StatusKind.update)
            {
                button2.Visible = true;
            }

            if (statusFrm==StatusKind.add)
            {
                btnAdd.Visible=true;
            }
            if (statusFrm == StatusKind.show)
            {
                btnAdd.Visible = false;
                button2.Visible = false;
        
            //    if (statusFrm == StatusKind.add) btnAdd.Visible = true;
            //    if (statusFrm == StatusKind.update)
            //    {
            //        btnUpdate.Visible = true;
                txtBID.Enabled = false;
            //    }
            }
        }
        public void FillFild(Customers aToWork)
        {
            txtBID.Text = aToWork.IDCust1.ToString();
            txtBFirst.Text = aToWork.FirstNameCust1.ToString();
            txtBLust.Text = aToWork.LustNameCust1.ToString();
            txtBPhon.Text = aToWork.PhoneCust1.ToString();
            txtBPost.Text = aToWork.PostCode1.ToString();
            txtBSity.Text = aToWork.SityCust1.ToString();
            txtBTel.Text = aToWork.TPhoneCust1.ToString();
            txtBStreet.Text = aToWork.StreetCust1.ToString();
            txtBHome.Text = aToWork.HomeNum1.ToString();
           
            //פיל פיילד לקומבו בוקס
            //comKind.DataSource = new ActivityKindsTable().GetTable();
            //comKind.DisplayMember = "nameKind";
            //comKind.ValueMember = "codeKind";
            //comKind.SelectedValue = aToWork.CodeKind;

            //comMan.DataSource = new MenActivitiesTable().GetTable();
            //comMan.DisplayMember = "NameMan";
            //comMan.ValueMember = "CodeMan";
            //comMan.SelectedValue = aToWork.CodeMan;

        }

     

        private void txtBSity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cust = BuildObjedtByField();
            if (cust != null)
            {
                DataRow dr = cust.BuildRow();
                CustomersTable prodacts = new CustomersTable();
                if (prodacts.Update(dr) == false)
                    MessageBox.Show("קיים במאגר");
                else
                {
                    MessageBox.Show("עודכן בהצלחה");
                    FrmShop1 shop = new FrmShop1(cust.IDCust1, cust.FirstNameCust1 + cust.LustNameCust1);
                    shop.Show();
                    ClosingOption = 3;
                    this.Close();
                }
            }

        }

        private void txtBPost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
