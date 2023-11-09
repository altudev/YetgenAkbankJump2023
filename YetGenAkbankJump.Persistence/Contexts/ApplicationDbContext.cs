using Microsoft.EntityFrameworkCore;
using YetgenAkbankJump.Domain.Entities;
using YetGenAkbankJump.Persistence.Configurations;

namespace YetGenAkbankJump.Persistence.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            modelBuilder.ApplyConfiguration(new CityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=91.151.83.102;Database=kalaymaster_caching_example;User Id=kalaymaster;Password=!123kalaylama123*;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
