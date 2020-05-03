using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
     public class CustomersTable:GeneralTable
    {
           public CustomersTable()
        
      
           : base("Customers", "IDCust", false)
         {
        }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["IDCust"] = from["IDCust"];
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
        public string GetCustomerFullNameById (string id)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["IDCust"].ToString().Equals(id))
                {
                    return dt.Rows[i]["FirstNameCust"].ToString() +" "+dt.Rows[i]["LustNameCust"].ToString();
                }
            }
            return null;
        }
    }
 }

