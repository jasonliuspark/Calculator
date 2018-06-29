using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Presenter
{
    class ResultFormPresenter
    {
        private string _results;
        
        public ResultFormPresenter(IResultFormViewable view)
        {
            _view = view;
            
            //_calculatorManager = 
        }

        public void ResultFormLoad()
        {
            Oberver();
        }
        private void Oberver()
        {
         //NotifyResultEvent  +=  UpdateResult;
        }

        private void Unobserver()
        {

        }
        private void UpdateResult()
        {
          //  _view.Result=_calculatorManager.Result;

        }

        private readonly IResultFormViewable _view;
        private readonly IResultManager _calculatorManager;
    }


}
