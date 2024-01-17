# Add a new route with Duet AI

Before we deploy our app to Cloud Run, let's add a new route to our app. 

In [Program.cs](../MyWebApp/Program.cs), add the following comment:

```csharp
// create a /greeting GET route with a `name` parameter
```

Duet AI should generated you the following code:

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// create a /greeting GET route with a `name` parameter
app.MapGet("/greeting", (string name) => $"Hello {name}!");

app.Run();
```

Let's test to make sure it works. While highlighting the newly generated code,
ask the following:

**Prompt**
> How can I test the /greeting endpoint using curl? The server is running on port 5074

**Answer**
> To test the /greeting endpoint using curl, you can use the following command:

```sh
curl http://localhost:5074/greeting?name=John
```

> This will send a request to the /greeting endpoint with the name parameter set
> to John.

Nice!
