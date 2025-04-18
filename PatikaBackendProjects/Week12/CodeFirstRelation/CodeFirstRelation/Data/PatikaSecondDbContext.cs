using CodeFirstRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PatikaCodeFirstDb2;Username=postgres;");
        }
    }
}