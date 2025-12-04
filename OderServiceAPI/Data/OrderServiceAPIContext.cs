using Microsoft.EntityFrameworkCore;
using OrderServiceAPI.Models;

namespace OrderServiceAPI.Data



{
    public class OrderServiceAPIContext : DbContext
    {

        public OrderServiceAPIContext(DbContextOptions<OrderServiceAPIContext> options)
        : base(options)
        { 
        }

        public DbSet<OrderServiceAPI.Models.Order> Order { get; set; } = default!;
    }
}
