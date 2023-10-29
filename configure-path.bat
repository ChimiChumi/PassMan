# configurepath.ps1
$env:DB_PATH = Get-Location
Write-Host "Database path set to $env:DB_PATH"