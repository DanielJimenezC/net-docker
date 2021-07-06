FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /app

COPY *.sln .
COPY luzdelsur.web.api/*.csproj ./luzdelsur.web.api/
COPY luzdelsur.web.business/*.csproj ./luzdelsur.web.business/
COPY luzdelsur.web.domain/*.csproj ./luzdelsur.web.domain/

RUN dotnet restore

COPY luzdelsur.web.api/. ./luzdelsur.web.api/
COPY luzdelsur.web.business/. ./luzdelsur.web.business/
COPY luzdelsur.web.domain/. ./luzdelsur.web.domain/
WORKDIR "/app/luzdelsur.web.api"
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /app/luzdelsur.web.api/out ./
ENTRYPOINT ["dotnet", "luzdelsur.web.api.dll"]
