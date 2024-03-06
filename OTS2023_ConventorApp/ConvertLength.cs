using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class ConvertLength
    {
        public static string ConvertFtToMeters(string pocetna)
        {
            double rez = Convert.ToDouble(pocetna) * 2.54;
            return rez.ToString();
        }
    }
}
