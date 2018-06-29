using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Presenter
{
    class ResultFormPresenter
    {

        public ResultFormPresenter(IResultFormViewable view)
        {
            _view = view;

        }

        public void ResultFormLoad()
        {

        }
        private void Oberver()
        {

        }

        private void Unobserver()
        {

        }

        private readonly IResultFormViewable _view;
    }


}
