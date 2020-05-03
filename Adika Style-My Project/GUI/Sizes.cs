using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Adika_Style_My_Project.BLL
{
   public class Sizes
   
   {
               private int CodeSize;
               private string NameSize;
 
     
          public Sizes(DataRow dr)
       {
           this.CodeSize =Convert.ToInt32( dr["CodeSize"]);
           this.NameSize = dr["NameSize"].ToString();
        

       }
          public Sizes(string CodeColor)
         {
             ColorsTable st = new ColorsTable();
             DataRow row = st.Find("CodeSize", CodeSize);
             this.CodeSize = Convert.ToInt32(row["CodeSize"]);
             this.NameSize = row["NameSize"].ToString();
          
            
         }
       public DataRow BuildRow()
       {
           SizesTable st = new SizesTable();
           DataTable stuTbl = st.Dt;
           DataRow newRow = stuTbl.NewRow();
           newRow["CodeSize"] = this.CodeSize;
           newRow["NameSize"] = this.NameSize;
         
           return newRow;


       }
       


    }
}
