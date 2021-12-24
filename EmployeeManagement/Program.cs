var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
// app.MapGet("/", () => System.Diagnostics.Process.GetCurrentProcess().ProcessName);

app.Run();
