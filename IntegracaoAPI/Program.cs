using Data.Proxy;
using Domain.Interfaces.Proxy;
using Domain.Interfaces.Service;
using Service.Mapping;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
//builder.Services.AddSingleton<IBancoService, BancoService>();
builder.Services.AddSingleton<IBrasilApiProxy, BrasilApiProxy>();
var config = new AutoMapper.MapperConfiguration(cfg => { cfg.AddProfile(new EnderecoMapping()); });
builder.Services.AddSingleton(config.CreateMapper());


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
