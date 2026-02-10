using Microsoft.EntityFrameworkCore;
using InvoiceSystem.Business.Microsoft.BusinessExtensions.DependencyInjection;
using InvoiceSystem.Data;
using InvoiceSystem.DataAccess.Microsoft.DataExtensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<InvoiceSystemDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("InvoiceSystem")));

builder.Services.AddServices();
builder.Services.AddRepositories();

var app = builder.Build();


app.UseDefaultFiles();   // serve Angular
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
