﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfTransaction
{
    public int IKeyBatch { get; set; }

    public int? IKeyId { get; set; }

    public int IKeyFile { get; set; }

    public int? IKeyProcess { get; set; }

    public DateTime? DRecord { get; set; }

    public Guid? GuidLink { get; set; }

    public int ICodeProcessResult { get; set; }

    public string CInvestorTaxId { get; set; }

    public string CAccountNumber { get; set; }

    public string CSymbol { get; set; }

    public string CDescription { get; set; }

    public string CCusip { get; set; }

    public string CCusipExt { get; set; }

    public string CAlternateId { get; set; }

    public int ICodeCompany { get; set; }

    public string CCompanyCode { get; set; }

    public string CCompanyDescription { get; set; }

    public int ICodeInvType { get; set; }

    public string CInvTypeCode { get; set; }

    public string CInvTypeDescription { get; set; }

    public bool? BFlagFixedValue { get; set; }

    public bool? BFlagMoneyMarket { get; set; }

    public string CKey1 { get; set; }

    public string CKey2 { get; set; }

    public string CRelatedKey { get; set; }

    public DateTime? DTranDate { get; set; }

    public DateTime? DSettle { get; set; }

    public DateTime? DTransmittal { get; set; }

    public int IKeyTransType { get; set; }

    public string CSourceTranTypePrimary { get; set; }

    public string CSourceTranTypeSecondary { get; set; }

    public string CTranDescription { get; set; }

    public string MTranComment { get; set; }

    public bool BFlagUnknownTransactionType { get; set; }

    public decimal NTransactionUnitCost { get; set; }

    public decimal NUnitValue { get; set; }

    public decimal NUnits { get; set; }

    public decimal NUnitsAfterDistribution { get; set; }

    public short IShareBalanceFlow { get; set; }

    public decimal YTotalPrincipal { get; set; }

    public decimal YTotalNet { get; set; }

    public decimal YCommissions { get; set; }

    public decimal YCommissionsExcluded { get; set; }

    public decimal YFees { get; set; }

    public decimal YWithheld { get; set; }

    public decimal YAccruedInterest { get; set; }

    public string COfficeNumber { get; set; }

    public string CRep1Code { get; set; }

    public string CRep1Fullname { get; set; }

    public bool BFlagRep1Organization { get; set; }

    public decimal NRep1ConcessionPct { get; set; }

    public string CRep2Code { get; set; }

    public string CRep2Fullname { get; set; }

    public bool BFlagRep2Organization { get; set; }

    public decimal NRep2ConcessionPct { get; set; }

    public string CMgr1Code { get; set; }

    public string CMgr1Fullname { get; set; }

    public bool BFlagMgr1Organization { get; set; }

    public int IKeyAccountInAa { get; set; }

    public int IKeySecurityInAa { get; set; }

    public bool BFlagSecurityFoundViaOld { get; set; }

    public int IKeyProducer1ReferenceInAa { get; set; }

    public int IKeyProducer2ReferenceInAa { get; set; }

    public int IKeyManager1ReferenceInAa { get; set; }

    public int IKeyLinkInAa { get; set; }

    public int IKeyTransInAa { get; set; }

    public bool BFlagSecurityNeedsValidation { get; set; }

    public bool BFlagCreateCashBalanceTrans { get; set; }

    public bool BFlagRepCode1NeedsValidation { get; set; }

    public bool BFlagRepCode2NeedsValidation { get; set; }

    public bool BFlagMgrCode1NeedsValidation { get; set; }

    public int IKeyProducer1InAa { get; set; }

    public int IKeyProducer2InAa { get; set; }

    public int IKeyManager1InAa { get; set; }

    public bool BFlagAccountNeedsValidation { get; set; }

    public string CReportMessage { get; set; }

    public int ICodeCustodian { get; set; }

    public string CCustodianCode { get; set; }

    public string CCustodianDescription { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}