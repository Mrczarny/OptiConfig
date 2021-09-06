Param($ServiceTag ,$USBname)

$USBletter = Get-Volume -FriendlyName $USBname | Select-Object -ExpandProperty DriveLetter
$USBletter = $USBletter + ":"
$USBrecoveryPath = $USBletter + "\Recovery\"
manage-bde -protectors -add C: -startupkey $USBletter 
manage-bde -protectors -get C: > $USBrecoveryPath + "\RecoveryKey_" + $ServiceTag + ".txt" 
manage-bde -on C:
Restart-Computer -Force 