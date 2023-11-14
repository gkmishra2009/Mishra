using System;
using Microsoft.EntityFrameworkCore;
using CondidateCodeTest.Data;

public static void Main(string[] args)
{

    

    var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IEmailWork, EmailWork>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContactsAPIDbContext>(option =>option.UseSqlServer(builder.Configuration.GetConnectionString("ContactAPIConnectionString")));

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

}