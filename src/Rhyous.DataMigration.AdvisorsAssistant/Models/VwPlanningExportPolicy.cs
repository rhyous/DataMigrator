﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwPlanningExportPolicy
{
    public int UniqueNameId { get; set; }

    public Guid NameGuid { get; set; }

    public Guid PolicyGuid { get; set; }

    public Guid CoverageGuid { get; set; }

    public string CoverageBeneficiaryNamed { get; set; }

    public string PolicyCompanyDescription { get; set; }

    public string PolicyCompanyAbbreviation { get; set; }

    public string PolicyNumber { get; set; }

    public string CoverageClassAbbreviation { get; set; }

    public string CoverageClassDescription { get; set; }

    public string CoveragePlanAbbreviation { get; set; }

    public string CoveragePlanDescription { get; set; }

    public string CoverageTypeAbbreviation { get; set; }

    public string CoverageTypeDescription { get; set; }

    public decimal CoverageBenefit { get; set; }

    public string CoverageBenefitModeAbbreviation { get; set; }

    public string CoverageBenefitModeDescription { get; set; }

    public string QualifiedPlanTypeAbbreviation { get; set; }

    public string QualifiedPlanTypeDescription { get; set; }

    public int CoverageParticipants { get; set; }

    public string PremiumMode { get; set; }

    public int PremiumModeFrequency { get; set; }

    public decimal? PremiumPolicyModalTotal { get; set; }

    public decimal? PremiumPolicyAnnualTotal { get; set; }

    public string CoverageStatusAbbreviation { get; set; }

    public string CoverageStatusDescription { get; set; }

    public string CoverageApprovalBasisAbbreviation { get; set; }

    public string CoverageApprovalBasisDescription { get; set; }

    public string RenewalProvisionAbbreviation { get; set; }

    public string RenewalProvisionDescription { get; set; }

    public DateTime? CoverageSubmitDate { get; set; }

    public DateTime? PolicyIssueDate { get; set; }

    public DateTime? CoverageEffectiveDate { get; set; }

    public DateTime? CoverageExpirationDate { get; set; }

    public DateTime? CoverageTerminationDate { get; set; }

    public DateTime? CoverageConversionDate { get; set; }

    public DateTime? CoverageRenewalDate { get; set; }

    public decimal PremiumCoverageAnnualTotal { get; set; }

    public decimal PremiumCoverageModalTotal { get; set; }

    public decimal CoverageCashValue { get; set; }

    public decimal CoverageNetCashValue { get; set; }

    public decimal CoverageOtherValue { get; set; }

    public decimal? PolicyLoanAmount { get; set; }

    public decimal? PolicySurrenderCharge { get; set; }

    public decimal? PolicySurrenderValue { get; set; }

    public decimal? PolicyNetCashValue { get; set; }

    public decimal? PolicyNetBenefit { get; set; }

    public decimal? PolicyPremiumToDate { get; set; }

    public DateTime? PremiumLastPaidDate { get; set; }

    public DateTime? PremiumsPaidThruDate { get; set; }

    public DateTime? PremiumNextDueDate { get; set; }

    public int PolicyFundingOptionCodeId { get; set; }

    public int DeathBenefitOptionCodeId { get; set; }

    public bool? BaseCoverage { get; set; }
}