using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Sylvere Ekponon
 * Student ID: 300936445
 * Date: August 2, 2017
 * Description: BMI Calculator using windows forms and UI Controls
 * Version: 0.1 - Project was created
 */

namespace Assignment5_300936445
{
    public static class Program
    {
        //Create Reference to BMICalculator
        public static BMICalculator bmiCalculator;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate a new object of type CalculatorForm
            bmiCalculator = new BMICalculator();

            Application.Run(new SpashScreen());
        }
    }
}
