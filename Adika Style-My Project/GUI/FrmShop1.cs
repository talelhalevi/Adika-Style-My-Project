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
    public partial class FrmShop1 : Form
    {
        public ItemsTable itemTable { get; set; }
        public int YLocationInShoppingCartPanel { get; set; }
        public List<ShoppingCartControl> shoppingCartListItems { get; set; }
        public int shoppingCartListItemsCount { get; set; }
        public string CurrentCustomerId { get; set; }
        public string CurrentCustomerName { get; set; }
        public FrmShop1(string customerId,string customerName)
        {
            InitializeComponent();
            itemTable = new ItemsTable();
            CurrentCustomerId = customerId;
            CurrentCustomerName = customerName;
            lblCustomerName.Text = customerName;
            YLocationInShoppingCartPanel = 0;
            shoppingCartListItems = new List<ShoppingCartControl>();
            shoppingCartListItemsCount = 0;

        }
       
        private void FrmShop_Load(object sender, EventArgs e)
        {
             DataTable itemsToView = itemTable.getItemsToView();
            ItemControl item;
            string itemImagePath, itemName, itemPrice;
            int itemCode;
            int itemX=5, itemY=5;
            int width,height=0;
            for (int i = 0; i < itemsToView.Rows.Count;)
            {
                for (int j = 0; j < 5 &&i < itemsToView.Rows.Count;j++)
                {
                    itemName = itemsToView.Rows[i]["nameItem"].ToString();
                    itemPrice = itemsToView.Rows[i]["priceItem"].ToString();
                    itemImagePath = @"pictures\" + itemsToView.Rows[i]["imagePath"].ToString();
                    itemCode = int.Parse(itemsToView.Rows[i]["codeItem"].ToString());
                    item = new ItemControl();
                    width = item.Width;
                    height = item.Height;
                    item.Location = new Point(itemX, itemY);
                    itemX += width + 5;
                    item.LblItemPrice.Text = itemPrice;
                    item.LblItemName.Text = itemName;
                    item.PctItemPicture.ImageLocation = itemImagePath;
                    item.itemCode = itemCode;
                    item.StockItems = itemTable.getColorsAndSizesStockForItem(itemCode);
                    item.CmbColors.DataSource = item.getItemColors();
                    item.CmbColors.ValueMember = "colorCode";
                    item.CmbColors.DisplayMember = "colorName";
                    item.CmbColors.SelectedValueChanged+=new EventHandler(CmbColors_SelectedValueChanged);
                    item.CmbColors.SelectedValue = -1;
                    item.CmbColors.Text = "-בחר צבע-";
                    item.CmbSizes.Enabled = false;
                    item.CmbSizes.SelectedValueChanged += new EventHandler(CmbSizes_SelectedValueChanged);
                    item.BtnAddToCart.Enabled = false;
                    item.BtnAddToCart.Click += new EventHandler(BtnAddToCart_Click);
                    pnlItems.Controls.Add(item);
                    i++;
                }
                itemY += 10 + height;
                itemX = 5;
            }
           
        }
        //אירוע הקורה כשלוחצים על כפתור הוספה לסל
        void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ItemControl control = btn.Parent as ItemControl;
            DataTable colorsTable;
            if (btn != null && control != null)
            {
                string selectedColor = control.CmbColors.SelectedValue as string;
                string selectedSize = control.CmbSizes.SelectedValue as string;
                string selectedColorName = control.CmbColors.Text;
                string selectedSizeName = control.CmbSizes.Text;
                int selectedColorCode, selectedSizeCode;
                if (selectedColor != null && selectedSize != null && int.TryParse(selectedColor, out selectedColorCode) && int.TryParse(selectedSize, out selectedSizeCode))
                {
                    //בדיקת מלאי הפריט ועדכון הפקדים בהתאם
                    control.decreaseTotalAmount(selectedColorCode, selectedSizeCode);
                    colorsTable=control.getItemColors();
                    if (colorsTable.Rows.Count == 0)
                    {
                        control.Enabled = false;
                        control.LblNoStock.Visible = true;
                    }    
                    else
                    {
                        control.CmbColors.DataSource = colorsTable;
                        control.CmbColors.ValueMember = "colorCode";
                        control.CmbColors.DisplayMember = "colorName";
                        control.CmbColors.SelectedValue = -1;
                        control.CmbColors.Text = "-בחר צבע-";
                        control.CmbSizes.Enabled = false;
                        control.CmbSizes.DataSource = null;
                        control.CmbSizes.Text = "";
                        control.BtnAddToCart.Enabled = false;
                    }
                    //הוספת הפריט לסל הקניות
                    ShoppingCartControl itemToShoppingCart = new ShoppingCartControl();
                    itemToShoppingCart.ItemCode = control.itemCode;
                    itemToShoppingCart.ColorCode = selectedColorCode;
                    itemToShoppingCart.SizeCode = selectedSizeCode;
                    itemToShoppingCart.LblItemColor.Text = selectedColorName;
                    itemToShoppingCart.LblItemSize.Text = selectedSizeName;
                    itemToShoppingCart.LblItemPrice.Text = control.LblItemPrice.Text;
                    itemToShoppingCart.LblItemName.Text = control.LblItemName.Text;
                    itemToShoppingCart.Item = control;
                    itemToShoppingCart.BtnRemove.Click += new EventHandler(BtnRemove_Click);
                    itemToShoppingCart.Location = new Point(0, YLocationInShoppingCartPanel);
                    itemToShoppingCart.ItemAmount = 1;
                    pnlShoppingCart.Controls.Add(itemToShoppingCart);
                    YLocationInShoppingCartPanel += 25;
                    shoppingCartListItems.Add(itemToShoppingCart);
                    shoppingCartListItemsCount++;
                    //עדכון תווית המחיר
                    int currentPrice = int.Parse(lblSumPrice.Text);
                    int priceToAdd=int.Parse(control.LblItemPrice.Text);
                    currentPrice += priceToAdd;
                    lblSumPrice.Text = currentPrice.ToString();
                }
            }
        }
        //אירוע הקורה כשלוחצים על כפתור הסרת פריט מסל הקניות
        void BtnRemove_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ShoppingCartControl control = btn.Parent as ShoppingCartControl;
            if (control != null)
            {
                ItemControl itemControl = control.Item;
                DataTable colorsTable;
                if (btn != null && control != null)
                {
                    int colorCode = control.ColorCode;
                    int sizeCode = control.SizeCode;
                    //בדיקת מלאי הפריט ועדכון הפקדים בהתאם
                    itemControl.increaseTotalAmount(colorCode, sizeCode);
                    colorsTable = itemControl.getItemColors();
                    itemControl.Enabled = true;
                    itemControl.LblNoStock.Visible = false;
                    itemControl.CmbColors.DataSource = colorsTable;
                    itemControl.CmbColors.ValueMember = "colorCode";
                    itemControl.CmbColors.DisplayMember = "colorName";
                    itemControl.CmbColors.SelectedValue = -1;
                    itemControl.CmbColors.Text = "-בחר צבע-";
                    itemControl.CmbSizes.Enabled = false;
                    itemControl.CmbSizes.DataSource = null;
                    itemControl.CmbSizes.Text = "";
                    itemControl.BtnAddToCart.Enabled = false;
                    //עדכון תווית המחיר
                    int currentPrice = int.Parse(lblSumPrice.Text);
                    int priceToAdd = int.Parse(control.LblItemPrice.Text);
                    currentPrice -= priceToAdd;
                    lblSumPrice.Text = currentPrice.ToString();
                    //הסרת הפריט מסל הקניות
                    shoppingCartListItemsCount--;
                    control.copyItem(shoppingCartListItems[shoppingCartListItemsCount]);
                    pnlShoppingCart.Controls.Remove(shoppingCartListItems[shoppingCartListItemsCount]);
                    shoppingCartListItems.Remove(shoppingCartListItems[shoppingCartListItemsCount]);
                    YLocationInShoppingCartPanel -= 25;
                    
                }
            }
           
        }
        //פונקציה הדואגת לאיפשור/אי איפשור של כפתור הוספה לסל
       //אירוע הקורה כשנבחרת מידה  
        void CmbSizes_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            ItemControl control = cmb.Parent as ItemControl;
            if (cmb.SelectedValue != null && cmb != null && control != null)
            {
                string selectedValue = cmb.SelectedValue as string;
                if (selectedValue != null)
                {
                    control.BtnAddToCart.Enabled = true;
                }
                else
                {
                    control.BtnAddToCart.Enabled = false;
                }
            }
            else
            {
                control.BtnAddToCart.Enabled = false;
            }
        }
        //אירוע הקורה כשנבחר צבע - ממלא את רשימת המידות בצבע הבחור
        void CmbColors_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            ItemControl control = cmb.Parent as ItemControl;
            if (cmb.SelectedValue != null && cmb!=null && control!=null)
            {
                string selectedValue = cmb.SelectedValue as string;
                if (selectedValue!=null)
                {
                    int selectedColorCode = int.Parse(selectedValue);
                    control.CmbSizes.DataSource = control.getItemSizesByColor(selectedColorCode);
                    control.CmbSizes.ValueMember = "sizeCode";
                    control.CmbSizes.DisplayMember = "sizeName";
                    control.CmbSizes.SelectedValue = -1;
                    control.CmbSizes.Text = "-בחר מידה-";
                    control.CmbSizes.Enabled = true;
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (pnlShoppingCart.Controls.Count == 0)
                MessageBox.Show("סל הקניות ריק");
            else
            {
                //יצירת הזמנה חדשה
                Orders order = new Orders(CurrentCustomerId,DateTime.Today);
                 //קריאה לטופס פרטי תשלום ומילוי הפרטים להעברה לטופס זה
                FrmCreditCardOfCustomers card = new FrmCreditCardOfCustomers();
                card.OrderToAdd = order;
                card.ShoppingCartListItems = shoppingCartListItems;
                card.SumToPay = int.Parse(lblSumPrice.Text);
                card.CurrentCustomerId = CurrentCustomerId;
                card.CurrentCustomerName = CurrentCustomerName;
                card.FormClosed += new FormClosedEventHandler(card_FormClosed);
                this.Enabled = false;
                //הצגת הטופס
                card.Show();
            }
        }
        //event of card form closing
        void card_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCreditCardOfCustomers form = sender as FrmCreditCardOfCustomers;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
      

     

       

      
    }
}
