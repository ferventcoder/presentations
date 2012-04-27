write-host '_Initialize-Variables.ps1'

function Initialize-Variables {
  write-host 'Initialize-Variables'
  
  $script:error_message = ''
  
  #Add-Numbers
  $script:add_numbers_was_called= $false
  $script:add_numbers_actual_was_called= $false
  $script:add_numbers_param_left = ''
  $script:add_numbers_param_right = ''
  $script:add_numbers_return_value =  ''
  $script:add_numbers_exec_actual = $false
  
  #Calculator-Add
  $script:calculator_add_was_called= $false
  $script:calculator_add_actual_was_called= $false
  $script:calculator_add_param_left = ''
  $script:calculator_add_param_right = ''
  $script:calculator_add_return_value = ''
  $script:calculator_add_exec_actual = $false
  
}