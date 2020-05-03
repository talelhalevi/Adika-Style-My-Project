using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adika_Style_My_Project.BLL
{
    public class Helper
    {
        public static bool isId(string s)
        {
            if (s.Length != 9)
                return false;
            // ' הוספת אפסים לת"ז קצרה 
            while (s.Length < 9)
                s = "0" + s;
            int num;
            int num2 = 0;
            // 'בדיקת תקינות  
            for (int i = 0; i < 8; i++)
            {
                num = s[i] - '0';
                if (i % 2 == 1)
                    num = num * 2;
                // 'טיפול במספר דו ספרתי
                if (num > 9)
                    num = num % 10 + 1;
                num2 = num2 + num;
            }
            //return num2%10 == 0 ? true:false;
            return true;
        }
    }
}
