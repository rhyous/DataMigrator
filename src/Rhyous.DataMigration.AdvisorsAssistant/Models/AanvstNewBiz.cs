﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstNewBiz
{
    public int IKeyId { get; set; }

    public int IKeyAccount { get; set; }

    public int IKeyFollowup { get; set; }

    public int IKeyNote { get; set; }

    public int IKeyVendor { get; set; }

    public int ICodeAction { get; set; }

    public int ICodePriority { get; set; }

    public DateTime? DInitial { get; set; }

    public string CAction { get; set; }

    public DateTime? DCompleted { get; set; }

    public decimal YAmount { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AanvstAccount IKeyAccountNavigation { get; set; }
}