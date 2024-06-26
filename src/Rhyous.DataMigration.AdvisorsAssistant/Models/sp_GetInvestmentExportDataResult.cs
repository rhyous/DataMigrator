﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetInvestmentExportDataResult
    {
        public int UniqueNameID { get; set; }
        public int UniqueInvestorID { get; set; }
        public int UniqueAccountID { get; set; }
        public int UniqueInvestmentID { get; set; }
        public int UniqueCustodianID { get; set; }
        public string AccountProducer1 { get; set; }
        public string AccountProducer2 { get; set; }
        public string AccountProducer3 { get; set; }
        public string AccountProducer4 { get; set; }
        public string AccountManager1 { get; set; }
        public string AccountManager2 { get; set; }
        public string AccountManager3 { get; set; }
        public string AccountManager4 { get; set; }
        public string InvestorFullName { get; set; }
        public string InvestorSortName { get; set; }
        public string InvestorPrimaryProducer { get; set; }
        public int? InvestorPrimaryProducerNameID { get; set; }
        public string InvestorHouseholdName { get; set; }
        public int InvestorHouseholdID { get; set; }
        public int? InvestorHeadOfHouseholdID { get; set; }
        public string OwnerFullName { get; set; }
        public string OwnerSortName { get; set; }
        public decimal? InvestorMarketValue { get; set; }
        public decimal? InvestorNetAdditions { get; set; }
        public decimal? InvestorAdditions { get; set; }
        public decimal? InvestorWithdrawals { get; set; }
        public decimal? HouseHoldNetAdditions { get; set; }
        public decimal? HouseHoldAdditions { get; set; }
        public decimal? HouseHoldWithdrawals { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? AccountClosedDate { get; set; }
        public decimal AccountMarketValue { get; set; }
        public string AssetCompany { get; set; }
        public string AssetCompanyAbbr { get; set; }
        public string AccountTitle { get; set; }
        public string AccountTypeAndNumber { get; set; }
        public string AccountCustodian { get; set; }
        public string AccountCustodianAbbr { get; set; }
        public string AccountOwnership { get; set; }
        public string AccountOwnershipAbbr { get; set; }
        public string AssetName { get; set; }
        public string AssetSymbol { get; set; }
        public string AssetCUSIP { get; set; }
        public string AssetCUSIPExt { get; set; }
        public string AssetAlternateID { get; set; }
        public string AssetType { get; set; }
        public string AssetClass { get; set; }
        public string AssetCategory { get; set; }
        public string AccountObjective { get; set; }
        public string AssetObjective { get; set; }
        public string AssetObjectiveAbbr { get; set; }
        public string AssetSector { get; set; }
        public DateTime? AccountAcquiredDate { get; set; }
        public string AccountTaxStatus { get; set; }
        public decimal AccountNetCashFlow { get; set; }
        public decimal AccountAdditions { get; set; }
        public decimal AccountWithdrawals { get; set; }
        public string AccountAllocationStrategy { get; set; }
        public string AccountRiskTolerance { get; set; }
        public decimal AccountLiquidityAmount { get; set; }
        public string AccountLiquidityTimePeriod { get; set; }
        public string AccountTimeHorizon { get; set; }
        public string AccountAuthorizedPerson { get; set; }
        public string AccountHoldStrategy { get; set; }
        public string AssetHoldStrategy { get; set; }
        public DateTime? AssetAcquiredDate { get; set; }
        public DateTime? AssetLiquidatedDate { get; set; }
        public DateTime? AssetMaturityDate { get; set; }
        public DateTime? SecurityMaturityDate { get; set; }
        public string AssetBasisType { get; set; }
        public decimal AssetMarketValue { get; set; }
        public DateTime? AssetSharePriceDate { get; set; }
        [Column("AssetShares", TypeName = "decimal(16,6)")]
        public decimal AssetShares { get; set; }
        [Column("AssetSharePrice", TypeName = "decimal(16,6)")]
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
        public decimal AssetCapGainsSTPaidOut { get; set; }
        public decimal AssetCapGainSTReinvested { get; set; }
        public decimal? AssetCapGainsSTTotal { get; set; }
        public decimal AssetCapGainsLTPaidOut { get; set; }
        public decimal AssetCapGainsLTReinvested { get; set; }
        public decimal? AssetCapGainsLTTotal { get; set; }
        public decimal AccountManagementFees { get; set; }
        public decimal AssetExpenses { get; set; }
        public decimal AssetCommissions { get; set; }
        public decimal AssetTransactionCost { get; set; }
        public decimal? AssetExpensesTotal { get; set; }
        public decimal AssetExpensesMisc { get; set; }
        public decimal AssetExpensesFees { get; set; }
        [Column("AssetBasisPerShare", TypeName = "decimal(38,17)")]
        public decimal? AssetBasisPerShare { get; set; }
        public decimal AssetGainsUnrealized { get; set; }
        public decimal AssetGainsRealized { get; set; }
        public decimal? AssetGainLossTotal { get; set; }
        [Column("AssetRORTimeAnnualized", TypeName = "decimal(12,4)")]
        public decimal AssetRORTimeAnnualized { get; set; }
        [Column("AssetRORDollarAnnualized", TypeName = "decimal(12,4)")]
        public decimal AssetRORDollarAnnualized { get; set; }
        [Column("AssetRORSimpleAnnualized", TypeName = "decimal(12,4)")]
        public decimal AssetRORSimpleAnnualized { get; set; }
        public bool AssetIsAccountCashBalance { get; set; }
        [Column("AssetFlexField01Numeric", TypeName = "decimal(13,2)")]
        public decimal? AssetFlexField01Numeric { get; set; }
        [Column("AssetFlexField02Numeric", TypeName = "decimal(13,2)")]
        public decimal? AssetFlexField02Numeric { get; set; }
        [Column("AssetFlexField03Numeric", TypeName = "decimal(13,2)")]
        public decimal? AssetFlexField03Numeric { get; set; }
        [Column("AssetFlexField04Numeric", TypeName = "decimal(13,2)")]
        public decimal? AssetFlexField04Numeric { get; set; }
        [Column("AssetFlexField05Numeric", TypeName = "decimal(16,6)")]
        public decimal? AssetFlexField05Numeric { get; set; }
        [Column("AssetFlexField06Numeric", TypeName = "decimal(16,6)")]
        public decimal? AssetFlexField06Numeric { get; set; }
        public int? AssetFlexField07Numeric { get; set; }
        public int? AssetFlexField08Numeric { get; set; }
        public string AssetFlexField09Text { get; set; }
        public string AssetFlexField10Text { get; set; }
        public string AssetFlexField11Text { get; set; }
        public string AssetFlexField12Text { get; set; }
        public DateTime? AssetFlexField13Date { get; set; }
        public DateTime? AssetFlexField14Date { get; set; }
        public DateTime? AssetFlexField15Date { get; set; }
        public DateTime? AssetFlexField16Date { get; set; }
        public string AssetFlexField17Text { get; set; }
        public string AssetFlexField18Text { get; set; }
        public string AssetFlexField19Text { get; set; }
        public string AssetFlexField20Text { get; set; }
        public DateTime? AssetFlexField21Date { get; set; }
        public DateTime? AssetFlexField22Date { get; set; }
        public string AssetFlexField23Text { get; set; }
        public string AssetFlexField24Text { get; set; }
        public string AssetFlexField25Text { get; set; }
        public string AssetFlexField26Text { get; set; }
        public string AssetFlexField27Text { get; set; }
        public string AssetFlexField28Text { get; set; }
        public string AssetFlexField29Text { get; set; }
        public string AssetFlexField30Text { get; set; }
        [Column("AccountProducer1Split", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer1Split { get; set; }
        [Column("AccountProducer1Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer1Renew { get; set; }
        [Column("AccountProducer2Split", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer2Split { get; set; }
        [Column("AccountProducer2Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer2Renew { get; set; }
        [Column("AccountProducer3Split", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer3Split { get; set; }
        [Column("AccountProducer3Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer3Renew { get; set; }
        [Column("AccountProducer4Split", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer4Split { get; set; }
        [Column("AccountProducer4Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountProducer4Renew { get; set; }
        [Column("AccountManager1Split", TypeName = "decimal(13,7)")]
        public decimal? AccountManager1Split { get; set; }
        [Column("AccountManager1Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountManager1Renew { get; set; }
        [Column("AccountManager2Split", TypeName = "decimal(13,7)")]
        public decimal? AccountManager2Split { get; set; }
        [Column("AccountManager2Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountManager2Renew { get; set; }
        [Column("AccountManager3Split", TypeName = "decimal(13,7)")]
        public decimal? AccountManager3Split { get; set; }
        [Column("AccountManager3Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountManager3Renew { get; set; }
        [Column("AccountManager4Split", TypeName = "decimal(13,7)")]
        public decimal? AccountManager4Split { get; set; }
        [Column("AccountManager4Renew", TypeName = "decimal(13,7)")]
        public decimal? AccountManager4Renew { get; set; }
    }
}
