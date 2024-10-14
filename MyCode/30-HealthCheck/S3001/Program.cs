var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();
var app = builder.Build();
app.UseHealthChecks(path: "/healthcheck");
app.Run();
