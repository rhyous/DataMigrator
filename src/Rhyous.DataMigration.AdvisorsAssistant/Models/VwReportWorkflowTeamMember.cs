﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportWorkflowTeamMember
{
    public int UniqueWorkflowTeamMemberLinkId { get; set; }

    public int UniqueWorkflowId { get; set; }

    public int UniqueNameId { get; set; }

    public int UniqueTeamMemberId { get; set; }

    public int UniquePrimaryProducerId { get; set; }

    public int UniqueTeamId { get; set; }

    public int UniqueWorkflowMasterId { get; set; }

    public string Wfdescription { get; set; }

    public string ClientSortName { get; set; }

    public string TeamName { get; set; }

    public string TeamMemberDisplayName { get; set; }

    public int Wfstatus { get; set; }

    public decimal WftotalRevenue { get; set; }

    public decimal TeamMemberSplit { get; set; }

    public decimal? TeamMemberRevenue { get; set; }

    public string NamePhase { get; set; }

    public string FieldLabel01 { get; set; }

    public string FieldLabel02 { get; set; }

    public string FieldLabel03 { get; set; }

    public string FieldLabel04 { get; set; }

    public string FieldLabel05 { get; set; }

    public string FieldLabel06 { get; set; }

    public decimal? FlexField01Numeric { get; set; }

    public decimal? FlexField02Numeric { get; set; }

    public string FlexField03Text { get; set; }

    public string FlexField04Text { get; set; }

    public DateTime? FlexField05Date { get; set; }

    public DateTime? FlexField06Date { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public string LastActivityDesc { get; set; }

    public string PhaseLabel { get; set; }
}