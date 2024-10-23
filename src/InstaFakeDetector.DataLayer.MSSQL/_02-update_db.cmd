dotnet tool update --global dotnet-ef --version 8.0.2
dotnet tool restore
dotnet build
dotnet ef --verbose --startup-project ../InstaFakeDetector/ database update --context MsSqlDbContext
pause