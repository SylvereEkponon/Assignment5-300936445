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
 * Version: 0.5 - Added the reset method which clears the form 
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
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        private void Calculate_BMI (double height, double weight)
        {
            if (MetricRadioButton.Checked)
            {
                double result = weight / Math.Pow(height, 2);
                resultTextBox.Text = Convert.ToString(result);
            }
            else
            {
                double result = (weight*703) / Math.Pow(height, 2);
                resultTextBox.Text = Convert.ToString(result);
            }
        }

        /// <summary>
        /// This is the HeightTextBox_KeyPress method which limits user's input
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
        }
    }
}
