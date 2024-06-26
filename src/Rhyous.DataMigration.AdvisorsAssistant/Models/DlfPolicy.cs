﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfPolicy
{
    public int IKeyBatch { get; set; }

    public int? IKeyId { get; set; }

    public int IKeyFile { get; set; }

    public int? IKeyProcess { get; set; }

    public int ICodeProcessResult { get; set; }

    public DateTime? DRecord { get; set; }

    public string CRegLine1 { get; set; }

    public string CRegLine2 { get; set; }

    public string CRegLine3 { get; set; }

    public string CRegLine4 { get; set; }

    public string CRegLine5 { get; set; }

    public string CRegLine6 { get; set; }

    public string CRegLine7 { get; set; }

    public string CIssueState { get; set; }

    public DateTime? DIssue { get; set; }

    public DateTime? DComplete { get; set; }

    public string CPolicyNumber { get; set; }

    public string CCertNumber { get; set; }

    public string CCaseRef { get; set; }

    public string CFundingAccount { get; set; }

    public int IKeyFundingAccount { get; set; }

    public int ICodeCompany { get; set; }

    public string CCompanyCode { get; set; }

    public string CCompanyDescription { get; set; }

    public int ICodePaymentMode { get; set; }

    public string CPaymentModeCode { get; set; }

    public string CPaymentModeDescription { get; set; }

    public int ICodePremiumPayMethod { get; set; }

    public string CPremiumPayMethodCode { get; set; }

    public string CPremiumPayMethodDescription { get; set; }

    public int ICodePlanSubType { get; set; }

    public string CPlanSubTypeCode { get; set; }

    public string CPlanSubTypeDescription { get; set; }

    public int ICodeQualifiedPlan { get; set; }

    public string CQualifiedPlanCode { get; set; }

    public string CQualifiedPlanDescription { get; set; }

    public DateTime? DPremiumPaidThru { get; set; }

    public DateTime? DLastPremiumPaid { get; set; }

    public int ICodeTobacco { get; set; }

    public string CTaxidOwner { get; set; }

    public DateTime? DOwnerDob { get; set; }

    public string CRep1Code { get; set; }

    public string CRep1Fullname { get; set; }

    public bool BFlagRep1Organization { get; set; }

    public string CRep2Code { get; set; }

    public string CRep2Fullname { get; set; }

    public bool BFlagRep2Organization { get; set; }

    public string CMgr1Code { get; set; }

    public string CMgr1FullName { get; set; }

    public bool BFlagMgr1Organization { get; set; }

    public string CReportMessage { get; set; }

    public int IKeyPolicyInAa { get; set; }

    public int IKeyBaseCoverageInAa { get; set; }

    public int IKeyProducer1ReferenceInAa { get; set; }

    public int IKeyProducer2ReferenceInAa { get; set; }

    public int IKeyManager1ReferenceInAa { get; set; }

    public bool BFlagRepCode1NeedsValidation { get; set; }

    public bool BFlagRepCode2NeedsValidation { get; set; }

    public bool BFlagMgrCode1NeedsValidation { get; set; }

    public int IKeyProducer1InAa { get; set; }

    public int IKeyProducer2InAa { get; set; }

    public int IKeyManager1InAa { get; set; }

    public bool BFlagPolicyNeedsValidation { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}