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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
