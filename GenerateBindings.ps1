[CmdletBinding()]
Param(
  [Parameter(Mandatory=$true, Position=0)]
  [string]$include
)

$vsPath = &"${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -property installationpath
Import-Module (Join-Path $vsPath "Common7\Tools\Microsoft.VisualStudio.DevShell.dll")
Enter-VsDevShell -VsInstallPath $vsPath -SkipAutomaticLocation

ClangSharpPInvokeGenerator `
-c latest-codegen generate-file-scoped-namespaces multi-file generate-helper-types exclude-fnptr-codegen `
-F $include `
-I $include `
-f avif.h `
-n AvifNet `
-m Avif `
-l avif `
-o .\AvifNet\
