using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductAPI.DAL;
using ProductAPI.Services.Implementations.Base;
using ProductAPI.Services.Implementations.Product;
using ProductAPI.Services.Implementations.Restaurant;
using ProductAPI.Services.Interfaces;
using ProductAPI.Services.Interfaces.BaseService;
using ProductAPI.Services.Interfaces.ProductService;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(
        options => options.UseSqlServer("name=ConnectionStrings:Default"));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

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
