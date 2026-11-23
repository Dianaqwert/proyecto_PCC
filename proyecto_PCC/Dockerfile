# Fase 1: Compilación con el SDK de .NET (Roslyn genera proyecto_PCC.dll)
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish "proyecto_PCC.csproj" -c Release -o /app/publish

# Fase 2: Ejecución ligera con el Runtime de ASP.NET Core (CLR)
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
