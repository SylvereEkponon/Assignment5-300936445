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
 * Version: 0.2 - created an event handler for the BMIcalculatorclosing
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
    }
}
