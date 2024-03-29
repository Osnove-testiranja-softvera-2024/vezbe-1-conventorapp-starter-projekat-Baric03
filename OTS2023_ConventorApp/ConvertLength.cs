﻿using System;
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

        public static string ConvertArrayFtToMeters(string pocetna)
        {
            string[] values = pocetna.Split(',');
            double[] results = new double[values.Length];
            string rez = "";
            for (int i = 0; i < values.Length; i++)
            {
                results[i] = Convert.ToDouble(values[i]) * 2.54;
                rez += Math.Round(results[i], 2) + " -- ";
            }

            return rez.ToString();
        }
    }
}
