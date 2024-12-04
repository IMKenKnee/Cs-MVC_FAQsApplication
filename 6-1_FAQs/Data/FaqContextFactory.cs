using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace _6_1_FAQs.Data
{
    public class FaqContextFactory : IDesignTimeDbContextFactory<FaqContext>
    {
        public FaqContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FaqContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FaqApp;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new FaqContext(optionsBuilder.Options);
        }
    }
}