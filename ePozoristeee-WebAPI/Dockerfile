#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
WORKDIR /src
COPY ["ePozoristeee-WebAPI/ePozoriste.WebAPI.csproj", "ePozoristeee-WebAPI/"]
COPY ["ePozoriste.Model/ePozoriste.Model.csproj", "ePozoriste.Model/"]
RUN dotnet restore "ePozoristeee-WebAPI/ePozoriste.WebAPI.csproj"
COPY . .
WORKDIR "/src/ePozoristeee-WebAPI"
RUN dotnet build "ePozoriste.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ePozoriste.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ePozoriste.WebAPI.dll"]