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
 * Date: August 10, 2017
 * Description: BMI Calculator using windows forms and UI Controls
 * Version: 0.1 - Created SplashScreenTimer Tick event
 */

namespace Assignment5_300936445
{
    public partial class SpashScreen : Form
    {
        //PUBLIC PROPERTIES
        public BMICalculator BmiCalculator
        {
            get
            {
                return Program.bmiCalculator;
            }
        }

        //CONSTRUCTOR
        /// <summary>
        /// 
        /// </summary>
        public SpashScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.BmiCalculator.Show();
            this.Hide();

            SpashScreenTimer.Enabled = false;//turned timer off
        }
    }
}
