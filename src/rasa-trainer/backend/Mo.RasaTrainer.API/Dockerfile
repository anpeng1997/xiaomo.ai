FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/rasa-trainer/backend/Mo.RasaTrainer.API/Mo.RasaTrainer.API.csproj", "src/rasa-trainer/backend/Mo.RasaTrainer.API/"]
RUN dotnet restore "src/rasa-trainer/backend/Mo.RasaTrainer.API/Mo.RasaTrainer.API.csproj"
COPY . .
WORKDIR "/src/src/rasa-trainer/backend/Mo.RasaTrainer.API"
RUN dotnet build "Mo.RasaTrainer.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Mo.RasaTrainer.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Mo.RasaTrainer.API.dll"]