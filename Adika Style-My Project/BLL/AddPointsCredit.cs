using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
    public class AddPointsCredit
    {
        private int codeAddPoint;

        public int CodeAddPoint
        {
            get { return codeAddPoint; }
            set { codeAddPoint = value; }
        }
        private int numOfPoint;

        public int NumOfPoint
        {
            get { return numOfPoint; }
            set { numOfPoint = value; }
        }

        private string idCustomer;

        public string IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public AddPointsCredit()
         {
             this.status = true;
         }
        public AddPointsCredit(DataRow dr)
        {
            this.codeAddPoint = Convert.ToInt32(dr["CodeAddPoint"]);
            this.numOfPoint = Convert.ToInt32(dr["NumOfPoint"]);
            this.status = Convert.ToBoolean(dr["Status"]);
            this.idCustomer = dr["IdCustomer"].ToString();
        }
        public AddPointsCredit(string CodeAddP)
        {
            AddPointsCreditTable st = new AddPointsCreditTable();
            DataRow row = st.Find("CodeAddPoint", codeAddPoint);
            this.codeAddPoint = Convert.ToInt32(row["CodeAddPoint"]);
            this.numOfPoint = Convert.ToInt32(row["NumOfPoint"]);
            this.status = Convert.ToBoolean(row["Status"]);
            this.idCustomer = row["IdCustomer"].ToString();
        }
        public DataRow BuildRow()
        {
            AddPointsCreditTable st = new AddPointsCreditTable();
            DataTable stuTbl = st.Dt;
            DataRow newRow = stuTbl.NewRow();
            newRow["CodeAddPoint"] = this.codeAddPoint;
            newRow["NumOfPoint"] = this.numOfPoint;
            newRow["Status"] = this.status;
            //newRow["IdCustomer"] = this.idCustomer;


            return newRow;


        }
    }
}
