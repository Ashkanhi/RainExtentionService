using Microsoft.EntityFrameworkCore;
using RainExtention.Infrastructure.Context;
using RainExtention.Application.Interface;
using RainExtention.Infrastructure.Repositories;
using RainExtentionService.Middleware;
using RainExtention.Application.Service;
using RainExtention.Domain.Interface;

var builder = WebApplication.CreateBuilder(args);

// ثبت DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RainExtentionConnection")));


builder.Services.AddScoped<IItemListService, ItemListService>();
builder.Services.AddScoped<IItemListRepository, ItemListRepository>();
// ثبت سرویس‌ها و ریپوزیتوری‌ها
builder.Services.AddScoped<IStockDocumentService, StockDocumentService>();
builder.Services.AddScoped<IStockDocumentRepository, StockDocumentRepository>();

// MVC + API
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// اجرای Basic Auth روی کل برنامه
app.UseMiddleware<BasicAuthMiddleware>();

app.UseAuthorization();

app.MapControllers();

// مسیر پیش‌فرض MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
