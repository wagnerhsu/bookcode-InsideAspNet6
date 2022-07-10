using Serilog;
using Serilog.WxLibrary;
using WebApiDemo;
using WebApiDemo.Settings;

new SerilogService(SerilogService.DefaultOptions).Initialize();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Trace);
builder.Host.UseSerilog();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<HostedService>();
builder.Services.Configure<Profile>(builder.Configuration.GetSection("Profile"));
builder.Services.Configure<Profile>("foo", builder.Configuration.GetSection("foo"));
builder.Services.Configure<Profile>("bar", builder.Configuration.GetSection("bar"));

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


