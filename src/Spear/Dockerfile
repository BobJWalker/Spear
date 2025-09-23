#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Spear/Spear.csproj", "Spear/"]
RUN dotnet restore "./Spear/./Spear.csproj"
COPY . .
WORKDIR "/src/Spear"
RUN dotnet build "./Spear.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Spear.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV SPEAR_INSTANCE_URL=blah
ENV SPEAR_INSTANCE_API_KEY=blah
ENV SPEAR_SUMOLOGIC_URL=blah
ENV SPEAR_ENVIRONMENT="Production"
ENV SPEAR_OPEN_FEATURE_CLIENT_ID="blah"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Spear.dll"]