using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Adika_Style_My_Project.BLL
{
    public class Orders
    {
        private int CodeOrder;
        private string IDCust;
        private DateTime DateOrder;
        public Orders(string IDCust,DateTime DateOrder)
        {
            this.CodeOrder = new OrdersTable().getNextCode();
            this.IDCust = IDCust;
            this.DateOrder = DateOrder;
        }
        public Orders(DataRow dr)
        {
            this.CodeOrder = Convert.ToInt32(dr["CodeOrder"]);
            this.IDCust = dr["IDCust"].ToString();
            this.DateOrder = Convert.ToDateTime(dr["DateOrder"]);
        }
        public Orders(string CodeColor)
        {
            ColorsTable st = new ColorsTable();
            DataRow row = st.Find("CodeOrder", CodeOrder);
            this.CodeOrder = Convert.ToInt32(row["CodeOrder"]);
            this.IDCust = row["IDCust"].ToString();
            this.DateOrder = Convert.ToDateTime(row["DateOrder"]);
        }
        public DataRow BuildRow()
        {
            OrdersTable st = new OrdersTable();
            DataTable stuTbl = st.Dt;
            DataRow newRow = stuTbl.NewRow();
            newRow["CodeOrder"] = this.CodeOrder;
            newRow["IDCust"] = this.IDCust;
            newRow["DateOrder"] = this.DateOrder;
            return newRow;
        }

        
        //public Colors(DataRow dr)
        //{
        //    this.CodeColor = dr["CodeColor"].ToString();
        //    this.NameColor = dr["NameColor"].ToString();


        //}
        // public Colors(string CodeColor)
        //  {
        //      ColorsTable st = new ColorsTable();
        //      DataRow row = st.Find("CodeColor", CodeColor);
        //      this.CodeColor = row["CodeColor"].ToString();
        //      this.NameColor = row["NameColor"].ToString();


        //  }
        //public DataRow BuildRow()
        //{
        //    ColorsTable st = new ColorsTable();
        //    DataTable stuTbl = st.Dt;
        //    DataRow newRow = stuTbl.NewRow();
        //    //newRow["CodeColor"] = this.CodeColor;
        //    //newRow["NameColor"] = this.NameColor;

        //    return newRow;


        //}



    }
}
