﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstPosition
{
    public int IKeyId { get; set; }

    public int IKeyNvst { get; set; }

    public int IKeyModule { get; set; }

    public int IKeyReconcile { get; set; }

    public int IKeyDlffileCreated { get; set; }

    public int ICodePositionType { get; set; }

    public int ICodeAccountValueType { get; set; }

    public DateTime? DPosition { get; set; }

    public decimal NPosition { get; set; }

    public decimal Nshareprice { get; set; }

    public bool BFlagReconcileToInit { get; set; }

    public bool BFlagPositionOnly { get; set; }

    public string Ccusip { get; set; }

    public string Ccusipext { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual Aamodule IKeyModuleNavigation { get; set; }

    public virtual Aanvst IKeyNvstNavigation { get; set; }
}