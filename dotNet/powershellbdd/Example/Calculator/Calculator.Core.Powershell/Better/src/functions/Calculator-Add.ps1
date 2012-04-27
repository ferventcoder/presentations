Write-Host 'Calculator-Add.ps1 (REAL)'

function Calculator-Add {
param(
	[int] $left,
	[int] $right
)
	Write-Host 'Calculator-Add Real'
 	Write-Host "Calculator-Add is calling Add-Numbers to add $left and $right"
 	Add-Numbers $left $right
}