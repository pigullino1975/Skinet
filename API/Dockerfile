# Get Base Image (Full .NET Core SDK)
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
EXPOSE 5001

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY API/*.csproj ./API/
COPY Core/*.csproj ./Core/
COPY Infrastructure/*.csproj ./Infrastructure/

RUN dotnet restore

# Copy everything else and build app
COPY API/. ./API
COPY Core/. ./Core
COPY Infrastructure/. ./Infrastructure
#
WORKDIR /app/API
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app

COPY --from=build /app/API/out ./
ENTRYPOINT ["dotnet", "API.dll"]