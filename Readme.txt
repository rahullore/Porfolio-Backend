#create solution
dotnet new sln -o Portfolio

#create project
dotnet new webapi -o Portfolio.Api
dotnet new classlib -o Portfolio.Contracts
dotnet new classlib -o Portfolio.Infrastructure
dotnet new classlib -o Portfolio.Application
dotnet new classlib -o Portfolio.Domain

#add project to solution
dotnet sln add(ls -r **\*.csproj)

#build project
dotnet build

#create dependency
dotnet add .\Portfolio.Api\ reference .\Portfolio.Contracts\ .\Portfolio.Application\
dotnet add .\Portfolio.Infrastructure\ reference .\Portfolio.Application\
dotnet add .\Portfolio.Application\ reference .\Portfolio.Domain\
dotnet add .\Portfolio.Api\ reference .\Portfolio.Infrastructure\