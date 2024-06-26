﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportTransaction
{
    public int UniqueTransactionId { get; set; }

    public int UniqueInvestmentId { get; set; }

    public int UniqueAccountId { get; set; }

    public int UniqueInvestorId { get; set; }

    public int? UniqueCustodianId { get; set; }

    public string InvestorFirstName { get; set; }

    public string InvestorLastName { get; set; }

    public string AccountNumber { get; set; }

    public DateTime? AccountAcquiredDate { get; set; }

    public DateTime? AssetAcquiredDate { get; set; }

    public string AccountCustodian { get; set; }

    public string AccountCustodianAbbr { get; set; }

    public string AccountType { get; set; }

    public string AccountTypeAndNumber { get; set; }

    public string InvestorSortName { get; set; }

    public string InvestorFullName { get; set; }

    public string OwnerSortName { get; set; }

    public string OwnerFullName { get; set; }

    public string AccountProducer1 { get; set; }

    public string AccountProducer2 { get; set; }

    public string AccountManager1 { get; set; }

    public string AssetName { get; set; }

    public string AssetSymbol { get; set; }

    public string AssetCusip { get; set; }

    public string AssetCusipExt { get; set; }

    public string AssetType { get; set; }

    public decimal AssetBeginingOfDayValue { get; set; }

    public decimal AssetEndOfDayValue { get; set; }

    public decimal AssetBeginingOfDayShares { get; set; }

    public decimal AssetEndOfDayShares { get; set; }

    public decimal EndofDaySharePrice { get; set; }

    public DateTime? EndOfDaySharePriceDate { get; set; }

    public DateTime? DateOfTransaction { get; set; }

    public DateTime? DateTransmittled { get; set; }

    public DateTime? DateSettled { get; set; }

    public string TransType { get; set; }

    public bool TransOnBlotterYn { get; set; }

    public bool TransCancelledYn { get; set; }

    public DateTime? TransCancelDate { get; set; }

    public short? ShareBalanceFlow { get; set; }

    public decimal TransShares { get; set; }

    public decimal TransSharePrice { get; set; }

    public decimal TransPrincipal { get; set; }

    public decimal TransLoadIncluded { get; set; }

    public decimal TransCommissionIncluded { get; set; }

    public decimal TransFee { get; set; }

    public decimal TransMiscExpense { get; set; }

    public decimal TransAccruedInterest { get; set; }

    public decimal TransClientTotal { get; set; }

    public decimal TransBasisPerShare { get; set; }

    public decimal TransBasisIn { get; set; }

    public decimal TransBasisOut { get; set; }

    public bool TransBasisFrozenYn { get; set; }

    public string TransMoneySourceOrDestination { get; set; }

    public string DownloadModule { get; set; }

    public string DownloadTransactionTypePrimary { get; set; }

    public string DownloadTransactionTypeSecondary { get; set; }

    public string TransComment { get; set; }
}