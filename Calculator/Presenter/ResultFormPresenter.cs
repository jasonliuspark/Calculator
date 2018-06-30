using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Calculator.Presenter
{
    class ResultFormPresenter
    {
        private string _results;
        private Delegate ResultHandler;
        public ResultFormPresenter(IResultFormViewable view)
        {
            _view = view;
        }

        public void ResultFormLoad()
        {
            Oberver();
        }
        #region Private methods
        private void Oberver()
        {
            CalculatorManager.NotifyResultEvent += UpdateResult;
        }

        private void Unobserver()
        {
            CalculatorManager.NotifyResultEvent -= UpdateResult;
        }
        private void UpdateResult(string result)
        {
            _view.Result = result;

        }
        #endregion
        #region private 
        private readonly IResultFormViewable _view;
        #endregion
    }


}
