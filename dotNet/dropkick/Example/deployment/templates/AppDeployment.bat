@echo off

SET DIR=%~d0%~p0%

xcopy "%DIR%${deploy.web.from}\*" "\\${server.app}\${deploy.web.path}" /r /i /c /h /k /e /y /d
xcopy "%DIR%..\environment.files\${environment}\${environment}.web.config" "\\${server.app}\${deploy.web.path}\web.config" /r /i /c /h /k /e /y /d