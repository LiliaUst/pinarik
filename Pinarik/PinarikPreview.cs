using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Pinarik
{
    public class PinarikPreview
    {
        private Options options;
        private static string templateIndex = "";
        private static string templateMonth = "";
        private static string templateDayActive = "";
        private static string templateDayInactive = "";

        public PinarikPreview(Options options)
        {
            this.options = options;
        }
        public string GetContent()
        {
            //ConfigurationManager.AppSettings["MyKey"];

            //Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //currentConfig.AppSettings.Settings["server"].Value = _serverTextBox.Text;

            PinarikPreview.InitTemplate();

            var uri = new Uri(Path.GetFullPath(ConfigurationManager.AppSettings["templateStyle"]));
           
            string content = "";
            int monthBegin = this.options.AllYear ? 1 : this.options.MonthFrom;
            int monthEnd = this.options.AllYear ? 12 : this.options.MonthTo;
            string month = "";

            for (int numMonth = monthBegin; numMonth <= monthEnd; numMonth++)
            {
                string days = this.GetDays(numMonth);
                month += templateMonth
                    .Replace("$titleMonth", Global.getNameMonth(numMonth))
                    .Replace("$days", days);
            }

            content = templateIndex
                .Replace("$langPage", "ru")
                .Replace("$titlePage", "Пинарик")
                .Replace("$style", uri.AbsoluteUri)
                .Replace("$title", this.options.Year + (!String.IsNullOrEmpty(this.options.Name) ? " - " + this.options.Name : ""))
                .Replace("$month", month);

            return content;
        }

        private string GetDays(int numMonth)
        {
            string days = "";

            int x = 8, y = 8;
            DateTime dt = new DateTime(this.options.Year, numMonth, 2);

            for (int l = 1; l <= 7; l++)
            {
            }

            int day = Global.getDayOfWeek(numMonth, this.options.Year);
            int i = 1;
            for (; i < day; i++)
            {
                days += PinarikPreview.templateDayInactive;
            }

            for (int numDay = 1; i < DateTime.DaysInMonth(this.options.Year, numMonth) + day; i++, numDay++)
            {
                days += PinarikPreview.templateDayActive.Replace("$day", numDay.ToString());
            }

            int cnt = i % 7 == 0 ? 1 : (7 - i % 7 + 1);
            if (cnt < 7)
            {
                for (int j = 1; j <= cnt; j++, i++)
                {
                    days += PinarikPreview.templateDayInactive;
                }
            }
            return days;
        }
        private static void InitTemplate()
        {
            if (String.IsNullOrEmpty(PinarikPreview.templateIndex))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateIndex"])))
                {
                    PinarikPreview.templateIndex = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikPreview.templateMonth))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateMonth"])))
                {
                    PinarikPreview.templateMonth = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikPreview.templateDayActive))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateDayActive"])))
                {
                    PinarikPreview.templateDayActive = templ.ReadToEnd();
                }
            }
            if (String.IsNullOrEmpty(PinarikPreview.templateDayInactive))
            {
                using (StreamReader templ = new StreamReader(Path.GetFullPath(ConfigurationManager.AppSettings["templateDayInactive"])))
                {
                    PinarikPreview.templateDayInactive = templ.ReadToEnd();
                }
            }
        }
    }
}
