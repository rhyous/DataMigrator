﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstNav
{
    public int Ikeyid { get; set; }

    public int Ikeysymbol { get; set; }

    public int IKeyReturn { get; set; }

    public int IKeyModule { get; set; }

    public int IKeyDlffileCreated { get; set; }

    public DateTime? Ddate { get; set; }

    public decimal Nnav { get; set; }

    public decimal NHigh { get; set; }

    public decimal NLow { get; set; }

    public long IVolume { get; set; }

    public decimal NPoolFactor { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AanvstNavReturn IKeyReturnNavigation { get; set; }
}