FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ObiletDemo.Web/ObiletDemo.Web.csproj", "ObiletDemo.Web/"]
RUN dotnet restore "ObiletDemo.Web/ObiletDemo.Web.csproj"
COPY . .
WORKDIR "/src/ObiletDemo.Web"
RUN dotnet build "ObiletDemo.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObiletDemo.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObiletDemo.Web.dll"] 