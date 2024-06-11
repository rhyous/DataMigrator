﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfPositionReconcileSet
{
    public int IKeyId { get; set; }

    public int IKeyProcess { get; set; }

    public int IKeyNvst { get; set; }

    public int IKeySecurity { get; set; }

    public int IKeyPosition { get; set; }

    public int IKeyReconcile { get; set; }

    public DateTime? DValue { get; set; }

    public decimal NUnits { get; set; }

    public decimal NSummedUnitsInAa { get; set; }

    public bool BFlagUpdate { get; set; }

    public bool BFlagInitialized { get; set; }

    public bool BFlagInitValuesOnly { get; set; }

    public DateTime? DInitialized { get; set; }

    public decimal NShareFactor { get; set; }

    public decimal NSharePrice { get; set; }

    public decimal NPoolFactor { get; set; }

    public DateTime? DLastReconcile { get; set; }

    public DateTime? DLastTransaction { get; set; }

    public DateTime? DLiquidated { get; set; }

    public DateTime? DAquired { get; set; }

    public decimal NTolerance { get; set; }

    public bool BFlagOption { get; set; }

    public bool BFlagInterestInDlpositions { get; set; }

    public int ICodeReconcileFrequency { get; set; }

    public int ICodePositionType { get; set; }

    public bool BFlagSkip { get; set; }

    public bool BFlagSummedPositions { get; set; }

    public bool BFlagSummedTransactions { get; set; }
}