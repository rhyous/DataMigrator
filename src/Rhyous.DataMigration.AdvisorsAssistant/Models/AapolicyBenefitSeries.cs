﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AapolicyBenefitSeries
{
    public int IKeyId { get; set; }

    public int IKeyLink { get; set; }

    public int ICodeBenefitType { get; set; }

    public string MText1 { get; set; }

    public string MText2 { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialid { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AapolicySeries IKeyLinkNavigation { get; set; }
}