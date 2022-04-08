using WEBBACK2.Models.Data;
using Microsoft.EntityFrameworkCore;

using WEBBACK2.Middleware;
using back.Services;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITestService, TestService>();



var connection = builder.Configuration.GetConnectionString("DefaultConnection"); //В файле конфигураций (application.json) в секции ConnectionStrings ищем строку подключения DefaultConnection



builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));


builder.Services.AddAuthorization();







var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();


app.UseExceptionHandlingMiddlwares();



/*using var serviceScope = app.Services.CreateScope();
var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
// auto migration
context?.Database.Migrate();*/




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
