#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Plexform.Web.Host/Plexform.Web.Host.csproj", "src/Plexform.Web.Host/"]
COPY ["../../Zero/aspnet-core/src/Plexform.Web.Core/Plexform.Web.Core.csproj", "src/Plexform.Web.Core/"]
COPY ["../../Zero/aspnet-core/src/Plexform.Application/Plexform.Application.csproj", "src/Plexform.Application/"]
COPY ["../../Zero/aspnet-core/src/Plexform.Application.Shared/Plexform.Application.Shared.csproj", "src/Plexform.Application.Shared/"]
COPY ["../../Zero/aspnet-core/src/Plexform.Core.Shared/Plexform.Core.Shared.csproj", "src/Plexform.Core.Shared/"]
COPY ["../../Zero/aspnet-core/src/Plexform.Core/Plexform.Core.csproj", "src/Plexform.Core/"]
COPY ["src/Plexform.EntityFrameworkCore/Plexform.EntityFrameworkCore.csproj", "src/Plexform.EntityFrameworkCore/"]
COPY ["../../Zero/aspnet-core/src/Plexform.GraphQL/Plexform.GraphQL.csproj", "src/Plexform.GraphQL/"]
#Plexform Lib
COPY ["src/Plexform.Logic/Plexform.Logic.csproj", "src/Plexform.Logic/"]
RUN dotnet restore "src/Plexform.Web.Host/Plexform.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Plexform.Web.Host"
RUN dotnet build "Plexform.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Plexform.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Plexform.Web.Host.dll"]
