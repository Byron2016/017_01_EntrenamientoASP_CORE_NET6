var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/", () => System.Diagnostics.Process.GetCurrentProcess().ProcessName);
// forma 1
var myKey = builder.Configuration["MyKey"];
var myKeya = builder.Configuration.GetValue<string>("MyKey");
var cookieAuthenticationLoginPath = builder.Configuration.GetValue<string>("Authentication:CookieAuthentication:LoginPath");
// forma 2
IConfiguration conf = app.Configuration;
var p = conf["MyKey"];
// forma 3 NO HACERLO TIENE WARNING.
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
var myKeyb = configuration.GetValue<string>("MyKey");

//app.MapGet("/", () => $"mykey: {myKey} mykeya: {myKeya} cookieAuthenticationLoginPath: {cookieAuthenticationLoginPath} p: {p} myKeyb: {myKeyb}");

app.MapGet("/", async (context) => { await context.Response.WriteAsync(myKey); });

// dotnet run MyKey="args" // PARA CORRER DESDE COMMAND LINE.

app.Run( );
