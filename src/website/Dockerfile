FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["./website/website.csproj", "website/"]
COPY ["./buildingblocks/ideacode.core/ideacode.core.csproj", "buildingblocks/ideacode.core/"]
COPY ["./buildingblocks/ideacode.api.core/ideacode.api.core.csproj", "buildingblocks/ideacode.api.core/"]
RUN dotnet restore "website/website.csproj"
COPY . .
WORKDIR "website"
RUN dotnet build "website.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "website.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "website.dll"]
