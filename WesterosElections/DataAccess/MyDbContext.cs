using Microsoft.EntityFrameworkCore;
using WesterosElections.MyModels;

namespace WesterosElections.DataAccess
{
    public class MyDbContext : DbContext
    {
        //public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }

        private static string connectionString = "Server=SP;Database=ElectionsDB;Trusted_Connection=True";
        public DbSet<Tribe> Tribes { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString); ;
        }
    }
}
