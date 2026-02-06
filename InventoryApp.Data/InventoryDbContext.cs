using InventoryApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InventoryApp.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext()
        {
            
        }

        public InventoryDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public virtual DbSet<Inventory> Inventories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }

}
