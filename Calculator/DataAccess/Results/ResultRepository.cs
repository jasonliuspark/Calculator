using Calculator.DataAccess.Entity_Contexts;
using Calculator.Domain.Results;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Calculator.DataAccess.Results
{
    public class ResultRepository : ICalculationResults
    {
        public static ResultRepository Instance => _uniqueResultRepository ?? (_uniqueResultRepository = new ResultRepository());

        private ResultRepository()
        {

        }

        #region Public Methods

        public void CalculationResultDbInsertion(double firstOperand, string operatorSymbol, double secondOperand, double result)
        {
            using (var dbContext = new ResultContext())
            {
                var calculation = new CalculationResult() { FirstOperand = firstOperand, OperatorSymble = operatorSymbol, SecondOperand = secondOperand, Result = result };
                dbContext.Calculations.Add(calculation);
                dbContext.SaveChanges();
            }

        }

        public DataTable GetResultData()
        {
            using (var db = new ResultContext())
            {
                DataTable dt = new DataTable("Calculations");
                var query = from b in db.Calculations orderby b.CalculationId select b;
                List<CalculationResult> list = query.ToList();
                var props = typeof(CalculationResult).GetProperties();

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

        #endregion

        private static ResultRepository _uniqueResultRepository;
    }
}
