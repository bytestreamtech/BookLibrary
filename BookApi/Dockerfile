# Use the official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY BookApi.csproj ./
RUN dotnet restore BookApi.csproj

# Copy the rest of the source code
COPY . .

# Publish the application to the /app/publish directory
RUN dotnet publish BookApi.csproj -c Release -o /app/publish --no-restore

# Use the official ASP.NET runtime image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expose port 8080
EXPOSE 8080

# Set the entrypoint
ENTRYPOINT ["dotnet", "BookApi.dll"]
