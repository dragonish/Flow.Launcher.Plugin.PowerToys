dotnet publish -c Release -r win-x64 --no-self-contained Flow.Launcher.Plugin.PowerToys.csproj
7z a -tzip "Flow.Launcher.Plugin.PowerToys.zip" "./bin/Release/win-x64/publish/*"
