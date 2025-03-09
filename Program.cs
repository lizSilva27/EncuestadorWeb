using EncuestadorWeb.Models;
using EncuestadorWeb.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EncuestadorWeb.Services;

// // "DefaultConnection": "Data Source = C:\\Users\\lizet\\OneDrive\\Documentos\\EncuestadorWeb\\BaseDeDatos\\EncuestadorWeb.db"

var builder = WebApplication.CreateBuilder(args);

// Registrar el contexto de la base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Registra el servicio SelectEncuestaAsig
builder.Services.AddScoped<EncuestaService>();


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();