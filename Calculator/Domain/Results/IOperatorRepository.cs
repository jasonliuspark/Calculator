using System.Collections.Generic;


namespace Calculator.Model
{
    public interface IOperatorRepository
    {
        //just to show data traffic
        IList<Operators> GetOperators();
    }
}
