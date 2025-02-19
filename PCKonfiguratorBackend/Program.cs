using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;
using PCKonfiguratorBackend.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSingleton<IAuthRepository, AuthService>();
builder.Services.AddSingleton<List<ProductCollection>>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyMethod()  
                .AllowAnyHeader(); 
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Middleware zur Fehlerbehandlung und Setzen der CORS-Header auch bei Fehlern
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unhandled Exception: {ex}"); 
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync($"Server Error: {ex.Message}");
    }
});

app.UseCors("AllowAll");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
}

app.Run();