using StoreApp.Services.Identity.Application.Logging;
using StoreApp.Services.Identity.Application.Mapping.AutoMapper;
using StoreApp.Services.Identity.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Configure Database Connection
builder.Services.ConfigureDatabaseConnection(builder.Configuration);

// Configure Identity
builder.Services.ConfigureIdentity();
builder.Services.AddAuthentication();

// Configure AutoMapper
builder.Services.AddAutoMapper(cfg => { }, typeof(AmMappingProfile));

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerService>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
