# clean-architecture

#0
mkdir Health.API
mkdir CORSClient

cd Health.API
dotnet new webapi

cd CORSClient
dotnet new web

cd..
dotnet new sln
dotnet sln Health-api.sln add Health.API/Health.API.csproj


#1
dotnet tool install --global dotnet-ef --version 3.0.0-*
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool install -g Microsoft.Web.LibraryManager.Cli

#2
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.Extensions.DependencyInjection --version 3.1.3

#3 scalfold
dotnet aspnet-codegenerator controller -name ValuesController -async -api --readWriteActions -outDir Controllers

dotnet aspnet-codegenerator controller -name PatientsController -async -api -m Patient -dc HealthContext -outDir Controllers


#4 CORSClient
libman install jquery@3.2.1 --provider cdnjs --destination wwwroot/scripts/jquery --files jquery.min.js