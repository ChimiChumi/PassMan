# The script below adds the database path dynamically to the environmental variable, which will be used to extract it in the code
$env:DB_PATH = Get-Location
Write-Host "Database path set to $env:DB_PATH"
