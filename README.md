# Crowe.HelloWorld
Programming exercise for Crowe

## Installing/Running
```
git clone https://github.com/ajdepersio/Crowe.HelloWorld
cd Crowe.HelloWorld
dotnet build
dotnet run --project ./Crowe.HelloWorld.Api

#Calling the API via curl
curl -XPOST 'http://localhost:5000/api/helloworld'
```

## Solution Organization
### Crowe.HelloWorld.Api
.NET Core 3.1 Web API project.  
The main API. Exposes one endpoint, POST /api/helloworld.
The writer can be configured via appsettings.json.  ConsoleWriter, the default and currently only implementation of IWriter will write out to the API executable's output.

### Crowe.HelloWorld.Writers
.NET Core 3.1 Class Library
Contains the IWriter interface and its implementations.  Further writers, such as a file writer, a DB writer, etc. would be created here.

### Crowe.HelloWorld.Tests
.NET Core 3.1 MSTest Project
Contains unit tests for both ConsoleWriter and HelloWorldController.
