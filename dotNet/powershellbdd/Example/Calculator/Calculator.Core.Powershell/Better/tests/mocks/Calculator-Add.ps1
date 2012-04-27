Write-Host 'Calculator-Add.ps1 (MOCK)'

function Calculator-Add {
param(
	[int] $left,
	[int] $right
)
 
	Write-Host 'Calculator-Add Mock'
	$script:calculator_add_was_called = $true
	$script:calculator_add_param_left = $left
	$script:calculator_add_param_right = $right
  
	if ($script:calculator_add_exec_actual) { 
    	$script:calculator_add_actual_was_called = $true
		Calculator-Add-Actual @PSBoundParameters
	} else {
		return $script:calculator_add_return_value
	}
}