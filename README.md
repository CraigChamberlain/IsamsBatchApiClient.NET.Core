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


You will get better performance if you connect to your instance as the module caches the client:

    Connect-Isams -DefaultApiKey "0A1C996B-8E74-4388-A3C4-8DA1E30ADA57"  -IsamsInstance "https://school.isams.cloud" 

And can then proceed without providing a ````ApiKey```` or ````IsamsInstance````

    Get-IsamsCurrentPupil

Further calls can be given a different ````ApiKey```` but the ````IsamsInstance```` will typically be ignored.

    Get-IsamsSibling -ApiKey "1B3G996B-9F74-4399-A3C4-0BA1E30ADG76"

I have also implemented an OAuth authentication Model which will be the default and recommended method as iSAMS deprecate the API Key Authentication system.

    Connect-Isams -ClientID "Your_ID" -ClientSecret "Your_SECRET" -IsamsInstance "https://school.isams.cloud" 

This should ideally be disconnected to invalidate the Bearer Token when using the OAuth method.

    Disconnect-Isams

N.B. it is not possible to have connections to two instances open at once.  Connecting again when already connected will automatically close the previous connection. 

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

