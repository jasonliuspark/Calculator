using Calculator.View;
using System;
using System.Globalization;
using System.Threading;
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
            CultureInfo cultureInfo = new CultureInfo(CultureInfo.InstalledUICulture.Name);
            System.Diagnostics.Debug.WriteLine(CultureInfo.InstalledUICulture.Name);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            new ResultForm().Show();
            new ResultForm().Show();
            Application.Run(new CalculatorFrom());
        }
    }
}
