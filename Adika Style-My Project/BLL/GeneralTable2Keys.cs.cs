using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Adika_Style_My_Project.DAL;

namespace Adika_Style_My_Project.BLL
{
     public class GeneralTable2Keys:GeneralTable
    {
        private string anotherKey;
        public GeneralTable2Keys(string key, string anotherkey, string tableName, bool isStatus)

            : base(tableName, key, isStatus)
        {
            this.anotherKey = anotherkey;
        }

        public override bool isSameKeys(DataRow dr1, DataRow dr2)
        {
            return base.isSameKeys(dr1, dr2) && dr1[anotherKey].Equals(dr2[anotherKey]);
        }
    }
}
