using System.Data.Entity;
using Calculator.Domain.Results;

namespace Calculator.DataAccess.Entity_Contexts
{
    public class ResultContext : DbContext
    {
        static ResultContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ResultContext>());
        }

        public DbSet<CalculationResult> Calculations
        {
            get;
            set;
        }
    }
}
