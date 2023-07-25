FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ALL.ALL.Web.Host/ALL.ALL.Web.Host.csproj", "src/ALL.ALL.Web.Host/"]
COPY ["src/ALL.ALL.Web.Core/ALL.ALL.Web.Core.csproj", "src/ALL.ALL.Web.Core/"]
COPY ["src/ALL.ALL.Application/ALL.ALL.Application.csproj", "src/ALL.ALL.Application/"]
COPY ["src/ALL.ALL.Core/ALL.ALL.Core.csproj", "src/ALL.ALL.Core/"]
COPY ["src/ALL.ALL.EntityFrameworkCore/ALL.ALL.EntityFrameworkCore.csproj", "src/ALL.ALL.EntityFrameworkCore/"]
WORKDIR "/src/src/ALL.ALL.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ALL.ALL.Web.Host", "src/ALL.ALL.Web.Host"]
COPY ["src/ALL.ALL.Web.Core", "src/ALL.ALL.Web.Core"]
COPY ["src/ALL.ALL.Application", "src/ALL.ALL.Application"]
COPY ["src/ALL.ALL.Core", "src/ALL.ALL.Core"]
COPY ["src/ALL.ALL.EntityFrameworkCore", "src/ALL.ALL.EntityFrameworkCore"]
WORKDIR "/src/src/ALL.ALL.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ALL.ALL.Web.Host.dll"]
