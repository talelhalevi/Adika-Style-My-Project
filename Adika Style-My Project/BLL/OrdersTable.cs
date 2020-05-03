using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
namespace Adika_Style_My_Project.BLL
{
    public class OrdersTable : GeneralTable
    {

        public OrdersTable()
            : base("Orders", "CodeOrder", false)
        {
        }

        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["CodeOrder"] = from["CodeOrder"];
            to["IDCust"] = from["IDCust"];
            to["DateOrder"] = from["DateOrder"];
            to.EndEdit();
        }
        public int getNextCode()
        {
            if (dt.Rows.Count == 0) return 1;
            int max = 1,currentCode=0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                currentCode=Convert.ToInt32(dt.Rows[i]["CodeOrder"].ToString());
                if (currentCode > max)
                    max = currentCode;
            }
            return max + 1;
        }
    }


}
