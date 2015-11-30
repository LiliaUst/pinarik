using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pinarik
{
    /// <summary>
    /// Предназначен для хранения текущих настроек пинарика.
    /// </summary>
    public class PinarikData
    {
        /// <summary>
        /// Получение или установка названия пинарика.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Получение или установка года пинарика.
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Получение или установка признака, что нужно печатать все месяцы года
        /// </summary>
        public bool AllYear { get; set; }
        /// <summary>
        /// Получение или установка месяца, с которого печатается пинарик.
        /// </summary>
        public int MonthFrom { get; set; }
        /// <summary>
        /// Получение или установка месяца, до которого печатается пинарик.
        /// </summary>
        public int MonthTo { get; set; }

        /// <summary>
        /// Конструирует экземпляр настройки пинарика.
        /// </summary>
        public PinarikData()
        {
            this.Name = "";
            this.Year = DateTime.Now.Year;
            this.AllYear = true;
            this.MonthFrom = 1;
            this.MonthTo = 12;
        }
    }
}
