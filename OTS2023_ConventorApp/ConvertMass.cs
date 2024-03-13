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

        public static string ConvertArrayPoundsToKilos(string pocetna)
        {
            string[] values = pocetna.Split(',');
            double[] results = new double[values.Length];
            string rez = "";
            for (int i = 0; i < values.Length; i++) 
            {
                results[i] = Convert.ToDouble(values[i]) / 2.2046;
                rez += Math.Round(results[i], 2) + " -- ";
            }
            
            return rez.ToString();
        }
    }
}
