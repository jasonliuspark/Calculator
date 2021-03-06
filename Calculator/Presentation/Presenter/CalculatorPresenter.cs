﻿using Calculator.BusinessLogic.Managers;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator.Presentation.Presenter
{
    public class CalculatorPresenter
    {
        #region Constructor

        public CalculatorPresenter(ICalculatorViewable view)
        {
            _view = view;
            _view.OperatorList = new List<string>() { "+", "-", "*", "/" };
        }

        #endregion

        #region Public Methods

        public void OnHandleCreated()
        {
            Observe();
        }

        public void OnHandleDestroyed()
        {
            Unobserve();
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
                CalculatorManager.Instance.Calculate(operatorSymbol, operands[0], operands[1]);
            }
            else
            {
                _view.ShowMessageBox(Properties.Resources.strInvalidInputNumberMsg);
            }
        }

        #endregion

        #region Private Methods

        private void Observe()
        {
            CalculatorManager.Instance.NotifyResultEvent += UpdateResultMain;
        }

        private void Unobserve()
        {
            CalculatorManager.Instance.NotifyResultEvent -= UpdateResultMain;
        }

        private void UpdateResultMain(object sender, ResultEventArgs e)
        {
            _view.CalculationResult = e.Result;
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

        #region Private Fields

        private readonly ICalculatorViewable _view;

        #endregion
    }
}
