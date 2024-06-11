﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetInvestmentDataResult
    {
        public int iKeyInvestment { get; set; }
        public int iKeyAccount { get; set; }
        public Guid AccountGUID { get; set; }
        public int iKeySecurity { get; set; }
        public Guid SecurityGUID { get; set; }
        public string SymbolDesc { get; set; }
        public string SymbolAbbr { get; set; }
        public string cCUSIP { get; set; }
        public string cCUSIPExt { get; set; }
        public string InvestmentType { get; set; }
        [Column("nNumUnits", TypeName = "decimal(16,6)")]
        public decimal? nNumUnits { get; set; }
        public decimal? yMktVal { get; set; }
        public DateTime? dValDate { get; set; }
        public string AccountNumber { get; set; }
        public string AccountNumberUnmasked { get; set; }
        public decimal? NetAdditions { get; set; }
        public decimal? yCostBasis { get; set; }
        public decimal? yUnrealGain { get; set; }
        public decimal? yRealGain { get; set; }
        public decimal? TotalGain { get; set; }
        public string Category { get; set; }
        public string Sector { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
        public string BasisType { get; set; }
        public string Investor { get; set; }
        public DateTime? AcquiredDate { get; set; }
        public string WhoChanged { get; set; }
        public DateTime? WhenChanged { get; set; }
        public string WhoAdded { get; set; }
        public DateTime? WhenAdded { get; set; }
        public Guid gUid { get; set; }
    }
}
