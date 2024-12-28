FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["./services/ideacode.api/ideacode.api.csproj", "services/ideacode.api/"]
COPY ["./buildingblocks/ideacode.api.core/ideacode.api.core.csproj", "buildingblocks/ideacode.api.core/"]
COPY ["./buildingblocks/ideacode.core/ideacode.core.csproj", "buildingblocks/ideacode.core/"]
RUN dotnet restore "services/ideacode.api/ideacode.api.csproj"
COPY . .
WORKDIR "services/ideacode.api"
RUN dotnet build "ideacode.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ideacode.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ideacode.api.dll"]
