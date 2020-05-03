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
    public partial class FrmCreditCardOfCustomers : FrmBasic
    {

        private CreditCardOfCustomers card; 
        private CreditCardOfCustomersTable cards;
        private StatusKind statusFrm;
        private Customers c;
        private int CreditCardDetailsCode;
        //properties for order details after comleting the pay proccess
        //-------
        public Orders OrderToAdd { get; set; }
        public List<ShoppingCartControl> ShoppingCartListItems{ get; set; }
        public int SumToPay { get; set; }
        public string CurrentCustomerId { get; set; }
        public string CurrentCustomerName { get; set; }
        //------
        //closing options:1=cancel,2=back to shopping cart,3=finish
        public int ClosingOption { get; set; }
        public FrmCreditCardOfCustomers()
        {
            InitializeComponent();
            cards = new CreditCardOfCustomersTable();
            CreditCardDetailsCode = cards.GetNextCode();
        }
        //מילוי פרטי הלקוח וסכום לתשלום בעת טעינת הטופס
        private void FrmCreditCardOfCustomers_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = CurrentCustomerName;
            lblPaymentSum.Text = SumToPay + "";
        }
        //cancel buying
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClosingOption = 1;
            this.Close();
        }
        //approve buying
        private void btnUpdate_Click(object sender, EventArgs e)
        {

           bool isDetailsValid = true;
          //check details validity
          errorProvider1.Clear();
          //check card number
          if (txtNumCard.Text.Length < 9 )
          {
              errorProvider1.SetError(txtNumCard, "מספר כרטיס לא תקין");
              isDetailsValid = false;
          }  
          //check owner id
          if (txtBID.Text.Length < 9  )
          {
                  
                  
              errorProvider1.SetError(txtBID, "נא הכנס תעודת זהות");
                   isDetailsValid = false;
          } 
              if (!Validition.correctId(txtBID.Text))
              {

                  errorProvider1.SetError(txtBID, "תעודת הזהות לא תקינה");
                  isDetailsValid = false;
              }

              errorProvider1.Clear();
          //check three card digits
          if (txtBThree.Text.Length < 3 )
          {
              errorProvider1.SetError(txtBThree, "עליך להקיש 3 ספרות");
              isDetailsValid = false;
          }
          //check card expire date
          if (dtpValidate.Value.AddMonths(-Convert.ToInt32(nudNumOfPayments.Value-1)) < (DateTime.Now))
          {
              errorProvider1.SetError(dtpValidate, "כרטיס אשראי לא בתוקף לעסקה המבוקשת");
              isDetailsValid = false;
          }
          if (isDetailsValid == true)
          {
            bool b=  addOrderDetails();
            if (b == true)
            {
                MessageBox.Show("התשלום התבצע בהצלחה\n"+"סך הכל שולם:"+lblPaymentSum.Text);
                ClosingOption = 3;
                this.Close();
            }
            else
            {
                MessageBox.Show("שגיאה בביצוע תשלום, מצטערים!!");
                ClosingOption = 1;
                this.Close();
            }
          } 
        }
        //add row for order, rows for order details and row for credit card.
        private bool addOrderDetails()
        {
            
            bool returnValue = true;
            int orderCode = 0;
            ItemStockTable itemStockT=new ItemStockTable();
            ItemsTable itemT = new ItemsTable();
            OrderDetailsTable orderDetailsT=new OrderDetailsTable();
            //add order



   


          
            try
            {
                OrdersTable ordersTable = new OrdersTable();
                DataRow rowToAdd = ordersTable.Dt.NewRow();
                DataRow currentRow = OrderToAdd.BuildRow();
                orderCode=int.Parse(currentRow["CodeOrder"].ToString());
                rowToAdd["CodeOrder"] = currentRow["CodeOrder"];
                rowToAdd["IDCust"] = currentRow["IDCust"];
                rowToAdd["DateOrder"] = currentRow["DateOrder"];
                returnValue=ordersTable.Add(rowToAdd);

            }
            catch (Exception)
            {
                returnValue=false;
            }
            //add order details
            OrderDetails detailToAdd;
            groupItemsList();
            foreach (var item in ShoppingCartListItems)
            {
                if (item.ItemAmount > 0)
                {
                   
                    detailToAdd = new OrderDetails();
                    detailToAdd.CodeOrder = orderCode;
                    detailToAdd.CodeItemStoke = itemStockT.getItemStockCode(item.ItemCode, item.ColorCode, item.SizeCode)+"";
                    //decrease amount of items in stock
                    returnValue = decreaseAmountOfItemInStock(int.Parse(detailToAdd.CodeItemStoke), item.ItemAmount);
                    detailToAdd.Amount = item.ItemAmount;
                    detailToAdd.PriceItem = itemT.getItemPrice(item.ItemCode);
                    detailToAdd.SaleItem = itemT.isSaleItem(item.ItemCode);
                    try
                    {
                        DataRow rowToAdd = detailToAdd.BuildRow();
                        returnValue = orderDetailsT.Add(rowToAdd);
                    }
                    catch (Exception)
                    {
                        returnValue = false;
                    }
                    
                }
            }
            //add credit card details
            CreditCardOfCustomers card = new CreditCardOfCustomers();
            CreditCardOfCustomersTable creditCardT=new CreditCardOfCustomersTable();
            card.CodeCreditCard = creditCardT.getNextCode();
            card.CodeOrder = orderCode;
            card.NumCreditCard = txtNumCard.Text;
            card.ValidityOfCreditCard = dtpValidate.Value;
            card.IdOwner = txtBID.Text;
            card.ThreeNumOnCard = int.Parse(txtBThree.Text);
            card.TotalOfPrice = lblPaymentSum.Text;
            card.NumOfPayments = (int)nudNumOfPayments.Value;
            card.KindOfDeal = "חיוב";
            DataRow rowToAddToCreditCardT = card.BuildRow();
            try
            {
                creditCardT.Add(rowToAddToCreditCardT);
            }
            catch (Exception)
            {
                returnValue = false;
            }
           

            return returnValue;
        }
        //decrease amount of item in stock
        private bool decreaseAmountOfItemInStock(int itemCode, int amountToDecrease)
        {
            ItemStockTable itemStockT = new ItemStockTable();
            DataRow rowToUpdate = itemStockT.Find("codeItemInStoke", itemCode+"");
            bool returnValue=true;
            if(rowToUpdate!=null)
            {
                int oldAmount = int.Parse(rowToUpdate["amountOfStoke"].ToString());
                 rowToUpdate["amountOfStoke"] = (oldAmount - amountToDecrease).ToString();
                 try
                 {
                     itemStockT.Update(rowToUpdate);
                 }
                 catch (Exception)
                 {
                     returnValue = false;
                 }
            }
            else
                returnValue=false;
            return returnValue;
          
        }
        //group the item stock list
        private void groupItemsList()
        {
            int listSize=ShoppingCartListItems.Count;
            for (int i = 0; i < listSize; i++)
            {
                if (ShoppingCartListItems[i].ItemAmount > 0)
                {
                    for (int j = i+1; j < listSize; j++)
                    {
                        if (ShoppingCartListItems[i].ItemCode == ShoppingCartListItems[j].ItemCode && ShoppingCartListItems[i].ColorCode == ShoppingCartListItems[j].ColorCode && ShoppingCartListItems[i].SizeCode == ShoppingCartListItems[j].SizeCode)
                        {
                            ShoppingCartListItems[i].ItemAmount += ShoppingCartListItems[j].ItemAmount;
                            ShoppingCartListItems[j].ItemAmount = 0;
                        }
                    } 
                }
                
            }
           
        }
        //enable only 3 numbers in txtBThree
        private void txtBThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar==8 ))
                e.Handled = true;
            if (txtBThree.Text.Length > 2 && e.KeyChar != 8) e.Handled = true;
        }
        //enable only 9 numbers in txtBID
        private void txtBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtBID.Text.Length > 8 && e.KeyChar != 8) e.Handled = true;
        }
        //enable only 16 numbers in txtNumCard
        private void txtNumCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
            if (txtNumCard.Text.Length > 15 && e.KeyChar != 8) e.Handled = true;
        }
        //back to shopping cart
        private void btnBack_Click(object sender, EventArgs e)
        {
            ClosingOption = 2;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPaymentSum_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenPoint_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void txtBThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
