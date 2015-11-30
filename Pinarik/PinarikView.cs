using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Pinarik
{
    /// <summary>
    /// Представляет отображаемый вид пинарика.
    /// </summary>
    public class PinarikView
    {
        private readonly int numMonthInRow = 3;
        /// <summary>
        /// Настройки пинарика.
        /// </summary>
        private PinarikData pinarikData;
        /// <summary>
        /// Шаблон файла index.html
        /// </summary>
        private static string templateIndex = "";
        private static string templateMonthRow = "";
        /// <summary>
        /// Шаблон представления месяца.
        /// </summary>
        private static string templateMonth = "";
        /// <summary>
        /// Шаблон представления дня месяца.
        /// </summary>
        private static string templateDayActive = "";
        /// <summary>
        /// Шаблон представления дня соседнего месяца.
        /// </summary>
        private static string templateDayInactive = "";
        /// <summary>
        /// Получение или установка uri файла с отображаемым видом пинарика.
        /// </summary>
        public string UriView { get; set; }

        /// <summary>
        /// Конструирует экземпляр внешнего вида пинарика.
        /// </summary>
        /// <param name="data">Настройки пинарика.</param>
        public PinarikView(PinarikData data)
        {
            this.pinarikData = data;
        }

        /// <summary>
        /// Создает внешний вид пинарика в соответствии с настройками.
        /// </summary>
        /// <returns></returns>
        public string CreateView()
        {
            PinarikView.InitTemplate();

            Uri uriStyle = new Uri(Path.GetFullPath(ConfigurationManager.AppSettings["templateStyle"]));
            Uri uriBootstrap = new Uri(Path.GetFullPath(ConfigurationManager.AppSettings["templateBootstrap"]));
           
            string content = "";
            int monthBegin = this.pinarikData.AllYear ? 1 : this.pinarikData.MonthFrom;
            int monthEnd = this.pinarikData.AllYear ? 12 : this.pinarikData.MonthTo;
            string month = "";
            string monthRow = "";


            int numRow = 1;
            string[] monthes = new string[3] { "", "", ""};
            for (int numMonth = monthBegin; numMonth <= monthEnd; numMonth++)
            {
                string row = "";
                //if ((numMonth - 1) % this.numMonthInRow == 0)
                //{

                //}
                monthes[(numMonth - 1) % this.numMonthInRow] = templateMonth
                    .Replace("$titleMonth", DateTimeEx.getNameMonth(numMonth))
                    .Replace("$days", this.GetDays(numMonth));
                if ((numMonth % this.numMonthInRow == 0) || (numMonth + 1) > monthEnd)
                {
                    monthRow += templateMonthRow
                        .Replace("$month1", monthes[0])
                        .Replace("$month2", monthes[1])
                        .Replace("$month3", monthes[2]);
                    numRow++;
                    monthes = new string[3] { "", "", "" };
                }


                //string days = this.GetDays(numMonth);
                //month += templateMonth
                //    .Replace("$titleMonth", DateTimeEx.getNameMonth(numMonth))
                //    .Replace("$days", days);
            }

            content = templateIndex
                .Replace("$langPage", "ru")
                .Replace("$titlePage", "Пинарик")
                .Replace("$style", uriStyle.AbsoluteUri)
                .Replace("$bootstrap", uriBootstrap.AbsoluteUri)
                .Replace("$title", this.pinarikData.Year + (!String.IsNullOrEmpty(this.pinarikData.Name) ? " - " + this.pinarikData.Name : ""))
                .Replace("$monthRow", monthRow);

            return content;
        }

        private string GetDays(int numMonth)
        {
            string days = "";
            DateTime dt = new DateTime(this.pinarikData.Year, numMonth, 2);

            //for (int l = 1; l <= 7; l++)
            //{
            //}

            int day = DateTimeEx.getDayOfWeek(numMonth, this.pinarikData.Year);

            int numTotalDay = DateTime.DaysInMonth(this.pinarikData.Year, numMonth) + day;
            int numRow = numTotalDay % 7;

            int i = 1;
            for (; i < day; i++)
            {
                if ((i - 1) % 7 == 0)
                {
                    days += "<div class=\"row\">";
                }
                days += PinarikView.templateDayInactive;
            }

            for (int numDay = 1; i < DateTime.DaysInMonth(this.pinarikData.Year, numMonth) + day; i++, numDay++)
            {
                if ((i - 1) % 7 == 0)
                {
                    days += "<div class=\"row\">";
                }
                days += PinarikView.templateDayActive.Replace("$day", numDay.ToString());
                if (i % 7 == 0)
                {
                    days += "</div>";
                }
            }

            int cnt = i % 7 == 0 ? 1 : (7 - i % 7 + 1);
            if (cnt < 7)
            {
                for (int j = 1; j <= cnt; j++, i++)
                {
                    days += PinarikView.templateDayInactive;
                    if (i % 7 == 0)
                    {
                        days += "</div>";
                    }
                }
            }
            return days;
        }
        private static void InitTemplate()
        {
            if (String.IsNullOrEmpty(PinarikView.templateIndex))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateIndex"])))
                {
                    PinarikView.templateIndex = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikView.templateMonthRow))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateMonthRow"])))
                {
                    PinarikView.templateMonthRow = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikView.templateMonth))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateMonth"])))
                {
                    PinarikView.templateMonth = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikView.templateDayActive))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateDayActive"])))
                {
                    PinarikView.templateDayActive = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikView.templateDayInactive))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateDayInactive"])))
                {
                    PinarikView.templateDayInactive = templ.ReadToEnd();
                }
            }
        }

        public string CreateViewFile()
        {
            string pathTmpPreview = Path.GetFullPath("index.html");
            StreamWriter wr = new StreamWriter(pathTmpPreview);
            wr.Write(this.CreateView());
            wr.Close();

            UriView = pathTmpPreview;
            return pathTmpPreview;
        }
    }
}
