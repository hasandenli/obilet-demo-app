FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5006

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ObiletDemo.Web.csproj", "."]
RUN dotnet restore "ObiletDemo.Web.csproj"
COPY . .
RUN dotnet build "ObiletDemo.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObiletDemo.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObiletDemo.Web.dll"]
