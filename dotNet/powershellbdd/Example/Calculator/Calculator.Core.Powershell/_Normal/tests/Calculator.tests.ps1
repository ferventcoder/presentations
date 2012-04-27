$here = Split-Path -Parent $MyInvocation.MyCommand.Definition
$calculator = Join-Path (Split-Path -Parent $here)  'Calculator.ps1'
. $calculator

Describe "When using a Calculator to add numbers" {
  $return = Calculator-Add  1 2

  It "should return appropriately" {
    $return.should.be(3)
  }
  
}