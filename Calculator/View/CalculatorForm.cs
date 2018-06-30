﻿using Calculator.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorFrom : Form, ICalculatorViewable
    {
        public CalculatorFrom()
        {
            InitializeComponent();
            _presenter = new CalculatorPresenter(this);
        }

        #region ICalculatorViewable Members

        public IList<string> OperatorList
        {
            get { return (IList<string>)this.OperatorSelectionBox.DataSource; }
            set { this.OperatorSelectionBox.DataSource = value; }
        }

        public string FirstOperand
        {
            get { return this.FirstNum.Text; }
        }

        public string SecondOperand
        {
            get { return this.SecNum.Text; }
        }

        public string CalculationResult
        {
            set { this.ResultText.Text = value; }
        }

        public string CalculationOperator
        {
            get { return OperatorSelectionBox.SelectedItem.ToString(); }
        }

        public void ShowMessageBox(string msg)
        {
            MessageBox.Show(msg);
        }

        #endregion

        #region private methods   
        private void calculateButton_Click(object sender, EventArgs e)
        {
            _presenter.OnCalculateButtonClick();
        }

        private void CalculatorFrom_Created(object sender, EventArgs e)
        {
            _presenter.OnHandleCalculatorFormCreated();
        }

        private void CalculatorFrom_FormDestroyed(object sender, EventArgs e)
        {
            _presenter.OnHandleCalculationFormDestroyed();
        }
        #endregion  
        private readonly CalculatorPresenter _presenter;
    }
}
