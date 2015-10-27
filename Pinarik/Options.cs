using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pinarik
{
    /**
     * 
     */
    public class Options
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
        
    }
}
