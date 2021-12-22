# parent env
FROM mcr.microsoft.com/dotnet/aspnet:3.1

# COPY File to Dev
COPY bin/Debug/netcoreapp3.1/ App/

# Env of docker
ENV DB_HOST="HelloWorld"
ENV DB_PASSWORD="999999"

WORKDIR /App
EXPOSE 80

CMD dotnet StudentDemo.dll ConnectionStrings:Postgres="Host=${DB_HOST};Database=postgres;Username=postgres;Password=${DB_PASSWORD}"