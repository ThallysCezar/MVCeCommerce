using Microsoft.EntityFrameworkCore;
using ProjetoYoutube.Data;
using ProjetoYoutube.Data.Services;
using ProjetoYoutube.Data.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add services to the container.
var connectionStringMySql = builder.Configuration.GetConnectionString("ConectionMyAPI");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(
    connectionStringMySql,
    ServerVersion.Parse("8.0.32-MySQL"))
);

builder.Services.AddScoped<IActorsServices, ActorsServices>();
builder.Services.AddScoped<IProducersService, ProducersService>();
builder.Services.AddScoped<ICinemasService, CinemasService>();
builder.Services.AddScoped<IMoviesService, MoviesService>();

var app = builder.Build();

AppDbInitializer.Seed(app);

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
