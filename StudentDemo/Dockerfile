FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /App

COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

# Env of docker
ENV DB_HOST="HelloWorld"
ENV DB_PASSWORD="999999"

WORKDIR /App
COPY --from=build-env /App/out .
EXPOSE 80

CMD dotnet StudentDemo.dll ConnectionStrings:Postgres="Host=${DB_HOST};Database=postgres;Username=postgres;Password=${DB_PASSWORD}"