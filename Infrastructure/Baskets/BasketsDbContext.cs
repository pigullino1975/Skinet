using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Baskets
{
    public class BasketsDbContext : DbContext
    {
        public BasketsDbContext(DbContextOptions<BasketsDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerBasket> CustomerBaskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        
    }
}