using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    

    public class CalculatorManager
    {
        
        public double Calculate(string operand, double firstNum, double secondNum)
        {
            double result = 0;
            switch (operand)
            {
                case "+":
                    result = (firstNum + secondNum);
                    break;
                case "-":
                    result = (firstNum - secondNum);
                    break;
                case "*":
                    result = (firstNum * secondNum);
                    break;
                case "/":
                    result = Math.Round((firstNum / secondNum), 2);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
