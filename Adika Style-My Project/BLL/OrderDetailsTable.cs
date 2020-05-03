using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
   public class OrderDetailsTable:GeneralTable2Keys
    {
       public OrderDetailsTable()


           : base("codeItemStoke", "CodeOrder", "OrderDetails", false)
        
       {
       }
 
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["CodeOrder"] = from["CodeOrder"];
            to["codeItemInStoke"] = from["codeItemInStoke"];
            to["FirstNameCust"] = from["FirstNameCust"];
            to["LustNameCust"] = from["LustNameCust"];
            to["PhoneCust"] = from["PhoneCust"];
            to["TPhoneCust"] = from["TPhoneCust"];
            to["SityCust"] = from["SityCust"];
            to["StreetCust"] = from["StreetCust"];
            to["PostCode"] = from["PostCode"];
            to["HomeNum"] = from["HomeNum"];
         
            to.EndEdit();
        }

    }
    }

