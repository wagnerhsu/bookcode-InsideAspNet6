RequestDelegate handler = context => context.Response.WriteAsync("Hello, World!");
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.Run(handler: handler);
// 最后调用WebApplication另一个无参Run扩展方法是为了启动承载的应用
app.Run();
