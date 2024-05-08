using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Mappings;
using Ecommerce.Application.Properties.Queries;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture;
using Ecommerce.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EcommerceDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddTransient<IRepository<Property>, EFRepository<Property>>();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetListOfProperties.Handler).Assembly));

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
