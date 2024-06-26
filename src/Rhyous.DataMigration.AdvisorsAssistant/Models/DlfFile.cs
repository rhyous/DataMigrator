﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class DlfFile
{
    public int IKeyId { get; set; }

    public int IKeyBatch { get; set; }

    public string CFilename { get; set; }

    public string COriginalFilename { get; set; }

    public string MOriginalFilePath { get; set; }

    public string CRenamedAfterProcess { get; set; }

    public bool BFlagFileDeleted { get; set; }

    public DateTime? DFile { get; set; }

    public DateTime? DProcessed { get; set; }

    public DateTime? DDateOfRecord { get; set; }

    public int ICodeStatus { get; set; }

    public string MFileContents { get; set; }

    public byte[] MFileContents2 { get; set; }

    public int? IRegistrations { get; set; }

    public int? IRegistrationsProcessed { get; set; }

    public int? IPositions { get; set; }

    public int? IPositionsProcessed { get; set; }

    public int? IBalances { get; set; }

    public int? IBalancesProcessed { get; set; }

    public int? ITransactions { get; set; }

    public int? ITransactionsProcessed { get; set; }

    public int? IPolicies { get; set; }

    public int? IPoliciesProcessed { get; set; }

    public int? ICoverages { get; set; }

    public int? ICoveragesProcessed { get; set; }

    public int? ISecurities { get; set; }

    public int? ISecuritiesProcessed { get; set; }

    public int? IPrices { get; set; }

    public int? IPricesProcessed { get; set; }

    public int? IPolicyPositions { get; set; }

    public int? IPolicyPositionsProcessed { get; set; }

    public string CPriceTable { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}