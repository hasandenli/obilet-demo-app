FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5007

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ObiletDemo.API.csproj", "."]
RUN dotnet restore "ObiletDemo.API.csproj"
COPY . .
WORKDIR "/src/ObiletDemo.API"
RUN dotnet build "ObiletDemo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObiletDemo.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObiletDemo.API.dll"] 