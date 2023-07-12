FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/App.ALL.Web.Host/App.ALL.Web.Host.csproj", "src/App.ALL.Web.Host/"]
COPY ["src/App.ALL.Web.Core/App.ALL.Web.Core.csproj", "src/App.ALL.Web.Core/"]
COPY ["src/App.ALL.Application/App.ALL.Application.csproj", "src/App.ALL.Application/"]
COPY ["src/App.ALL.Core/App.ALL.Core.csproj", "src/App.ALL.Core/"]
COPY ["src/App.ALL.EntityFrameworkCore/App.ALL.EntityFrameworkCore.csproj", "src/App.ALL.EntityFrameworkCore/"]
WORKDIR "/src/src/App.ALL.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/App.ALL.Web.Host", "src/App.ALL.Web.Host"]
COPY ["src/App.ALL.Web.Core", "src/App.ALL.Web.Core"]
COPY ["src/App.ALL.Application", "src/App.ALL.Application"]
COPY ["src/App.ALL.Core", "src/App.ALL.Core"]
COPY ["src/App.ALL.EntityFrameworkCore", "src/App.ALL.EntityFrameworkCore"]
WORKDIR "/src/src/App.ALL.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "App.ALL.Web.Host.dll"]
