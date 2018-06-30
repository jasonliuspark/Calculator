using Calculator.Model;
using System;

namespace Calculator.Presenter
{
    class ResultFormPresenter
    {
        #region Public Method           
        public ResultFormPresenter(IResultFormViewable view)
        {
            _view = view;
        }

        public void OnHandleResultFormCreated()
        {
            Observe();
        }

        public void OnHandleResultFormDestroyed()
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
        private void UpdateResult(object sender, ResultEventEventArgs e)
        {
            _view.Result = e.Result;
        }
        #endregion
        #region Private Fields
        private readonly IResultFormViewable _view;
        #endregion


    }
}
