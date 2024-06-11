﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportInvestmentSecurity
{
    public string SecName { get; set; }

    public string SecSymbol { get; set; }

    public string SecCusip { get; set; }

    public string SecCusipextension { get; set; }

    public string SecAlternateId { get; set; }

    public string SecPreviousCusip { get; set; }

    public string SecPreviousExtension { get; set; }

    public string SecPreviousAlternamteId { get; set; }

    public string UpdatePriceMethod { get; set; }

    public string AssetDownloadSource { get; set; }

    public string SecType { get; set; }

    public string SecCompany { get; set; }

    public string SecCatagory { get; set; }

    public string SecSector { get; set; }

    public string SecObjective { get; set; }

    public string StockExchange { get; set; }

    public decimal NormalLoad { get; set; }

    public decimal AnnYieldPerShare { get; set; }

    public decimal FactorAlpha { get; set; }

    public decimal FactorBeta { get; set; }

    public string RiskLevel { get; set; }

    public string LiquidityLevel { get; set; }

    public bool TrailerCommsTf { get; set; }

    public decimal TrailerCommPce { get; set; }

    public short TrailerTimesPerYear { get; set; }

    public DateTime? TrailerBegins { get; set; }

    public DateTime? TrailerCommsPaidThru { get; set; }

    public bool InterestBearingTf { get; set; }

    public bool InterestFromPositionTf { get; set; }

    public bool InterestDepreciationPoolTf { get; set; }

    public bool InterestFixedIncomeTf { get; set; }

    public decimal InterestRateAnnual { get; set; }

    public bool InterestAccruesForRortf { get; set; }

    public decimal PriceFactor { get; set; }

    public decimal ShareFactor { get; set; }

    public DateTime? MaturityDate { get; set; }

    public DateTime? CallDate { get; set; }

    public bool OptionTf { get; set; }

    public decimal OptionStrikePrice { get; set; }

    public DateTime? OptionExpires { get; set; }

    public decimal ReconcileShareTolerance { get; set; }

    public string ReconcileFrequency { get; set; }

    public int UniqueSecurityId { get; set; }

    public int UniqueCompanyId { get; set; }

    public int UniqueInvestmentTypeId { get; set; }

    public int? UniqueDlid { get; set; }
}