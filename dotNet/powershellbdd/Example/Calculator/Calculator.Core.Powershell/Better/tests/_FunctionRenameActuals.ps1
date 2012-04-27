write-host '_FunctionRenameActuals.ps1'
write-host 'Renaming Add-Numbers (REAL) to Add-Numbers-Actual'
rename-item function:Add-Numbers Add-Numbers-Actual
write-host 'Renaming Calculator-Add (REAL) to Calculator-Add-Actual'
rename-item function:Calculator-Add Calculator-Add-Actual