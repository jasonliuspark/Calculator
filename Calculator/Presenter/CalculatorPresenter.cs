using Calculator.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Calculator.Presenter
{
    public class CalculatorPresenter
    {
        private string _result;

        public CalculatorPresenter(ICalculatorViewable view)
        {
            _view = view;
            _view.OperatorList = new List<string>() { "+", "-", "*", "/" };
        }


        public void CalculationFormLoad()
        {
            Observer();
        }

        public void OnCalculateButtonClick()
        {
            string firstOperand = _view.FirstOperand;
            string secondOperand = _view.SecondOperand;
            string operatorSymbol = _view.CalculationOperator;
            double[] operands = new double[5];

            if (InputRestrainTest(firstOperand) && InputRestrainTest(secondOperand))
            {
                operands = TryParseNum(firstOperand, secondOperand);
                _result = CalculatorManager.CalculateAction(operatorSymbol, operands[0], operands[1]).ToString();
                CalculatorManager.NotifyResultEvent(_result);
            }
            else
            {
                _view.ShowMessageBox("please input valid numbers for both text boxes");
            }
        }

        #region Private Methods  
        private void Observer()
        {
            CalculatorManager.NotifyResultEvent += UpdateResultMain;
        }

        public void CalculationFormClosed()
        {
            Unobserver();
        }
        private void Unobserver()
        {
            CalculatorManager.NotifyResultEvent -= UpdateResultMain;
        }

        private void UpdateResultMain(string result)
        {
            _view.CalculationResult = result;
        }

        private double[] TryParseNum(string firstNum, string secondNum)
        {
            double[] parseResult = new double[5];
            double.TryParse(firstNum, out parseResult[0]);
            double.TryParse(secondNum, out parseResult[1]);
            return parseResult;
        }

        private bool InputRestrainTest(string inputValidation)
        {

            if (inputValidation != "")
            {
                string pattern = @"^(-?\d+)(\.\d+)?$";
                Match mt = Regex.Match(inputValidation, pattern);
                if (!mt.Success)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            { return false; }
        }
        #endregion
        private readonly ICalculatorViewable _view;

    }


}
