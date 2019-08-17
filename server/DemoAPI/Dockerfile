FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["DemoAPI/DemoAPI.csproj", "DemoAPI/"]
RUN dotnet restore "DemoAPI/DemoAPI.csproj"
COPY . .
WORKDIR "/src/DemoAPI"
RUN dotnet build "DemoAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DemoAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DemoAPI.dll"]