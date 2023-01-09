# Introduction 
This client covers only the Free/Core endpoints of the iSAMS Batch API.

The standard endpoints are outside the scope of my agreement with iSAMS atm.

If you have an interest in these other endpoints I have DTO objects for all responses and filters.  I am prepared to upgrade my license if there is a market for my product so get in touch, email: craig@craigchamberlain.it or make an issue.


## PowerShell implementation

Please try the PowerShell Module, I will produce some examples on how it can be used with AD to help manage changes to title and to create new accounts.

Install from the PowerShell Gallery:

    Install-Module -Name IsamsBatchApi

Use like this:

    Get-SchoolTerms "40CA2D09-3BC4-4D5E-9274-24CAEDE8986A" "https://domain.isams.cloud" 

Endpoints in this current free edition are limited to:
  - Get-AcademicHouses
  - Get-AllYears
  - Get-BoardingHouses
  - Get-CurrentPupils
  - Get-CurrentStaff
  - Get-PastoralTutors
  - Get-SchoolDivisions
  - Get-SchoolForms
  - Get-SchoolTerms
  - Get-Siblings

## Road-Map

- Implement OAuth
- In the PWSH Module, use an Environmental variable to cache the iSAMS Client and default API key.  
