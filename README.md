# Introduction 
This client covers only the Free/Core endpoints of the iSAMS Batch API.

The standard endpoints are outside the scope of my agreement with iSAMS atm.

If you have an interest in these other endpoints I have DTO objects for all responses and filters.  I am prepared to upgrade my license if there is a market for my product so get in touch, email: craig@craigchamberlain.it or make an issue.


## PowerShell implementation

Please try the PowerShell Module, I will produce some examples on how it can be used with AD to help manage changes to title and to create new accounts.

Install from the PowerShell Gallery:

    Install-Module -Name IsamsBatchApi

Use like this:

    Get-IsamsCurrentPupil -ApiKey "0A1C996B-8E74-4388-A3C4-8DA1E30ADA57"  -IsamsInstance "https://school.isams.cloud"  

## Endpoints in this current free edition are limited to:
  
### Human Resources
  - Get-IsamsCurrentStaff

### Pupil
  - Get-IsamsCurrentPupil
  - Get-IsamsSibling

### School
  - Get-IsamsAcademicHouse
  - Get-IsamsSchoolYear
  - Get-IsamsBoardingHouse
  - Get-IsamsSchoolForm
  - Get-IsamsPastoralTutor
  - Get-IsamsSchoolDivision
  - Get-IsamsSchoolTerm

## Road-Map

- Implement OAuth
- In the PWSH Module, use an Environmental variable to cache the iSAMS Client and default API key.  
