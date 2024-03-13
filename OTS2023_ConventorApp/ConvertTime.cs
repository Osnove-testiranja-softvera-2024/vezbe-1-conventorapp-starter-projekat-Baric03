using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class ConvertTime
    {
        public static string ConvertToHours(string pocetna)
        {
            double rez = Convert.ToDouble(pocetna) * 24;
            return rez.ToString();
        }

        public static string ConvertToMinutes(string pocetna)
        {
            double rez = Convert.ToDouble(pocetna) * 24 * 60;
            return rez.ToString();
        }

        public static string ConvertToSeconds(string pocetna)
        {
            double rez = Convert.ToDouble(pocetna) * 24 * 60 * 60;
            return rez.ToString();
        }
    }
}
