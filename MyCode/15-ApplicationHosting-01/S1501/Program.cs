using Microsoft.AspNetCore;

WebHost.CreateDefaultBuilder(args)
    .Configure(app => app.Run(context => context.Response.WriteAsync("Hello World!")))
    .Build()
    .Run();
