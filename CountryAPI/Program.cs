using Microsoft.EntityFrameworkCore;
using CountryAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<CountryContext>(opt =>
    opt.UseInMemoryDatabase("CountryList"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
