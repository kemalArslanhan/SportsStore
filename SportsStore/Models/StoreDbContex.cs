using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class StoreDbContex: DbContext
    {
        public StoreDbContex(DbContextOptions<StoreDbContex> opts) : base(opts) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
 
