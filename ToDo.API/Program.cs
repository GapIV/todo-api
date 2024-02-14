using ToDo.BLL.DI;
using ToDo.API.Mapper;
using ToDo.API.Validators;
using ToDo.API.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IValidator<ToDoViewModel>, ToDoValidator>();
builder.Services.AddScoped<IValidator<UserViewModel>, UserValidator>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBusinessLogic(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();