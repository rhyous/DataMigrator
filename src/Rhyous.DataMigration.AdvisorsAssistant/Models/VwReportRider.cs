﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportRider
{
    public string InsuredName { get; set; }

    public string PolicyOwner { get; set; }

    public string RiderType { get; set; }

    public string RiderPlan { get; set; }

    public decimal RiderBenefit { get; set; }

    public decimal PremiumRiderAnnual { get; set; }

    public decimal? PremiumRiderModal { get; set; }

    public string RiderOtherFeatures { get; set; }

    public DateTime? RiderEffectiveDate { get; set; }

    public DateTime? RiderNextExerciseDate { get; set; }

    public DateTime? RiderExpirationDate { get; set; }

    public DateTime? RiderTerminationDate { get; set; }

    public bool RiderAddToBenefit { get; set; }

    public decimal RiderCashValue { get; set; }

    public decimal RiderLoanAmount { get; set; }

    public int RiderParticipants { get; set; }

    public int UniqueRiderId { get; set; }

    public int UniqueCoverageId { get; set; }

    public int UniquePolicyId { get; set; }

    public int UniqueNameId { get; set; }

    public int UniqueInsuredNameId { get; set; }

    public string CoverageClass { get; set; }

    public string CoveragePlan { get; set; }

    public string PrimaryInsured { get; set; }

    public string PolicyCompany { get; set; }

    public DateTime? CoverageEffectiveDate { get; set; }

    public decimal CoverageBenefit { get; set; }

    public string CoverageBenefitMode { get; set; }

    public decimal PremiumCoverageAnnualTotal { get; set; }

    public decimal PremiumCoverageModalTotal { get; set; }

    public string PremiumMode { get; set; }

    public decimal PremiumCoverageBaseAnnual { get; set; }
}