# 1. Estágio base para execução da aplicação (imagem mais leve)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

# 2. Estágio de build utilizando o SDK completo
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ErpJuridico.Api.csproj", "."]
RUN dotnet restore "./ErpJuridico.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ErpJuridico.Api.csproj" -c Release -o /app/build

# 3. Estágio de publicação (gera os arquivos otimizados)
FROM build AS publish
RUN dotnet publish "ErpJuridico.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# 4. Estágio final (copia os binários publicados para a imagem base)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ErpJuridico.Api.dll"]