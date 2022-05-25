using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Application.IoC;
using PsicopataPedido.Application.Services;
using PsicopataPedido.Domain.constantes;
using PsicopataPedido.Infraestructrue.Context;
using PsicopataPedido.Infraestructrue.IoC;
using PsicopataPedido.Infraestructrue.Repository;
using Swashbuckle.AspNetCore.Filters;
using System.Net;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string myConnection = builder.Configuration.GetConnectionString("defaultConnection");
string myCors = "patito";


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

//builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration);
//HttpClient.DefaultProxy = new WebProxy(new Uri("http://localhost:5000/"));

builder.Services.AddDbContext<PsicopataPedidoContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddRegisterServices();


builder.Services.AddAppRegister(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddValidator();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddMicrosoftIdentityWebApi(options =>
//{
//    builder.Configuration.Bind("AzureAdB2C", options);

//    options.TokenValidationParameters.NameClaimType = "name";
//},
//    options => { builder.Configuration.Bind("AzureAdB2C", options); });
// //End of the Microsoft Identity platform block    



builder.Services.AddCors(op => 
{
    op.AddPolicy(name: Core.MyCore, builder =>
    {
        //builder.WithOrigins("https://localhost:7103");
       builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(Core.MyCore);
app.UseAuthentication();
//app.Use(async (context, next) =>
//{
//    if (!context.User.Identity?.IsAuthenticated ?? false)
//    {
//        context.Response.StatusCode = 401;
//        await context.Response.WriteAsync("Not Access");
//    }
//    await next();
//});
app.UseAuthorization();

app.MapControllers();

app.Run();
