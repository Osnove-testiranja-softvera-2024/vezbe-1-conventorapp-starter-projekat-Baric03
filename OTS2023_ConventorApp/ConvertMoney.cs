using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class ConvertMoney
    {
        public static string ConvertDollarToDin(string pocetna)
        {
            double rez = Convert.ToDouble(pocetna) * 108.54;
            return rez.ToString();
        }

        public static string ConvertArrayDollarToDin(string pocetna)
        {
            string[] values = pocetna.Split(',');
            double[] results = new double[values.Length];
            string rez = "";
            for (int i = 0; i < values.Length; i++)
            {
                results[i] = Convert.ToDouble(values[i]) * 108.54;
                rez += Math.Round(results[i], 2) + " -- ";
            }

            return rez.ToString();
        }
    }
}
