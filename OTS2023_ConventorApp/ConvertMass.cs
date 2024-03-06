using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    public class ConvertMass
    {
        public static string ConvertPoundsToKilos(string pocetna)
        {
            double rez = Convert.ToDouble(pocetna) / 2.2046;
            return rez.ToString();
        }
    }
}
