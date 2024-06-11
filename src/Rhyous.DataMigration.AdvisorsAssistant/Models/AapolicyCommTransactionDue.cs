﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AapolicyCommTransactionDue
{
    public int IKeyId { get; set; }

    public int IKeyTransaction { get; set; }

    public int IKeyCalculatedFrom { get; set; }

    public int IKeyPayee { get; set; }

    public int IKeyRider { get; set; }

    public int IProducerSlot { get; set; }

    public int ICodeLevel { get; set; }

    public int ICodeCommissionType { get; set; }

    public int ICodeOverride { get; set; }

    public int ICodeMode { get; set; }

    public decimal NBaseAmount { get; set; }

    public decimal NRate { get; set; }

    public decimal NSplitFactor { get; set; }

    public decimal YAdjustment { get; set; }

    public decimal YDueAmount { get; set; }

    public bool BFlagDirectPay { get; set; }

    public bool BFlagDirectPayDeductFromAgencyNet { get; set; }

    public int ICodeApplyPremiumRatesTo { get; set; }

    public int ICodeApplyParticipantRatesTo { get; set; }

    public DateTime? DAdvancedThru { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}