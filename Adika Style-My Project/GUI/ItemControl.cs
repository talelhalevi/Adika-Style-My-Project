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
    public partial class ItemControl : UserControl
    {
        public int itemCode { get; set; }
        public PictureBox PctItemPicture { get; set; }
        public Label LblItemName { get; set; }
        public Label LblItemPrice { get; set; }
        public Label LblNoStock { get; set; }
        public Button BtnAddToCart { get; set; }
        public ComboBox CmbColors { get; set; }
        public ComboBox CmbSizes { get; set; }
        public DataTable StockItems { get; set; }
        public ItemControl()
        {
            InitializeComponent();
            PctItemPicture = pctItemPicture;
            LblItemName = lblItemName;
            LblItemPrice = lblItemPrice;
            LblNoStock = lblNoStock;
            BtnAddToCart = btnAddToCart;
            CmbColors = cmbColors;
            CmbSizes = cmbSizes;
        }
        //פונקציה המחזירה רשימת צבעים לפריט מסויים
        public DataTable getItemColors()
        {
            DataTable table = new DataTable();
            table.Columns.Add("colorCode");
            table.Columns.Add("colorName");
            if(StockItems!=null)
            for (int i = 0; i < StockItems.Rows.Count; i++)
            {
                int totalAmount=int.Parse(StockItems.Rows[i]["totalAmount"].ToString());
                int currentColorCode=int.Parse( StockItems.Rows[i]["colorCode"].ToString());
                if (totalAmount > 0 && isColorInTable(currentColorCode,table)==false)
                {
                    table.Rows.Add(new string[] {currentColorCode.ToString(), StockItems.Rows[i]["colorName"].ToString() });
                }
                   
            }
            return table;
        }
        //פונקציה הבודקת האם צבע כבר קיים בטבלת צבעים
        private bool isColorInTable(int colorCode, DataTable table)
        {
            if (table != null && table.Rows != null)
            {
                int currentColorCode;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    currentColorCode=int.Parse(table.Rows[i]["colorCode"].ToString());
                    if (currentColorCode == colorCode)
                        return true;
                }
            }
            return false;
        }
        //פונקציה המחזירה רשימת מידות לפריט בצבע מסויים
        public DataTable getItemSizesByColor(int selectedColorCode)
        {
            DataTable table = new DataTable();
            table.Columns.Add("sizeCode");
            table.Columns.Add("sizeName");
            if (StockItems != null)
                for (int i = 0; i < StockItems.Rows.Count; i++)
                {
                    int totalAmount = int.Parse(StockItems.Rows[i]["totalAmount"].ToString());
                    int colorCode = int.Parse(StockItems.Rows[i]["colorCode"].ToString());
                    int currentSizeCode=int.Parse(StockItems.Rows[i]["sizeCode"].ToString());
                    if (totalAmount > 0 && selectedColorCode == colorCode && isSizeInTable(currentSizeCode,table)==false)
                    {
                        table.Rows.Add(new string[] {currentSizeCode.ToString() , StockItems.Rows[i]["sizeName"].ToString()});
                    }
                }
            return table;
        }
        //פונקציה הבודקת האם מידה כבר קיימת בטבלת מידות
        private bool isSizeInTable(int SizeCode, DataTable table)
        {
            if (table != null && table.Rows != null)
            {
                int currentSizeCode;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    currentSizeCode = int.Parse(table.Rows[i]["sizeCode"].ToString());
                    if (currentSizeCode == SizeCode)
                        return true;
                }
            }
            return false;
        }
        //פונקציה המקטינה את הכמות של פריט בצבע ומידה מסויימים
        public void decreaseTotalAmount(int colorCode, int sizeCode)
        {
            if (StockItems != null)
            {
                int currentColorCode, currentSizeCode,currentTotalAmount;
                for (int i = 0; i < StockItems.Rows.Count; i++)
                {
                    currentColorCode = int.Parse(StockItems.Rows[i]["colorCode"].ToString());
                    currentSizeCode = int.Parse(StockItems.Rows[i]["sizeCode"].ToString());
                    if (currentColorCode==colorCode && currentSizeCode==sizeCode )
                    {
                        currentTotalAmount = int.Parse(StockItems.Rows[i]["totalAmount"].ToString());
                        StockItems.Rows[i]["totalAmount"] = (currentTotalAmount - 1).ToString();
                    }

                }
            }
        }
        //פונקציה המגדילה את הכמות של פריט בצבע ומידה מסויימים
        public void increaseTotalAmount(int colorCode, int sizeCode)
        {
            if (StockItems != null)
            {
                int currentColorCode, currentSizeCode, currentTotalAmount;
                for (int i = 0; i < StockItems.Rows.Count; i++)
                {
                    currentColorCode = int.Parse(StockItems.Rows[i]["colorCode"].ToString());
                    currentSizeCode = int.Parse(StockItems.Rows[i]["sizeCode"].ToString());
                    if (currentColorCode == colorCode && currentSizeCode == sizeCode)
                    {
                        currentTotalAmount = int.Parse(StockItems.Rows[i]["totalAmount"].ToString());
                        StockItems.Rows[i]["totalAmount"] = (currentTotalAmount + 1).ToString();
                    }

                }
            }
        }
    }
}
