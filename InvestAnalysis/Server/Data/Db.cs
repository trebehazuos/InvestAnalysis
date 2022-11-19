using Microsoft.EntityFrameworkCore;
namespace InvestAnalysis.Server.Data
{
    public class Db:DbContext
    {
        public Db(DbContextOptions<Db> options)
            : base(options) => Database.EnsureCreated();
        public DbSet<pessoas> Pessoas { get; set; } 
    }

    public class pessoas
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
