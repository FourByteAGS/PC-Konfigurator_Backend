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

// CORS aktivieren
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000") 
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials(); 
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Migrationen ausführen
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();