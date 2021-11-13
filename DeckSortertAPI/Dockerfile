
FROM  mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY ["DeckSortertAPI.csproj", "DeckSortertAPI/"]
RUN dotnet restore "DeckSortertAPI/DeckSortertAPI.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "DeckSortertAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DeckSortertAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DeckSortertAPI.dll"]
