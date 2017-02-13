FROM microsoft/dotnet:1.0-runtime

WORKDIR /aspdotnetcoreproject
COPY out .

ENTRYPOINT ["dotnet", "AspDotnetCoreProject.dll"]