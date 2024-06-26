﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_BenchMarkReportDatasetTopLevelResult
    {
        public int iKeyID { get; set; }
        public int iKeyIndex1 { get; set; }
        public int iKeyIndex2 { get; set; }
        public int iKeyTopLevel { get; set; }
        public string cLabel { get; set; }
        public string cLevelCalculations { get; set; }
        public string cPeriodCalculations { get; set; }
        public DateTime? dReportStart { get; set; }
        public DateTime? dReportEnd { get; set; }
        public decimal yStartValue { get; set; }
        public decimal yEndValue { get; set; }
        public decimal yNetContributions { get; set; }
        public bool bFlagExpensesIncluded { get; set; }
        public bool bFlagFeesIncluded { get; set; }
        public string cIndex1Name { get; set; }
        public string cIndex2Name { get; set; }
        [Column("nTimeWeightedIndex", TypeName = "decimal(18,12)")]
        public decimal nTimeWeightedIndex { get; set; }
        [Column("nTimeWeightedROR", TypeName = "decimal(18,4)")]
        public decimal nTimeWeightedROR { get; set; }
        [Column("nDollarWeighedROR", TypeName = "decimal(18,4)")]
        public decimal nDollarWeighedROR { get; set; }
        public decimal yAverageDailyBalance { get; set; }
        public decimal yTotalGain { get; set; }
        [Column("nIndex1Return", TypeName = "decimal(18,4)")]
        public decimal nIndex1Return { get; set; }
        [Column("nIndex2Return", TypeName = "decimal(18,4)")]
        public decimal nIndex2Return { get; set; }
        [Column("nComparisonIndexDWR1", TypeName = "decimal(12,4)")]
        public decimal nComparisonIndexDWR1 { get; set; }
        [Column("nComparisonIndexDWR2", TypeName = "decimal(12,4)")]
        public decimal nComparisonIndexDWR2 { get; set; }
        [Column("nComparisonIndexTWR1", TypeName = "decimal(12,4)")]
        public decimal nComparisonIndexTWR1 { get; set; }
        [Column("nComparisonIndexTWR2", TypeName = "decimal(12,4)")]
        public decimal nComparisonIndexTWR2 { get; set; }
    }
}
