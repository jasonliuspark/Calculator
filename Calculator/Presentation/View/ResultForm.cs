using System;
using System.Data;
using System.Windows.Forms;
using Calculator.DataAccess.Results;
using Calculator.Presentation.Presenter;

namespace Calculator.Presentation.View
{
    public partial class ResultForm : Form, IResultFormViewable
    {
        #region Constructor

        public ResultForm()
        {
            InitializeComponent();
            _presenter = new ResultFormPresenter(this, ResultRepository.Instance);
        }

        #endregion

        #region IResultFormViewable Members
        public string Result
        {
            set { ResultBox2.Text = value; }
        }

        public DataTable Dt
        {
            set
            { ResultPresentationGrid.DataSource = value; }
        }

        #endregion

        #region Event Handlers

        private void ResultForm_HandleCreated(object sender, EventArgs e)
        {
            _presenter.OnHandleCreated();
        }

        private void ResultForm_HandleDestroyed(object sender, EventArgs e)
        {
            _presenter.OnHandleDestroyed();
        }

        #endregion

        #region Private Fields

        private readonly ResultFormPresenter _presenter;

        #endregion

    }
}
