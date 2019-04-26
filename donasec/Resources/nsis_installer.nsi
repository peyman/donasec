; Installer for Donasec

;--------------------------------

!define PRODUCT "Donasec"

Name "${PRODUCT} Installer"

OutFile "..\bin\Release\${PRODUCT}_install.exe"

; Default installation directory
InstallDir $PROGRAMFILES\${PRODUCT}

; Store install dir in the registry
InstallDirRegKey HKLM "Software\${PRODUCT}" "Install_Dir"

; Request application privileges for UAC
RequestExecutionLevel admin


;--------------------------------

; Installer pages
Page directory
Page instfiles

; Uninstaller pages
UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------


Section "Installer"

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR

  ; Put file there
  File ..\bin\Release\donasec.exe

  ; Add configuration to the registry
  WriteRegStr HKCR ${PRODUCT} "" "URL: Donasec."
  WriteRegStr HKCR ${PRODUCT} "URL Protocol" ""
  WriteRegStr HKCR ${PRODUCT}\DefaultIcon "" "$INSTDIR\donasec.exe,0"
  WriteRegStr HKCR ${PRODUCT}\shell\open\command "" "$INSTDIR\donasec.exe $\"%1$\""
  WriteRegStr HKLM SOFTWARE\Clients\${PRODUCT}\Capabilities "ApplicationDescription" "Donasec."
  WriteRegStr HKLM SOFTWARE\Clients\${PRODUCT}\Capabilities "ApplicationName" "Donasec"
  WriteRegStr HKLM SOFTWARE\Clients\${PRODUCT}\Capabilities\UrlAssociations "http" "Donasec"
  WriteRegStr HKLM SOFTWARE\Clients\${PRODUCT}\Capabilities\UrlAssociations "https" "Donasec"
  WriteRegStr HKLM SOFTWARE\RegisteredApplications "${PRODUCT}" "SOFTWARE\Clients\${PRODUCT}\Capabilities"

  ; Write the installation path to the registry
  WriteRegStr HKLM SOFTWARE\${PRODUCT} "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys to the registry
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "DisplayName" "${PRODUCT}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "UninstallString" '"$INSTDIR\${PRODUCT}_uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "NoRepair" 1
  WriteUninstaller "${PRODUCT}_uninstall.exe"

  ExecShell "open" "http://www.donasec.com/thank-you"

SectionEnd

;--------------------------------


Section "Uninstall"

  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}"
  DeleteRegKey HKLM SOFTWARE\${PRODUCT}

  ; Add configuration to the registry
  DeleteRegKey HKCR ${PRODUCT}
  DeleteRegKey HKLM SOFTWARE\Clients\${PRODUCT}
  DeleteRegValue HKLM SOFTWARE\RegisteredApplications "${PRODUCT}"

  ; Remove files and uninstaller
  Delete $INSTDIR\${PRODUCT}.exe
  Delete $INSTDIR\${PRODUCT}_uninstall.exe
  RMDir $INSTDIR

  ExecShell "open" "http://www.donasec.com/thank-you-uninstall"

SectionEnd