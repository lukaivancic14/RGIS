FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ivancic_bencak.csproj", "."]
RUN dotnet restore "./Ivancic_bencak.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Ivancic_bencak.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ivancic_bencak.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ivancic_bencak.dll"]
