using System.ComponentModel.DataAnnotations;

namespace Calculator.Model
{
    public class CalculationResultModel
    {
        #region Model members

        [Key]
        public int CalculationId { get; set; }
        public double FirstOperand { get; set; }
        public string OperatorSymble { get; set; }
        public double SecondOperand { get; set; }
        public double Result { get; set; }

        #endregion
    }
}
