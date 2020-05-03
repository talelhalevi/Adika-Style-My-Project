using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
//using Microsoft.Office.Interop.Access;

namespace Adika_Style_My_Project.DAL
{
      
    public static class DAL
    {
        private static DataSet dsProject;
        private static OleDbConnection con;
        private static OleDbDataAdapter[] adapters;
        private static string[] TableNames = new string[] { "AddPointsCredit", "Colors", "CreditCardOfCustomers", "Customers", "ItemStock", "Items", "Orders", "Sizes", "OrderDetails" };
       // public static Microsoft.Office.Interop.Access.Application oAccess = null;
       // static String dbpath = Environment.CurrentDirectory + "\\AdikaStyle.accdb'";

        /// <summary>
        /// שיטה המתחברת למסד נתונים וממלא את הטבלאות בדטה סט
        /// </summary>
        public static void ConnectToDB()
        {
            dsProject = new DataSet();
            // מחזיר את המיקום הנוכחי של התוכנית
            //System.IO.Directory.GetCurrentDirectory()
          // con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + System.IO.Directory.GetCurrentDirectory() + @"\store.accdb'");
           con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='"+System.IO.Directory.GetCurrentDirectory()+ "\\AdikaStyle.accdb'");
            adapters = new OleDbDataAdapter[TableNames.Length];

            for (int i = 0; i < TableNames.Length; i++)
            {
                adapters[i] = new OleDbDataAdapter("select * from " + TableNames[i], con);
                adapters[i].Fill(dsProject, TableNames[i]);
                // בנית פקודות לעדכון
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapters[i]);
                adapters[i].InsertCommand = builder.GetInsertCommand();
                adapters[i].UpdateCommand = builder.GetUpdateCommand();
                adapters[i].DeleteCommand = builder.GetDeleteCommand();
            }
        }
        /// <summary>
        /// שיטה המקבלת שם טבלה ומחזירה את הדטהטייבל מתוך הדטהסט
        /// </summary>
        /// <param name="tableName">שם הטבלה</param>
        /// <returns>dataTable</returns>
        public static DataTable GetTable(string tableName)
        {
            return dsProject.Tables[tableName];
        }
        public static DataTable GetTableFromSQL(string sqlSelect)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static void Update(string tableName)
        {
            for (int i = 0; i < TableNames.Length; i++)
            {
                if (TableNames[i] == tableName)
                    adapters[i].Update(dsProject, tableName);
            }
        }
        ////הדפסת דוחות עם פרמטר
        public static void DealWithReport(string reportName, string whereCondindition)
        {
          ////  Microsoft.Office.Interop.Access.Application oAccess = null;
          //  // Start a new instance of Access for Automation:
          //  try
          //  {
          //      oAccess = new Microsoft.Office.Interop.Access.Application();
          //      // Open a database in exclusive mode:
          //      oAccess.OpenCurrentDatabase(dbpath, true);
          //      // Preview a report named Sales:
          //      oAccess.DoCmd.OpenReport(
          //         reportName, //ReportName
          //        AcView.acViewPreview, //View
          //         System.Reflection.Missing.Value, //FilterName
          ////        whereCondindition //WhereCondition
          ////         );
          //      oAccess.DoCmd.OutputTo(AcOutputObjectType.acOutputReport, System.Reflection.Missing.Value, "pdf", System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
          //  }
          //  catch (Exception ex)
          //  {
          //      throw new Exception("הדוח מוצג");
          //  }

          //  oAccess.Quit();

        }
    }
}
    

