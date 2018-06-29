using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public delegate void ResultUpdateEvenetHandler(object sender, ResultUpdateEventArgs e);

    public class ResultUpdateEventArgs : EventArgs
    {
        public string Result { get; set; }

        public ResultUpdateEventArgs(string result)
        {
            Result = result;
        }
    }

    public interface ICalculatorManagerable
    {
        event ResultUpdateEvenetHandler ResultUpdated;
        void NotifyReportTemplateUpdated();
    }
}
