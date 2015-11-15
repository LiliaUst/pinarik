using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Pinarik
{
    public class PinarikView
    {
        private PinarikData pinarikData;
        private static string templateIndex = "";
        private static string templateMonth = "";
        private static string templateDayActive = "";
        private static string templateDayInactive = "";

        public PinarikView(PinarikData data)
        {
            this.pinarikData = data;
        }
        public string CreateView()
        {
            //ConfigurationManager.AppSettings["MyKey"];

            //Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //currentConfig.AppSettings.Settings["server"].Value = _serverTextBox.Text;

            PinarikView.InitTemplate();

            var uri = new Uri(Path.GetFullPath(ConfigurationManager.AppSettings["templateStyle"]));
           
            string content = "";
            int monthBegin = this.pinarikData.AllYear ? 1 : this.pinarikData.MonthFrom;
            int monthEnd = this.pinarikData.AllYear ? 12 : this.pinarikData.MonthTo;
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
                .Replace("$title", this.pinarikData.Year + (!String.IsNullOrEmpty(this.pinarikData.Name) ? " - " + this.pinarikData.Name : ""))
                .Replace("$month", month);

            return content;
        }

        private string GetDays(int numMonth)
        {
            string days = "";
            DateTime dt = new DateTime(this.pinarikData.Year, numMonth, 2);

            for (int l = 1; l <= 7; l++)
            {
            }

            int day = Global.getDayOfWeek(numMonth, this.pinarikData.Year);
            int i = 1;
            for (; i < day; i++)
            {
                days += PinarikView.templateDayInactive;
            }

            for (int numDay = 1; i < DateTime.DaysInMonth(this.pinarikData.Year, numMonth) + day; i++, numDay++)
            {
                days += PinarikView.templateDayActive.Replace("$day", numDay.ToString());
            }

            int cnt = i % 7 == 0 ? 1 : (7 - i % 7 + 1);
            if (cnt < 7)
            {
                for (int j = 1; j <= cnt; j++, i++)
                {
                    days += PinarikView.templateDayInactive;
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
            return pathTmpPreview;
        }

        
    }
}
