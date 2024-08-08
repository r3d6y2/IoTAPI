FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy the solution file and restore dependencies
COPY *.sln .
COPY IoTApi/IoTApi.csproj IoTApi/
COPY IoTApi.Core/IoTApi.Core.csproj IoTApi.Core/
COPY IoTApi.Domain/IoTApi.Domain.csproj IoTApi.Domain/
COPY IoTApi.Infrastructure/IoTApi.Infrastructure.csproj IoTApi.Infrastructure/
COPY IoTApi.Common/IoTApi.Common.csproj IoTApi.Common/
RUN dotnet restore

# Copy the rest of the files and publish the project
COPY . .
WORKDIR /source/IoTApi
RUN dotnet publish -c Release -o /app/publish

# Use the official .NET runtime image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "IoTApi.dll"]