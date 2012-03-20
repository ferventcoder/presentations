@echo off
SET DIR=%~d0%~p0%
pushd %DIR%
dropkick\dk.exe execute /deployment:DeploymentSpecification\Deployment.dll /environment:${environment} /settings:.\settings /roles:Website,VirtualDirectory
popd
pause
