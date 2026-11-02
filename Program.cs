using GameVault.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC controllers + Razor views
builder.Services.AddControllersWithViews();

// Register the DbContext with the DI container (Inversion of Control).
// The connection string lives in appsettings.json and the context is injected into controllers.
builder.Services.AddDbContext<GameVaultContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameVaultContext")));

var app = builder.Build();

// In development, create/upgrade the LocalDB database from the EF Core migrations on startup.
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<GameVaultContext>();
    db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
