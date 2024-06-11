﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetAccountDataResult
    {
        public int iKeyID { get; set; }
        public int iKeyPrimaryClient { get; set; }
        public string AccountType { get; set; }
        public string Ownership { get; set; }
        public string Status { get; set; }
        public string Custodian { get; set; }
        public string Objective { get; set; }
        public string TaxStatus { get; set; }
        public string BasisType { get; set; }
        public decimal yMktVal { get; set; }
        public DateTime? dProcess { get; set; }
        public string AccountNumber { get; set; }
        public string AccountNumberUnmasked { get; set; }
        public string AccountTitle { get; set; }
        public string AccountTitleUnmasked { get; set; }
        public decimal? NetAdditions { get; set; }
        public DateTime? dOldestValueDate { get; set; }
        public int? NewBizCountPending { get; set; }
        public int? NewBizCountCompleted { get; set; }
        public decimal yUnrealGain { get; set; }
        public decimal yRealGain { get; set; }
        public decimal? TotalGains { get; set; }
        public DateTime? dEffective { get; set; }
        public decimal yCostBasis { get; set; }
        public string Investor { get; set; }
        public string WhoChanged { get; set; }
        public DateTime? WhenChanged { get; set; }
        public string WhoAdded { get; set; }
        public DateTime? WhenAdded { get; set; }
        public Guid gUid { get; set; }
        public Guid UniqueNameGUID { get; set; }
    }
}