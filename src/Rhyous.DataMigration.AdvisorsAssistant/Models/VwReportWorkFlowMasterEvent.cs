﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportWorkFlowMasterEvent
{
    public int UniqueWorkflowMasterId { get; set; }

    public int UniqueWorkflowEventMasterId { get; set; }

    public string Wfmdescription { get; set; }

    public int Wfmduration { get; set; }

    public int WfmeventCount { get; set; }

    public string Wfmtype { get; set; }

    public string WfmcreatorUserInitials { get; set; }

    public string WfmcreatorUserName { get; set; }

    public int Wfemsequence { get; set; }

    public string Wfemdescription { get; set; }

    public string Wfemphase { get; set; }

    public int Wfemduration { get; set; }

    public int WfemwaitDays { get; set; }

    public bool WfemrevenueStepFlag { get; set; }

    public string Wfemtype { get; set; }

    public string WfemdefaultUserInitials { get; set; }

    public string WfemdefaultUserName { get; set; }

    public string WfemdefaultUserGroupName { get; set; }

    public string Wfeminstructions { get; set; }

    public bool WfemallowSkipTf { get; set; }

    public string PhaseLabel { get; set; }
}