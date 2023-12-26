using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEfCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }

}
