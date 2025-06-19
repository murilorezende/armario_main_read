using Armario42.Models;
using Microsoft.EntityFrameworkCore;

try
{
    Console.WriteLine("Iniciando aplicação...");
    
    var builder = WebApplication.CreateBuilder(args);
    
    // Configurar logging detalhado
    builder.Logging.ClearProviders();
    builder.Logging.AddConsole();
    builder.Logging.AddDebug();
    builder.Logging.SetMinimumLevel(LogLevel.Debug);
    
    Console.WriteLine($"Ambiente: {builder.Environment.EnvironmentName}");
    Console.WriteLine($"Connection String: {builder.Configuration.GetConnectionString("DefaultConnection")}");
    
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    });
    
    builder.Services.AddControllersWithViews();
    
    var app = builder.Build();
    
    // Configuração da porta para Azure App Service Linux
    var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
    Console.WriteLine($"Usando porta: {port}");
    app.Urls.Clear(); // Limpa URLs padrão
    app.Urls.Add($"http://*:{port}");
    
    // ✅ Executar migrations na inicialização
    using (var scope = app.Services.CreateScope())
    {
        Console.WriteLine("Aplicando migrations...");
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        db.Database.Migrate(); // Aplica as migrations pendentes
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
    Console.WriteLine($"ERRO CRÍTICO: {ex}");
    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
    throw;
}