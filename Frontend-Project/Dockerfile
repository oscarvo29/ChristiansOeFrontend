FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Frontend-Project/Frontend-Project.csproj", "Frontend-Project/"]
RUN dotnet restore "Frontend-Project/Frontend-Project.csproj"
COPY . .
WORKDIR "/src/Frontend-Project"
RUN dotnet build "Frontend-Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Frontend-Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Frontend-Project.dll"]
