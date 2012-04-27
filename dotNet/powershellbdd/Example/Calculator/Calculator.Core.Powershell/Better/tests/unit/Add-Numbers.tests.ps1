write-host 'Starting Add-Numbers.tests.ps1'

$here = Split-Path -Parent $MyInvocation.MyCommand.Definition
$common = Join-Path (Split-Path -Parent $here)  '_Common.ps1'
. $common

Describe "When calling Add-Numbers to add numbers" {
  Initialize-Variables
  $script:add_numbers_exec_actual = $true
  $script:add_numbers_return_value = 25
  $return = Add-Numbers  1 2

  It "should not return the mocked value" {
    $true.should.be($return -ne $script:add_numbers_return_value)
  }
  
  It "should call Add-Numbers mock" {
    $script:add_numbers_was_called.should.be($true)
  }
  
  It "should call Add-Numbers actual" {
    $script:add_numbers_actual_was_called.should.be($true)
  }
  
}