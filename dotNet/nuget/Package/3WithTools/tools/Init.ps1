param($installPath, $toolsPath, $package, $project)

#add-type -Assembly EnvDTE

$requiredAssemblies = Get-ChildItem $ToolsPath -Filter *.dll

$requiredAssemblies | ForEach-Object { Add-Type -Path $_.FullName }

$modules = Get-ChildItem $ToolsPath -Filter *.psm1

$modules | ForEach-Object { import-module -name  $_.FullName }
