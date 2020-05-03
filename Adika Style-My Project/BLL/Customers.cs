using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
     public class Customers
    {

        private string IDCust;

        public string IDCust1
        {
            get { return IDCust; }
            set 
            {
                if (!Validition.correctId(value))
                    throw new Exception("תעודת הזהות שגויה");
                IDCust = value; 
            }
        }
          private string FirstNameCust;

          public string FirstNameCust1
          {
              get { return FirstNameCust; }
              set { FirstNameCust = value; }
          }
          private string LustNameCust;

          public string LustNameCust1
          {
              get { return LustNameCust; }
              set { LustNameCust = value; }
          }
          private string PhoneCust;

          public string PhoneCust1
          {
              get { return PhoneCust; }
              set { PhoneCust = value; }
          }
          private string TPhoneCust;

          public string TPhoneCust1
          {
              get { return TPhoneCust; }
              set { TPhoneCust = value; }
          }
          private string SityCust;

          public string SityCust1
          {
              get { return SityCust; }
              set { SityCust = value; }
          }
          private string StreetCust;

          public string StreetCust1
          {
              get { return StreetCust; }
              set { StreetCust = value; }
          }
          private string PostCode;

          public string PostCode1
          {
              get { return PostCode; }
              set { PostCode = value; }
          }
          private string HomeNum;

          public string HomeNum1
          {
              get { return HomeNum; }
              set { HomeNum = value; }
          }



          public Customers()
         {
          
         }
         public Customers(DataRow dr)
        {
            this.IDCust = dr["IDCust"].ToString();
            this.FirstNameCust = dr["FirstNameCust"].ToString();
            this.LustNameCust = dr["LustNameCust"].ToString();
            this.PhoneCust = dr["PhoneCust"].ToString();
            this.TPhoneCust = dr["TPhoneCust"].ToString();
            this.SityCust = dr["SityCust"].ToString();
            this.StreetCust = dr["StreetCust"].ToString();
            this.PostCode = dr["PostCode"].ToString();
            this.HomeNum = dr["HomeNum"].ToString();

        }
        public Customers(string IDCust)
        {
            CustomersTable st = new CustomersTable();
            DataRow row = st.Find("IDCust", IDCust);
            this.IDCust = row["IDCust"].ToString();
            this.FirstNameCust = row["FirstNameCust"].ToString();
            this.LustNameCust = row["LustNameCust"].ToString();
            this.PhoneCust = row["PhoneCust"].ToString();
            this.TPhoneCust = row["TPhoneCust"].ToString();
            this.SityCust = row["SityCust"].ToString();
            this.StreetCust = row["StreetCust"].ToString();
            this.PostCode = row["PostCode"].ToString();
            this.HomeNum = row["HomeNum"].ToString();


        }
        public DataRow BuildRow()
        {
            CustomersTable st = new CustomersTable();
            DataTable stuTbl = st.Dt;
            DataRow newRow = stuTbl.NewRow();
            newRow["IDCust"] = this.IDCust;
            newRow["FirstNameCust"] = this.FirstNameCust;
            newRow["LustNameCust"] = this.LustNameCust;
            newRow["PhoneCust"] = this.PhoneCust;
            newRow["TPhoneCust"] = this.TPhoneCust;
            newRow["SityCust"] = this.SityCust;
            newRow["StreetCust"] = this.StreetCust;
            newRow["PostCode"] = this.PostCode;
            newRow["HomeNum"] = this.HomeNum;
            return newRow;
        }
    }
}

  