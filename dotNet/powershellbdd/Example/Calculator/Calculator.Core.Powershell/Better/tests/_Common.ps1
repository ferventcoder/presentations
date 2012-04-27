write-host '_Common.ps1'
$here = Split-Path -Parent $MyInvocation.MyCommand.Definition
$script = Join-Path (Split-Path -Parent $here)  'src\Calculator.ps1'

$functionRenames = Join-Path $here '_FunctionRenameActuals.ps1'
$setup = Join-Path $here '_Setup.ps1'
$initializeVariables = Join-Path $here '_Initialize-Variables.ps1'

Import-Module $script 
Import-Module $functionRenames

# grab mocks from files
Resolve-Path "$here\mocks\*.ps1" | % { . $_.ProviderPath }

Import-Module $setup
Import-Module $initializeVariables