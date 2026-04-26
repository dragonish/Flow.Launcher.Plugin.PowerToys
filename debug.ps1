dotnet publish ./Flow.Launcher.Plugin.PowerToys.csproj -c Debug -r win-x64 --no-self-contained

$AppDataFolder = [Environment]::GetFolderPath("ApplicationData")
$flowLauncherExe = "$env:LOCALAPPDATA\FlowLauncher\Flow.Launcher.exe"

if (Test-Path $flowLauncherExe) {
    Stop-Process -Name "Flow.Launcher" -Force -ErrorAction SilentlyContinue
    Start-Sleep -Seconds 2

    $pluginDir = "$AppDataFolder\FlowLauncher\Plugins"
    $pluginPath = "$pluginDir\PowerToys"

    if (Test-Path "$pluginPath") {
        Remove-Item -Recurse -Force "$pluginPath"
    }

    Copy-Item "bin\Debug\win-x64\publish" "$pluginDir\" -Recurse -Force
    Rename-Item -Path "$pluginDir\publish" -NewName "PowerToys"

    Start-Sleep -Seconds 2
    Start-Process $flowLauncherExe
} else {
    $flowLauncherExe = "$env:USERPROFILE\scoop\apps\flow-launcher\current\Flow.Launcher.exe"
    if (Test-Path $flowLauncherExe) {
        Stop-Process -Name "Flow.Launcher" -Force -ErrorAction SilentlyContinue
        Start-Sleep -Seconds 2

        $pluginDir = "$env:USERPROFILE\scoop\persist\flow-launcher\UserData\Plugins"
        $pluginPath = "$pluginDir\PowerToys"

        if (Test-Path "$pluginPath") {
            Remove-Item -Recurse -Force "$pluginPath"
        }

        Copy-Item "bin\Debug\win-x64\publish" "$pluginDir\" -Recurse -Force
        Rename-Item -Path "$pluginDir\publish" -NewName "PowerToys"

        Start-Sleep -Seconds 2
        Start-Process $flowLauncherExe
    }
    else {
        Write-Host "Flow.Launcher.exe not found. Please install Flow Launcher first"
    }
}
