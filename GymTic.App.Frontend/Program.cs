
using GymTic.App.Persistencia;
using GymTic.App.Persistencia.AppRepositorio;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var services = new ServiceCollection();

// Add services to the container.
builder.Services.AddRazorPages();
builder.services.AddSingleton<IRepositorioCliente>();
builder.services.AddSingleton<IRepositorioRutina, RepositorioRutina>();
builder.services.AddSingleton<IRepositorioEjercicio, RepositorioEjercicio>()

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
///
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
