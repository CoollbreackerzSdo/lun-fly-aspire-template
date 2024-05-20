using Projects;

var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<LunFly_ApiService>("api");
builder.Build().Run();