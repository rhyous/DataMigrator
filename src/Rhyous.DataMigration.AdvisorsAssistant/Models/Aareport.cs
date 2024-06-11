﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class Aareport
{
    public int IKeyId { get; set; }

    public int IKeyGroup { get; set; }

    public int IKeyProgram { get; set; }

    public int IKeyFootnote { get; set; }

    public string CDescription { get; set; }

    public string MComment { get; set; }

    public string CReportname { get; set; }

    public string MReportXml { get; set; }

    public string CReportFormatFile { get; set; }

    public string MSwapXml { get; set; }

    public string MChartXml { get; set; }

    public bool BFlagChartExists { get; set; }

    public bool BFlagEdit { get; set; }

    public bool BFlagSwapReport { get; set; }

    public bool BFlagNoCopy { get; set; }

    public bool BFlagFootnoteLastPageOnly { get; set; }

    public bool BFlagForceAdminTitles { get; set; }

    public bool BFlagRequiresCriteriaHousehold { get; set; }

    public bool BFlagRequiresCriteriaRelatedName { get; set; }

    public bool BFlagRequiresCriteriaRelatedType { get; set; }

    public bool BFlagRequiresCriteriaHouseholdOrRelatedName { get; set; }

    public bool BFlagWebAvailable { get; set; }

    public string CRequiresCriteriaCustomMessage { get; set; }

    public bool BFlagHide { get; set; }

    public bool BFlagIsInternal { get; set; }

    public string CBurstTopLevelGroupingFieldName { get; set; }

    public bool BFlagAllowBursting { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual ICollection<AareportFavorite> AareportFavorites { get; set; } = new List<AareportFavorite>();

    public virtual AareportFootNote IKeyFootnoteNavigation { get; set; }

    public virtual AareportProgram IKeyProgramNavigation { get; set; }
}