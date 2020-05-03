using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
    public class AddPointsCreditTable : GeneralTable
    {
        public AddPointsCreditTable()
      
      
           : base("AddPointsCredit", "CodeAddPoint", true)
        {    

    }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["CodeAddP"] = from["CodeAddP"];
            to["NumOfPoint"] = from["NumOfPoint"];
            to["Status"] = from["Status"];

            to.EndEdit();
        }

    }
}