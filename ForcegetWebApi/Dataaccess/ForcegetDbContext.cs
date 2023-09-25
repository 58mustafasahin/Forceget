using ForcegetWebApi.Entities;
using ForcegetWebApi.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace ForcegetWebApi.Dataaccess
{
    public class ForcegetDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ForcegetDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgreDbContext")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); }

        public DbSet<Order> Orders { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
