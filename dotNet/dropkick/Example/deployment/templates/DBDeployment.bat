@echo off

SET DIR=%~d0%~p0%

SET environment="${environment}"
SET connection.string="${connection.string}"
SET sql.files.directory="${dirs.db}"
SET repository.path="${repository.path}"

"%DIR%Console\rh.exe" /cs=%connection.string% /csa=%connection.string% /f=%sql.files.directory% /r=%repository.path% /env=%environment%

pause