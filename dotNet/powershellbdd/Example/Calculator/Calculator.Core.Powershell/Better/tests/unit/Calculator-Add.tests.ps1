write-host 'Starting Calculator-Add.tests.ps1'

$here = Split-Path -Parent $MyInvocation.MyCommand.Definition
$common = Join-Path (Split-Path -Parent $here)  '_Common.ps1'
. $common

Describe "When calling Calculator-Add to add numbers" {
  Initialize-Variables
  $script:calculator_add_exec_actual = $true
  $script:add_numbers_return_value = 3
  $left = 1
  $right = 2
  $return = Calculator-Add  $left $right

  It "should return appropriately" {
    $return.should.be($script:add_numbers_return_value)
  }
  
  It "should call Calculator-Add mock" {
    $script:calculator_add_was_called.should.be($true)
  }
  
  It "should call Calculator-Add actual" {
    $script:calculator_add_actual_was_called.should.be($true)
  }
  
  It "should call Add-Numbers mock" {
    $script:add_numbers_was_called.should.be($true)
  }
  
  It "should call Add-Numbers with a left value of $left" {
    $script:add_numbers_param_left.should.be($left)
  }  
  
  It "should call Add-Numbers with a right value of $right" {
    $script:add_numbers_param_right.should.be($right)
  }
  
  It "should not actually call the real Add-Numbers" {
    $script:add_numbers_actual_was_called.should.be($false)
  }
}