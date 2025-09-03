using Microsoft.EntityFrameworkCore;
using RainExtention.Infrastructure.Context;
using RainExtention.Application.Interface;
using RainExtention.Infrastructure.Repositories;
using RainExtentionService.Middleware;
using RainExtention.Application.Service;
using RainExtention.Domain.Interface;
using RainExtention.Infrastructure.Mapping;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RainExtentionConnection")));

// ✅ ✅ روش تضمینی و سازگار با تمام نسخه‌های AutoMapper (6.0 به بالا)
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<MappingProfile>(); // ✅ مستقیماً پروفایل رو اضافه می‌کنیم
});

// ریپازیتوری‌ها
builder.Services.AddScoped<IDisableProceduresRepository, DisableProceduresRepository>();
builder.Services.AddScoped<IEnableProceduresRepository, EnableProceduresRepository>();
builder.Services.AddScoped<IItemListRepository, ItemListRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IStockDocumentRepository, StockDocumentRepository>();
builder.Services.AddScoped<ISaleInvoiceRepository, SaleInvoiceRepository>();

// سرویس‌ها
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<IItemListService, ItemListService>();
builder.Services.AddScoped<IStockDocumentService, StockDocumentService>();
builder.Services.AddScoped<SaleInvoiceService>();

// MVC + API
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline
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