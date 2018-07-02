using System.Data.Entity;

namespace Calculator.Model
{
    public class CalculationContext : DbContext
    {
        static CalculationContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalculationContext>());
        }

        public DbSet<CalculationResultModel> Calculations
        {
            get;
            set;
        }
    }
}
