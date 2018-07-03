using System.Data;

namespace Calculator.Domain.Results
{
    interface ICalculationResults
    {
        void CalculationResultDbInsertion(double firstOperand, string operatorSymbol, double secondOperand, double result);
        DataTable GetResultData();
    }
}
