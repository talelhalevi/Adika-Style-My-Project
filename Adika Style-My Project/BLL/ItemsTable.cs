using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
     
         public class ItemsTable:GeneralTable
    {
      public ItemsTable()
          : base("Items", "CodeItem" , true)
        {

        }
        public override void update(DataRow from, DataRow to)
        {
             to.BeginEdit();
            to["CodeItem"] = from["CodeItem"];
            to["NameItem"] = from["NameItem"];
            to["PictureItemDescription"] = from["PictureItemDescription"];
            to["MinItem"] = from["MinItem"];
            to["PriceItem"] = from["PriceItem"];
            to["Status"] = from["Status"];
            to["SeasonItem"] = from["SeasonItem"];
            to["SaleItem"] = from["SaleItem"];
           
        }

        //Methods
        public DataTable GetItemsBySeason()
        {
            string sql;
            int season = DateTime.Now.Month;
            if (GlobalClass.GetSeason(season) == Season.allSeason)
                season++;

            // Season.winter
            if (GlobalClass.GetSeason(season) == Season.winter)
                sql = "select * from Items where SeasonItem ='winter' or SeasonItem='allSeason'";
            // Season.summer
            sql = "select * from Items where SeasonItem ='summer' or SeasonItem='allSeason'";
                 
            return DAL.DAL.GetTableFromSQL(sql);
        }
        //שיטה המחזירה מחרוזת המתארת את העונה הנוכחית : winter/summer
        public string GetCurrentSeason()
        {
            string currentSeason="";
            int season = DateTime.Now.Month;
            if (GlobalClass.GetSeason(season) == Season.allSeason)
                season--;
            // Season.winter
            if (GlobalClass.GetSeason(season) == Season.winter)
                currentSeason="winter";
            // Season.summer
            currentSeason = "summer";
            return currentSeason;
        }
        //פונקציה המחזירה טבלה של פריטים שיש להם פריטים בסטוק
        public DataTable getItemsToView()
        {
            string currentSeason = GetCurrentSeason();
            string sql = "SELECT Items.CodeItem as codeItem, Items.NameItem as nameItem, Items.MinItem as minItem, Items.PriceItem as priceItem, Items.Status, Items.SeasonItem, Items.SaleItem, Items.PictureItemDescription as imagePath,Sum(ItemStock.amountOfStoke) AS totalAmount FROM Items INNER JOIN ItemStock ON Items.CodeItem = ItemStock.CodeItem WHERE (((Items.Status)=True) AND ((Items.SeasonItem)='allSeason')) OR (((Items.SeasonItem)='" + currentSeason + "') ) GROUP BY Items.CodeItem, Items.NameItem, Items.MinItem, Items.PriceItem, Items.Status, Items.SeasonItem, Items.SaleItem, Items.PictureItemDescription HAVING (((Sum(ItemStock.amountOfStoke))>0));";
            DataTable table=DAL.DAL.GetTableFromSQL(sql);
            return table;
        }
        //פונקציה המחזירה טבלה של צבעים לפריט בסטוק
        public DataTable getItemColorsInStock(int itemCode)
        {
            string sql = "SELECT distinct ItemStock.colorOfItem as colorCode, Colors.NameColor as colorName FROM Colors INNER JOIN ItemStock ON Colors.CodeColor = ItemStock.colorOfItem WHERE (((ItemStock.CodeItem)='" + itemCode + "'));";
            return DAL.DAL.GetTableFromSQL(sql);
        }
        //פונקציה המחזירה טבלה של מידות לפריט בצבע מסויים בסטוק
        public DataTable getItemSizesInStockByColor(int itemCode,int colorCode)
        {
            string sql = "SELECT ItemStock.codeSize as sizeCode, Sizes.nameSize as sizeName FROM Sizes INNER JOIN ItemStock ON Sizes.codeSize = ItemStock.codeSize WHERE (((ItemStock.CodeItem)='"+itemCode+"') AND ((ItemStock.colorOfItem)="+colorCode+"));";
            return DAL.DAL.GetTableFromSQL(sql);
        }
        //פונקציה המחזירה טבלה של מידות וצבעים הקיימים בסטוק לפריט מסויים
        public DataTable getColorsAndSizesStockForItem(int codeItem)
        {
            string sql = "SELECT ItemStock.CodeItem as itemCode, Sizes.codeSize as sizeCode, Sizes.nameSize as sizeName, Colors.CodeColor as colorCode, Colors.NameColor as colorName, Sum(ItemStock.amountOfStoke) AS totalAmount FROM Sizes INNER JOIN (Colors INNER JOIN ItemStock ON Colors.CodeColor = ItemStock.colorOfItem) ON Sizes.codeSize = ItemStock.codeSize GROUP BY ItemStock.CodeItem, Sizes.codeSize, Sizes.nameSize, Colors.CodeColor, Colors.NameColor HAVING (((ItemStock.CodeItem)='"+codeItem+"') AND ((Sum(ItemStock.amountOfStoke))>0));";
            return DAL.DAL.GetTableFromSQL(sql);
        }
        //פונקציה המחזירה האם פריט מסוים בסייל
        public bool isSaleItem(int itemCode)
        {
            bool isSale;
            string sql = "SELECT Items.SaleItem FROM Items WHERE (((Items.CodeItem)='"+itemCode+"'));";
            DataTable d= DAL.DAL.GetTableFromSQL(sql);
            try
            {
                isSale = bool.Parse(d.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                isSale = false;
            }
            return isSale;
        }
        //פונקציה המחזירה מחיר של פריט מסוים
        public int getItemPrice(int itemCode)
        {
            int price;
            string sql = "SELECT Items.PriceItem FROM Items WHERE (((Items.CodeItem)='"+itemCode+"'));";
            DataTable d = DAL.DAL.GetTableFromSQL(sql);
            try
            {
                price = int.Parse(d.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                price = 0;
            }
            return price;
        }
        //מתאים לקודים כשהקוד מסוג טקסט
        public int getNextCode()
        {
            int currentCode = 0;
            int maxCode = 0;
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                try 
	            {
                    currentCode = int.Parse(Dt.Rows[i]["CodeItem"].ToString());
	            }
	            catch (Exception)
	            {
                    currentCode = 0;
	            }
                if (currentCode > maxCode) maxCode = currentCode;
            }
            return maxCode+1;
        }
    }
}

    

