using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Adika_Style_My_Project.BLL
{
    public class Items
    {

        private string CodeItem;

        public string CodeItem1
        {
            get { return CodeItem; }
            set { CodeItem = value; }
        }
        private string NameItem;

        public string NameItem1
        {
            get { return NameItem; }
            set { NameItem = value; }
        }
        private string PictureItemDescription;

        public string PictureItemDescription1
        {
            get { return PictureItemDescription; }
            set { PictureItemDescription = value; }
        }
        private string MinItem;

        public string MinItem1
        {
            get { return MinItem; }
            set { MinItem = value; }
        }
        private string PriceItem;

        public string PriceItem1
        {
            get { return PriceItem; }
            set { PriceItem = value; }
        }
        private bool Status;

        public bool Status1
        {
            get { return Status; }
            set { Status = value; }
        }
        private string SeasonItem;

        public string SeasonItem1
        {
            get { return SeasonItem; }
            set { SeasonItem = value; }
        }
        private bool SaleItem;

        public bool SaleItem1
        {
            get { return SaleItem; }
            set { SaleItem = value; }
        }

        public Items(DataRow dr)
        {
            this.CodeItem = dr["CodeItem"].ToString();
            this.NameItem = dr["NameItem"].ToString();
            this.PictureItemDescription = dr["PictureItemDescription"].ToString();
            this.MinItem = dr["MinItem"].ToString();
            this.PriceItem = dr["PriceItem"].ToString();
            this.Status = Convert.ToBoolean(dr["Status"]);
            this.SeasonItem = dr["SeasonItem"].ToString();
            this.SaleItem = Convert.ToBoolean(dr["SaleItem"]);

        }
        public Items(string CodeItem)
        {
            ItemsTable st = new ItemsTable();
            DataRow row = st.Find("CodeItem", CodeItem);
            this.NameItem = row["NameItem"].ToString();
            this.PictureItemDescription = row["PictureItemDescription"].ToString();
            this.MinItem = row["MinItem"].ToString();
            this.PriceItem = row["PriceItem"].ToString();
            this.Status = Convert.ToBoolean(row["Status"]);
            this.SeasonItem = row["SeasonItem"].ToString();
            this.SaleItem = Convert.ToBoolean(row["SaleItem"]);



        }
        public DataRow BuildRow()
        {
            ItemsTable st = new ItemsTable();
            DataTable colTbl = st.Dt;
            DataRow newRow = colTbl.NewRow();
            newRow["CodeItem"] = this.CodeItem;
            newRow["NameItem"] = this.NameItem;
            newRow["PictureItemDescription"] = this.PictureItemDescription;
            newRow["MinItem"] = this.MinItem;
            newRow["PriceItem"] = this.PriceItem;
            newRow["Status"] = this.Status;
            newRow["SeasonItem"] = this.SeasonItem;
            newRow["SaleItem"] = this.SaleItem;

            return newRow;

        }
        public Items()
        {
        }
    }
}
