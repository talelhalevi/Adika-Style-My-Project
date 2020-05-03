using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
   public  class CreditCardOfCustomersTable : GeneralTable
    {
        public CreditCardOfCustomersTable()
           : base("CreditCardOfCustomers", "codeCreditCard", false)
        {

        }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["codeCreditCard"] = from["codeCreditCard"];
            to["validityOfCreditCard"] = from["codeItemInStoke"];
            to["IDOwnerCard"] = from["IDOwnerCard"];
            to["ThreeNumOnCard"] = from["ThreeNumOnCard"];
            to["totalOfPrice"] = from["totalOfPrice"];
            to["numOfPayments"] = from["numOfPayments"];
            to["kindOfDeal"] = from["kindOfDeal"];

            to.EndEdit();
        }
        public int getNextCode()
        {
            int code = 1;
            string sql="SELECT max(CreditCardOfCustomers.codeCreditCard) FROM CreditCardOfCustomers;";
            DataTable d = DAL.DAL.GetTableFromSQL(sql);
            try
            {
                code = int.Parse(d.Rows[0][0].ToString()) + 1;
            }
            catch (Exception)
            {
                code = 1;
            }
            return code;
        }
    }
}
