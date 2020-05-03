using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adika_Style_My_Project.GUI
{
    public partial class ShoppingCartControl : UserControl
    {
        public int ItemCode { get; set; }
        public int ColorCode{ get; set; }
        public int SizeCode { get; set; }
        public int ItemAmount { get; set; }
        public Label LblItemName { get; set; }
        public Label LblItemColor { get; set; }
        public Label LblItemSize { get; set; }
        public Label LblItemPrice { get; set; }
        public Button BtnRemove { get; set; }
        public ItemControl Item { get; set; }
        public ShoppingCartControl()
        {
            InitializeComponent();
            LblItemName = lblItemName;
            LblItemColor = lblItemColor;
            LblItemSize = lblItemSize;
            LblItemPrice = lblItemPrice;
            BtnRemove = btnRemove;
            ItemAmount = 0;
        }
        public void copyItem(ShoppingCartControl itemToCopy)
        {
            this.ItemCode=itemToCopy.ItemCode;
            this.ColorCode = itemToCopy.ColorCode;
            this.SizeCode = itemToCopy.SizeCode;
            lblItemName.Text = itemToCopy.LblItemName.Text;
            lblItemColor.Text = itemToCopy.LblItemColor.Text;
            lblItemSize.Text = itemToCopy.LblItemSize.Text;
            lblItemPrice.Text = itemToCopy.LblItemPrice.Text;
            this.Item = itemToCopy.Item;
        }
    }
}
