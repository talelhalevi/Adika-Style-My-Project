using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
    public class ColorsTable: GeneralTable
    {
        
    
        public ColorsTable()
          : base("Colors", "CodeColor",false)
        {

        }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["CodeColor"] = from["CodeColor"];
            to["NameColor"] = from["NameColor"];
           
            to.EndEdit();
        }


        public DataTable ColorsByColor(string searchColor)
        {
            string sql = "select * from colors where NameColor like '%" + searchColor + "%'";
            return DAL.DAL.GetTableFromSQL(sql);
        }
    }
}
