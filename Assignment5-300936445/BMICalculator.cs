using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Sylvere Ekponon
 * Student ID: 300936445
 * Date: August 2, 2017
 * Description: BMI Calculator using windows forms and UI Controls
 * Version: 0.9 - Refactored the CalculateBMIButton_click method
 */

namespace Assignment5_300936445
{
    public partial class BMICalculator : Form
    {
        //PRIVATE CONSTANCES
        private const int BACKSPACE = 8;
        private const int DECIMAL_PONT = 46;
        private const int ZERO = 48;
        private const int NINE = 57;
        private const int NOT_FOUND = -1;

        //PRIVATE INSTANCES VARIABLES
        private double _result;

        //PUBLIC PROPERTIES
        public double RESULT
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }


        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for the BMIcalculatorclosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method display metric units if MetricRadioButton is Checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked)
            {
                HeightUnitLabel.Text = "Meters";
                WeightUnitLabel.Text = "Kg";
            }
        }
        /// <summary>
        /// his method display imperial units if MetricRadioButton is Checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                HeightUnitLabel.Text = "Inches";
                WeightUnitLabel.Text = "Pounds";
            }
        }
        /// <summary>
        /// This is the private Calculate_BMI method
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        private void Calculate_BMI (double height, double weight)
        {
            if (MetricRadioButton.Checked)
            {
                this.RESULT = weight / Math.Pow(height, 2);
                resultTextBox.Text = string.Format("{0:f}",RESULT);
            }
            else
            {
                this.RESULT = (weight*703) / Math.Pow(height, 2);
                resultTextBox.Text = string.Format("{0:f}", this.RESULT);
            }
        }

        /// <summary>
        /// This is the HeightTextBox_KeyPress method which limits user's input
        /// Ref:https://www.codeproject.com/Tips/841727/How-to-Limit-TextBox-Entries-to-Decimal-or-Integer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyValue = e.KeyChar;

            if ((keyValue==BACKSPACE)||((keyValue>=ZERO)&&(keyValue<=NINE)))
            {
                return;
            }

            if ((keyValue == DECIMAL_PONT) && (HeightTextBox.Text.IndexOf(".")==NOT_FOUND))
            {
                return;
            }
            e.Handled = true;
        }

        /// <summary>
        /// This is the WeightTextBox_KeyPress method which limits user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyValue = e.KeyChar;

            if ((keyValue == BACKSPACE) || ((keyValue >= ZERO) && (keyValue <= NINE)))
            {
                return;
            }

            if ((keyValue == DECIMAL_PONT) && (WeightTextBox.Text.IndexOf(".") == NOT_FOUND))
            {
                return;
            }
            e.Handled = true;

        }
        /// <summary>
        /// This is the reset method which clears the form whenever the click button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            resultTextBox.Clear();
            BMIProgressBar.Hide();
        }

        /// <summary>
        /// This is the CalculateBMIButton_Click method which performs the calculation 
        /// whenever the calculate bmi button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (_checked())
            {
                double height = double.Parse(HeightTextBox.Text);
                double weight = double.Parse(WeightTextBox.Text);
                Calculate_BMI(height, weight);
                this._bmiProgressBar();
            }

           
        }
        /// <summary>
        /// This is the private _bmiProgressBar method
        /// </summary>
        private void _bmiProgressBar()
        {
            if (this.RESULT > 30)
            {
                BMIProgressBar.Value = BMIProgressBar.Maximum;
                BMIProgressBar.ForeColor = Color.Red;
            }
            else if (this.RESULT > 24.9)
            {
                BMIProgressBar.Value = (int)this.RESULT;
                BMIProgressBar.ForeColor = Color.Orange;
            }
            else if (this.RESULT > 18.5)
            {
                BMIProgressBar.Value = (int)this.RESULT;
                BMIProgressBar.ForeColor = Color.Green;
            }
            else
            {
                BMIProgressBar.Value = (int)this.RESULT;
                BMIProgressBar.ForeColor = Color.LightGreen;
            }
            BMIProgressBar.Show();
        }

        /// <summary>
        /// This is the private _checked()
        /// it returns true only if HeightTextBox.Text and WeightTextBox.Text are not empty
        /// </summary>
        /// <returns>tue</returns>
        private bool _checked()
        {
            if ((HeightTextBox.Text=="")||(WeightTextBox.Text==""))
            {
                return false;
            }
            return true;
        }
    }
}
