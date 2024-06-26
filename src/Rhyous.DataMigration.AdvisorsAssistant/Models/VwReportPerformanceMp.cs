﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportPerformanceMp
{
    public int UniqueAccountId { get; set; }

    public int UniqueSecurityId { get; set; }

    public int UniqueInvestorId { get; set; }

    public int UniqueOwnerId { get; set; }

    public int UniqueGroupWithId { get; set; }

    public int UniqueInvestmentId { get; set; }

    public int UniqueHouseHoldId { get; set; }

    public string HouseHoldName { get; set; }

    public string ReportLevel1Label { get; set; }

    public string ReportLevel1Data { get; set; }

    public int UniqueLevel1Id { get; set; }

    public bool? ReportHasIndexes { get; set; }

    public string InvestorSortName { get; set; }

    public string InvestorFullName { get; set; }

    public string OwnerSortName { get; set; }

    public string OwnerFullName { get; set; }

    public int? InvestorHeadOfHouseholdId { get; set; }

    public string GroupedWithSortName { get; set; }

    public string GroupedWithFullName { get; set; }

    public string PrimaryProducerSortName { get; set; }

    public string PrimaryProduceFullName { get; set; }

    public int UniquePrimaryProducerId { get; set; }

    public string AccountType { get; set; }

    public string AccountNumber { get; set; }

    public bool BFlagAdvisoryAccount { get; set; }

    public string AccountTitle { get; set; }

    public string AccountObjective { get; set; }

    public int UniqueCustodianId { get; set; }

    public string AccountCustodian { get; set; }

    public string AccountCustodianAbbr { get; set; }

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

    public DateTime? AssetLiquidatedDate { get; set; }

    public bool AssetCalculateRor { get; set; }

    public bool? AssetCalculationHasError { get; set; }

    public string AssetCalculationErrorMessage { get; set; }

    public bool? P1selected { get; set; }

    public DateTime P1startDate { get; set; }

    public DateTime P1endDate { get; set; }

    public decimal? AssetRordollarP1 { get; set; }

    public decimal? AssetRortimeP1 { get; set; }

    public decimal? AssetRorsimpleP1 { get; set; }

    public decimal? Level1RordollarP1 { get; set; }

    public decimal? Level1RortimeP1 { get; set; }

    public decimal? Level1RorsimpleP1 { get; set; }

    public decimal? AccountRordollarP1 { get; set; }

    public decimal? AccountRortimeP1 { get; set; }

    public decimal? AccountRorsimpleP1 { get; set; }

    public bool? AssetRorisAnnualizedP1 { get; set; }

    public decimal? AssetRordollarAnnualizedP1 { get; set; }

    public decimal? AssetRortimeAnnualizedP1 { get; set; }

    public decimal? AssetRorsimpleAnnualizedP1 { get; set; }

    public bool? AccountRorisAnnualizedP1 { get; set; }

    public decimal? AccountRordollarAnnualizedP1 { get; set; }

    public decimal? AccountRortimeAnnualizedP1 { get; set; }

    public decimal? AccountRorsimpleAnnualizedP1 { get; set; }

    public bool? Level1RorisAnnualizedP1 { get; set; }

    public decimal? Level1RordollarAnnualizedP1 { get; set; }

    public decimal? Level1RortimeAnnualizedP1 { get; set; }

    public decimal? Level1RorsimpleAnnualizedP1 { get; set; }

    public decimal? AssetValueAtStartP1 { get; set; }

    public decimal? AssetSharesAtStartP1 { get; set; }

    public decimal? AssetValueAtEndP1 { get; set; }

    public decimal? AssetSharesAtEndP1 { get; set; }

    public decimal? AssetDistributionsPaidOutP1 { get; set; }

    public decimal? AssetDistributionsReinvestedP1 { get; set; }

    public decimal? AssetCashFlowNetP1 { get; set; }

    public decimal? AssetAverageDailyBalanceP1 { get; set; }

    public decimal? AssetAdditionsP1 { get; set; }

    public decimal? AssetWithdrawalsP1 { get; set; }

    public decimal? AssetExpensesP1 { get; set; }

    public decimal? AssetGainLossP1 { get; set; }

    public bool? AssetCalculatedP1 { get; set; }

    public bool? AssetCalculationHasErrorP1 { get; set; }

    public DateTime AssetStartDateP1 { get; set; }

    public DateTime AssetEndDateP1 { get; set; }

    public decimal? AccountAdditionsP1 { get; set; }

    public decimal? AccountWithdrawalsP1 { get; set; }

    public decimal? AccountDistributionsTotalP1 { get; set; }

    public decimal? AccountDistributionsPaidoutP1 { get; set; }

    public decimal? AccountDistributionsInternalP1 { get; set; }

    public decimal? AccountExpensesP1 { get; set; }

    public decimal? AccountGainLossP1 { get; set; }

    public decimal? AccountManagementFeesP1 { get; set; }

    public decimal? AccountStartValueP1 { get; set; }

    public decimal? AccountEndValueP1 { get; set; }

    public decimal? AccountAverageDailyBalanceP1 { get; set; }

    public decimal? AccountEndCashBalanceP1 { get; set; }

    public DateTime AccountStartDateP1 { get; set; }

    public DateTime AccountEndDateP1 { get; set; }

    public DateTime Level1StartDateP1 { get; set; }

    public DateTime Level1EndDateP1 { get; set; }

    public decimal? Level1StartValueP1 { get; set; }

    public decimal? Level1EndValueP1 { get; set; }

    public bool? P2selected { get; set; }

    public DateTime P2startDate { get; set; }

    public DateTime P2endDate { get; set; }

    public decimal? AssetRordollarP2 { get; set; }

    public decimal? AssetRortimeP2 { get; set; }

    public decimal? AssetRorsimpleP2 { get; set; }

    public decimal? Level1RordollarP2 { get; set; }

    public decimal? Level1RortimeP2 { get; set; }

    public decimal? Level1RorsimpleP2 { get; set; }

    public decimal? AccountRordollarP2 { get; set; }

    public decimal? AccountRortimeP2 { get; set; }

    public decimal? AccountRorsimpleP2 { get; set; }

    public bool? AssetRorisAnnualizedP2 { get; set; }

    public decimal? AssetRordollarAnnualizedP2 { get; set; }

    public decimal? AssetRortimeAnnualizedP2 { get; set; }

    public decimal? AssetRorsimpleAnnualizedP2 { get; set; }

    public bool? AccountRorisAnnualizedP2 { get; set; }

    public decimal? AccountRordollarAnnualizedP2 { get; set; }

    public decimal? AccountRortimeAnnualizedP2 { get; set; }

    public decimal? AccountRorsimpleAnnualizedP2 { get; set; }

    public bool? Level1RorisAnnualizedP2 { get; set; }

    public decimal? Level1RordollarAnnualizedP2 { get; set; }

    public decimal? Level1RortimeAnnualizedP2 { get; set; }

    public decimal? Level1RorsimpleAnnualizedP2 { get; set; }

    public decimal? AssetValueAtStartP2 { get; set; }

    public decimal? AssetSharesAtStartP2 { get; set; }

    public decimal? AssetValueAtEndP2 { get; set; }

    public decimal? AssetSharesAtEndP2 { get; set; }

    public decimal? AssetCashFlowNetP2 { get; set; }

    public decimal? AssetAverageDailyBalanceP2 { get; set; }

    public decimal? AssetAdditionsP2 { get; set; }

    public decimal? AssetWithdrawalsP2 { get; set; }

    public decimal? AssetDistributionsPaidOutP2 { get; set; }

    public decimal? AssetDistributionsReinvestedP2 { get; set; }

    public decimal? AssetExpensesP2 { get; set; }

    public decimal? AssetGainLossP2 { get; set; }

    public bool? AssetCalculatedP2 { get; set; }

    public bool? AssetCalculationHasErrorP2 { get; set; }

    public DateTime AssetStartDateP2 { get; set; }

    public DateTime AssetEndDateP2 { get; set; }

    public decimal? AccountAdditionsP2 { get; set; }

    public decimal? AccountWithdrawalsP2 { get; set; }

    public decimal? AccountDistributionsTotalP2 { get; set; }

    public decimal? AccountDistributionsPaidoutP2 { get; set; }

    public decimal? AccountDistributionsInternalP2 { get; set; }

    public decimal? AccountExpensesP2 { get; set; }

    public decimal? AccountGainLossP2 { get; set; }

    public decimal? AccountManagementFeesP2 { get; set; }

    public decimal? AccountStartValueP2 { get; set; }

    public decimal? AccountEndValueP2 { get; set; }

    public decimal? AccountAverageDailyBalanceP2 { get; set; }

    public decimal? AccountEndCashBalanceP2 { get; set; }

    public DateTime AccountStartDateP2 { get; set; }

    public DateTime AccountEndDateP2 { get; set; }

    public DateTime Level1StartDateP2 { get; set; }

    public DateTime Level1EndDateP2 { get; set; }

    public decimal? Level1StartValueP2 { get; set; }

    public decimal? Level1EndValueP2 { get; set; }

    public bool? P3selected { get; set; }

    public DateTime P3startDate { get; set; }

    public DateTime P3endDate { get; set; }

    public decimal? AssetRordollarP3 { get; set; }

    public decimal? AssetRortimeP3 { get; set; }

    public decimal? AssetRorsimpleP3 { get; set; }

    public decimal? Level1RordollarP3 { get; set; }

    public decimal? Level1RortimeP3 { get; set; }

    public decimal? Level1RorsimpleP3 { get; set; }

    public decimal? AccountRordollarP3 { get; set; }

    public decimal? AccountRortimeP3 { get; set; }

    public decimal? AccountRorsimpleP3 { get; set; }

    public bool? AssetRorisAnnualizedP3 { get; set; }

    public decimal? AssetRordollarAnnualizedP3 { get; set; }

    public decimal? AssetRortimeAnnualizedP3 { get; set; }

    public decimal? AssetRorsimpleAnnualizedP3 { get; set; }

    public bool? AccountRorisAnnualizedP3 { get; set; }

    public decimal? AccountRordollarAnnualizedP3 { get; set; }

    public decimal? AccountRortimeAnnualizedP3 { get; set; }

    public decimal? AccountRorsimpleAnnualizedP3 { get; set; }

    public bool? Level1RorisAnnualizedP3 { get; set; }

    public decimal? Level1RordollarAnnualizedP3 { get; set; }

    public decimal? Level1RortimeAnnualizedP3 { get; set; }

    public decimal? Level1RorsimpleAnnualizedP3 { get; set; }

    public decimal? AssetValueAtStartP3 { get; set; }

    public decimal? AssetSharesAtStartP3 { get; set; }

    public decimal? AssetValueAtEndP3 { get; set; }

    public decimal? AssetSharesAtEndP3 { get; set; }

    public decimal? AssetCashFlowNetP3 { get; set; }

    public decimal? AssetAverageDailyBalanceP3 { get; set; }

    public decimal? AssetAdditionsP3 { get; set; }

    public decimal? AssetWithdrawalsP3 { get; set; }

    public decimal? AssetDistributionsPaidOutP3 { get; set; }

    public decimal? AssetDistributionsReinvestedP3 { get; set; }

    public decimal? AssetExpensesP3 { get; set; }

    public decimal? AssetGainLossP3 { get; set; }

    public bool? AssetCalculatedP3 { get; set; }

    public bool? AssetCalculationHasErrorP3 { get; set; }

    public DateTime AssetStartDateP3 { get; set; }

    public DateTime AssetEndDateP3 { get; set; }

    public decimal? AccountAdditionsP3 { get; set; }

    public decimal? AccountWithdrawalsP3 { get; set; }

    public decimal? AccountDistributionsTotalP3 { get; set; }

    public decimal? AccountDistributionsPaidoutP3 { get; set; }

    public decimal? AccountDistributionsInternalP3 { get; set; }

    public decimal? AccountExpensesP3 { get; set; }

    public decimal? AccountGainLossP3 { get; set; }

    public decimal? AccountManagementFeesP3 { get; set; }

    public decimal? AccountStartValueP3 { get; set; }

    public decimal? AccountEndValueP3 { get; set; }

    public decimal? AccountAverageDailyBalanceP3 { get; set; }

    public decimal? AccountEndCashBalanceP3 { get; set; }

    public DateTime AccountStartDateP3 { get; set; }

    public DateTime AccountEndDateP3 { get; set; }

    public DateTime Level1StartDateP3 { get; set; }

    public DateTime Level1EndDateP3 { get; set; }

    public decimal? Level1StartValueP3 { get; set; }

    public decimal? Level1EndValueP3 { get; set; }

    public bool? P4selected { get; set; }

    public DateTime P4startDate { get; set; }

    public DateTime P4endDate { get; set; }

    public decimal? AssetRordollarP4 { get; set; }

    public decimal? AssetRortimeP4 { get; set; }

    public decimal? AssetRorsimpleP4 { get; set; }

    public decimal? Level1RordollarP4 { get; set; }

    public decimal? Level1RortimeP4 { get; set; }

    public decimal? Level1RorsimpleP4 { get; set; }

    public decimal? AccountRordollarP4 { get; set; }

    public decimal? AccountRortimeP4 { get; set; }

    public decimal? AccountRorsimpleP4 { get; set; }

    public bool? AssetRorisAnnualizedP4 { get; set; }

    public decimal? AssetRordollarAnnualizedP4 { get; set; }

    public decimal? AssetRortimeAnnualizedP4 { get; set; }

    public decimal? AssetRorsimpleAnnualizedP4 { get; set; }

    public bool? AccountRorisAnnualizedP4 { get; set; }

    public decimal? AccountRordollarAnnualizedP4 { get; set; }

    public decimal? AccountRortimeAnnualizedP4 { get; set; }

    public decimal? AccountRorsimpleAnnualizedP4 { get; set; }

    public bool? Level1RorisAnnualizedP4 { get; set; }

    public decimal? Level1RordollarAnnualizedP4 { get; set; }

    public decimal? Level1RortimeAnnualizedP4 { get; set; }

    public decimal? Level1RorsimpleAnnualizedP4 { get; set; }

    public decimal? AssetValueAtStartP4 { get; set; }

    public decimal? AssetSharesAtStartP4 { get; set; }

    public decimal? AssetValueAtEndP4 { get; set; }

    public decimal? AssetSharesAtEndP4 { get; set; }

    public decimal? AssetCashFlowNetP4 { get; set; }

    public decimal? AssetAverageDailyBalanceP4 { get; set; }

    public decimal? AssetAdditionsP4 { get; set; }

    public decimal? AssetWithdrawalsP4 { get; set; }

    public decimal? AssetDistributionsPaidOutP4 { get; set; }

    public decimal? AssetDistributionsReinvestedP4 { get; set; }

    public decimal? AssetExpensesP4 { get; set; }

    public decimal? AssetGainLossP4 { get; set; }

    public bool? AssetCalculatedP4 { get; set; }

    public bool? AssetCalculationHasErrorP4 { get; set; }

    public DateTime AssetStartDateP4 { get; set; }

    public DateTime AssetEndDateP4 { get; set; }

    public decimal? AccountAdditionsP4 { get; set; }

    public decimal? AccountWithdrawalsP4 { get; set; }

    public decimal? AccountDistributionsTotalP4 { get; set; }

    public decimal? AccountDistributionsPaidoutP4 { get; set; }

    public decimal? AccountDistributionsInternalP4 { get; set; }

    public decimal? AccountExpensesP4 { get; set; }

    public decimal? AccountGainLossP4 { get; set; }

    public decimal? AccountManagementFeesP4 { get; set; }

    public decimal? AccountStartValueP4 { get; set; }

    public decimal? AccountEndValueP4 { get; set; }

    public decimal? AccountAverageDailyBalanceP4 { get; set; }

    public decimal? AccountEndCashBalanceP4 { get; set; }

    public DateTime AccountStartDateP4 { get; set; }

    public DateTime AccountEndDateP4 { get; set; }

    public DateTime Level1StartDateP4 { get; set; }

    public DateTime Level1EndDateP4 { get; set; }

    public decimal? Level1StartValueP4 { get; set; }

    public decimal? Level1EndValueP4 { get; set; }
}