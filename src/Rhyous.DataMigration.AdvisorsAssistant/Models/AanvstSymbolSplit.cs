﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstSymbolSplit
{
    public int IKeyId { get; set; }

    public int IKeySymbol { get; set; }

    public int IKeyTransType { get; set; }

    public DateTime? DTranDate { get; set; }

    public decimal NSharesAfter { get; set; }

    public decimal NSharesBefore { get; set; }

    public decimal NFormula { get; set; }

    public string CDescription { get; set; }

    public bool BFlagGenerated { get; set; }

    public DateTime? DGenerated { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AanvstLotAndSplitLink AanvstLotAndSplitLink { get; set; }
}