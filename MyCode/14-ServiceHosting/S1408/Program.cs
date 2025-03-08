// Copyright (c) xxx, 2025. All rights reserved.

using App;
using System.Reflection;

Host.CreateDefaultBuilder(args)
    .ConfigureServices(svcs => svcs.AddHostedService<FakeHostedService>())
    .UseServiceProviderFactory(new CatServiceProviderFactory())
    .ConfigureContainer<CatBuilder>(builder => builder.Register(Assembly.GetEntryAssembly()!))
    .Build()
    .Run();
