using Microsoft.EntityFrameworkCore;

namespace StateParksApi.Models
{
    public class StateParkDbContext : DbContext
    {
        public StateParkDbContext(DbContextOptions<StateParkDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

        }

        public DbSet<Park> Parks { get; set; }
    }
}