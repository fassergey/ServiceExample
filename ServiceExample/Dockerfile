#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-bionic AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic AS build

WORKDIR /src
COPY . .

RUN dotnet restore "ServiceExample.csproj" \
    && dotnet build "ServiceExample.csproj" -c Release -o /app \
    && dotnet publish "ServiceExample.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .

EXPOSE 80
ENV ASPNETCORE_URLS=http://*:80

ENTRYPOINT ["dotnet", "ServiceExample.dll"]