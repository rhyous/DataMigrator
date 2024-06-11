﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetAnnuitiesResult
    {
        public int PK { get; set; }
        public string ContractNumber { get; set; }
        public string ContractNumberUnmasked { get; set; }
        public string AnnuitantName { get; set; }
        public string OwnerName { get; set; }
        public string AnnuityType { get; set; }
        public string PlanDescription { get; set; }
        public string CompanyDescription { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? AnnuitizationDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal NetCashValue { get; set; }
        public DateTime? TotalNetValueAsOf { get; set; }
        public string StatusDescription { get; set; }
        public string AnnuitySurrenderPeriodDescription { get; set; }
        public DateTime? ProjectedSurrenderPeriodEndDate { get; set; }
        public string SurrenderPeriodRemaining { get; set; }
        public int PolicyKeyID { get; set; }
        public Guid? PolicyKeyGUID { get; set; }
        public int BaseCoverageKeyID { get; set; }
        public int AccountKeyID { get; set; }
        public Guid? AccountKeyGUID { get; set; }
        public int NameKeyID { get; set; }
        public string WhoAdded { get; set; }
        public DateTime? WhenAdded { get; set; }
        public string WhoChanged { get; set; }
        public DateTime? WhenChanged { get; set; }
        public Guid GUID { get; set; }
    }
}
