# OrderServiceAPI Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY ../Eccommerce.sln ./
COPY OderServiceAPI/*.csproj ./OderServiceAPI/

RUN dotnet restore Eccommerce.sln

COPY OderServiceAPI/. ./OderServiceAPI/
WORKDIR /app/OderServiceAPI

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/OderServiceAPI/out .
EXPOSE 5256
ENTRYPOINT ["dotnet", "OderServiceAPI.dll"]