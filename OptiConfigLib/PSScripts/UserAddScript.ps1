Param([securestring]$Password, $UserName, $UserLocalGroup)
New-LocalUser -Name $UserName -Password $Password 
Add-LocalGroupMember -Group $UserLocalGroup -Member $UserName
