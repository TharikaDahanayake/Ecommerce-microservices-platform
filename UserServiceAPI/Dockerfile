# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY ../Eccommerce.sln ./
COPY UserService/*.csproj ./UserService/

RUN dotnet restore Eccommerce.sln

COPY UserService/. ./UserService/
WORKDIR /app/UserService

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/UserService/out .
EXPOSE 5002
ENTRYPOINT ["dotnet", "UserService.dll"]