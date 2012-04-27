
function Calculator-Add {
param(
	[int] $left,
	[int] $right
)

	Write-Host "Calculator-Add is calling Add-Numbers to add $left and $right"
 	Add-Numbers $left $right
}



function Add-Numbers {
param(
	[int] $left,
	[int] $right
)

	Write-Host "Add-Numbers is doing some time intensive stuff before adding $left and $right"
	Start-Sleep -Seconds 5
	
	return $left + $right;
}
