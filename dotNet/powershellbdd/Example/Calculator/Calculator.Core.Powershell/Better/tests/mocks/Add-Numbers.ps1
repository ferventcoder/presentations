Write-Host 'Add-Numbers.ps1 (MOCK)'

function Add-Numbers {
param(
	[int] $left,
	[int] $right
)
	Write-Host 'Add-Numbers Mock'
	$script:add_numbers_was_called = $true
  	$script:add_numbers_param_left = $left
  	$script:add_numbers_param_right = $right
  
	if ($script:add_numbers_exec_actual) { 
    	$script:add_numbers_actual_was_called = $true
		Add-Numbers-Actual @PSBoundParameters
	} else {
		return $script:add_numbers_return_value
	}
}