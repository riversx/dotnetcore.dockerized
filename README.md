# Dotnet Core Dockerized Project

**The walking skeleton is ready!**

```sh
/dotnetcore.dockerized
|__global.json
|__/src
|  |__/AspDotnetCoreProject
|     |_ ... (project files)
|     |__project.json
|__/test
   |__/AspDotnetCoreProject.Tests
|     |_ ... (test project files)
      |__project.json
```

## Build solution and run tests
Build and run the tests
```sh
dotnet restore src/AspDotnetCoreProject/project.json
dotnet build src/AspDotnetCoreProject/project.json
dotnet restore test/AspDotnetCoreProject.Tests/project.json
dotnet test test/AspDotnetCoreProject.Tests/project.json
```

You should get a red bar
```sh
xUnit.net .NET CLI test runner (64-bit osx.10.11-x64)
  Discovering: AspDotnetCoreProject.Tests
  Discovered:  AspDotnetCoreProject.Tests
  Starting:    AspDotnetCoreProject.Tests
  Finished:    AspDotnetCoreProject.Tests
=== TEST EXECUTION SUMMARY ===
   AspDotnetCoreProject.Tests  Total: 1, Errors: 0, Failed: 0, Skipped: 0, Time: 0.167s
SUMMARY: Total: 1 targets, Passed: 1, Failed: 0.
```

**FINISH!**
Well done! You are ready to start!

## Build Docker image ##
```sh
dotnet publish src/AspDotnetCoreProject/project.json -c Release -o out
docker build -t aspdotnetcoreproject .
```
## Run Docker image ##
```sh
docker run --rm -it -p 80:5000 --name aspnetcoreproject aspnetcoreproject
```