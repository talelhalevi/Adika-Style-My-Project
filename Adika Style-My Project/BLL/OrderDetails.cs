using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{

  public class OrderDetails
  {
      private int codeOrder;

      public int CodeOrder
      {
          get { return codeOrder; }
          set { codeOrder = value; }
      }
      private string codeItemStoke;

      public string CodeItemStoke
      {
          get { return codeItemStoke; }
          set { codeItemStoke = value; }
      }
      private int amount;

      public int Amount
      {
          get { return amount; }
          set { amount = value; }
      }
      private int priceItem;

      public int PriceItem
      {
          get { return priceItem; }
          set { priceItem = value; }
      }
      private bool saleItem;

      public bool SaleItem
      {
          get { return saleItem; }
          set { saleItem = value; }
      }


        public OrderDetails(DataRow dr)
        {
            this.CodeOrder = Convert.ToInt32(dr["CodeOrder"]);
            this.codeItemStoke = dr["codeItemStoke"].ToString();
            this.amount = Convert.ToInt32(dr["amount"]);
            this.priceItem = Convert.ToInt32(dr["priceItem"]);
            this.saleItem = Convert.ToBoolean(dr["saleItem"]);


        }
        public OrderDetails(string CodeOrder, string colorOfItem)
        {
            OrderDetailsTable st = new OrderDetailsTable();
            DataRow row = st.Find("colorOfItem" ,"CodeOrder",colorOfItem,CodeOrder);
            this.CodeOrder = Convert.ToInt32(row["CodeOrder"]);
            this.codeItemStoke = row["codeItemStoke"].ToString();
            this.amount = Convert.ToInt32(row["amount"]);
            this.priceItem = Convert.ToInt32(row["priceItem"]);
            this.saleItem = Convert.ToBoolean(row["saleItem"]);
          


        }
        public OrderDetails() { }
        public DataRow BuildRow()
        {
            OrderDetailsTable st = new OrderDetailsTable();
            DataTable colTbl = st.Dt;
            DataRow newRow = colTbl.NewRow();
            newRow["CodeOrder"] = this.CodeOrder;
            newRow["codeItemStoke"] = this.codeItemStoke;
            newRow["amount"] = this.amount;
            newRow["priceItem"] = this.priceItem;
            newRow["saleItem"] = this.saleItem;

            return newRow;


        }

    }
}
