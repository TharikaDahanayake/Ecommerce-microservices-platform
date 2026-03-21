# ProductServiceAPI Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY ../Eccommerce.sln ./
COPY ProductServiceAPI/*.csproj ./ProductServiceAPI/

RUN dotnet restore Eccommerce.sln

COPY ProductServiceAPI/. ./ProductServiceAPI/
WORKDIR /app/ProductServiceAPI

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/ProductServiceAPI/out .
EXPOSE 5103
ENTRYPOINT ["dotnet", "ProductServiceAPI.dll"]