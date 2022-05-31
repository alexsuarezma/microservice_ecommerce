using Catalog.Presitence.Database;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Test.Config
{
    public static class ApplicationDbContextInMemory
    {
        public static ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: $"Catalog.Db")
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}
