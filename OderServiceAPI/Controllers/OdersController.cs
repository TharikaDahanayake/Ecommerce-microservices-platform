using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;       // Needed for ToListAsync

using OrderServiceAPI.Data;                // DbContext lives here
using OrderServiceAPI.Models;            // Models live here

namespace OrderServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderServiceAPIContext _context;
        private readonly HttpClient _httpClient;
        private readonly IHttpClientFactory _httpClientFactory;

        public OrdersController(OrderServiceAPIContext context, HttpClient httpClient, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
            _httpClient = httpClient;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            return await _context.Order.ToListAsync();
        }
        //POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]

        public async Task<ActionResult<Order>> Postorder(Order order)
        {
            // Create HttpClient instance for API Gateway
            var client = _httpClientFactory.CreateClient("ApiGateway");
            // Call UserService via API Gateway to get user details
            var userResponse = await client.GetAsync($"/users/{order.UserId}");
            if (!userResponse.IsSuccessStatusCode)
            {
                return NotFound("User not found");
            }
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

    }    
}
