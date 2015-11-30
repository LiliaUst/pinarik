using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pinarik
{
    public sealed class DateTimeEx
    {
        /// <summary>
        /// Возвращает название месяца по его номеру.
        /// </summary>
        /// <param name="month">Номер месяца.</param>
        /// <returns>Название месяца.</returns>
        public static string getNameMonth(int month)
        {
            if (month < 1 || month > 12)
                return "";
            DateTime dt = new DateTime(DateTime.Now.Year, month, 1);
            return dt.ToString("MMMM");
        }

        /// <summary>
        /// Возвращает номер дня недели в первый день указанного месяца и года
        /// </summary>
        /// <param name="month">Номер месяца.</param>
        /// <param name="year">Год.</param>
        /// <returns>Номер дня недели.</returns>
        public static int getDayOfWeek(int month, int year)
        {
            if (month < 1 || month > 12)
                return 1;
            DateTime dt = new DateTime(year, month, 1);
            return (int)dt.DayOfWeek == 0 ? 7 : (int)dt.DayOfWeek;
        }
    }
}
