using FirstAppEf;
using FirstAppEf.Business;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Repository.Dao;
using FirstAppEf.Repository.InterfacesDao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using WebServicePrueba;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AplicationDbContext>(options =>
    options.UseSqlServer("name=DefaultConnection"));

builder.Services.AddAutoMapper(typeof(Program));

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IPersonaDao, PersonaDao>();
builder.Services.AddScoped<IPersonaBusiness, PersonaBusiness>();

builder.Services.AddScoped<IPeliculaDao, PeliculaDao>();
builder.Services.AddScoped<IPeliculaBusiness, PeliculaBusiness>();

builder.Services.AddScoped<IGeneroDao, GeneroDao>();
builder.Services.AddScoped<IMiWebServiceDePrueba, MiWebServiceClient>();


builder.Services.AddScoped(typeof(IBaseDao<,>), typeof(BaseDao<,>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
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
