FROM mcr.microsoft.com/dotnet/sdk:5.0.100-alpine3.12-amd64

WORKDIR /app
COPY . /app

RUN dotnet publish -c Release -r linux-x64 --self-contained false

FROM mcr.microsoft.com/dotnet/runtime:5.0.0-alpine3.12-amd64

WORKDIR /app
COPY --from=0 /app/bin/Release/net5.0/linux-x64/publish .

ENTRYPOINT ["dotnet", "FsdnTelegram.dll"]