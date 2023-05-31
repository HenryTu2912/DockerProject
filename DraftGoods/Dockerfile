FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /DraftGoods

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /DraftGoods
COPY --from=build-env /DraftGoods/out .
ENTRYPOINT ["dotnet", "DraftGoods.dll"]
