#
# Script.ps1
#
$here = Split-Path -Parent $MyInvocation.MyCommand.Definition

# grab functions from files
Resolve-Path $here\_Normal\*.ps1 | %{ . $_.ProviderPath }


Calculator-Add 1 2 | Write-Host