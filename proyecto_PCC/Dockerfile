FROM mcr.microsoft.com/dotnet/sdk:10.0 AS builder
WORKDIR /src
COPY . .
RUN dotnet publish "proyecto_PCC.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=builder /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "proyecto_PCC.dll"]