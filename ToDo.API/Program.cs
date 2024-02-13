
using ToDo.BLL.DI;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();

builder.Services.AddBusinessLogic(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();