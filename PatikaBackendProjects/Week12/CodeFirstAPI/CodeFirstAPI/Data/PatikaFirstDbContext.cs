using Microsoft.EntityFrameworkCore;
using CodeFirstAPI.Data.Entities;

namespace CodeFirstAPI.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Windows Authentication için
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=PatikaCodeFirstDb1; Trusted_Connection = true; TrustServerCertificate=True");
        }
    }
}
