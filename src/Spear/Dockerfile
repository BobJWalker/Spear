# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER app
WORKDIR /app


# This stage is used to build the service project
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
ARG APP_VERSION="6.13.0"
WORKDIR /src
COPY ["Spear/Spear.csproj", "Spear/"]
RUN dotnet restore "Spear/Spear.csproj"
COPY . .
WORKDIR "/src/Spear"
RUN dotnet build "Spear.csproj" -c Release -o /app/build /p:$APP_VERSION -a $TARGETARCH

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
RUN dotnet publish "Spear.csproj" -c Release -o /app/publish /p:UseAppHost=false /p:Version=$APP_VERSION -a $TARGETARCH

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
ENV SPEAR_INSTANCE_URL=blah
ENV SPEAR_INSTANCE_API_KEY=blah
ENV SPEAR_SUMOLOGIC_URL=blah
ENV SPEAR_ENVIRONMENT="Production"
ENV SPEAR_OPEN_FEATURE_CLIENT_ID="blah"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Spear.dll"]