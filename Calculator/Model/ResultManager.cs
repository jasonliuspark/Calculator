using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    delegate void ResultEventHandler();
    class ResultManager : IResultManager
    {
        public event EventHandler ResultUpdate;

        private string _result;
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public void NotifyResultUpdated()
        {
          // ResultUpdate() ;
        }
    }
}
