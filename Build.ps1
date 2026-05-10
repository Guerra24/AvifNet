[CmdletBinding()]
Param(
  [Parameter(Mandatory=$true, Position=0)]
  [ValidateSet('x64-windows','arm64-windows')]
  [string]$triplet,
  [Parameter(Mandatory=$true, Position=1)]
  [string]$lib
)

if ($triplet -eq "x64-windows") {
	$arch="x64"
} else {
	$arch="ARM64"
}

$ErrorActionPreference = "Stop"

$currentDirectory = Get-Location

$vsPath = &"${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -property installationpath
Import-Module (Join-Path $vsPath "Common7\Tools\Microsoft.VisualStudio.DevShell.dll")
Enter-VsDevShell -VsInstallPath $vsPath -SkipAutomaticLocation -DevCmdArguments "-arch=$($arch.ToLower())"

cd $lib
cmake `
-B "build-$triplet" `
-A $arch `
-DCMAKE_BUILD_TYPE=Release `
-DBUILD_SHARED_LIBS=ON `
-DAVIF_CODEC_AOM=LOCAL `
-DAVIF_CODEC_AOM_ENCODE=ON `
-DAVIF_CODEC_AOM_DECODE=OFF `
-DAVIF_CODEC_DAV1D=LOCAL `
-DAVIF_LIBYUV=LOCAL `
-DAVIF_JPEG=OFF `
-DAVIF_ZLIBPNG=OFF `
-DAVIF_ENABLE_EXPERIMENTAL_MINI=ON `
-DAVIF_ENABLE_EXPERIMENTAL_EXTENDED_PIXI=ON `
-DAVIF_ENABLE_WERROR=ON

cmake --build "build-$triplet" --config Release --parallel

cd $currentDirectory
