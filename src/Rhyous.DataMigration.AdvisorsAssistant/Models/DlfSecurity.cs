﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfSecurity
{
    public int IKeyBatch { get; set; }

    public int? IKeyId { get; set; }

    public int IKeyFile { get; set; }

    public int? IKeyProcess { get; set; }

    public DateTime? DRecord { get; set; }

    public int ICodeProcessResult { get; set; }

    public string CSymbol { get; set; }

    public string CDescription { get; set; }

    public string CUnderlyingSecurity { get; set; }

    public string CUnderlyingSecuritySearch { get; set; }

    public string COptionSymbol { get; set; }

    public string CCusip { get; set; }

    public string CCusipExt { get; set; }

    public string CAlternateId { get; set; }

    public decimal NPoolFactor { get; set; }

    public int ICodeCompany { get; set; }

    public string CCompanyCode { get; set; }

    public string CCompanyDescription { get; set; }

    public int ICodeCategory { get; set; }

    public string CCategoryCode { get; set; }

    public string CCategoryDescription { get; set; }

    public int ICodeSector { get; set; }

    public string CSectorCode { get; set; }

    public string CSectorDescription { get; set; }

    public int ICodeInvType { get; set; }

    public string CInvTypeCode { get; set; }

    public string CInvTypeDescription { get; set; }

    public int ICodeClass { get; set; }

    public string CClassCode { get; set; }

    public string CClassDescription { get; set; }

    public bool? BFlagPoolFactor { get; set; }

    public bool? BFlagFixedValue { get; set; }

    public bool? BFlagMoneyMarket { get; set; }

    public bool? BFlagFixedIncome { get; set; }

    public bool? BFlagInterestBearing { get; set; }

    public int ICodeSecurityObjective { get; set; }

    public string CSecurityObjectiveCode { get; set; }

    public string CSecurityObjectiveDescription { get; set; }

    public decimal NUnitValue { get; set; }

    public DateTime? DValue { get; set; }

    public decimal NPriceFactor { get; set; }

    public decimal NUnitFactor { get; set; }

    public bool? BFlagOption { get; set; }

    public DateTime? DOptionExpiration { get; set; }

    public decimal YStrikePrice { get; set; }

    public DateTime? DMaturity { get; set; }

    public decimal NInterestRate { get; set; }

    public DateTime? DCallable { get; set; }

    public int IKeySecurityInAa { get; set; }

    public bool BFlagSecurityFoundViaOld { get; set; }

    public bool BFlagSecurityNeedsValidation { get; set; }

    public bool BFlagSkipSecurity { get; set; }

    public string CReportMessage { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}