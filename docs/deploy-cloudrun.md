# Deploy to Cloud Run with Duet AI

Now, we're ready to deploy our app to Cloud Run.

**Prompt**
> Do I need to change anything in `Program.cs` to deploy and run it on Cloud Run?

**Answer**
> No, you do not need to make any changes to the Program.cs file to deploy and
> run it on Cloud Run. The code you have provided is sufficient to create a
> simple web application that can be deployed to Cloud Run.

> However, there are a few things you may want to consider when deploying your
> application to Cloud Run.

> First, you will need to create a Cloud Run service. You can do this by going
> to the Cloud Run page in the Google Cloud console and clicking the Create
> Service button.

> When you create your service, you will need to specify a region. You can
> choose a region that is close to your users or that has the resources you
> need.

> You will also need to specify a container image. You can use the container
> image that you built locally, or you can use a container image that is
> available in Artifact Registry.

> Once you have created your service, you can deploy your application by
> clicking the Deploy button.

For Cloud Run to work, the server needs to listen on port 8080 or `PORT` env
variable. It doesn't seem like Duet AI knows that, so let's go ahead and add the
following comment in the code before `app.Run()`:

```csharp
// listen on PORT env variable or 8080
```

This should generate the following code:

```csharp
// listen on PORT env variable or 8080
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
app.Urls.Add(url);

app.Run();
```

If the code generation does not kick in, use `Ctrl+Enter` to generate the code.

Now, we're ready to deploy to Cloud Run. We know that Cloud Run can deploy code
form source code using gcloud. So, let's try a specific prompt to get the right command.

**Prompt**
> What's the gcloud command to deploy to Cloud Run from source code?

**Answer**
> To deploy your application to Cloud Run from source code, you can use the
> following gcloud command:

```sh
gcloud run deploy SERVICE --source .
Replace SERVICE with the name you want to give your service.
```

That was a good answer and allowed me to deploy my web app to Cloud Run. Mission accomplished!

**Lessons learned**:

* Duet AI will not get it right all the time (eg. it doesn't know that you need
  to listen on port 8080 on Cloud Run), so you need to nudge it in the right
  direction.
* Duet AI code generation might get confused between generating comments and
  code. In that case, you can force code generation with `Ctrl+Enter`
