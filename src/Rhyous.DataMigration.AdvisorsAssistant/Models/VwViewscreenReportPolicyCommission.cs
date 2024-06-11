﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwViewscreenReportPolicyCommission
{
    public int UniqueDistributionId { get; set; }

    public int UniqueTransactionId { get; set; }

    public int UniqueRemainderId { get; set; }

    public int UniquePolicyId { get; set; }

    public int UniqueCoverageId { get; set; }

    public string CoveragePlan { get; set; }

    public string InsuredFullName { get; set; }

    public string RiderAbbr { get; set; }

    public string BaseAmountType { get; set; }

    public string PayeeName { get; set; }

    public string PayeePosition { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal DueAmount { get; set; }

    public DateTime? PostedDate { get; set; }

    public decimal? PostedAmount { get; set; }

    public string PostedBy { get; set; }

    public DateTime? PostedOn { get; set; }

    public int UniqueLevelCodeId { get; set; }

    public int RatesApplyTo { get; set; }

    public decimal BaseAmount { get; set; }

    public decimal Rate { get; set; }

    public string Comment { get; set; }
}