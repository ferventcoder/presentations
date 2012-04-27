Write-Host 'Calculator.ps1'

$calDir = Split-Path -Parent $MyInvocation.MyCommand.Definition
# grab functions from files
Resolve-Path "$calDir\functions\*.ps1" | %{ . $_.ProviderPath }

Write-Host 'The Calculator is ready'
