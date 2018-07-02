using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Calculator.Model
{
    public class CalculatorManager
    {
        public EventHandler<ResultEventArgs> NotifyResultEvent;

        public EventHandler<UpdateDbEventArgs> UpdateDbEvent;
        #region Constructor       

        private CalculatorManager()
        {

        }
        #endregion

        public static CalculatorManager Instance => _uniqueCalculatorManager ?? (_uniqueCalculatorManager = new CalculatorManager());

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
            NotifyResultEvent?.Invoke(this, new ResultEventArgs { Result = result.ToString() });
            using (var db = new CalculationContext())
            {
                CalculationResultDbInsertion(db, firstNum, operand, secondNum, result);
            }
            UpdateDbEvent?.Invoke(this, new UpdateDbEventArgs { CalculatinResult = GetResultData() });
            return result;
        }

        #region Private methods

        public DataTable GetResultData()
        {
            using (var db = new CalculationContext())
            {
                DataTable dt = new DataTable("Calculations");
                var query = from b in db.Calculations orderby b.CalculationId select b;
                List<CalculationResultModel> list = query.ToList();
                var props = typeof(CalculationResultModel).GetProperties();

                dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
                if (list.Count() > 0)
                {
                    for (int i = 0; i < list.Count(); i++)
                    {
                        ArrayList tempList = new ArrayList();
                        foreach (PropertyInfo pi in props)
                        {
                            object obj = pi.GetValue(list.ElementAt(i), null);
                            tempList.Add(obj);
                        }
                        object[] array = tempList.ToArray();
                        dt.LoadDataRow(array, true);
                    }
                }

                return dt;
            }

        }

        private void CalculationResultDbInsertion(CalculationContext dbContext, double firstOperand, string operatorSymbol, double secondOperand, double result)
        {
            var calculation = new CalculationResultModel() { FirstOperand = firstOperand, OperatorSymble = operatorSymbol, SecondOperand = secondOperand, Result = result };
            dbContext.Calculations.Add(calculation);
            dbContext.SaveChanges();
        }

        #endregion

        private static CalculatorManager _uniqueCalculatorManager;
    }

    public class ResultEventArgs : EventArgs
    {
        public string Result { get; set; }
    }

    public class UpdateDbEventArgs : EventArgs
    {
        public DataTable CalculatinResult { get; set; }
    }
}


