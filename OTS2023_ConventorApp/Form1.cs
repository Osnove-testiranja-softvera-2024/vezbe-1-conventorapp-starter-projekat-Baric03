using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioMass.Checked)
            {
                txtKonvertovana.Text =  ConvertMass.ConvertPoundsToKilos(txtPocetna.Text);
            }
            else if(radioLength.Checked)
            {
                txtKonvertovana.Text = ConvertLength.ConvertFtToMeters(txtPocetna.Text);
            }
            else
            {
                MessageBox.Show("Niste selektovali tip konverzije!");
            }
        }

        private void radioMass_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds:";
            label2.Text = "Kg:";
        }

        private void radioLength_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Ft:";
            label2.Text = "Meters:";
        }

        public string GetConvertValue()
        {
            return txtPocetna.Text;
        }

        public void SetConvertValue(string x)
        {
            txtKonvertovana.Text = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
