; For the sample, please visit https://github.com/rkoCyrus/NSIS_JDK_jar2exe_sample/blob/master/Run.jarbyNSIS.nsi
; ------------
; Number Bomb JAR - NSIS Launcher

; Informations for the program itself
Name "Number Bomb (Java)"
Caption "Number Bomb (JRE version)"
OutFile "numberbomb.exe"

; Remember mark this as we need it run only. NSIS's mainpurpose is installing program
SilentInstall silent
AutoCloseWindow true
ShowInstDetails nevershow

; In default, it require UAC permission. However, since it nothing write in program files, it turn to become annoying
RequestExecutionLevel user

; Program part
Section ""
    Call JDKEnabled
    Pop $R0

    StrCpy $0 '"$R0" -jar numberbomb.jar'

    SetOutPath $EXEDIR
    ExecWait $0
SectionEnd

Function "JDKEnabled"
    # Variable setup
    Push $R0
    Push $R1

    # We only need JAVA_HOME which suppose to be added manually.
    ClearErrors
    ReadEnvStr $R0 "JAVA_HOME"
    StrCpy $R0 "$R0\bin\java.exe"
    IfErrors 0 JREFound

    StrCpy $R0 "java.exe"

    JREFound:
        Pop $R1
        Exch $R0
FunctionEnd