﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetValuationsForRorCalculationsResult
    {
        public int iKeyNvst { get; set; }
        public int iKeySymbol { get; set; }
        public int iKeyAcct { get; set; }
        public DateTime? dActivity { get; set; }
        public decimal yBeginingOfDayValue { get; set; }
        [Column("nBeginingOfDayShares", TypeName = "decimal(18,6)")]
        public decimal nBeginingOfDayShares { get; set; }
        [Column("nOpeningNav", TypeName = "decimal(16,6)")]
        public decimal nOpeningNav { get; set; }
        [Column("nClosingNav", TypeName = "decimal(16,6)")]
        public decimal nClosingNav { get; set; }
        public DateTime? dClosingNav { get; set; }
        public decimal yEndOfDayValue { get; set; }
        [Column("nEndOfDayShares", TypeName = "decimal(18,6)")]
        public decimal nEndOfDayShares { get; set; }
        public bool bFlagRorPeriod { get; set; }
        public bool bFlagPeriod { get; set; }
        public bool bFlagSkipRor { get; set; }
        public bool? bFlagInit { get; set; }
        public decimal yFlow { get; set; }
        public decimal yClientNetFlow { get; set; }
        public decimal yClientFlowIn { get; set; }
        public decimal yClientFlowOut { get; set; }
        public decimal yAccruedInterest { get; set; }
        public decimal yAccruedInterestInPeriod { get; set; }
        public decimal yDistributionsPaidOut { get; set; }
        public decimal yDistributionsReinvested { get; set; }
        public decimal yExpenses { get; set; }
        public decimal yFees { get; set; }
        public bool? bFlagRor { get; set; }
        public decimal yMoneyIn { get; set; }
        public decimal yMoneyOut { get; set; }
        public decimal yCapGainsLTPaidOut { get; set; }
        public decimal yCapGainsSTPaidOut { get; set; }
        public decimal yDividendPaidOut { get; set; }
        public decimal yInterestPaidOut { get; set; }
        public decimal yCapGainsLTReinvested { get; set; }
        public decimal yCapGainsSTReinvested { get; set; }
        public decimal yDividendReinvested { get; set; }
        public decimal yInterestReinvested { get; set; }
        public decimal yCommissionOnTransaction { get; set; }
        public decimal yExpenseOnTransaction { get; set; }
        public decimal yAccountFlowIn { get; set; }
        public decimal yAccountFlowOut { get; set; }
        public decimal yAccountDistributionsInternal { get; set; }
        public decimal yAccountDistributionsPaidOut { get; set; }
        public decimal yAccountDistRecievedIntoCashBalance { get; set; }
        public decimal yGainsRealized { get; set; }
        public decimal yGainsTotal { get; set; }
        [Column("nBeginingOfTradeDateShares", TypeName = "decimal(18,6)")]
        public decimal nBeginingOfTradeDateShares { get; set; }
        [Column("nEndOfTradeDateShares", TypeName = "decimal(18,6)")]
        public decimal nEndOfTradeDateShares { get; set; }
        public decimal yBeginingOfTradeDateValue { get; set; }
        public decimal yEndOfTradeDateValue { get; set; }
        public bool bFlagExpiration { get; set; }
        public decimal yOnDeposit { get; set; }
        public decimal yfacevalue { get; set; }
        public bool AssetIsAccountCashBalance { get; set; }
        public bool bFlagAccrueInt { get; set; }
        [Column("nAnnualInterestRate", TypeName = "decimal(9,4)")]
        public decimal nAnnualInterestRate { get; set; }
        public bool bflagfixedval { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
    }
}