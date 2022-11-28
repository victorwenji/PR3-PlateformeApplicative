using Microsoft.EntityFrameworkCore;
using  _3ilApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<_3ilContext>(opt =>
    opt.UseInMemoryDatabase("CompteList"));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
