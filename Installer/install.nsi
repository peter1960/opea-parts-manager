!include dotnet.nsi

# name the installer
OutFile "C:\data\build\OPEAinstaller.exe"
 
 
 # default section start; every NSIS script has at least one section.
Section
 call CheckAndDownloadDotNet45
 SetOutPath "c:\opeaManager\bin\"
 file /r /x CVS C:\data\git\opea-parts-manager\bin\Release\*.*
 CreateDirectory "c:\opeaManager\backup"
 SetOutPath "c:\opeaManager\extra\"
 file "C:\data\build\sqlitebrowser-3.6.0v3-win32.exe"
 SetOutPath "c:\opeaManager\bin\"
 CreateShortcut $SMPROGRAMS\OPEAManager.lnk $OUTDIR\OPEAManager.exe
# default section end
SectionEnd

