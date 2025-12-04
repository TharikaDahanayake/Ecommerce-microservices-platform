
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
            options.UseSqlServer(builder.Configuration.GetConnectionString("OrderServiceAPIContext")));
            
            // Add services to the container.

            builder.Services.AddControllers();


            // Register HttpClient with named client "ApiGateway"
            builder.Services.AddHttpClient("ApiGateway", client =>
            { 
            client.BaseAddress = new Uri("http://localhost:5146"); // API Gateway URL
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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
