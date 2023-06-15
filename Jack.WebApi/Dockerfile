#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Jack.WebApi/Jack.WebApi.csproj", "Jack.WebApi/"]
RUN dotnet restore "Jack.WebApi/Jack.WebApi.csproj"
COPY . .
WORKDIR "/src/Jack.WebApi"
RUN dotnet build "Jack.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jack.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jack.WebApi.dll"]