﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfPrice
{
    public DateTime? DRecord { get; set; }

    public int ICodeProcessResult { get; set; }

    public string CSymbol { get; set; }

    public string CDescription { get; set; }

    public string CCusip { get; set; }

    public string CCusipExt { get; set; }

    public string CAlternateId { get; set; }

    public decimal NPoolFactor { get; set; }

    public DateTime? DPriceDate { get; set; }

    public decimal NUnitValue { get; set; }

    public decimal NPriceFactor { get; set; }

    public decimal NUnitFactor { get; set; }

    public int IKeySecurityInAa { get; set; }

    public int IKeyDlffileCreated { get; set; }

    public bool BFlagSecurityFoundViaOld { get; set; }

    public bool BFlagSecurityNeedsValidation { get; set; }

    public bool BFlagSkipSecurity { get; set; }

    public Guid GUid { get; set; }
}