using System.Collections.Generic;

namespace Calculator.Model
{
    public class DataGenerator : IOperatorRepository
    {
        //just for mocking incoming data

        private List<Operators> _operators = new List<Operators> {
            new Operators { OperatorSymbol = "+"},
            new Operators { OperatorSymbol = "-"},
            new Operators { OperatorSymbol = "*"},
            new Operators { OperatorSymbol = "/"}
        };
        public IList<Operators> GetOperators()
        {
            return _operators;
        }
    }
}
