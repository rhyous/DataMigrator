﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AaworkFlowMaster
{
    public int Ikeyid { get; set; }

    public string CDescription { get; set; }

    public int IDefaultPriority { get; set; }

    public int IDuration { get; set; }

    public int IEventCount { get; set; }

    public int ICodeWorkFlowType { get; set; }

    public int IKeyUser { get; set; }

    public bool BFlagDeactivated { get; set; }

    public bool BFlagDoNotExport { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}