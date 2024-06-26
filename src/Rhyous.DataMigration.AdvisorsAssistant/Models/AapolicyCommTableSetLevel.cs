﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AapolicyCommTableSetLevel
{
    public int IKeyId { get; set; }

    public int IKeyTable { get; set; }

    public int IKeyProducer { get; set; }

    public int IKeyManager { get; set; }

    public int ICodeLevel { get; set; }

    public int ICodeApplyPremiumRatesTo { get; set; }

    public int ICodeApplyParticipantRatesTo { get; set; }

    public decimal NTrailerRate { get; set; }

    public int IAdvanceMonthsPremium { get; set; }

    public int IAdvanceMonthsFixedAmount { get; set; }

    public bool BFlagDirectPremium { get; set; }

    public bool BFlagDirectPremiumDeductFromAgencyNet { get; set; }

    public bool BFlagDirectParticipant { get; set; }

    public bool BFlagDirectParticipantDeductFromAgencyNet { get; set; }

    public bool BFlagDirectTrailerDeductFromAgencyNet { get; set; }

    public string MComment { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}