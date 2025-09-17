using Microsoft.EntityFrameworkCore;
using RainExtention.Infrastructure.Context;
using RainExtention.Application.Interface;
using RainExtention.Infrastructure.Repositories;
using RainExtention.Application.Service;
using RainExtention.Domain.Interface;
using RainExtention.Infrastructure.Mapping;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.OpenApi.Models;
using RainExtentionService.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RainExtentionConnection")));

// AutoMapper Configuration
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<MappingProfile>(); // روش صحیح و بدون خطا
});

// Add Controllers and Razor Pages
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add Swagger with Configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "RainExtention API",
        Version = "v1",
        Description = "API for RainExtention Application"
    });

    // فعال‌سازی XML Comments (اختیاری)
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
});

// Register Repositories
builder.Services.AddScoped<IDisableProceduresRepository, DisableProceduresRepository>();
builder.Services.AddScoped<IEnableProceduresRepository, EnableProceduresRepository>();
builder.Services.AddScoped<IItemListRepository, ItemListRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IStockDocumentRepository, StockDocumentRepository>();
builder.Services.AddScoped<ISaleInvoiceRepository, SaleInvoiceRepository>();

// Register Services
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<IItemListService, ItemListService>();
builder.Services.AddScoped<IStockDocumentService, StockDocumentService>();
builder.Services.AddScoped<SaleInvoiceService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "RainExtention API V1");
        c.RoutePrefix = string.Empty; // دسترسی به Swagger در ریشه[](http://localhost:<port>)
    });
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// اجرای Basic Auth Middleware
app.UseMiddleware<BasicAuthMiddleware>();

app.UseAuthorization();

app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();