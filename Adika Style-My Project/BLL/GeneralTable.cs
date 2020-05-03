using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Adika_Style_My_Project.BLL
{
  
    public class GeneralTable
    {
        protected DataTable dt;
        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        protected string NameOfTable;
        protected string Key;
        protected bool isStatus;


        public GeneralTable(string NameOfTable, string key, bool isStatus)
        {
            dt = DAL.DAL.GetTable(NameOfTable);
            this.Key = key;
            this.isStatus = isStatus;
        }
        public DataTable GetTable()
        {
            if (isStatus == true)
                return DAL.DAL.GetTableFromSQL(" SELECT * FROM " + Dt.TableName + " WHERE status=true");
            return dt;
        }
        public int GetNextCode()
        {
            int max = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row[this.Key]) > max)
                    max = Convert.ToInt32(row[this.Key]);
            }
            return max + 1;
        }
        public DataTable GetTable(string field1, string field2)
        {
            if (isStatus == true)
                return DAL.DAL.GetTableFromSQL(" SELECT " + this.Key + ",[" + field1 + "] + ' ' + [ " + field2 + " ] AS FullName FROM " + this.dt.TableName + " WHERE Status=true ");
            return DAL.DAL.GetTableFromSQL(" SELECT " + this.Key + " , [" + field1 + "]+ ' '  +[" + field2 + "] AS FullName FROM " + dt.TableName);

        }
        public DataRow Find(string colunmName, object value)
        {
            foreach (DataRow item in dt.Rows)
            {
                if (item[colunmName].Equals(value))
                    if (isStatus)
                    {
                        if (item["status"].Equals(true))
                            return item;
                    }
                    else
                        return item;
                        
            }
            return null;


        }
        public DataRow Find(string colunmName1, string colunmName2, object value1, object value2)
        {
            foreach (DataRow item in dt.Rows)
            {
                if (item[colunmName1].Equals(value1) && item[colunmName2].Equals(value2))
                    if (isStatus && item["status"].Equals(true))
                        return item;
            }
            return null;
        }
        public void update()
        {
            DAL.DAL.Update(dt.TableName);
        }
        public virtual bool Add(DataRow dr)
        {
            foreach (DataRow item in dt.Rows)
            {
                if (isSameKeys(dr, item))
                {
                    if (isStatus == true && item["status"].Equals(false))
                    {
                        item["status"] = true;

                        update(dr, item);
                        update();
                        return true;

                    }
                    else return false;
                }
            }
            dt.Rows.Add(dr);
            update();
            return true;
         }
        public virtual bool Update(DataRow drApdated)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (isSameKeys(drApdated, row))
                {
                    update(drApdated, row);
                    update();
                    return true;

                }
            }
            return false;
        }

        public virtual bool isSameKeys(DataRow dr1, DataRow dr2)
        {
            if (dr1[Key].ToString() == dr2[Key].ToString())
                return true;
            return false;
        }
        public virtual void update(DataRow r1, DataRow r2)
        {
        }
        public bool Delete(DataRow RowToDelete)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (isSameKeys(RowToDelete, row))
                    if (isStatus == true && row["status"].Equals(true))
                    {
                       row["status"] = false;
                       update();
                         return true;
                    }
                    else
                    {
                        row.Delete();
                        update();
                        return true;
                    }
            }
            return false;


        }


    } 
    
}

    
