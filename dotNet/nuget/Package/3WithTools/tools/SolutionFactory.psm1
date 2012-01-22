function Add-Project {
	param([string] $target)
	"Add project $($target) to the solution."
	[SolutionFactory.Projects]::AddProject($dte,$target)
}

function Add-ProjectReference {
param(
    [string] $target,
    [string] $reference
    )
	"Add Project Reference from the $target project to $reference."
	[SolutionFactory.Projects]::AddReference($dte,$target,$reference)

}
function Add-LibraryReference {
param(
    [string] $target,
    [string] $reference
    )
	"Add Library Reference from the $target project to $reference."
	[SolutionFactory.Projects]::AddLibraryReference($dte,$target,$reference)
}

function Remove-LibraryReference {
param(
    [string] $target,
    [string] $reference
    )
	"Remove Library Reference from the $target project to $reference."
	[SolutionFactory.Projects]::RemoveLibraryReference($dte,$target,$reference)
}

function Set-ProjectNamespace {
param(
    [string] $target,
    [string] $namespace
    )
	"Setting the Default Namespace of project $target to $namespace"
	[SolutionFactory.Projects]::SetNamespace($dte,$target,$namespace)
}

export-modulemember -function Add-Project
export-modulemember -function Add-ProjectReference
export-modulemember -function Set-ProjectNamespace
export-modulemember -function Add-LibraryReference
export-modulemember -function Remove-LibraryReference

