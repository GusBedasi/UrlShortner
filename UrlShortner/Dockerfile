#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UrlShortner/UrlShortner.csproj", "UrlShortner/"]
RUN dotnet restore "UrlShortner/UrlShortner.csproj"
COPY . .
WORKDIR "/src/UrlShortner"
RUN dotnet build "UrlShortner.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UrlShortner.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UrlShortner.dll"]