﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportPerformance
{
    public int? UniqueInvestmentId { get; set; }

    public int? UniqueAccountId { get; set; }

    public int? UniqueSecurityId { get; set; }

    public int UniqueClientId { get; set; }

    public int UniqueInvestorId { get; set; }

    public int UniquePrimaryProducerId { get; set; }

    public int? UniqueHouseHoldId { get; set; }

    public string HouseHoldName { get; set; }

    public int UniqueOwnerId { get; set; }

    public int UniqueGroupWithId { get; set; }

    public DateTime? ReportDateStart { get; set; }

    public DateTime? ReportDateEnd { get; set; }

    public string ReportLevel1Label { get; set; }

    public string ReportLevel1Data { get; set; }

    public int UniqueLevel1Id { get; set; }

    public string ReportLevel2Label { get; set; }

    public string ReportLevel2Data { get; set; }

    public int UniqueLevel2Id { get; set; }

    public bool? ReportHasTopLevel { get; set; }

    public bool? ReportHasIndexes { get; set; }

    public bool? ReportIndexAnnualized { get; set; }

    public int? ReportCashBalanceOption { get; set; }

    public string InvestorFullName { get; set; }

    public string InvestorSortName { get; set; }

    public string InvestorNickName { get; set; }

    public string InvestorPrefix { get; set; }

    public string InvestorSuffix { get; set; }

    public string OwnerFullName { get; set; }

    public string OwnerSortName { get; set; }

    public int? InvestorHeadOfHouseholdId { get; set; }

    public string GroupedWithFullName { get; set; }

    public string GroupedWithSortName { get; set; }

    public string PrimaryProducerSortName { get; set; }

    public string PrimaryProducerFullName { get; set; }

    public string AccountProducer1 { get; set; }

    public string AccountType { get; set; }

    public string AccountNumber { get; set; }

    public bool BFlagAdvisoryAccount { get; set; }

    public string AccountTitle { get; set; }

    public string AccountObjective { get; set; }

    public string AccountCustodian { get; set; }

    public string AccountCustodianAbbr { get; set; }

    public int UniqueCustodianId { get; set; }

    public string AccountTypeAndNumber { get; set; }

    public string AssetName { get; set; }

    public string AssetSymbol { get; set; }

    public string AssetCusip { get; set; }

    public string AssetType { get; set; }

    public string AssetCategory { get; set; }

    public string AssetSector { get; set; }

    public string AssetCompany { get; set; }

    public string AssetObjective { get; set; }

    public string AssetObjectiveAbbr { get; set; }

    public string AssetClass { get; set; }

    public DateTime? AssetAcquiredDate { get; set; }

    public string AssetBasisType { get; set; }

    public DateTime? AssetLiquidatedDate { get; set; }

    public bool? AssetIsAccountCashBalance { get; set; }

    public DateTime AssetPeriodStartDate { get; set; }

    public decimal? AssetPeriodStartValue { get; set; }

    public decimal? AssetPeriodStartShares { get; set; }

    public decimal? AssetPeriodStartSharePrice { get; set; }

    public DateTime AssetPeriodStartSharePriceDate { get; set; }

    public DateTime AssetPeriodEndDate { get; set; }

    public decimal? AssetPeriodEndValue { get; set; }

    public decimal? AssetPeriodEndShares { get; set; }

    public decimal? AssetPeriodEndSharePrice { get; set; }

    public DateTime AssetPeriodEndSharePriceDate { get; set; }

    public DateTime Level1PeriodStartDate { get; set; }

    public decimal? Level1PeriodStartValue { get; set; }

    public DateTime Level1PeriodEndDate { get; set; }

    public decimal? Level1PeriodEndValue { get; set; }

    public DateTime AccountPeriodStartDate { get; set; }

    public decimal? AccountPeriodStartValue { get; set; }

    public DateTime AccountPeriodEndDate { get; set; }

    public decimal? AccountPeriodEndValue { get; set; }

    public decimal? AccountPeriodEndCashBalance { get; set; }

    public bool? AssetCalculateRor { get; set; }

    public bool? AssetCalculationHasError { get; set; }

    public string AssetCalculationErrorMessage { get; set; }

    public bool? Level1CalculationHasError { get; set; }

    public string Level1CalculationErrorMessage { get; set; }

    public bool? AccountCalculationHasError { get; set; }

    public string AccountCalculationErrorMessage { get; set; }

    public decimal? AssetRordollar { get; set; }

    public decimal? AssetRortime { get; set; }

    public decimal? AssetRorsimple { get; set; }

    public bool? AssetRorisAnnualized { get; set; }

    public decimal? AssetRordollarAnnualized { get; set; }

    public decimal? AssetRortimeAnnualized { get; set; }

    public decimal? AssetRorsimpleAnnualized { get; set; }

    public decimal? Level1Rordollar { get; set; }

    public decimal? Level1Rortime { get; set; }

    public decimal? Level1Rorsimple { get; set; }

    public bool? Level1RorisAnnualized { get; set; }

    public decimal? Level1RordollarAnnualized { get; set; }

    public decimal? Level1RortimeAnnualized { get; set; }

    public decimal? Level1RorsimpleAnnualized { get; set; }

    public decimal? AccountRordollar { get; set; }

    public decimal? AccountRortime { get; set; }

    public decimal? AccountRorsimple { get; set; }

    public bool? AccountRorisAnnualized { get; set; }

    public decimal? AccountRordollarAnnualized { get; set; }

    public decimal? AccountRortimeAnnualized { get; set; }

    public decimal? AccountRorsimpleAnnualized { get; set; }

    public decimal? AssetNetCashFlow { get; set; }

    public decimal? AssetDistributionsPaidOut { get; set; }

    public decimal? AssetGainsAndReinvestedDistributions { get; set; }

    public decimal? AssetDividendsPaidOut { get; set; }

    public decimal? AssetDividendsReinvested { get; set; }

    public decimal? AssetDividendsTotal { get; set; }

    public decimal? AssetCapGainsLtpaidOut { get; set; }

    public decimal? AssetCapGainsLtreinvested { get; set; }

    public decimal? AssetCapGainsStpaidOut { get; set; }

    public decimal? AssetCapGainsStreinvested { get; set; }

    public decimal? AssetCapGainsTotal { get; set; }

    public decimal? AssetInterestPaidOut { get; set; }

    public decimal? AssetInterestReinvested { get; set; }

    public decimal? AssetInterestTotal { get; set; }

    public decimal? AssetCommissions { get; set; }

    public decimal? AssetExpenses { get; set; }

    public decimal? AccountExpenses { get; set; }

    public decimal? AccountManagementFees { get; set; }

    public decimal? AccountAdditions { get; set; }

    public decimal? AccountAverageDailyBalance { get; set; }

    public decimal? AccountWithdrawals { get; set; }

    public decimal? AccountNetCashFlow { get; set; }

    public decimal? AccountGainLossTotal { get; set; }

    public decimal? AccountDistributionsTotal { get; set; }

    public decimal? AccountDistributionsPaidout { get; set; }

    public decimal? AccountDistributionsInternal { get; set; }

    public decimal? Level1Expenses { get; set; }

    public decimal? Level1ManagementFees { get; set; }

    public decimal? Level1Additions { get; set; }

    public decimal? Level1AverageDailyBalance { get; set; }

    public decimal? Level1Withdrawals { get; set; }

    public decimal? Level1NetCashFlow { get; set; }

    public decimal? Level1GainLossTotal { get; set; }

    public decimal? Level1DistributionsTotal { get; set; }

    public decimal? Level1DistributionsPaidout { get; set; }

    public decimal? Level1DistributionsInternal { get; set; }

    public decimal? AssetInterestAccrued { get; set; }

    public decimal? AssetPriceIncreasePct { get; set; }

    public decimal? AssetFaceValue { get; set; }

    public decimal? AssetFaceValuePlusReinvestedInterest { get; set; }

    public decimal? AssetDistributionsReinvested { get; set; }

    public decimal? AssetDistributionsTotal { get; set; }

    public decimal? AssetAdditions { get; set; }

    public decimal? AssetWithdrawals { get; set; }

    public decimal? AssetGainsRealized { get; set; }

    public decimal? AssetGainsUnRealized { get; set; }

    public decimal? AssetGainLossTotal { get; set; }

    public decimal? AssetAverageDailyBalance { get; set; }

    public string AccountManager1 { get; set; }
}