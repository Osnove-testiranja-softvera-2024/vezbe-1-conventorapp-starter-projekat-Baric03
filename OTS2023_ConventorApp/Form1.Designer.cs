namespace OTS2023_ConventorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtPocetna = new System.Windows.Forms.TextBox();
            this.txtKonvertovana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMass = new System.Windows.Forms.RadioButton();
            this.radioLength = new System.Windows.Forms.RadioButton();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.radioCustomMoney = new System.Windows.Forms.RadioButton();
            this.groupBoxConverterType = new System.Windows.Forms.GroupBox();
            this.groupBoxTimeOutput = new System.Windows.Forms.GroupBox();
            this.radioHours = new System.Windows.Forms.RadioButton();
            this.radioMinutes = new System.Windows.Forms.RadioButton();
            this.radioSeconds = new System.Windows.Forms.RadioButton();
            this.groupBoxSegmentType = new System.Windows.Forms.GroupBox();
            this.radioSingleValue = new System.Windows.Forms.RadioButton();
            this.radioArrayOfValues = new System.Windows.Forms.RadioButton();
            this.groupBoxConverterType.SuspendLayout();
            this.groupBoxTimeOutput.SuspendLayout();
            this.groupBoxSegmentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(488, 418);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 54);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPocetna
            // 
            this.txtPocetna.Location = new System.Drawing.Point(423, 305);
            this.txtPocetna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPocetna.Name = "txtPocetna";
            this.txtPocetna.Size = new System.Drawing.Size(175, 26);
            this.txtPocetna.TabIndex = 1;
            // 
            // txtKonvertovana
            // 
            this.txtKonvertovana.Location = new System.Drawing.Point(423, 345);
            this.txtKonvertovana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKonvertovana.Name = "txtKonvertovana";
            this.txtKonvertovana.Size = new System.Drawing.Size(175, 26);
            this.txtKonvertovana.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // radioMass
            // 
            this.radioMass.AutoSize = true;
            this.radioMass.Location = new System.Drawing.Point(20, 34);
            this.radioMass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioMass.Name = "radioMass";
            this.radioMass.Size = new System.Drawing.Size(72, 24);
            this.radioMass.TabIndex = 5;
            this.radioMass.TabStop = true;
            this.radioMass.Text = "Mass";
            this.radioMass.UseVisualStyleBackColor = true;
            this.radioMass.CheckedChanged += new System.EventHandler(this.radioMass_CheckedChanged);
            // 
            // radioLength
            // 
            this.radioLength.AutoSize = true;
            this.radioLength.Location = new System.Drawing.Point(20, 68);
            this.radioLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioLength.Name = "radioLength";
            this.radioLength.Size = new System.Drawing.Size(84, 24);
            this.radioLength.TabIndex = 6;
            this.radioLength.TabStop = true;
            this.radioLength.Text = "Length";
            this.radioLength.UseVisualStyleBackColor = true;
            this.radioLength.CheckedChanged += new System.EventHandler(this.radioLength_CheckedChanged);
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Location = new System.Drawing.Point(20, 102);
            this.radioMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(81, 24);
            this.radioMoney.TabIndex = 7;
            this.radioMoney.TabStop = true;
            this.radioMoney.Text = "Money";
            this.radioMoney.UseVisualStyleBackColor = true;
            this.radioMoney.CheckedChanged += new System.EventHandler(this.radioMoney_CheckedChanged);
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(20, 136);
            this.radioTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(68, 24);
            this.radioTime.TabIndex = 8;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "Time";
            this.radioTime.UseVisualStyleBackColor = true;
            this.radioTime.CheckedChanged += new System.EventHandler(this.radioTime_CheckedChanged);
            // 
            // radioCustomMoney
            // 
            this.radioCustomMoney.AutoSize = true;
            this.radioCustomMoney.Location = new System.Drawing.Point(20, 170);
            this.radioCustomMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioCustomMoney.Name = "radioCustomMoney";
            this.radioCustomMoney.Size = new System.Drawing.Size(140, 24);
            this.radioCustomMoney.TabIndex = 9;
            this.radioCustomMoney.TabStop = true;
            this.radioCustomMoney.Text = "Custom Money";
            this.radioCustomMoney.UseVisualStyleBackColor = true;
            this.radioCustomMoney.CheckedChanged += new System.EventHandler(this.radioCustomMoney_CheckedChanged);
            // 
            // groupBoxConverterType
            // 
            this.groupBoxConverterType.Controls.Add(this.radioCustomMoney);
            this.groupBoxConverterType.Controls.Add(this.radioMass);
            this.groupBoxConverterType.Controls.Add(this.radioTime);
            this.groupBoxConverterType.Controls.Add(this.radioLength);
            this.groupBoxConverterType.Controls.Add(this.radioMoney);
            this.groupBoxConverterType.Location = new System.Drawing.Point(182, 44);
            this.groupBoxConverterType.Name = "groupBoxConverterType";
            this.groupBoxConverterType.Size = new System.Drawing.Size(177, 225);
            this.groupBoxConverterType.TabIndex = 10;
            this.groupBoxConverterType.TabStop = false;
            this.groupBoxConverterType.Text = "Converter Type";
            // 
            // groupBoxTimeOutput
            // 
            this.groupBoxTimeOutput.Controls.Add(this.radioHours);
            this.groupBoxTimeOutput.Controls.Add(this.radioMinutes);
            this.groupBoxTimeOutput.Controls.Add(this.radioSeconds);
            this.groupBoxTimeOutput.Location = new System.Drawing.Point(377, 44);
            this.groupBoxTimeOutput.Name = "groupBoxTimeOutput";
            this.groupBoxTimeOutput.Size = new System.Drawing.Size(146, 133);
            this.groupBoxTimeOutput.TabIndex = 11;
            this.groupBoxTimeOutput.TabStop = false;
            this.groupBoxTimeOutput.Text = "Time Output";
            // 
            // radioHours
            // 
            this.radioHours.AutoSize = true;
            this.radioHours.Location = new System.Drawing.Point(20, 34);
            this.radioHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioHours.Name = "radioHours";
            this.radioHours.Size = new System.Drawing.Size(77, 24);
            this.radioHours.TabIndex = 5;
            this.radioHours.TabStop = true;
            this.radioHours.Text = "Hours";
            this.radioHours.UseVisualStyleBackColor = true;
            this.radioHours.CheckedChanged += new System.EventHandler(this.radioHours_CheckedChanged);
            // 
            // radioMinutes
            // 
            this.radioMinutes.AutoSize = true;
            this.radioMinutes.Location = new System.Drawing.Point(20, 68);
            this.radioMinutes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioMinutes.Name = "radioMinutes";
            this.radioMinutes.Size = new System.Drawing.Size(90, 24);
            this.radioMinutes.TabIndex = 6;
            this.radioMinutes.TabStop = true;
            this.radioMinutes.Text = "Minutes";
            this.radioMinutes.UseVisualStyleBackColor = true;
            this.radioMinutes.CheckedChanged += new System.EventHandler(this.radioMinutes_CheckedChanged);
            // 
            // radioSeconds
            // 
            this.radioSeconds.AutoSize = true;
            this.radioSeconds.Location = new System.Drawing.Point(20, 102);
            this.radioSeconds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSeconds.Name = "radioSeconds";
            this.radioSeconds.Size = new System.Drawing.Size(97, 24);
            this.radioSeconds.TabIndex = 7;
            this.radioSeconds.TabStop = true;
            this.radioSeconds.Text = "Seconds";
            this.radioSeconds.UseVisualStyleBackColor = true;
            this.radioSeconds.CheckedChanged += new System.EventHandler(this.radioSeconds_CheckedChanged);
            // 
            // groupBoxSegmentType
            // 
            this.groupBoxSegmentType.Controls.Add(this.radioSingleValue);
            this.groupBoxSegmentType.Controls.Add(this.radioArrayOfValues);
            this.groupBoxSegmentType.Location = new System.Drawing.Point(543, 44);
            this.groupBoxSegmentType.Name = "groupBoxSegmentType";
            this.groupBoxSegmentType.Size = new System.Drawing.Size(170, 102);
            this.groupBoxSegmentType.TabIndex = 12;
            this.groupBoxSegmentType.TabStop = false;
            this.groupBoxSegmentType.Text = "Segment Type";
            // 
            // radioSingleValue
            // 
            this.radioSingleValue.AutoSize = true;
            this.radioSingleValue.Location = new System.Drawing.Point(20, 34);
            this.radioSingleValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioSingleValue.Name = "radioSingleValue";
            this.radioSingleValue.Size = new System.Drawing.Size(123, 24);
            this.radioSingleValue.TabIndex = 5;
            this.radioSingleValue.TabStop = true;
            this.radioSingleValue.Text = "Single Value";
            this.radioSingleValue.UseVisualStyleBackColor = true;
            // 
            // radioArrayOfValues
            // 
            this.radioArrayOfValues.AutoSize = true;
            this.radioArrayOfValues.Location = new System.Drawing.Point(20, 68);
            this.radioArrayOfValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioArrayOfValues.Name = "radioArrayOfValues";
            this.radioArrayOfValues.Size = new System.Drawing.Size(145, 24);
            this.radioArrayOfValues.TabIndex = 6;
            this.radioArrayOfValues.TabStop = true;
            this.radioArrayOfValues.Text = "Array Of Values";
            this.radioArrayOfValues.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBoxSegmentType);
            this.Controls.Add(this.groupBoxTimeOutput);
            this.Controls.Add(this.groupBoxConverterType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKonvertovana);
            this.Controls.Add(this.txtPocetna);
            this.Controls.Add(this.btnConvert);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConverterType.ResumeLayout(false);
            this.groupBoxConverterType.PerformLayout();
            this.groupBoxTimeOutput.ResumeLayout(false);
            this.groupBoxTimeOutput.PerformLayout();
            this.groupBoxSegmentType.ResumeLayout(false);
            this.groupBoxSegmentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtPocetna;
        private System.Windows.Forms.TextBox txtKonvertovana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioMass;
        private System.Windows.Forms.RadioButton radioLength;
        private System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.RadioButton radioCustomMoney;
        private System.Windows.Forms.GroupBox groupBoxConverterType;
        private System.Windows.Forms.GroupBox groupBoxTimeOutput;
        private System.Windows.Forms.RadioButton radioHours;
        private System.Windows.Forms.RadioButton radioMinutes;
        private System.Windows.Forms.RadioButton radioSeconds;
        private System.Windows.Forms.GroupBox groupBoxSegmentType;
        private System.Windows.Forms.RadioButton radioSingleValue;
        private System.Windows.Forms.RadioButton radioArrayOfValues;
    }
}

