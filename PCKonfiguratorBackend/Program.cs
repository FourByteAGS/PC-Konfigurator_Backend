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
            policy.AllowAnyOrigin()  // 🔥 Erlaubt ALLE Ursprünge (nicht sicher für Auth-geschützte APIs)
                .AllowAnyMethod()  // 🔥 Erlaubt ALLE HTTP-Methoden (GET, POST, PUT, DELETE, usw.)
                .AllowAnyHeader(); // 🔥 Erlaubt ALLE Header
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

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

// 📌 Anwendung starten
app.Run();