﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportPolicyCoverage
{
    public int? UniquePolicyId { get; set; }

    public int UniqueCoverageId { get; set; }

    public int? UniqueNameId { get; set; }

    public string PolicyProducer1 { get; set; }

    public int? PolicyProducerNameId1 { get; set; }

    public decimal? PolicyProducer1Split { get; set; }

    public decimal? PolicyProducer1Renew { get; set; }

    public int? PolicyProducer1UniqueId { get; set; }

    public string PolicyProducer2 { get; set; }

    public int? PolicyProducerNameId2 { get; set; }

    public decimal? PolicyProducer2Split { get; set; }

    public decimal? PolicyProducer2Renew { get; set; }

    public int? PolicyProducer2UniqueId { get; set; }

    public string PolicyProducer3 { get; set; }

    public int? PolicyProducerNameId3 { get; set; }

    public decimal? PolicyProducer3Split { get; set; }

    public decimal? PolicyProducer3Renew { get; set; }

    public int? PolicyProducer3UniqueId { get; set; }

    public string PolicyProducer4 { get; set; }

    public int? PolicyProducerNameId4 { get; set; }

    public decimal? PolicyProducer4Split { get; set; }

    public decimal? PolicyProducer4Renew { get; set; }

    public int? PolicyProducer4UniqueId { get; set; }

    public string PolicyManager1 { get; set; }

    public int? PolicyManagerNameId1 { get; set; }

    public decimal? PolicyManager1Split { get; set; }

    public decimal? PolicyManager1Renew { get; set; }

    public int? PolicyManager1UniqueId { get; set; }

    public string PolicyManager2 { get; set; }

    public int? PolicyManagerNameId2 { get; set; }

    public decimal? PolicyManager2Split { get; set; }

    public decimal? PolicyManager2Renew { get; set; }

    public int? PolicyManager2UniqueId { get; set; }

    public string PolicyManager3 { get; set; }

    public int? PolicyManagerNameId3 { get; set; }

    public decimal? PolicyManager3Split { get; set; }

    public decimal? PolicyManager3Renew { get; set; }

    public int? PolicyManager3UniqueId { get; set; }

    public string PolicyManager4 { get; set; }

    public int? PolicyManagerNameId4 { get; set; }

    public decimal? PolicyManager4Split { get; set; }

    public decimal? PolicyManager4Renew { get; set; }

    public int? PolicyManager4UniqueId { get; set; }

    public string PolicyPayor { get; set; }

    public DateTime? PolicyPayorDateOfBirth { get; set; }

    public string PolicyOwner { get; set; }

    public string PolicyOwnerSortName { get; set; }

    public string PolicyOwnerFirstname { get; set; }

    public string PolicyOwnerLastname { get; set; }

    public DateTime? PolicyOwnerDateOfBirth { get; set; }

    public string PolicyOwnerEmail { get; set; }

    public string CoverageBeneficiaryLong { get; set; }

    public string CoverageBeneficiaryNamed { get; set; }

    public string PolicyCompany { get; set; }

    public string PolicyCompanyAbbr { get; set; }

    public string PolicyNumber { get; set; }

    public string CertificateId { get; set; }

    public string CaseReference { get; set; }

    public DateTime? PolicyValuationDate { get; set; }

    public string CoverageClass { get; set; }

    public string CoverageClassAbbr { get; set; }

    public string CoveragePlan { get; set; }

    public string CoveragePlanAbbr { get; set; }

    public string CoverageTypeDesc { get; set; }

    public string CoverageType { get; set; }

    public int? UniqueCoverageTypeId { get; set; }

    public string PolicyTobaccoDesc { get; set; }

    public string PolicyTobacco { get; set; }

    public int? UniquePolicyTobaccoId { get; set; }

    public decimal CoverageBenefit { get; set; }

    public decimal CoverageCashWithApp { get; set; }

    public string CoverageBenefitMode { get; set; }

    public string PrimaryCoverage { get; set; }

    public string QualifiedPlanType { get; set; }

    public string CoverageBenefitPeriod { get; set; }

    public string CoverageBenefitPeriodSick { get; set; }

    public string CoverageBenefitPeriodAccident { get; set; }

    public string CoverageElimPeriodSick { get; set; }

    public string CoverageElimPeriodAccident { get; set; }

    public decimal CoverageBenefitAccident { get; set; }

    public decimal CoverageBenefitSick { get; set; }

    public int CoverageParticipants { get; set; }

    public string PremiumMode { get; set; }

    public string PremiumModeAbbr { get; set; }

    public decimal? PremiumPolicyModalTotal { get; set; }

    public decimal? PremiumPolicyAnnualTotal { get; set; }

    public decimal CoverageLastPaidAmount { get; set; }

    public int? UniquePolicyInsuredNameId { get; set; }

    public int UniqueCoverageInsuredNameId { get; set; }

    public string PrimaryInsured { get; set; }

    public string PrimaryInsuredSortName { get; set; }

    public string PrimaryInsuredFirstname { get; set; }

    public string PrimaryInsuredLastname { get; set; }

    public DateTime? PrimaryInsuredDateOfBirth { get; set; }

    public int? PrimaryInsuredHouseholdId { get; set; }

    public int? PrimaryInsuredHeadOfHouseholdId { get; set; }

    public int? OwnerHouseholdId { get; set; }

    public int? OwnerHeadOfHouseholdId { get; set; }

    public string CoverageStatus { get; set; }

    public string CoverageApprovalBasis { get; set; }

    public string RenewalProvision { get; set; }

    public DateTime? CoverageSubmitDate { get; set; }

    public string CoverageSubmitMonthYear { get; set; }

    public DateTime? PolicyIssueDate { get; set; }

    public string PolicyIssueMonthYear { get; set; }

    public DateTime? CoverageEffectiveDate { get; set; }

    public string CoverageEffectiveMonthYear { get; set; }

    public string CoverageEffectiveMonthDaySort { get; set; }

    public string CoverageEffectiveMonthDay { get; set; }

    public DateTime? CoverageCompletedDate { get; set; }

    public string CoverageCompletedMonthYear { get; set; }

    public DateTime? CoverageExpirationDate { get; set; }

    public string CoverageExpirationMonthYear { get; set; }

    public DateTime? CoverageTerminationDate { get; set; }

    public string CoverageTerminationMonthYear { get; set; }

    public DateTime? CoverageConversionDate { get; set; }

    public string ConversionMonthYear { get; set; }

    public DateTime? CoverageRenewalDate { get; set; }

    public string CoverageRenewalMonthYear { get; set; }

    public double? CoverageYear { get; set; }

    public decimal PremiumCoverageBaseAnnual { get; set; }

    public decimal PremiumCoverageExcessAnnual1 { get; set; }

    public decimal PremiumCoverageExcessAnnual2 { get; set; }

    public decimal PremiumCoverageAnnualTotal { get; set; }

    public decimal PremiumCoverageModalTotal { get; set; }

    public string CoverageDividendOption { get; set; }

    public string FundingOption { get; set; }

    public decimal CoverageCashValue { get; set; }

    public decimal CoverageNetCashValue { get; set; }

    public decimal CoverageOtherValue { get; set; }

    public decimal CoverageSurrenderCharge { get; set; }

    public decimal? CoverageSurrenderValue { get; set; }

    public decimal CoverageLoanAmount { get; set; }

    public decimal? PolicyLoanAmount { get; set; }

    public decimal? PolicySurrenderCharge { get; set; }

    public decimal? PolicySurrenderValue { get; set; }

    public decimal? PolicyNetCashValue { get; set; }

    public decimal? PolicyNetBenefit { get; set; }

    public decimal? PolicyPremiumToDate { get; set; }

    public DateTime? PremiumLastPaidDate { get; set; }

    public DateTime? PremiumsPaidThruDate { get; set; }

    public DateTime? PremiumNextDueDate { get; set; }

    public string StatusPolicy { get; set; }

    public string CoverageUnderwriter { get; set; }

    public decimal CoverageTotalRiderCashValue { get; set; }

    public decimal CoverageTotalRiderLoanAmount { get; set; }

    public decimal CommissionCoverage1stYrTotal { get; set; }

    public decimal? CommissionPolicy1stYrTotal { get; set; }

    public string GroupMasterCoverage { get; set; }

    public int GroupMasterCoverageUniqueId { get; set; }

    public string AccountNumber { get; set; }

    public string AccountType { get; set; }

    public string AnnuitySurrenderPeriod { get; set; }

    public decimal? CoverageFlexField01Numeric { get; set; }

    public decimal? CoverageFlexField02Numeric { get; set; }

    public decimal? CoverageFlexField03Numeric { get; set; }

    public decimal? CoverageFlexField04Numeric { get; set; }

    public decimal? CoverageFlexField05Numeric { get; set; }

    public decimal? CoverageFlexField06Numeric { get; set; }

    public int? CoverageFlexField07Numeric { get; set; }

    public int? CoverageFlexField08Numeric { get; set; }

    public string CoverageFlexField09Text { get; set; }

    public string CoverageFlexField10Text { get; set; }

    public string CoverageFlexField11Text { get; set; }

    public string CoverageFlexField12Text { get; set; }

    public DateTime? CoverageFlexField13Date { get; set; }

    public DateTime? CoverageFlexField14Date { get; set; }

    public DateTime? CoverageFlexField15Date { get; set; }

    public DateTime? CoverageFlexField16Date { get; set; }

    public string CoverageFlexField17Text { get; set; }

    public string CoverageFlexField18Text { get; set; }

    public string CoverageFlexField19Text { get; set; }

    public string CoverageFlexField20Text { get; set; }

    public DateTime? CoverageFlexField21Date { get; set; }

    public DateTime? CoverageFlexField22Date { get; set; }

    public string CoverageFlexField23Text { get; set; }

    public string CoverageFlexField24Text { get; set; }

    public string CoverageFlexField25Text { get; set; }

    public string CoverageFlexField26Text { get; set; }

    public string CoverageFlexField27Text { get; set; }

    public string CoverageFlexField28Text { get; set; }

    public string CoverageFlexField29Text { get; set; }

    public string CoverageFlexField30Text { get; set; }
}