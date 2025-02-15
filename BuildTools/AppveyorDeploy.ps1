# get current directory (this will be something/something/BuildTools)
# so root would be $loc\..\
$loc = Split-Path $script:MyInvocation.MyCommand.Path
$root = (get-item $loc).parent.FullName

if ($env:APPVEYOR -eq $true)
{
    write-host "Appveyor detected"
    
    # build should be successful if we get this far
    # create a text file that contains the version number
    write-host "Creating version file for https://medlaunch.info website"

    if ($env:APPVEYOR_REPO_BRANCH -eq "dev")
    {
    	$verFile = "LatestDevVersion.txt"  
        
        # we HAVE to publish something to github for the pre/post-build scripts to run. Therefore just make sure to send it to the same draft release everytime        
        Set-AppveyorBuildVariable -Name 'MEDLAUNCH_VERSION_DOT' -Value '(Dev Draft Placeholder)'
        
        write-host "Creating dummy artifact to upload to github releases (as this is DEV!)"
        
        # also wipe the artifact
        $strEmpty = "dummyfile"
        $artifactpath = "$root\MedLaunch\bin\$($env:ML_ARTIFACT_NAME).zip"
        $strEmpty | Out-File -filepath $artifactpath -force
        
        
        Set-AppveyorBuildVariable -Name 'ML_ARTIFACT_NAME_NEW' -Value ""
    }
    if ($env:APPVEYOR_REPO_BRANCH -eq "master")
    {
    	$verFile = "LatestMasterVersion.txt" 
        
        Set-AppveyorBuildVariable -Name 'ML_ARTIFACT_NAME_NEW' -Value $env:ML_ARTIFACT_NAME
    }

    $verNo = $env:APPVEYOR_BUILD_VERSION
    write-host "Build: $verNo"
    New-Item $verFile -ItemType file

    $verNo | Set-Content $verFile

    # upload latest succesfull build information to https://medlaunch.info and https://downloads.medlaunch.info
    $ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/downloads.medlaunch.info/public_html/data/" + $verFile
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    write-host "Uploading $verFile to medlaunch downloads site"
    $webclient.UploadFile($uri, $verFile)

    $ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/medlaunch.info/public_html/" + $verFile
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    write-host "Uploading $verFile to medlaunch website"
    $webclient.UploadFile($uri, $verFile)
    
    # update website changelog from repo
    write-host "Updating Changelog @ https://medlaunch.info/changelog"
    $localCL = "$loc\ChangeLog\default.md"
    $ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/medlaunch.info/public_html/user/pages/05.changelog/default.md"
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    $webclient.UploadFile($uri, $localCL)

    # update website homepage from repo
    write-host "Updating Homepage @ https://medlaunch.info/changelog"
    $localCL = "$loc\HomePage\default.md"
    $ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/medlaunch.info/public_html/user/pages/01.home/default.md"
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    $webclient.UploadFile($uri, $localCL)
    
    # update downloads data file on server
    write-host "Updating release data @ https://downloads.medlaunch.info"
    $localCL = "$loc\downloads.medlaunch.info\versions.php"
    $ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/downloads.medlaunch.info/public_html/data/versions.php"
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    $webclient.UploadFile($uri, $localCL)
}

else
{
    ### script is running locally
    $lines = get-content "$loc\ftpcreds.txt"

    # update website changelog from repo
    write-host "Updating Changelog @ https://medlaunch.info/changelog"
    $localCL = "$loc\ChangeLog\default.md"
    $ftp = "ftp://" + $lines[0] + ":" + $lines[1] + "@185.182.58.12/domains/medlaunch.info/public_html/user/pages/05.changelog/default.md"
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    $webclient.UploadFile($uri, $localCL)

    # update website homepage from repo
    write-host "Updating Homepage @ https://medlaunch.info/changelog"
    $localCL = "$loc\HomePage\default.md"
    $ftp = "ftp://" + $lines[0] + ":" + $lines[1] + "@185.182.58.12/domains/medlaunch.info/public_html/user/pages/01.home/default.md"
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    $webclient.UploadFile($uri, $localCL)
    
    # update downloads data file on server
    write-host "Updating release data @ https://downloads.medlaunch.info"
    $localCL = "$loc\downloads.medlaunch.info\versions.php"
    $ftp = "ftp://" + $lines[0] + ":" + $lines[1] + "@185.182.58.12/domains/downloads.medlaunch.info/public_html/data/versions.php"
    $webclient = New-Object System.Net.WebClient
    $uri = New-Object System.Uri($ftp)
    $webclient.UploadFile($uri, $localCL)
}


