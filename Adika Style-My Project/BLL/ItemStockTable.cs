 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
   public class ItemStockTable:GeneralTable
    {

        public ItemStockTable()
           : base("ItemStock", "codeItemInStoke", false)
        {

        }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["codeItemInStoke"] = from["codeItemInStoke"];
            to["CodeItem"] = from["CodeItem"];
            to["colorOfItem"] = from["colorOfItem"];
            to["codeSize"] = from["codeSize"];
            to["amountOfStoke"] = from["amountOfStoke"];
            to["minStoke"] = from["minStoke"];
            to["maxStoke"] = from["maxStoke"];
            to.EndEdit();
        }
       //get itemStock code by itemCode, colorCode and sizeCode
       public int getItemStockCode(int itemCode,int colorCode,int sizeCode)
       {
           int code;
           try
           {
               DataTable d = DAL.DAL.GetTableFromSQL("SELECT ItemStock.codeItemInStoke FROM ItemStock WHERE (((ItemStock.codeSize)=" + sizeCode + ") AND ((ItemStock.colorOfItem)=" + colorCode + ") AND ((ItemStock.CodeItem)='" + itemCode + "'));");
              code=-1;
               if(d.Rows.Count>0)
               code =int.Parse(d.Rows[0][0].ToString());
           }
           catch (Exception)
           {

               code= - 1;
           }
           return code;
       }

       public int getNextCode()
       {
           int currentCode = 0;
           int maxCode = 0;
           for (int i = 0; i < Dt.Rows.Count; i++)
           {
               try
               {
                   currentCode = int.Parse(Dt.Rows[i]["codeItemInStoke"].ToString());
               }
               catch (Exception)
               {
                   currentCode = 0;
               }
               if (currentCode > maxCode) maxCode = currentCode;
           }
           return maxCode + 1;
       }

    }
}
