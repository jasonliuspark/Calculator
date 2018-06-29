using System;
using Calculator.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Calculator.View;
using Calculator.Model;


namespace Calculator.Presenter
{
   // public delegate void ResultEventHandler(string result);
    public class CalculatorPresenter
    {
        private string _result;
        //public delegate void ResultEventHandler(string result);
       // public ResultEventHandler NotifyResultEvent;

        public CalculatorPresenter(ICalculatorViewable view)
        {
            _view = view;
            _view.OperatorList = new List<string>() { "+", "-", "*", "/" };
            //_calculatorManagerable = ();
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
                _result = new CalculatorManager().Calculate(operatorSymbol, operands[0], operands[1]).ToString();
                //NotifyResultEvent(_result);
            }
            else
            {
                _view.ShowMessageBox("please input valid numbers for both text boxes");
            }
        }

        private void Observer()
        {
            //NotifyResultEvent += UpdateResultMain;
            // NotifyResultEvent += UpdateResultSecond;
        }

        public void CalculationFormClosed()
        {
            Unobserver();
        }
        private void Unobserver()
        {
            //NotifyResultEvent -= UpdateResultMain;
            // NotifyResultEvent -= UpdateResultSecond;

        }

        private void UpdateResultMain(string result)
        {
            _view.CalculationResult = result;
        }
        private void UpdateResultSecond(string result)
        {
            //_resultFormView.Result = result;
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

        private readonly ICalculatorViewable _view;
        //private readonly IResultFormViewable _resultFormView;
        private readonly ICalculatorManagerable _calculatorManagerable;

    }


}
