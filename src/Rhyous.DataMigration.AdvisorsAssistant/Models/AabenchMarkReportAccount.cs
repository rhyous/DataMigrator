﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AabenchMarkReportAccount
{
    public long IKeyId { get; set; }

    public int IKeyBenchMarkReport { get; set; }

    public int IKeyAccount { get; set; }

    public string CAccountNumber { get; set; }

    public decimal YStartingMarketValue { get; set; }

    public decimal YEndingMarketValue { get; set; }

    public decimal YAverageMarketValue { get; set; }

    public decimal YNetContributions { get; set; }

    public decimal NTimeWeightedIndex { get; set; }

    public decimal NTimeWeightedRor { get; set; }

    public decimal NDollarWeightedRor { get; set; }

    public decimal YAverageDailyBalance { get; set; }

    public decimal YTotalGain { get; set; }

    public decimal NComparisonIndexTwr1 { get; set; }

    public decimal NComparisonIndexTwr2 { get; set; }

    public decimal NComparisonIndexDwr1 { get; set; }

    public decimal NComparisonIndexDwr2 { get; set; }
}