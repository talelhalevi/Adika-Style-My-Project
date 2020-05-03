using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public enum StatusKind { add, update, delete, show };
public enum Season { summer, winter, allSeason };

namespace Adika_Style_My_Project
{
    class GlobalClass
    {
        public static Season GetSeason(int month)
        {
            switch (month)
            {
                case 1: return Season.winter;
                case 2: return Season.winter;
                case 3: return Season.winter;
                case 4: return Season.allSeason;
                case 5: return Season.summer;
                case 6: return Season.summer;
                case 7: return Season.summer;
                case 8: return Season.summer;
                case 9: return Season.summer;
                case 10: return Season.allSeason;
                case 11: return Season.winter;
                case 12: return Season.winter;
                default: return Season.allSeason;

            }

        }
    }
}
