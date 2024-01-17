var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// create a /greeting GET route with a `name` parameter
app.MapGet("/greeting", (string name) => $"Hello {name}!");

// listen on PORT env variable or 8080 by default
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");


app.Run();
