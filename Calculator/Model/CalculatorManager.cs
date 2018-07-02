using System;

namespace Calculator.Model
{

    public class CalculatorManager
    {
        public EventHandler<ResultEventArgs> NotifyResultEvent;

        #region Constructor

        private static CalculatorManager _uniqueCalculatorManager;
        private CalculatorManager()
        {

        }
        #endregion

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
            NotifyResultEvent?.Invoke(this, new ResultEventArgs { Result = result.ToString() });
            return result;
        }
    }

    public class ResultEventArgs : EventArgs
    {
        public string Result { get; set; }
    }

}


