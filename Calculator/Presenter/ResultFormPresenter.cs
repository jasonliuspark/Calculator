using Calculator.Model;

namespace Calculator.Presenter
{
    class ResultFormPresenter
    {
        #region Constructor

        public ResultFormPresenter(IResultFormViewable view)
        {
            _view = view;
        }

        #endregion

        #region Event Handler

        public void OnHandleCreated()
        {
            Observe();
        }

        public void OnHandleDestroyed()
        {
            Unobserve();
        }

        #endregion

        #region Private methods

        private void Observe()
        {
            CalculatorManager.Instance.NotifyResultEvent += UpdateResult;
        }

        private void Unobserve()
        {
            CalculatorManager.Instance.NotifyResultEvent -= UpdateResult;
        }

        private void UpdateResult(object sender, ResultEventArgs e)
        {
            _view.Result = e.Result;
        }

        #endregion

        #region Private Fields

        private readonly IResultFormViewable _view;

        #endregion
    }
}
