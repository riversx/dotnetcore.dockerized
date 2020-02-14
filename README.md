# Dotnet Core Dockerized Project

**The walking skeleton is ready!**

```sh
/dotnetcore.dockerized
|__dotnetcore.dockerized.sln (solution project)
|__/src
|  |__/project-api
|     |__ ... (project files)
|     |__ project-api.csproj
|__/test
   |__/project-api.ntest
      |__ ... (NUnit test project files)
      |__ project-api.ntest.csproj
   |__/project-api.xtest
      |__ ... (XUnit test project files)
      |__ project-api.xtest.csproj
```

## Build solution and run tests

Build and run the tests

```sh
dotnet build
dotnet test
dotnet test test/project-api.xtest/project-api.xtest.csproj
```

You should get a red bar

```sh
Test run for /Users/boris/projects/experiments/dotnetcore.dockerized/test/project-api.ntest/bin/Debug/netcoreapp3.1/project-api.ntest.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.3.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 5
     Passed: 5
 Total time: 0.7602 Seconds
```

**FINISH!**
Well done! You are ready to start!

## Run the project

```sh
dotnet run -p src/project-api/project-api.csproj
```

## Build Docker image

```sh
rm -Rf out
dotnet publish src/project-api/project-api.csproj -c Release -o out
docker build -t projectapi .
```

## Run Docker image

```sh
docker run --rm -it -p 80:5000 --name projectapi projectapi
```
