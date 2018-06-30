using System;

namespace Calculator.Model
{

    public class CalculatorManager
    {
        public EventHandler<ResultEventEventArgs> NotifyResultEvent;

        #region Public Methods
        private static CalculatorManager _uniqueCalculatorManager;
        private CalculatorManager()
        {

        }

        public static CalculatorManager Instance => _uniqueCalculatorManager ?? (_uniqueCalculatorManager = new CalculatorManager());

        public double Calculate(string operand, double firstNum, double secondNum)
        {
            double result = 0;
            switch (operand)
            {
                case "+":
                    result = (firstNum + secondNum);
                    break;
                case "-":
                    result = (firstNum - secondNum);
                    break;
                case "*":
                    result = (firstNum * secondNum);
                    break;
                case "/":
                    result = Math.Round((firstNum / secondNum), 2);
                    break;
                default:
                    break;
            }
            NotifyResultEvent(this, new ResultEventEventArgs(result.ToString()));
            return result;
        }
        #endregion
    }
    public class ResultEventEventArgs : EventArgs
    {
        public string Result { get; set; }

        public ResultEventEventArgs(string result)
        {
            Result = result;
        }
    }

}


