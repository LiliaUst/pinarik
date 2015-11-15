using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pinarik
{
    public class PinarikData
    {
        private string name = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int year = 0;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private bool allYear = true;
        public bool AllYear
        {
            get { return allYear; }
            set { allYear = value; }
        }
        private int monthFrom = 1;
        public int MonthFrom
        {
            get { return monthFrom; }
            set { monthFrom = value; }
        }
        private int monthTo = 12;
        public int MonthTo
        {
            get { return monthTo; }
            set { monthTo = value; }
        }

        public PinarikData()
        {
            this.year = DateTime.Now.Year;
        }
    }
}
