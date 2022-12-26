Param($PasswordComplexity, $MinimumPasswordLength, $MaximumPasswordAge, $PasswordHistorySize)

Function Parse-SecPol($CfgFile){ 
    secedit /export /cfg "$CfgFile" | out-null
    $obj = New-Object psobject
    $index = 0
    $contents = Get-Content $CfgFile -raw
    [regex]::Matches($contents,"(?<=\[)(.*)(?=\])") | %{
        $title = $_
        [regex]::Matches($contents,"(?<=\]).*?((?=\[)|(\Z))", [System.Text.RegularExpressions.RegexOptions]::Singleline)[$index] | %{
            $section = new-object psobject
            $_.value -split "\r\n" | ?{$_.length -gt 0} | %{
                $value = [regex]::Match($_,"(?<=\=).*").value
                $name = [regex]::Match($_,".*(?=\=)").value
                $section | add-member -MemberType NoteProperty -Name $name.tostring().trim() -Value $value.tostring().trim() -ErrorAction SilentlyContinue | out-null
            }
            $obj | Add-Member -MemberType NoteProperty -Name $title -Value $section
        }
        $index += 1
    }
    return $obj
}

Function Set-SecPol($Object, $CfgFile){
   $SecPool.psobject.Properties.GetEnumerator() | %{
        "[$($_.Name)]"
        $_.Value | %{
            $_.psobject.Properties.GetEnumerator() | %{
                "$($_.Name)=$($_.Value)"
            }
        }
    } | out-file $CfgFile -ErrorAction Stop
    secedit /configure /db c:\windows\security\local.sdb /cfg "$CfgFile" /areas SECURITYPOLICY
}


$SecPool = Parse-SecPol -CfgFile C:\Users\$env:UserName\Desktop\Test.cfg
$SecPool.'System Access'.PasswordComplexity = $PasswordComplexity
$SecPool.'System Access'.MinimumPasswordLength = $MinimumPasswordLength
if($MaximumPasswordAge -eq 0) {
    $SecPool.'System Access'.MaximumPasswordAge = $null
} else {
    $SecPool.'System Access'.MaximumPasswordAge = $MaximumPasswordAge
}
$SecPool.'System Access'.PasswordHistorySize = $PasswordHistorySize

Set-SecPol -Object $SecPool -CfgFile C:\Users\$env:UserName\Desktop\Test.cfg
Remove-Item C:\Users\$env:UserName\Desktop\Test.cfg