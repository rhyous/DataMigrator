﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetViewPolicyDataCoverageResult
    {
        public int iKeyID { get; set; }
        public int IkeyPol { get; set; }
        public int iKeyFlex { get; set; }
        public decimal yTotalBenefitAmt { get; set; }
        public decimal yBenefitAmtCov { get; set; }
        public int iCodeProductClass { get; set; }
        public string BenefitModeDesc { get; set; }
        public string StatusDesc { get; set; }
        public string TypeDesc { get; set; }
        public string SeriesDesc { get; set; }
        public string AppBasisDesc { get; set; }
        public DateTime? dSubmit { get; set; }
        public DateTime? dEffective { get; set; }
        public DateTime? dRenewal { get; set; }
        public DateTime? dTermination { get; set; }
        public DateTime? dConversion { get; set; }
        public DateTime? dExpiration { get; set; }
        public string PrimaryInsuredName { get; set; }
        public string PrimaryBeneficiaryName { get; set; }
        public string mBeneficiary { get; set; }
        public decimal yTotalRiderAnnualPrem { get; set; }
        public decimal yTotalAnnualPrem { get; set; }
        public int iParticipants { get; set; }
        public int? RiderCount { get; set; }
        public decimal? yIncludedRiderBenefit { get; set; }
        public string FundingOptionDesc { get; set; }
        public string cFundingAccountNumber { get; set; }
        public decimal ySurrenderCharge { get; set; }
        public decimal yAnnBasePrem { get; set; }
        public decimal yAnnExcess1Prem { get; set; }
        public decimal yAnnExcess2Prem { get; set; }
        public decimal yTotalRiderModalPrem { get; set; }
        public decimal? CoverageModalPrem { get; set; }
        public decimal yBenefitAmtAccident { get; set; }
        public decimal yBenefitAmtSickness { get; set; }
        public string SicknessElimPerDesc { get; set; }
        public string AccidentElimPerDesc { get; set; }
        public string SicknessBenePerDesc { get; set; }
        public string AccidentBenePerDesc { get; set; }
        public string BenefitPeriodDesc { get; set; }
        public string DeductiblePeriodDesc { get; set; }
        public string DeductibleMaxDesc { get; set; }
        public decimal yDeductible { get; set; }
        public string InflationProtectionDesc { get; set; }
        public decimal yCashval { get; set; }
        public int iKeyPrimaryInsured { get; set; }
        public string DeathBenefitOptionDesc { get; set; }
        public int iCodeCovType { get; set; }
        public bool bFlagGroupMaster { get; set; }
        public int? Participants { get; set; }
        public int iKeyCommissionRateTable { get; set; }
        public int iKeySeries { get; set; }
        public string AnnuitySurrenderPeriodDescription { get; set; }
        public DateTime? ProjectedSurrenderPeriodEndDate { get; set; }
        public string SurrenderPeriodRemaining { get; set; }
    }
}
