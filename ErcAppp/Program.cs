using ErcApp.Domain.Interfaces;
using ErcApp.Infrastructure.Data;
using ErcApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("ErcDatabase");
builder.Services.AddDbContext<ErcAppDbContext>(options =>
{
    options.UseSqlite(connection);
});

builder.Services.AddScoped<IIndicationRepository, IndicationServises>();
builder.Services.AddScoped<IInvoiceRepository, InvoiceServices>();

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
