FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 65431
EXPOSE 44304

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["api.csproj", ""]
RUN dotnet restore "./api.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api.dll"]