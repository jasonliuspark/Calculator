using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Calculator.Presentation.Presenter;

namespace Calculator.Presentation.View
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
            set { OperatorSelectionBox.DataSource = value; }
        }

        public string FirstOperand
        {
            get { return FirstNum.Text; }
        }

        public string SecondOperand
        {
            get { return SecNum.Text; }
        }

        public string CalculationResult
        {
            set { ResultText.Text = value; }
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

        #region Event Handlers 

        private void calculateButton_Click(object sender, EventArgs e)
        {
            _presenter.OnCalculateButtonClick();
        }

        private void CalculatorFrom_HandleCreated(object sender, EventArgs e)
        {
            _presenter.OnHandleCreated();
        }

        private void CalculatorFrom_HandleDestroyed(object sender, EventArgs e)
        {
            _presenter.OnHandleDestroyed();
        }

        #endregion

        #region Private Fields

        private readonly CalculatorPresenter _presenter;

        #endregion
    }
}
