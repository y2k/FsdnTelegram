FROM microsoft/dotnet:2.1-sdk

WORKDIR /app
COPY . /app
RUN dotnet publish -c Release -r linux-x64 --self-contained false

FROM microsoft/dotnet:2.1-runtime

WORKDIR /app
COPY --from=0 /app/bin/Release/netcoreapp2.0/linux-x64/publish .

ENTRYPOINT ["dotnet", "FsdnTelegram.dll"]