using FoodDrink.Service.Implementation;
using FoodDrink.Service.Interface;
using FooDrink.database;
using FooDrink.Repository.Implementation;
using FooDrink.Repository.Interface;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Root configuration = new();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.ConnectionStrings.DefaultConnection));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();





public class ConnectionStrings
{
    public required string DefaultConnection { get; set; }
}

public class Logging
{
    public required LogLevel LogLevel { get; set; }
}

public class LogLevel
{
    public required string Default { get; set; }

    public required string MicrosoftAspNetCore { get; set; }
}

public class Root
{
    public required Logging Logging { get; set; }
    public required ConnectionStrings ConnectionStrings { get; set; }
    public required string AllowedHosts { get; set; }
}