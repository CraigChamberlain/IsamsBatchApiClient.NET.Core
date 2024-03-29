﻿using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.HRManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsCurrentStaff")]
    [OutputType(typeof(StaffMember))]
    public class GetIsamsCurrentStaffCommand : GetIsamsCommand
    {
        protected override Method Method => Method.HumanResources_GetCurrentStaff;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.HRManager.CurrentStaff, true);
            base.ProcessRecord();
        }
    }
}