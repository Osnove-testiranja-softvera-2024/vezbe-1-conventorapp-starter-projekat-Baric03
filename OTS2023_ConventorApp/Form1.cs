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

        //Button for conversion
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPocetna.Text == "")
            {
                MessageBox.Show("Blank TextBox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radioMass.Checked && radioSingleValue.Checked)
                {
                    txtKonvertovana.Text = ConvertMass.ConvertPoundsToKilos(txtPocetna.Text);
                }
                else if (radioLength.Checked && radioSingleValue.Checked)
                {
                    txtKonvertovana.Text = ConvertLength.ConvertFtToMeters(txtPocetna.Text);
                }
                else if (radioMoney.Checked && radioSingleValue.Checked)
                {
                    txtKonvertovana.Text = ConvertMoney.ConvertDollarToDin(txtPocetna.Text);
                }
                else if (radioHours.Checked)
                {
                    txtKonvertovana.Text = ConvertTime.ConvertToHours(txtPocetna.Text);
                }
                else if (radioMinutes.Checked)
                {
                    txtKonvertovana.Text = ConvertTime.ConvertToMinutes(txtPocetna.Text);
                }
                else if (radioSeconds.Checked)
                {
                    txtKonvertovana.Text = ConvertTime.ConvertToSeconds(txtPocetna.Text);
                }
                else if (radioCustomMoney.Checked)
                {
                    txtKonvertovana.Text = ConvertCustomMoney.ConvertToDin(txtPocetna.Text);
                }
                else if(radioArrayOfValues.Checked && radioMass.Checked)
                {
                    txtKonvertovana.Text = ConvertMass.ConvertArrayPoundsToKilos(txtPocetna.Text);
                }
                else if (radioArrayOfValues.Checked && radioLength.Checked)
                {
                    txtKonvertovana.Text = ConvertLength.ConvertArrayFtToMeters(txtPocetna.Text);
                }
                else if (radioArrayOfValues.Checked && radioMoney.Checked)
                {
                    txtKonvertovana.Text = ConvertMoney.ConvertArrayDollarToDin(txtPocetna.Text);
                }
                else
                {
                    MessageBox.Show("Select Conversion And Segment Type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Mass
        private void radioMass_CheckedChanged(object sender, EventArgs e)
        {
            radioArrayOfValues.Checked = false;
            radioSingleValue.Checked = false;
            label1.Text = "Pounds:";
            label2.Text = "Kg:";
            groupBoxTimeOutput.Visible = false;
            groupBoxSegmentType.Visible = true;
            txtPocetna.Text = string.Empty;
            txtKonvertovana.Text = string.Empty;
        }

        //Length
        private void radioLength_CheckedChanged(object sender, EventArgs e)
        {
            radioArrayOfValues.Checked = false;
            radioSingleValue.Checked = false;
            label1.Text = "Ft:";
            label2.Text = "Meters:";
            groupBoxTimeOutput.Visible = false;
            groupBoxSegmentType.Visible = true;
            txtPocetna.Text = string.Empty;
            txtKonvertovana.Text = string.Empty;
        }

        //Getter and Setter for TxtBoxes
        public string GetConvertValue()
        {
            return txtPocetna.Text;
        }

        public void SetConvertValue(string x)
        {
            txtKonvertovana.Text = x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hiding groupBoxes
            groupBoxTimeOutput.Visible = false;
            groupBoxSegmentType.Visible = false;
        }

        //Time convertor
        private void radioHours_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Days:";
            label2.Text = "Hours:";
        }

        private void radioMinutes_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Days:";
            label2.Text = "Minutes:";
        }

        private void radioSeconds_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Days:";
            label2.Text = "Seconds:";
        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {
            radioArrayOfValues.Checked = false;
            radioSingleValue.Checked = false;
            groupBoxTimeOutput.Visible = true;
            groupBoxSegmentType.Visible = false;
            txtPocetna.Text = string.Empty;
            txtKonvertovana.Text = string.Empty;
        }

        //Money
        private void radioMoney_CheckedChanged(object sender, EventArgs e)
        {
            radioArrayOfValues.Checked = false;
            radioSingleValue.Checked = false;
            label1.Text = "$:";
            label2.Text = "Din:";
            groupBoxSegmentType.Visible = true;
            groupBoxTimeOutput.Visible = false;
            txtPocetna.Text = string.Empty;
            txtKonvertovana.Text = string.Empty;
        }

        //Custom Money
        private void radioCustomMoney_CheckedChanged(object sender, EventArgs e)
        {
            radioArrayOfValues.Checked = false;
            radioSingleValue.Checked = false;
            label1.Text = "Custom money:";
            label2.Text = "Din:";
            groupBoxSegmentType.Visible = false;
            groupBoxTimeOutput.Visible = false;
            txtPocetna.Text = string.Empty;
            txtKonvertovana.Text = string.Empty;
        }
    }
}
