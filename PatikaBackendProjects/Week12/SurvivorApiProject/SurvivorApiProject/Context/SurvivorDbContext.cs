using Microsoft.EntityFrameworkCore;
using SurvivorApiProject.Entities;

namespace SurvivorApiProject.Context
{
    public class SurvivorDbContext : DbContext
    {
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CompetitorEntity> Competitors { get; set; }

        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}