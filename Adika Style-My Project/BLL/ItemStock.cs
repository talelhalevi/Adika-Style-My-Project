using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
    public class ItemStock
    {
        private string codeItemInStoke;

        public string CodeItemInStoke
        {
            get { return codeItemInStoke; }
            set { codeItemInStoke = value; }
        }
        private string CodeItem;

        public string CodeItem1
        {
            get { return CodeItem; }
            set { CodeItem = value; }
        }
        private int colorOfItem;

        public int ColorOfItem
        {
            get { return colorOfItem; }
            set { colorOfItem = value; }
        }
        private int codeSize;

        public int CodeSize
        {
            get { return codeSize; }
            set { codeSize = value; }
        }
        private int amountOfStoke;

        public int AmountOfStoke
        {
            get { return amountOfStoke; }
            set { amountOfStoke = value; }
        }
        private int minStoke;

        public int MinStoke
        {
            get { return minStoke; }
            set { minStoke = value; }
        }
        private int maxStoke;

        public int MaxStoke
        {
            get { return maxStoke; }
            set { maxStoke = value; }
        }


          public ItemStock(string IDCust)
        {
            ItemStockTable st = new ItemStockTable();
            DataRow row = st.Find("codeItemInStoke", codeItemInStoke);
            this.codeItemInStoke = row["codeItemInStoke"].ToString();
            this.CodeItem = row["CodeItem"].ToString();
            this.colorOfItem = Convert.ToInt32(row["colorOfItem"]);
            this.codeSize =Convert.ToInt32( row["codeSize"]);
            this.amountOfStoke =Convert.ToInt32( row["amountOfStoke"]);
            this.minStoke = Convert.ToInt32(row["minStoke"]);
            this.maxStoke = Convert.ToInt32(row["maxStoke"]);
         


        }
        public DataRow BuildRow()
        {
           ItemStockTable st = new ItemStockTable();
            DataTable stuTbl = st.Dt;
            DataRow newRow = stuTbl.NewRow();
            newRow["codeItemInStoke"] = this.codeItemInStoke;
            newRow["CodeItem"] = this.CodeItem;
            newRow["colorOfItem"] = this.colorOfItem;
            newRow["codeSize"] = this.codeSize;
            newRow["amountOfStoke"] = this.amountOfStoke;
            newRow["minStoke"] = this.minStoke;
            newRow["maxStoke"] = this.maxStoke;
            return newRow;
        }
    }
  
    
    
    
    }




    










