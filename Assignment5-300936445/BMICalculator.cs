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
 * Version: 0.3 - Added the MetricRadioButton_CheckedChanged method
 */

namespace Assignment5_300936445
{
    public partial class BMICalculator : Form
    {
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
    }
}
