; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=ContactsApp
AppVersion=1.0
WizardStyle=modern
DefaultDirName={autopf}\My Program
DefaultGroupName=My Program
UninstallDisplayIcon={app}\MyProg.exe
Compression=lzma2
SolidCompression=yes
OutputDir=userdocs:Inno Setup Examples Output

[Files]
Source: "ContactsAppUI.exe"; DestDir: "ContactsAppUI.exe"

[Icons]
Name: "{group}\My Program"; Filename: "{app}\MyProg.exe"
