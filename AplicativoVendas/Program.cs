using AplicativoVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using AplicativoVendas.Services;
using AplicativoVendas.Data;
using Microsoft.AspNetCore.Localization;
using System.Globalization;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AplicativoVendasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AplicativoVendasContext") ?? throw new InvalidOperationException("Connection string 'AplicativoVendasContext' not found.")));

// Add services to the container.
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<AppSettingsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWebMvcContext")));



var enUS = new CultureInfo("en-US");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(enUS),
    SupportedCultures = new List<CultureInfo> { enUS },
    SupportedUICultures = new List<CultureInfo> { enUS }
};





var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var seedingService = services.GetRequiredService<SeedingService>();
    seedingService.Seed();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
