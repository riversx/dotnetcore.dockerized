FROM mcr.microsoft.com/dotnet/core/sdk:3.1

WORKDIR /projectapi
COPY out .

ENTRYPOINT ["dotnet", "project-api.dll"]