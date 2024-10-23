rem dotnet tool update -g snitch
rem snitch InstaFakeDetector.csproj
dotnet tool install --global DetectDuplicates
detectduplicates
pause