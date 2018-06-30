using Calculator.Presenter;
using System;
using System.Windows.Forms;

namespace Calculator.View
{
    public partial class ResultForm : Form, IResultFormViewable
    {
        public ResultForm()
        {
            InitializeComponent();
            _presenter = new ResultFormPresenter(this);
        }

        public string Result
        {
            set { ResultBox2.Text = value; }
        }

        private readonly ResultFormPresenter _presenter;

        private void ResultForm_Load(object sender, EventArgs e)
        {
            _presenter.OnHandleResultFormCreated();
        }

        private void OnHandleResultFormDestroyed(object sender, EventArgs e)
        {
            _presenter.OnHandleResultFormDestroyed();
        }
    }
}
