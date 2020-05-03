using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
   public class Colors
    {
        private int codeColor;

        public int CodeColor
        {
            get { return codeColor; }
            set { codeColor = value; }
        }
        private string nameColor;

        public string NameColor
        {
            get { return nameColor; }
            set { nameColor = value; }
        }



        public Colors(DataRow dr)
       {
           this.CodeColor = Convert.ToInt32(dr["CodeColor"]);
           this.NameColor = dr["NameColor"].ToString();
        

       }
        public Colors(string nameColor)
         {
             this.NameColor = nameColor;
            // this.CodeColor =( 'nameColor.ToCharArray()[0]' +' '+ 'nameColor.ToCharArray()[1]').ToString();
            
         }
       public DataRow BuildRow()
       {
           ColorsTable st = new ColorsTable();
           DataTable stuTbl = st.Dt;
           DataRow newRow = stuTbl.NewRow();
           newRow["CodeColor"] = this.CodeColor;
           newRow["NameColor"] = this.NameColor;
         
           return newRow;


       }
    }
}
