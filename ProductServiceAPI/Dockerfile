FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ProductServiceAPI.csproj ./
RUN dotnet restore ProductServiceAPI.csproj

COPY . ./
RUN dotnet publish ProductServiceAPI.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "ProductServiceAPI.dll"]