Write-Host 'Add-Numbers.ps1 (REAL)'

function Add-Numbers {
param(
	[int] $left,
	[int] $right
)
	Write-Host 'Add-Numbers Real'
	Write-Host "Add-Numbers is doing some time intensive stuff before adding $left and $right"
	Start-Sleep -Seconds 5
	
	return $left + $right;
}