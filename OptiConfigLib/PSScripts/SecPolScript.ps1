Param(
    [Parameter(Mandatory = $true)]
    [int]$PasswordComplexity,

    [Parameter(Mandatory = $true)]
    [int]$MinimumPasswordLength,

    [Parameter(Mandatory = $true)]
    [int]$MaximumPasswordAge,

    [Parameter(Mandatory = $true)]
    [int]$PasswordHistorySize
)

$ErrorActionPreference = "Stop"

$cfgFile = Join-Path $env:TEMP ("OptiConfig-SecPol-{0}.cfg" -f [Guid]::NewGuid().ToString("N"))

# Apply only the password policy keys this tool manages.
$cfgContent = @(
    "[System Access]",
    "PasswordComplexity=$PasswordComplexity",
    "MinimumPasswordLength=$MinimumPasswordLength",
    "MaximumPasswordAge=$MaximumPasswordAge",
    "PasswordHistorySize=$PasswordHistorySize"
)

$cfgContent | Out-File -FilePath $cfgFile -Encoding Unicode -Force

try {
    secedit /configure /db "$env:windir\security\local.sdb" /cfg "$cfgFile" /areas SECURITYPOLICY | Out-Null
}
finally {
    Remove-Item -Path $cfgFile -ErrorAction SilentlyContinue
}