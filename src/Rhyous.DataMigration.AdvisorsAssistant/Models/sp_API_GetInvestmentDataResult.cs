﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_API_GetInvestmentDataResult
    {
        public int iKeyID { get; set; }
        public Guid guid { get; set; }
        public int iKeyAcct { get; set; }
        [Column("nNumUnits", TypeName = "decimal(16,6)")]
        public decimal nNumUnits { get; set; }
        public decimal yMktVal { get; set; }
        public DateTime? dValDate { get; set; }
        [Column("nunitval", TypeName = "decimal(16,6)")]
        public decimal nunitval { get; set; }
        public decimal yCostBasis { get; set; }
        public DateTime? dEffective { get; set; }
        public DateTime? dLiquidated { get; set; }
        public string cWhoChange { get; set; }
        public DateTime? dLastChange { get; set; }
        public int SymbolKeyID { get; set; }
        public Guid SymbolGUID { get; set; }
    }
}
