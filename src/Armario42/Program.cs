using Armario42.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

try
{
    Console.WriteLine("Iniciando aplicação...");

    var builder = WebApplication.CreateBuilder(args);

    // Logging configurado
    builder.Logging.ClearProviders();
    builder.Logging.AddSimpleConsole();
    builder.Logging.AddDebug();
    builder.Logging.SetMinimumLevel(LogLevel.Debug);

    Console.WriteLine($"Ambiente: {builder.Environment.EnvironmentName}");

    // Connection string
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Connection string 'DefaultConnection' não foi encontrada.");
    }

    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseNpgsql(connectionString);
        options.EnableSensitiveDataLogging(); // Só manter em dev
        options.EnableDetailedErrors();
    });

    builder.Services.AddControllersWithViews();

    var app = builder.Build();

    // Define porta compatível com Render, Azure e Heroku
    var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
    app.Urls.Clear();
    app.Urls.Add($"http://*:{port}");

    // Aplicar migrations apenas em desenvolvimento
    if (app.Environment.IsDevelopment())
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        Console.WriteLine("Aplicando migrations (dev)...");
        db.Database.Migrate();
        Console.WriteLine("Migrations aplicadas com sucesso");
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

    Console.WriteLine("Aplicação configurada, iniciando...");
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("ERRO CRÍTICO:");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    throw;
}