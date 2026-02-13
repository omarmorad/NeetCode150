@echo off
setlocal

if "%~1"=="" (
    echo Usage: %0 ^<solution_class^>
    echo Example: %0 "NeetCode150.Arrays.ContainsDuplicate"
    exit /b 1
)

echo Building solution with startup object: %1
dotnet build --property:StartupObject="%1" || exit /b 1

echo Running solution...
dotnet ./NeetCode150/bin/Debug/net10.0/NeetCode150.exe