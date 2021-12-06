param (
    [Parameter(Mandatory=$True)]
    [string] $WorkingDirectory,
    [Parameter(Mandatory=$True)]
    [string] $NupkgFilesDestination,
    [string] $NugetSource="https://pkgs.dev.azure.com/azure-sdk/public/_packaging/azure-sdk-for-net/nuget/v3/index.json",
    [string] $FeedId="azure-sdk-for-net"
)

. (Join-Path $PSScriptRoot ".." common scripts common.ps1)

$allPackages = Get-AllPkgProperties
$trackTwoPackages = $allPackages.Where({ $_.IsNewSdk })

LogDebug "Number of track two packages $($trackTwoPackages.Count)"

Push-Location $WorkingDirectory
$nugetPackagesPath = Join-Path $WorkingDirectory nugetPackages
New-Item -Path $WorkingDirectory -Type "directory" -Name "nugetPackages"

$packagesInFeed = Get-PackagesInArtifactFeed -FeedId $FeedId -IncludeAllVersions  $true

foreach ($pkg in $trackTwoPackages)
{
  $pkg = $packagesInFeed.Where({ ($_.Name -eq $package.Name) })
  $pkgVersions = $pkg.versions.version
  $alphaVersions = $pkgVersions.Where({ ($_ -like "*-alpha.*") })

  $versionsSorted = @()

  # Use the latest alpha version where it is available otherwise use latest version
  if ($alphaVersionsInFeed.Count -gt 0)
  {
    $versionsSorted = [AzureEngSemanticVersion]::SortVersionStrings($alphaVersions)
  }
  elseif ($allVersionsInFeed.Count -gt 0)
  {
    $versionsSorted = [AzureEngSemanticVersion]::SortVersionStrings($pkgVersions)
  }

  if($versionsSorted.Count -gt 0)
  {
    $latestDevVersion = $versionsSorted[0]
    LogDebug "Instaling $($package.Name) $($latestDevVersion)"

    nuget install $package.Name `
    -Version $latestDevVersion `
    -OutputDirectory $nugetPackagesPath `
    -Prerelease `
    -Source $NugetSource `
    -DependencyVersion Ignore `
    -DirectDownload `
    -NoCache 
  }
}

$nupkgDirPath = Join-Path $WorkingDirectory $NupkgFilesDestination
New-Item -Path $WorkingDirectory -Type "directory" -Name $NupkgFilesDestination

Get-ChildItem -Path $nugetPackagesPath -Include *.nupkg -Recurse | Copy-Item -Destination $nupkgDirPath