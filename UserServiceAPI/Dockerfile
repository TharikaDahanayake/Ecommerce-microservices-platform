FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY UserServiceAPI.csproj ./
RUN dotnet restore UserServiceAPI.csproj

COPY . ./
RUN dotnet publish UserServiceAPI.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "UserServiceAPI.dll"]