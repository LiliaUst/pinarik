using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pinarik
{
    public static class Global
    {
        public static string getNameMonth(int month)
        {
            if (month < 1 || month > 12)
                return "";
            DateTime dt = new DateTime(DateTime.Now.Year, month, 1);
            return dt.ToString("MMMM");
        }

        public static int getDayOfWeek(int month, int year)
        {
            if (month < 1 || month > 12)
                return 1;
            DateTime dt = new DateTime(year, month, 1);
            return (int)dt.DayOfWeek == 0 ? 7 : (int)dt.DayOfWeek;
        }
    }
}
