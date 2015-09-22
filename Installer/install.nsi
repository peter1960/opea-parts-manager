!include dotnet.nsi

# name the installer
OutFile "C:\data\build\OPEAinstaller.exe"
 
 
 # default section start; every NSIS script has at least one section.
Section
 call CheckAndDownloadDotNet45
 SetOutPath "c:\opeaManager\bin\"
 file /r /x CVS C:\data\git\opea-parts-manager\bin\Release\*.*
 
 SetOutPath "c:\opeaManager\bin\"
 CreateShortcut $SMPROGRAMS\OPEAManager.lnk $OUTDIR\OPEAManager.exe
# default section end
SectionEnd

