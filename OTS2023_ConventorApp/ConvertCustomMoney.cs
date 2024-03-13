using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    internal class ConvertCustomMoney
    {
        public static string ConvertToDin(string pocetna)
        {
            double rez = 0;
            //Example: 50$

            string [] reci = pocetna.Split(' ');
            char currency = pocetna.Substring(pocetna.Length - 1, 1)[0];//Takes only $
            string num = reci[0].Substring(0, reci[0].Length - 1);//Takes only number

            if(currency == '$')
            {
                rez = Convert.ToDouble(num) * 108.54;
            }
            else if(currency == 'e' || currency == 'E')
            {
                rez = Convert.ToDouble(num) * 118.7;
            }
            else
            {
                MessageBox.Show("Unknown Currency!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            return rez.ToString();
        }
    }
}
