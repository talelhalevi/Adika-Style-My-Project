using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Adika_Style_My_Project.BLL
{
   public class SizesTable:GeneralTable
   
   {


       public SizesTable()
           : base("Sizes", "CodeSize", false)
        {

        }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["CodeSize"] = from["CodeSize"];
            to["NameSize"] = from["NameSize"];
           
            to.EndEdit();
        }

    }
}
