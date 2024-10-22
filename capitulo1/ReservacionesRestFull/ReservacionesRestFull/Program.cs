using Microsoft.EntityFrameworkCore;
using ReservacionesRestFull.Bussiness.Services;
using ReservacionesRestFull.Bussiness.Services.Implementation;
using ReservacionesRestFull.Data;
using ReservacionesRestFull.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//INYECTAR CONTEXTO DE BD EN TIEMPO DE EJECUCIÓN
builder.Services.AddDbContext<AppDBContext>(
    context =>
    {
        context.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
    );

//INYECTAR REPOSITORIOS
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<RoomRepository>();
builder.Services.AddScoped<ReservationRepository>();

//INYECTAR SERVICIOS

builder.Services.AddScoped<IReservationService,ReservationServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
