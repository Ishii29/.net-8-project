using Microsoft.Azure.Cosmos;
var builder = WebApplication.CreateBuilder(args);

namespace Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddSingleton((provider) =>
            {
                var endpointUri = configuration["CosmosDbSettings : EndpointUri"];
                var primaryKey = configuration["CosmosDbSettings : PrimaryKey"];
                var databaseName = configuration["CosmosDbSettings : DatabaseName"];

                var cosmosClientOptions = new CosmosClientOptions
                {
                    ApplicationName = databaseName
                };

                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                });
                // Add services to the container.

                var cosmosClient = new CosmosClient(endpointUri, primaryKey, cosmosClientOptions);
                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                cosmosClient.ClientOptions.ConnectionMode = ConnectionMode.Direct;
                var app = builder.Build();

                return cosmosClient;
            });

            builder.Services.AddControllers();
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
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseAuthorization();

            app.MapControllers();
            app.MapControllers();

            app.Run();
        }
    }
}
  