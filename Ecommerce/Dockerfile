# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY ../Eccommerce.sln ./
COPY Eccommerce/*.csproj ./Eccommerce/

RUN dotnet restore Eccommerce.sln

COPY Eccommerce/. ./Eccommerce/
WORKDIR /app/Eccommerce

RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/Eccommerce/out .
EXPOSE 5251
ENTRYPOINT ["dotnet", "Eccommerce.dll"]