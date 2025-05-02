FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ObiletDemo.API/ObiletDemo.API.csproj", "ObiletDemo.API/"]
RUN dotnet restore "ObiletDemo.API/ObiletDemo.API.csproj"
COPY . .
WORKDIR "/src/ObiletDemo.API"
RUN dotnet build "ObiletDemo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObiletDemo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObiletDemo.API.dll"] 