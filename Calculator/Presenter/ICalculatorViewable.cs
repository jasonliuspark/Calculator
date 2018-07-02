using System.Collections.Generic;

namespace Calculator.Presenter
{
    public interface ICalculatorViewable
    {
        #region Members

        IList<string> OperatorList { set; }
        string FirstOperand { get; }
        string SecondOperand { get; }
        string CalculationResult { set; }
        string CalculationOperator { get; }
        void ShowMessageBox(string msg);

        #endregion
    }
}
