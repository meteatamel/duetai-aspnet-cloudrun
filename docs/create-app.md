# Create a new web app with Duet AI]

Let's start by asking Duet AI how to create a new ASP.NET web app.

**Prompt**
> How can I create a new ASP.NET web application from the terminal using dotnet command line tool? I want the app to be in MyWebApp folder.

**Answer**
> To create a new ASP.NET web application from the terminal using the dotnet command line tool, you can follow these steps:

Open the terminal or command prompt.

Navigate to the folder where you want to create the new ASP.NET web application. In this case, it is the `MyWebApp` folder.

Run the following command:

```sh
dotnet new web
```

The answer was pretty good and worked! 

Next, let's test and make sure that the app runs fine locally.

**Prompt**
> How can I run Program.cs locally and then test it using curl?

**Answer**
> To run the` Program.cs` file locally, you can use the following steps:

* Open the terminal or command prompt.
* Navigate to the folder where the Program.cs file is located.
* Run the following command:

```sh
dotnet run
`````

> This will start the web application and listen for requests on port 5000.
>
> To test the web application using curl, you can use the following command:

```sh
curl http://localhost:5000
```

In this case, everything was good except the port number. I'm using .NET 8 which
has `5074` as the default port. But overall, I got a new app created and running
pretty quickly!

**Lessons learned**:

* You need to be clear (e.g. create an application from the
  console is ambiguous, it can mean terminal but it can also mean Google Cloud
  console).
* You need to be specific (eg. you can create an app from the IDE or
  using the `dotnet` command line tool, say which one)
* Duet AI will not get it right all the time (eg. it think default port number
  is 5000 when it's 5074)
