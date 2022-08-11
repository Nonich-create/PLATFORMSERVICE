using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PLATFORMSERVICE.Data;
using PLATFORMSERVICE.SyncDataServices.Http;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlatformSerivce", Version = "v1" });
});

Console.WriteLine($"--> CommandService Endpoint {builder.Configuration["CommandService"]}");

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();

builder.Services.AddHttpClient<ICommandDataClient, CommandDataClient>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
 
var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

PrepDb.PrepPopulation(app);

app.Run();
