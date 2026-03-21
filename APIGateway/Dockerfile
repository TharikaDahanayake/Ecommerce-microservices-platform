# UserServiceAPI Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY ../Eccommerce.sln ./
COPY UserServiceAPI/*.csproj ./UserServiceAPI/

RUN dotnet restore Eccommerce.sln

COPY UserServiceAPI/. ./UserServiceAPI/
WORKDIR /app/UserServiceAPI

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/UserServiceAPI/out .
EXPOSE 5036
ENTRYPOINT ["dotnet", "UserServiceAPI.dll"]