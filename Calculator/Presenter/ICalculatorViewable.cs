using System.Collections.Generic;

namespace Calculator.Presenter
{
    public interface ICalculatorViewable
    {
        IList<string> OperatorList { get; set; }

        string FirstOperand { get; }

        string SecondOperand { get; }

        string CalculationResult { set; }

        string CalculationOperator { get; }

        void ShowMessageBox(string msg);

        
    }
}
