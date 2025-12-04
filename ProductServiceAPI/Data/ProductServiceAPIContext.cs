using Microsoft.EntityFrameworkCore;
using ProductServiceAPI.Models;


namespace ProductServiceAPI.Data
{
    public class ProductServiceAPIContext :DbContext
    {
        public ProductServiceAPIContext(DbContextOptions<ProductServiceAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductServiceAPI.Models.Product> Product { get; set; } = default!;
    }
}
