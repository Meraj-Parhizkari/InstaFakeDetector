dotnet tool update --global dotnet-ef --version 8.0.2
dotnet tool restore
dotnet build
dotnet ef --startup-project ../InstaFakeDetector/ database update --context SQLiteDbContext
pause