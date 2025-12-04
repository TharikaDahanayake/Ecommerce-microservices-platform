using Microsoft.AspNetCore.Mvc;
using ProductServiceAPI.Data;
using ProductServiceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductServiceAPIContext _context; 

        public ProductsController(ProductServiceAPIContext context)
        { 
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return await _context.Product.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

    }
}
