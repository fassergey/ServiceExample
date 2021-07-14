using Microsoft.EntityFrameworkCore;

namespace ServiceExample
{
    public class SomeDbContext : DbContext
    {
        public SomeDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}