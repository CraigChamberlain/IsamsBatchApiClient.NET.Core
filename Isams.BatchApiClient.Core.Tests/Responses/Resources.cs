namespace Isams.BatchApiClient.Tests;
public class Resources
{

    public readonly Resource Agent_GetActive =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=739A1241-EB52-49BF-AB5D-FBCC1E468F5E",
                "./Agent_GetActive.xml",
                "",
                false
           );

    public readonly Resource Agent_GetInactive =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=4DEAFBA6-E91F-481E-9C38-A44F1B2D7536",
                "./Agent_GetInactive.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetCategories =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B67ED89B-F7AC-4E13-9896-09D6E51B84BB",
                "./Calendar_GetCategories.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetEvents =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=5BBACD15-90E1-4FEA-A8EB-987DA7785695",
                "./Calendar_GetEvents.xml",
                "",
                true
           );

    public readonly Resource Calendar_GetEventsNextMonth =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=A25F7D3B-5CF5-4DAC-A33B-3305562261C2",
                "./Calendar_GetEventsNextMonth.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetEventsNextWeek =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=FA3F4190-50D4-4110-BBF0-38E7EB3DC16F",
                "./Calendar_GetEventsNextWeek.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetEventsNextYear =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=EB3B3576-B457-4E90-9B53-24639437D2A1",
                "./Calendar_GetEventsNextYear.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetEventsThisMonth =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=36CC097B-9141-451F-B103-98ACAA84D209",
                "./Calendar_GetEventsThisMonth.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetEventsThisWeek =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=38E69B85-D0A1-4C9C-AE45-5DCA3E39BD7E",
                "./Calendar_GetEventsThisWeek.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetEventsThisYear =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=60EE7A3D-471D-4CCC-8854-288337A4166F",
                "./Calendar_GetEventsThisYear.xml",
                "",
                false
           );

    public readonly Resource Calendar_GetTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=8CD9031F-3661-4EE5-AEA4-9B809DEB466A",
                "./Calendar_GetTypes.xml",
                "",
                false
           );

    public readonly Resource ControlPanel_GetAllGlobalLists =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=C7E95FCA-A73A-4214-9172-6BCF140C65DC",
                "./ControlPanel_GetAllGlobalLists.xml",
                "",
                false
           );

    public readonly Resource ControlPanel_GetContactTypeGlobalList =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=FBBDC9B7-E9E3-432D-8261-4D9CB7825A94",
                "./ControlPanel_GetContactTypeGlobalList.xml",
                "",
                false
           );

    public readonly Resource ControlPanel_GetAllUserGroups =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=AC7C5D9C-4987-4F2A-962A-10425907295A",
                "./ControlPanel_GetAllUserGroups.xml",
                "",
                false
           );

    public readonly Resource ControlPanel_GetAllUsers =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=ED34B858-C0CF-4E4F-9B98-F35E6C9134DA",
                "./ControlPanel_GetAllUsers.xml",
                "",
                false
           );

    public readonly Resource ControlPanel_GetGroupedModules =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E8C9C518-498E-4CA8-BDD6-10FB86616A81",
                "./ControlPanel_GetGroupedModules.xml",
                "",
                false
           );

    public readonly Resource ControlPanel_GetModulePermissions =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=C3618C17-0D22-4055-97BD-633292C1B0D3",
                "./ControlPanel_GetModulePermissions.xml",
                "",
                false
           );

    public readonly Resource Cover_GetAllAbsenceReasons =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=9BBDD9F7-C948-4BCA-A883-3D6689C4800B",
                "./Cover_GetAllAbsenceReasons.xml",
                "",
                false
           );

    public readonly Resource Cover_GetAllAgencies =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=836F3C78-F941-40A9-A053-E3B86FB0E3C4",
                "./Cover_GetAllAgencies.xml",
                "",
                false
           );

    public readonly Resource Cover_GetAllCoverStaff =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=95043488-5A7F-4C16-8150-675195885954",
                "./Cover_GetAllCoverStaff.xml",
                "",
                false
           );

    public readonly Resource Cover_GetAllEventReasons =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=421CF2D3-FEA1-4AE9-91F4-52E71FD25FA5",
                "./Cover_GetAllEventReasons.xml",
                "",
                false
           );

    public readonly Resource Cover_GetAllLessonSuspensions =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=508C9047-DFE1-48B6-B96E-C453086307B1",
                "./Cover_GetAllLessonSuspensions.xml",
                "",
                true
           );

    public readonly Resource Cover_GetAllRoomClosureReasons =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=8CB1D703-ED8B-4890-B13E-721BB0EC2905",
                "./Cover_GetAllRoomClosureReasons.xml",
                "",
                false
           );

    public readonly Resource Cover_GetAllRoomClosuresAndCover =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=6B1D9FC8-30FA-4E96-BE0C-8F54B78E0CE4",
                "./Cover_GetAllRoomClosuresAndCover.xml",
                "",
                true
           );

    public readonly Resource Cover_GetAllUnavailableReasons =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=9249A649-6022-43D6-BE53-F1A908C89187",
                "./Cover_GetAllUnavailableReasons.xml",
                "",
                false
           );

    public readonly Resource DailyBulletin_GetAllCategories =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=3E015908-A0E7-4E2D-91DA-F26D46C91939",
                "./DailyBulletin_GetAllCategories.xml",
                "",
                false
           );

    public readonly Resource DailyBulletin_GetDailyBulletins =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B0919955-480A-41C5-9671-A3547A751395",
                "./DailyBulletin_GetDailyBulletins.xml",
                "",
                true
           );

    public readonly Resource DailyBulletin_GetTodaysDailyBulletins =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=7A47512E-9556-4C25-AED3-C5C1A89429CD",
                "./DailyBulletin_GetTodaysDailyBulletins.xml",
                "",
                false
           );

    public readonly Resource DailyBulletin_GetTomorrowsDailyBulletins =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=5214841C-F890-416E-85A0-957CC64D0E2D",
                "./DailyBulletin_GetTomorrowsDailyBulletins.xml",
                "",
                false
           );

    public readonly Resource Discipline_GetDetentions =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=82426379-6C41-4A20-82A4-6FDF8980DA47",
                "./Discipline_GetDetentions.xml",
                "Students",
                true
           );

    public readonly Resource Discipline_GetDetentionsThisMonth =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=50906CF8-0461-459B-AA53-D401B94A3201",
                "./Discipline_GetDetentionsThisMonth.xml",
                "Students",
                false
           );

    public readonly Resource Discipline_GetDetentionsThisTerm =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=43FE9A7F-B262-4AA2-A384-6BEA9D557731",
                "./Discipline_GetDetentionsThisTerm.xml",
                "Students",
                false
           );

    public readonly Resource Estate_GetAllBuildingsAndClassrooms =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=40084A65-B5A0-49E9-81CF-F5C55D64FDF3",
                "./Estate_GetAllBuildingsAndClassrooms.xml",
                "",
                false
           );

    public readonly Resource ExternalExams_GetExamArrangements =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E47D8EDA-3D25-4A25-BD0F-20C0C93DFD2F",
                "./ExternalExams_GetExamArrangements.xml",
                "Students",
                false
           );

    public readonly Resource ExternalExams_GetExamCentres =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=FB2F5FD2-7415-4908-85D0-5F434096D320",
                "./ExternalExams_GetExamCentres.xml",
                "",
                false
           );

    public readonly Resource ExternalExams_GetExamCycles =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=91CC3417-9C24-420D-A611-8A255EBB1700",
                "./ExternalExams_GetExamCycles.xml",
                "",
                false
           );

    public readonly Resource ExternalExams_GetExamEntries =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=3985ADF0-B624-44BF-9E68-684A04488C8B",
                "./ExternalExams_GetExamEntries.xml",
                "Students",
                false
           );

    public readonly Resource ExternalExams_GetExamResults =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E2B5FDDB-F5BE-41F1-8598-ACE195E5CCCA",
                "./ExternalExams_GetExamResults.xml",
                "Students",
                false
           );

    public readonly Resource ExternalExams_GetQualifications =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=FFD75632-A4F4-4F97-AB9A-E340936667C3",
                "./ExternalExams_GetQualifications.xml",
                "",
                false
           );

    public readonly Resource ExternalExams_GetUabGroups =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=8B209EA0-BDC3-4154-AD6D-1EDD44F6D92F",
                "./ExternalExams_GetUabGroups.xml",
                "",
                false
           );

    public readonly Resource ExternalExams_GetUabIdentifiers =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=119D0936-EA74-4CAB-89C3-235443C5BB44",
                "./ExternalExams_GetUabIdentifiers.xml",
                "",
                false
           );

    public readonly Resource HumanResources_GetCurrentStaff =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E370EE48-0A72-48E4-A926-FE8916F99570",
                "./HumanResources_GetCurrentStaff.xml",
                "Employees",
                false
           );

    public readonly Resource HumanResources_GetCurrentStaffWithCustomFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B60979B5-9582-42DE-81E0-355661FF4D35",
                "./HumanResources_GetCurrentStaffWithCustomFields.xml",
                "Employees",
                false
           );

    public readonly Resource HumanResources_GetCurrentStaffPhotos =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=https://developerdemo.isams.cloud/api/batch/1.0/staffphotos.ashx?apiKey=B2B628C3-B7FC-44D1-A6D6-E76C94026902",
                "./HumanResources_GetCurrentStaffPhotos.xml",
                "",
                false
           );

    public readonly Resource News_GetActiveNews =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=699828B1-059C-4F1E-9230-BA8C5C22E2C5",
                "./News_GetActiveNews.xml",
                "",
                false
           );

    public readonly Resource News_GetArchivedNews =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=A25CB51E-91A5-4143-AA55-BB1D9679E7EE",
                "./News_GetArchivedNews.xml",
                "",
                false
           );

    public readonly Resource News_GetFutureNews =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=5FA8E9F6-856C-4790-A7C4-D65B7CCE2E9D",
                "./News_GetFutureNews.xml",
                "",
                false
           );

    public readonly Resource News_GetNewsTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=39EA0552-B39D-40FB-AF7D-D1C4C915C081",
                "./News_GetNewsTypes.xml",
                "",
                false
           );

    public readonly Resource OffGames_GetAllOffGames =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=DE92842D-403D-49D3-AAF9-09D659347D90",
                "./OffGames_GetAllOffGames.xml",
                "Students",
                false
           );

    public readonly Resource OtherSchools_BoardingTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=D4C66A5B-2A96-4305-8A90-2A5855C36B3A",
                "./OtherSchools_BoardingTypes.xml",
                "",
                false
           );

    public readonly Resource OtherSchools_GetOtherSchools =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=C79E7B54-3F06-4F7B-BBB3-3B94F25A047E",
                "./OtherSchools_GetOtherSchools.xml",
                "",
                false
           );

    public readonly Resource OtherSchools_GetSchoolTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=47DCE680-4A45-4F30-906C-2727A0FB99EF",
                "./OtherSchools_GetSchoolTypes.xml",
                "",
                false
           );

    public readonly Resource OtherSchools_GovernanceTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=773F7537-F39C-45F6-A36B-AF032FAD2300",
                "./OtherSchools_GovernanceTypes.xml",
                "",
                false
           );

    public readonly Resource OtherSchools_IntakeTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=9806F03B-0948-4BDB-A2D9-366D7DC9840C",
                "./OtherSchools_IntakeTypes.xml",
                "",
                false
           );

    public readonly Resource ContactAdvanced_GetContacts =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=35B76A61-9169-45D3-98D5-51F939ADF337",
                "./ContactAdvanced_GetContacts.xml",
                "Students",
                true
           );

    public readonly Resource ContactAdvanced_GetContactsWithCustomFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=A7B9BCDA-2944-47FB-A157-B5F356B3BDDB",
                "./ContactAdvanced_GetContactsWithCustomFields.xml",
                "Students",
                true
           );

    public readonly Resource Pupil_GetAlumni =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=16271AFD-7D20-4872-BCA2-5C38B4A54145",
                "./Pupil_GetAlumni.xml",
                "",
                false
           );

    public readonly Resource Pupil_GetApplicants =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=D92B3DEE-1E58-40E6-A2F2-4EAE4CE46765",
                "./Pupil_GetApplicants.xml",
                "",
                false
           );

    public readonly Resource Pupil_GetApplicantsWithCustomFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=1767E184-C4E5-49F4-8AFD-3835878E9B3F",
                "./Pupil_GetApplicantsWithCustomFields.xml",
                "",
                false
           );

    public readonly Resource Pupil_GetCurrentPupils =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=0A1C996B-8E74-4388-A3C4-8DA1E40ADA57",
                "./Pupil_GetCurrentPupils.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetCurrentPupilsWithCustomFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=2888E2CA-8D9E-400E-B17B-E6AFFD31271B",
                "./Pupil_GetCurrentPupilsWithCustomFields.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetCurrentPupilsHealth =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=63D635B2-C857-4BBB-9667-A9375DA08B51",
                "./Pupil_GetCurrentPupilsHealth.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetCurrentPupilsHealthWithCustomFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=BCB281F3-B860-4925-8F64-51237C330953",
                "./Pupil_GetCurrentPupilsHealthWithCustomFields.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetPassports =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=4D599387-E273-43BA-B846-55CCA90C3072",
                "./Pupil_GetPassports.xml",
                "Students",
                true
           );

    public readonly Resource Pupil_GetCurrentPupilsTransport =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=88A34AE7-1AA9-48F8-95DE-9AD3957FC803",
                "./Pupil_GetCurrentPupilsTransport.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetCurrentPupilsTransportWithCustomFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E5282D56-8B07-4D41-B4B0-FC660D033EA1",
                "./Pupil_GetCurrentPupilsTransportWithCustomFields.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetCustomGroupCategories =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=F459DEA8-02B9-49D0-A437-5C6520A4E5E8",
                "./Pupil_GetCustomGroupCategories.xml",
                "",
                false
           );

    public readonly Resource Pupil_GetCustomPupilGroupMembership =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=9EC77F19-1B83-4A73-B3DD-EB04C12DFB7B",
                "./Pupil_GetCustomPupilGroupMembership.xml",
                "Students",
                false
           );

    public readonly Resource Pupil_GetCustomPupilGroupMembershipFiltered =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=16A3B190-638D-4FA3-9769-429070AC6555",
                "./Pupil_GetCustomPupilGroupMembershipFiltered.xml",
                "Students",
                true
           );

    public readonly Resource Pupil_GetCustomPupilGroups =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=57492072-7B70-48CE-9A26-A2A31D9C2398",
                "./Pupil_GetCustomPupilGroups.xml",
                "",
                false
           );

    public readonly Resource Pupil_GetCurrentPupilsPhotos =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=https://developerdemo.isams.cloud/api/batch/1.0/photos.ashx?apiKey=81572CDA-6141-4416-9E40-7766C68871D1",
                "./Pupil_GetCurrentPupilsPhotos.xml",
                "",
                false
           );

    public readonly Resource Pupil_GetSiblings =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=FFD19299-ACD0-471B-883F-252900DEDA83",
                "./Pupil_GetSiblings.xml",
                "Students",
                false
           );

    public readonly Resource PupilRegisters_GetFreeSchoolMeals =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=C2338057-D2E8-4EF5-A5FB-E04989B430FC",
                "./PupilRegisters_GetFreeSchoolMeals.xml",
                "Students",
                true
           );

    public readonly Resource Registration_GetDatesAndTimes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=3748F378-0D3A-4DC1-9B96-AD4986C687E4",
                "./Registration_GetDatesAndTimes.xml",
                "",
                false
           );

    public readonly Resource Registration_GetOutOfSchoolPupils =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=A194D484-381A-4824-BCAA-385AF61D0EF5",
                "./Registration_GetOutOfSchoolPupils.xml",
                "Students",
                true
           );

    public readonly Resource Registration_GetPresentCodes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B377508E-D156-49D1-8B59-BE4FB0264FC3",
                "./Registration_GetPresentCodes.xml",
                "",
                false
           );

    public readonly Resource Registration_GetRegistrationCodes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=5D49A07A-A769-432C-B22E-3A724307D561",
                "./Registration_GetRegistrationCodes.xml",
                "",
                false
           );

    public readonly Resource Registration_GetRegistrationPeriods =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=8887FB85-F7D1-4735-A9E6-943A597BE112",
                "./Registration_GetRegistrationPeriods.xml",
                "",
                true
           );

    public readonly Resource Registration_GetRegistrationStatus =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E3B7F0DC-147B-44E7-994B-A35B036C00D8",
                "./Registration_GetRegistrationStatus.xml",
                "Students",
                true
           );

    public readonly Resource RewardsAndConduct_GetFields =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=68297BD5-3E21-47C9-8CF6-ED2D84D83F8A",
                "./RewardsAndConduct_GetFields.xml",
                "",
                false
           );

    public readonly Resource RewardsAndConduct_GetRecords =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=69EC89E0-4D79-4D80-9A44-10817F3DC34C",
                "./RewardsAndConduct_GetRecords.xml",
                "Students",
                true
           );

    public readonly Resource RewardsAndConduct_GetRewardsTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=CF722211-6466-40DB-8636-E2527D4F4B43",
                "./RewardsAndConduct_GetRewardsTypes.xml",
                "",
                false
           );

    public readonly Resource School_GetAcademicHouses =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E1D90693-7B3B-49FE-8A80-8CAED13B6051",
                "./School_GetAcademicHouses.xml",
                "",
                false
           );

    public readonly Resource School_GetBoardingHouses =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=706D16CD-3E63-44C5-9DEB-0548DB91BB11",
                "./School_GetBoardingHouses.xml",
                "",
                false
           );

    public readonly Resource School_GetSchoolForms =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=1321A8D9-D8B7-47F1-BDA5-4B38A5BE8DC5",
                "./School_GetSchoolForms.xml",
                "",
                false
           );

    public readonly Resource School_GetPastoralTutors =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=840DBA4B-14C5-46ED-AE8C-1C4FF9DBEC2C",
                "./School_GetPastoralTutors.xml",
                "",
                false
           );

    public readonly Resource School_GetSchoolDivisions =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=F5D47C7E-5E1D-4F71-BEC6-4E951AB6F1BD",
                "./School_GetSchoolDivisions.xml",
                "",
                false
           );

    public readonly Resource School_GetSchoolTerms =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=40CA2D09-3BC4-4D5E-9274-24CAEDE8986E",
                "./School_GetSchoolTerms.xml",
                "",
                false
           );

    public readonly Resource School_GetAllYears =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=3519FFE3-29FF-4AC9-BDCE-5A2A4175F1E1",
                "./School_GetAllYears.xml",
                "",
                false
           );

    public readonly Resource SchoolReports_GetReports =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=C1C6F600-D757-401F-B6E1-7FB3359FDF44",
                "./SchoolReports_GetReports.xml",
                "Students",
                true
           );

    public readonly Resource SchoolReports_GetReportCycles =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=11A2F2F0-16F2-49AE-9603-427637152D84",
                "./SchoolReports_GetReportCycles.xml",
                "Students",
                true
           );

    public readonly Resource SchoolReports_GetReportTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B85E3C15-4870-4F74-92DF-030B82667C11",
                "./SchoolReports_GetReportTypes.xml",
                "",
                false
           );

    public readonly Resource SchoolReports_GetTemplates =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=41EF5EA0-32D8-4202-8836-E1E33646B046",
                "./SchoolReports_GetTemplates.xml",
                "",
                false
           );

    public readonly Resource SenManager_GetExternalExams =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=AC7E1A7A-6470-4BC4-95E4-E32B58A8FDD4",
                "./SenManager_GetExternalExams.xml",
                "Students",
                false
           );

    public readonly Resource SenManager_GetGiftedAndTalentedRegister =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=AB68354F-5AF8-4576-ADAA-552A20FA77D4",
                "./SenManager_GetGiftedAndTalentedRegister.xml",
                "Students",
                false
           );

    public readonly Resource SenManager_GetInternalExams =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=ACC7301A-C119-4C59-A974-78589A849CC6",
                "./SenManager_GetInternalExams.xml",
                "Students",
                false
           );

    public readonly Resource SenManager_GetSenLessons =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=501C0A75-759B-4053-84D7-D8E6619B560E",
                "./SenManager_GetSenLessons.xml",
                "Students",
                false
           );

    public readonly Resource SenManager_GetTypes =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=06E3E495-4619-42DC-B0A8-A82955BBDE79",
                "./SenManager_GetTypes.xml",
                "",
                false
           );

    public readonly Resource SenManager_GetSenRegister =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=0478ABFA-26F8-41C6-BB46-7730398880CC",
                "./SenManager_GetSenRegister.xml",
                "Students",
                false
           );

    public readonly Resource Teaching_GetDepartmentsAndSubjects =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=E4DBF841-72A2-4193-9977-7AC21FC2B4E8",
                "./Teaching_GetDepartmentsAndSubjects.xml",
                "",
                false
           );

    public readonly Resource Teaching_GetTeachingForms =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=59ACD131-C796-461F-8F36-BF003E7C85AF",
                "./Teaching_GetTeachingForms.xml",
                "",
                false
           );

    public readonly Resource Teaching_GetTeachingSetLists =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B9F36068-E254-4401-A606-DED56971952B",
                "./Teaching_GetTeachingSetLists.xml",
                "",
                false
           );

    public readonly Resource Teaching_GetTeachingSets =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=CEFC4293-C2E4-4971-B65B-75F8613B97EB",
                "./Teaching_GetTeachingSets.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetArchivedTimetables =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=5D94E324-60CD-490C-B9A8-D576FA9FFA7E",
                "./Timetable_GetArchivedTimetables.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetDevelopmentTimetables =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B0945297-AA76-4A79-B030-491F17274B8B",
                "./Timetable_GetDevelopmentTimetables.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetPreliminaryTimetables =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=B971B62F-2B39-4449-8E45-935F7616AE12",
                "./Timetable_GetPreliminaryTimetables.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetPrepTimetables =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=1FB91D5A-B57B-4744-AA2F-F37A7FFC78B5",
                "./Timetable_GetPrepTimetables.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetPublishedTimetables =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=DCB8DA43-2A8A-4580-8832-C6BE2A0432D2",
                "./Timetable_GetPublishedTimetables.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetTimetableStructure =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=7B69F223-E4CC-42E8-B32C-F11A74359B7A",
                "./Timetable_GetTimetableStructure.xml",
                "",
                false
           );

    public readonly Resource Timetable_GetPupilTimetables =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=5123373A-009B-401C-AB79-6A61E5FE13CD",
                "./Timetable_GetPupilTimetables.xml",
                "Students",
                false
           );

    public readonly Resource Timetable_GetTimetableWeekAllocations =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=DBC146E2-8647-4C44-A6E0-9F6E1B73E245",
                "./Timetable_GetTimetableWeekAllocations.xml",
                "",
                false
           );

    public readonly Resource Tracking_GetExternalData =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=912FD6DD-4D82-4D4F-9FD7-976E76688FEE",
                "./Tracking_GetExternalData.xml",
                "",
                true
           );

    public readonly Resource Tracking_GetExternalDataList =
            new(
                "https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=FB687664-9F1D-4567-9C08-B1B98077080F",
                "./Tracking_GetExternalDataList.xml",
                "",
                false
           );
}
