using Calculator.View;
using System;
using System.Windows.Forms;

namespace Calculator
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
            new ResultForm().Show();
            new ResultForm().Show();
            Application.Run(new CalculatorFrom());
        }
    }
}
