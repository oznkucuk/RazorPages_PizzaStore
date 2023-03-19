using Microsoft.EntityFrameworkCore;
using RazorPages_PizzaStore.Model;

namespace RazorPages_PizzaStore.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }


        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaOrder>()
                .ToTable("Orders");
        }

    }
}
