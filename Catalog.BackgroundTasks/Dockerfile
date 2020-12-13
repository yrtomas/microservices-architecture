#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Catalog.BackgroundTasks/Catalog.BackgroundTasks.csproj", "Catalog.BackgroundTasks/"]
RUN dotnet restore "Catalog.BackgroundTasks/Catalog.BackgroundTasks.csproj"
COPY . .
WORKDIR "/src/Catalog.BackgroundTasks"
RUN dotnet build "Catalog.BackgroundTasks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.BackgroundTasks.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.BackgroundTasks.dll"]