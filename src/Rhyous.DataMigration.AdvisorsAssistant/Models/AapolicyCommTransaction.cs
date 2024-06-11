﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AapolicyCommTransaction
{
    public int IKeyId { get; set; }

    public DateTime? DDue { get; set; }

    public int ICodeStatus { get; set; }

    public int ICodeOverriddenStatus { get; set; }

    public string MComment { get; set; }

    public string MStatusOverrideMessage { get; set; }

    public int ICoverageYear { get; set; }

    public int IParticipants { get; set; }

    public Guid? GuidTemp { get; set; }

    public decimal YAgencyGrossDue { get; set; }

    public decimal YAgencyGrossPaid { get; set; }

    public decimal YAgencyDistributionsDue { get; set; }

    public decimal YAgencyDistributionsPaid { get; set; }

    public decimal YAgencyNetDue { get; set; }

    public decimal YAgencyNetPaid { get; set; }

    public decimal YProducerGrossDue { get; set; }

    public decimal YProducerGrossPaid { get; set; }

    public decimal YProducerDirectDue { get; set; }

    public decimal YProducerDirectPaid { get; set; }

    public decimal YManagerGrossDue { get; set; }

    public decimal YManagerGrossPaid { get; set; }

    public decimal YManagerDirectDue { get; set; }

    public decimal YManagerDirectPaid { get; set; }

    public decimal YCompanyDue { get; set; }

    public decimal YCompanyPaid { get; set; }

    public DateTime? DPaidDateMin { get; set; }

    public DateTime? DPaidDateMax { get; set; }

    public bool BFlagContainsBasePremium { get; set; }

    public bool BFlagContainsExcess1Premium { get; set; }

    public bool BFlagContainsExcess2Premium { get; set; }

    public bool BFlagContainsNormal { get; set; }

    public bool BFlagContainsOverride1 { get; set; }

    public bool BFlagContainsOverride2 { get; set; }

    public bool BFlagContainsParticipant { get; set; }

    public bool BFlagContainsTrailer { get; set; }

    public bool BFlagContainsFixedAmount { get; set; }

    public bool BFlagContainsAdjustment { get; set; }

    public bool BFlagContainsChargeback { get; set; }

    public decimal YAdjustmentDue { get; set; }

    public decimal YAdjustmentPaid { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}