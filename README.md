# Api Health

Web api created in .Net Core Cli

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Step 0

```bash
mkdir Health.API
mkdir CORSClient

cd Health.API
dotnet new webapi

cd CORSClient
dotnet new web

cd..
dotnet new sln
dotnet sln Health-api.sln add Health.API/Health.API.csproj
dotnet sln Health-api.sln add CORSClient/CORSClient.API.csproj
```


### Step 1

```bash
dotnet tool install --global dotnet-ef --version 3.0.0-*
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

### Step 2

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.Extensions.DependencyInjection --version 3.1.3
```

### Create api controller

```bash
dotnet aspnet-codegenerator controller -name ValuesController -async -api --readWriteActions -outDir Controllers
dotnet aspnet-codegenerator controller -name PatientsController -async -api -m Patient -dc HealthContext -outDir Controllers
```

### libman install CORSClient
```bash
libman install jquery@3.2.1 --provider cdnjs --destination wwwroot/scripts/jquery --files jquery.min.js
```

### Building and running

To create an optimised version of the app:

## cd Health.API
```bash
dotnet watch run
```

## cd CORSClient
```bash
dotnet watch run
```