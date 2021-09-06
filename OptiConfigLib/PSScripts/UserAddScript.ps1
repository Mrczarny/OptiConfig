Param($Password, $UserName)
[securestring]$SecurePassword = ConvertTo-SecureString $Password -AsPlainText -Force
New-LocalUser -Name $UserName -Password $SecurePassword -AccountNeverExpires
Add-LocalGroupMember -Group "Użytkownicy" -Member $UserName
