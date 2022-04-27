using Microsoft.EntityFrameworkCore;
using ProductOperation.Core.Repositories;
using ProductOperation.Core.Services;
using ProductOperation.Core.UnitOfWorks;
using ProductOperation.Repository;
using ProductOperation.Service;
using ProductOperation.Service.Mapping;
using ProductOperation.Service.Repositories;
using ProductOperation.Service.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));


builder.Services.AddScoped<IProductionOperationRepository, ProductionOperationRepository>();
builder.Services.AddScoped<IProductionOperationService, ProductionOperationService>();
builder.Services.AddScoped<IStandartStoppingRepository, StandartStoppingRepository>();
builder.Services.AddScoped<IStandartStoppingService, StandartStoppingService>();

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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
