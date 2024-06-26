﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class Aapolicy
{
    public int Ikeyid { get; set; }

    public int IKeyBaseCoverage { get; set; }

    public int IKeyFirstCoverage { get; set; }

    public int IKeyRecentCoverage { get; set; }

    public int IkeyPrimaryClient { get; set; }

    public int IKeyGroupMaster { get; set; }

    public int IKeyPrimaryInsured { get; set; }

    public int IKeyPrimaryProducer { get; set; }

    public int IKeyPayor { get; set; }

    public int IKeyAgency { get; set; }

    public int IKeyProducerLevel1 { get; set; }

    public int IKeyProducerLevel2 { get; set; }

    public int IKeyProducerLevel3 { get; set; }

    public int IKeyProducerLevel4 { get; set; }

    public int IKeyManagerLevel1 { get; set; }

    public int IKeyManagerLevel2 { get; set; }

    public int? IKeyManagerLevel3 { get; set; }

    public int IKeyManagerLevel4 { get; set; }

    public string Cnameid { get; set; }

    public string CPolicyNumber { get; set; }

    public string CCertNumber { get; set; }

    public string CControlNumber { get; set; }

    public string CControlNumberOld { get; set; }

    public int ICodeQualifiedPlanType { get; set; }

    public int ICodeSubType { get; set; }

    public int ICodePremiumType { get; set; }

    public int ICodePremiumPayMethod { get; set; }

    public int ICodePremiumMode { get; set; }

    public int IKeyCommissionRateTable { get; set; }

    public int IPremiumDueDay { get; set; }

    public string Ccaseref { get; set; }

    public int ICodeTobacco { get; set; }

    public bool BFlagGroupMaster { get; set; }

    public int ICodeIssueState { get; set; }

    public DateTime? DIssue { get; set; }

    public DateTime? Dcomplete { get; set; }

    public DateTime? DNextPremiumDue { get; set; }

    public DateTime? DLastPremiumPaid { get; set; }

    public DateTime? DPremPaidThru { get; set; }

    public DateTime? DTotalNetValueAsOf { get; set; }

    public decimal YTotalAnnualPrem { get; set; }

    public decimal YTotalAnnualPremBase { get; set; }

    public decimal YTotalAnnualPremExcess1 { get; set; }

    public decimal YTotalAnnualPremExcess2 { get; set; }

    public decimal YTotalModalPrem { get; set; }

    public decimal YTotalPremiumToDate { get; set; }

    public decimal YTotalAnnualPremRider { get; set; }

    public decimal YTotalCashVal { get; set; }

    public decimal YTotalOtherValue { get; set; }

    public decimal YTotalLoans { get; set; }

    public decimal YTotalSurrenderCharge { get; set; }

    public decimal YSurrenderValue { get; set; }

    public decimal YNetCashValue { get; set; }

    public decimal YTotalBenefitAmt { get; set; }

    public decimal YNetBenefit { get; set; }

    public decimal YTotalAnnualCommission { get; set; }

    public string Cdwlid { get; set; }

    public int ICodeRecordCreationSource { get; set; }

    public DateTime? DDlRegistration { get; set; }

    public int IKeyModule { get; set; }

    public int IKeyPosition { get; set; }

    public bool BFlagUsePosition { get; set; }

    public DateTime? DPremiumDueDatesCalculatedFrom { get; set; }

    public DateTime? DPremiumDueDatesCalculatedThrough { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual ICollection<AacomDue> AacomDues { get; set; } = new List<AacomDue>();

    public virtual ICollection<AapolicyPdcr> AapolicyPdcrs { get; set; } = new List<AapolicyPdcr>();

    public virtual ICollection<AapolicyPremiumDue> AapolicyPremiumDues { get; set; } = new List<AapolicyPremiumDue>();

    public virtual ICollection<AapolicyRelation> AapolicyRelations { get; set; } = new List<AapolicyRelation>();

    public virtual Aaname IkeyPrimaryClientNavigation { get; set; }
}