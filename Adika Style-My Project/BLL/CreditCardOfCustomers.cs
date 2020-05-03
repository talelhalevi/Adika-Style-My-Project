using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
    public class CreditCardOfCustomers
    {

        private int codeCreditCard;

        public int CodeCreditCard
        {
            get { return codeCreditCard; }
            set { codeCreditCard = value; }
        }

        private string numCreditCard;

        public string NumCreditCard
        {
            get { return numCreditCard; }
            set { numCreditCard = value; }
        } 
        
        private DateTime validityOfCreditCard;

        public DateTime ValidityOfCreditCard
        {
            get { return validityOfCreditCard; }
            set {
                if (value.CompareTo(DateTime.Now)<0)
                    throw new Exception("לא בתוקף ");
                validityOfCreditCard = value; }
        }
        private string idOwner;

        public string IdOwner
        {
            get { return idOwner; }
            set {

                //if (!Validition.correctId(value))
                     

                //    throw new Exception("תעודת הזהות שגויה");
                //else

                idOwner = value; }
        }
        private int codeOrder;

        public int CodeOrder
        {
            get { return codeOrder; }
            set { codeOrder = value; }
        }
        private int threeNumOnCard;

        public int ThreeNumOnCard
        {
            get { return threeNumOnCard; }
            set { threeNumOnCard = value; }
        }
        private string totalOfPrice;

        public string TotalOfPrice
        {
            get { return totalOfPrice; }
            set { totalOfPrice = value; }
        }
        private int numOfPayments;

        public int NumOfPayments
        {
            get { return numOfPayments; }
            set { numOfPayments = value; }
        }
        private string kindOfDeal;

        public string KindOfDeal
        {
            get { return kindOfDeal; }
            set { kindOfDeal = value; }
        }


        
          public CreditCardOfCustomers()
         {
          
         }

        public CreditCardOfCustomers(DataRow dr)
        {
            this.numCreditCard = dr["codeCreditCard"].ToString();
            this.codeCreditCard = Convert.ToInt32(dr["numCreditCard"].ToString());
            this.validityOfCreditCard = Convert.ToDateTime(dr["validityOfCreditCard"]);
            this.idOwner = dr["IDCust"].ToString();
            this.codeOrder = Convert.ToInt32(dr["CodeOrder"]);
            this.threeNumOnCard =Convert.ToInt32( dr["ThreeNumOnCard"]);
            this.totalOfPrice = dr["totalOfPrice"].ToString();
            this.numOfPayments = Convert.ToInt32(dr["numOfPayments"].ToString());
            this.kindOfDeal = dr["kindOfDeal"].ToString();


        }
        public CreditCardOfCustomers(string codeCreditCard)
        {
            CreditCardOfCustomersTable st = new CreditCardOfCustomersTable();
            DataRow row = st.Find("codeCreditCard", codeCreditCard);
            this.numCreditCard = row["codeCreditCard"].ToString();
            this.validityOfCreditCard = Convert.ToDateTime(row["validityOfCreditCard"]);
            this.idOwner = row["IDOwnerCard"].ToString();
            this.codeOrder = Convert.ToInt32(row["CodeOrder"]);
            this.threeNumOnCard = Convert.ToInt32(row["ThreeNumOnCard"]);
            this.totalOfPrice = row["totalOfPrice"].ToString();
            this.numOfPayments = Convert.ToInt32(row["numOfPayments"].ToString());
            this.kindOfDeal = row["kindOfDeal"].ToString();


        }
        public DataRow BuildRow()
        {
            CreditCardOfCustomersTable st = new CreditCardOfCustomersTable();
            DataTable stuTbl = st.Dt;
            DataRow newRow = stuTbl.NewRow();
            newRow["codeCreditCard"] = this.codeCreditCard; 
            newRow["numCreditCard"] = this.numCreditCard;
            newRow["validityOfCreditCard"] = this.validityOfCreditCard;
            newRow["IDOwnerCard"] = this.idOwner;
            newRow["CodeOrder"] = this.codeOrder;
            newRow["ThreeNumOnCard"] = this.threeNumOnCard;
            newRow["totalOfPrice"] = this.totalOfPrice;
            newRow["numOfPayments"] = this.numOfPayments;
            newRow["kindOfDeal"] = this.kindOfDeal;



            return newRow;
        }
    }
}
