using Microsoft.EntityFrameworkCore;
using PruebaApi.Model;
using PruebaApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IFormService,FormService>();
//builder.Services.AddDbContext<ApiFormContext>(x => x.UseSqlServer("Server=DESKTOP-7UK397V\\SQLEXPRESS;Database=ApiForm;Trusted_Connection=True;user id=sa; password=Colombia123++"));
//var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddDbContext<ApiFormContext>();

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
