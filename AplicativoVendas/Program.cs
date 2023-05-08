using AplicativoVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using AplicativoVendas.Services;
using AplicativoVendas.Data;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AplicativoVendasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AplicativoVendasContext") ?? throw new InvalidOperationException("Connection string 'AplicativoVendasContext' not found.")));

// Add services to the container.
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();        
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<AppSettingsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWebMvcContext")));


var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var seedingService = services.GetRequiredService<SeedingService>();
        seedingService.Seed();
    }
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
