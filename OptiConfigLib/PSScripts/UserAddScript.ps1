Param($Password, $UserName, $UserLocalGroup)
[securestring]$SecurePassword = ConvertTo-SecureString $Password -AsPlainText -Force
New-LocalUser -Name $UserName -Password $SecurePassword -AccountNeverExpires
Add-LocalGroupMember -Group $UserLocalGroup -Member $UserName
