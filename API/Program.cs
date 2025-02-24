using FlightReservationAPI.Infrastructure.Data;
using FlightReservationAPI.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Configurar conexión a MySQL en Docker
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30)) // Cambia a la versión que estás usando
    ));

// Inyección automática de repositorios y servicios
builder.Services.AddApplicationServices();

builder.Services.AddControllers()
    .AddApplicationPart(Assembly.GetExecutingAssembly()); // Registra automáticamente los controladores

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
