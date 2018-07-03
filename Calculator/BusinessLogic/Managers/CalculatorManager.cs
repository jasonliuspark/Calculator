using Calculator.DataAccess.Results;
using Calculator.Domain.Results;
using System;
using System.Data;

namespace Calculator.BusinessLogic.Managers
{
    public class CalculatorManager
    {
        public EventHandler<ResultEventArgs> NotifyResultEvent;

        public EventHandler<UpdateDbEventArgs> UpdateDbEvent;
        #region Constructor       

        private CalculatorManager(ICalculationResults results)
        {
            _iCalculationResults = results;
        }
        #endregion

        public static CalculatorManager Instance => _uniqueCalculatorManager ?? (_uniqueCalculatorManager = new CalculatorManager(ResultRepository.Instance));

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
            _iCalculationResults.CalculationResultDbInsertion(firstNum, operand, secondNum, result);
            UpdateDbEvent?.Invoke(this, new UpdateDbEventArgs { CalculatinResult = _iCalculationResults.GetResultData() });
            return result;
        }

        #region Private Fields

        private static CalculatorManager _uniqueCalculatorManager;
        private readonly ICalculationResults _iCalculationResults;

        #endregion

    }

    public class ResultEventArgs : EventArgs
    {
        public string Result { get; set; }
    }

    public class UpdateDbEventArgs : EventArgs
    {
        public DataTable CalculatinResult { get; set; }
    }
}


