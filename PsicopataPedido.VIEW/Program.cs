using Microsoft.EntityFrameworkCore;
using PsicopataPedido.Infraestructrue.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string myConnection = builder.Configuration.GetConnectionString("defaultConnection");

builder.Services.AddControllers();
builder.Services.AddDbContext<PsicopataPedidoContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
