﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportCommDistribution
{
    public int UniqueTransactionId { get; set; }

    public int UniqueDistributionId { get; set; }

    public int UniquePostingId { get; set; }

    public int UniqueRemainderId { get; set; }

    public int UniqueCompanyId { get; set; }

    public int UniqueAgencyId { get; set; }

    public int PolicyProducer1UniqueId { get; set; }

    public string PolicyProducer1Name { get; set; }

    public int PolicyProducer2UniqueId { get; set; }

    public int PolicyProducer3UniqueId { get; set; }

    public int PolicyProducer4UniqueId { get; set; }

    public int PolicyManager1UniqueId { get; set; }

    public int PolicyManager2UniqueId { get; set; }

    public int PolicyManager3UniqueId { get; set; }

    public int PolicyManager4UniqueId { get; set; }

    public int PolicyOwnerUniqueId { get; set; }

    public int CoveragePrimaryInsuredUniqueId { get; set; }

    public int UniqueCoverageTypeId { get; set; }

    public int UniqueRiderId { get; set; }

    public int UniquePolicyId { get; set; }

    public int UniqueCoverageId { get; set; }

    public int UniqueDistributionTypeId { get; set; }

    public int UniqueOverrideTypeId { get; set; }

    public DateTime? CoverageEffectiveDate { get; set; }

    public int UniqueStatusId { get; set; }

    public string PrimaryInsuredSortName { get; set; }

    public string PolicyNumber { get; set; }

    public string CoveragePlan { get; set; }

    public string CoveragePlanAbbrev { get; set; }

    public string CoverageTypeAbbrev { get; set; }

    public string CoverageTypeDescription { get; set; }

    public decimal? CoverageModalPremium { get; set; }

    public decimal BaseAmount { get; set; }

    public decimal Rate { get; set; }

    public decimal PayeeSplit { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal DueAmount { get; set; }

    public DateTime? PostedDate { get; set; }

    public decimal? PostedAmount { get; set; }

    public decimal? AgencyCommDue { get; set; }

    public int Status { get; set; }

    public int BasisOfCalculation { get; set; }

    public int RatesApplyTo { get; set; }

    public int PremiumPaymentsPerYear { get; set; }

    public int UniquePayeeId { get; set; }

    public string PayeeName { get; set; }

    public int PaidBy { get; set; }

    public int Level { get; set; }

    public int ProducerNumber { get; set; }

    public int CoverageYear { get; set; }

    public string FirstRenewal { get; set; }

    public string PolicyCompanyAbbr { get; set; }

    public string PostedBy { get; set; }

    public DateTime? PostedOn { get; set; }

    public int Remainder { get; set; }

    public int Adjustment { get; set; }

    public int Chargeback { get; set; }

    public string NormalTrailer { get; set; }

    public bool BFlagTransactionContainsBasePremium { get; set; }

    public bool BFlagTransactionContainsExcess1Premium { get; set; }

    public bool BFlagTransactionContainsExcess2Premium { get; set; }

    public bool BFlagTransactionContainsNormal { get; set; }

    public bool BFlagTransactionContainsOverride1 { get; set; }

    public bool BFlagTransactionContainsOverride2 { get; set; }

    public bool BFlagTransactionContainsParticipant { get; set; }

    public bool BFlagTransactionContainsTrailer { get; set; }

    public bool BFlagTransactionContainsFixedAmount { get; set; }

    public bool BFlagTransactionContainsAdjustment { get; set; }

    public bool BFlagTransactionContainsChargeback { get; set; }

    public int UniquePrimaryProducerId { get; set; }
}