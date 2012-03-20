@echo off

SET DIR=%~d0%~p0%

SET environment="${environment}"
SET database.name="${database.name}"
SET sql.files.directory="%DIR%${dirs.db}"
SET repository.path="${repository.path}"
SET restore.path="%DIR%${restore.from.path}"
SET restore.custom.options="${restore.custom.options}"

"%DIR%Console\rh.exe" /d=%database.name% /f=%sql.files.directory% /s=%server.database% /vf=%version.file% /vx=%version.xpath% /r=%repository.path% /env=%environment% /restore /rfp=%restore.path% /rco=%restore.custom.options%

pause