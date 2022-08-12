using IdentityUsuario.Data;
using IdentityUsuario.Services;
using AutoMapper;
using IdentityUsuario.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>();

builder.Services.AddAuthentication(); //se agrego
builder.Services.ConfigureIdentity();  //se agrego de serviceExtensions

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//tuve que instalar Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
//MapperInitializer es una clase propia de la carpeta Configurations
builder.Services.AddAutoMapper(typeof(MapperInitializer).Assembly);

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
