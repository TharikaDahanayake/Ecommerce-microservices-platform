
using Microsoft.EntityFrameworkCore;
using OrderServiceAPI.Data;

namespace OderServiceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<OrderServiceAPIContext>(options =>
                options.UseInMemoryDatabase("OrdersDb"));
            
            // Add services to the container.

            builder.Services.AddControllers();


            // Register HttpClient with named client "ApiGateway"
            var apiGatewayBaseUrl = builder.Configuration["ApiGateway:BaseUrl"] ?? "http://api-gateway:8080";
            builder.Services.AddHttpClient("ApiGateway", client =>
            { 
                client.BaseAddress = new Uri(apiGatewayBaseUrl);
            });

            // Register HttpClient

            builder.Services.AddHttpClient();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
