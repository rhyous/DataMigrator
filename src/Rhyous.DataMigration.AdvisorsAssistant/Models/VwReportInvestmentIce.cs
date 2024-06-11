﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportInvestmentIce
{
    public int UniqueNameId { get; set; }

    public int UniqueInvestorId { get; set; }

    public int UniqueAccountId { get; set; }

    public int UniqueInvestmentId { get; set; }

    public string AccountProducer1 { get; set; }

    public string AccountProducer2 { get; set; }

    public string AccountProducer3 { get; set; }

    public string AccountProducer4 { get; set; }

    public string AccountManager1 { get; set; }

    public string InvestorFullName { get; set; }

    public string InvestorSortName { get; set; }

    public string InvestorPrimaryProducer { get; set; }

    public int? InvestorPrimaryProducerNameId { get; set; }

    public string InvestorHouseholdName { get; set; }

    public int InvestorHouseholdId { get; set; }

    public string AccountType { get; set; }

    public string AccountTypeCode { get; set; }

    public string AccountNumber { get; set; }

    public string AssetCompany { get; set; }

    public string AssetCompanyAbbr { get; set; }

    public string AccountTypeAndNumber { get; set; }

    public int UniqueSecurityId { get; set; }

    public string AssetName { get; set; }

    public string AssetSymbol { get; set; }

    public string AssetCusip { get; set; }

    public string AssetCusipExt { get; set; }

    public string AssetType { get; set; }

    public string AssetCategory { get; set; }

    public string AccountObjective { get; set; }

    public string AssetSector { get; set; }

    public DateTime? AccountAcquiredDate { get; set; }

    public bool AccountTaxQualified { get; set; }

    public string AccountTaxStatus { get; set; }

    public decimal AccountNetCashFlow { get; set; }

    public decimal AccountAdditions { get; set; }

    public decimal AccountWithdrawals { get; set; }

    public DateTime? AssetAcquiredDate { get; set; }

    public DateTime? AssetLiquidatedDate { get; set; }

    public string AssetBasisType { get; set; }

    public decimal AssetMarketValue { get; set; }

    public DateTime? AssetSharePriceDate { get; set; }

    public decimal AssetShares { get; set; }

    public decimal AssetSharePrice { get; set; }

    public decimal AssetBasis { get; set; }

    public decimal? AssetNetCashFlow { get; set; }

    public decimal AssetAdditions { get; set; }

    public decimal AssetWithdrawals { get; set; }

    public decimal AssetInterestPaidOut { get; set; }

    public decimal AssetInterestReinvested { get; set; }

    public decimal? AssetInterestTotal { get; set; }

    public decimal AssetDividendsPaidOut { get; set; }

    public decimal AssetDividendsReinvested { get; set; }

    public decimal? AssetDividendsTotal { get; set; }

    public decimal AssetCapGainsStpaidOut { get; set; }

    public decimal AssetCapGainStreinvested { get; set; }

    public decimal? AssetCapGainsSttotal { get; set; }

    public decimal AssetCapGainsLtpaidOut { get; set; }

    public decimal AssetCapGainsLtreinvested { get; set; }

    public decimal? AssetCapGainsLttotal { get; set; }

    public decimal AccountManagementFees { get; set; }

    public decimal AssetExpenses { get; set; }

    public decimal AssetCommissions { get; set; }

    public decimal AssetTransactionCost { get; set; }

    public decimal? AssetExpensesTotal { get; set; }

    public decimal AssetExpensesMisc { get; set; }

    public decimal AssetExpensesFees { get; set; }

    public decimal? AssetBasisPerShare { get; set; }

    public decimal AssetGainsUnrealized { get; set; }

    public decimal AssetGainsRealized { get; set; }

    public decimal? AssetGainLossTotal { get; set; }

    public decimal AssetRortimeAnnualized { get; set; }

    public decimal AssetRordollarAnnualized { get; set; }

    public decimal AssetRorsimpleAnnualized { get; set; }
}