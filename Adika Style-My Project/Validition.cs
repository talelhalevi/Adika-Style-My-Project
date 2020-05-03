using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adika_Style_My_Project
{
    public class Validition
    {
        public static bool correctId(string id)
        {
            int[] array = new int[9];
            int sum = 0;
            if (id.Length < 9)
            {
                for (int i = 0; i < 9 - id.Length; i++)
                    id = "0" + id;
            }
            for (int i = 0; i < 9; i += 2)
                array[i] = Convert.ToInt32(id[i].ToString());
            for (int i = 1; i < 8; i += 2)
                array[i] = Convert.ToInt32(id[i].ToString()) * 2;
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > 9) array[i] = array[i] % 10 + array[i] / 10;
                sum += array[i];
            }
            if (sum % 10 == 0) return true;
            return false;
        }

        public static bool isIdChar(char c)
        {
            return (Char.IsDigit(c) || c == '\b');
        }
        public static bool isIdMoreThanNime(string id, char c)
        {
            return (id.Length == 9 && c != '\b');
        }
    }
}
