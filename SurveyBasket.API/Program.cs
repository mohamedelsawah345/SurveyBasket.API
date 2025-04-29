using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using SurveyBasket.API;
using SurveyBasket.API.Middileware;
using SurveyBasket.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IOperationTransiente, WindoesOscs>();
builder.Services.AddScoped<IOperationScoped, WindoesOscs>();
builder.Services.AddSingleton<IOperationSingelton, WindoesOscs>();


//builder.Services.AddTransient<IOperationTransiente, MacOsServices>();
//builder.Services.AddScoped<IOperationScoped, MacOsServices>();
//builder.Services.AddSingleton<IOperationSingelton, MacOsServices>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCustomMiddleware();

//app.Use(async (context, next) =>
//{
//    app.Logger.LogError("Proccessing request");

//    await next(context);

//    app.Logger.LogWarning("Proccessing responce");
//});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
