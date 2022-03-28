#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Nav.API/Nav.API/Nav.API.csproj", "Nav.API/Nav.API/"]
COPY ["Nav.Infrastructure/Nav.Infrastructure.csproj", "Nav.Infrastructure/"]
COPY ["Nav.Core/Nav.Core.csproj", "Nav.Core/"]
COPY ["Nav.Application/Nav.Application.csproj", "Nav.Application/"]
RUN dotnet restore "Nav.API/Nav.API/Nav.API.csproj"
COPY . .
WORKDIR "/src/Nav.API/Nav.API"
RUN dotnet build "Nav.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nav.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nav.API.dll"]
