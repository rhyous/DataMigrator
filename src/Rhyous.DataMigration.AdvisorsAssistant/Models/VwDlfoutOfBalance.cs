﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwDlfoutOfBalance
{
    public Guid GUid { get; set; }

    public int IKeyFile { get; set; }

    public int ICodeProcessResult { get; set; }

    public string CAccountNumber { get; set; }

    public string InvestorFullName { get; set; }

    public string InvestorSortName { get; set; }

    public string CSecurityId { get; set; }

    public decimal NPosition { get; set; }

    public decimal NOutOfBalance { get; set; }

    public decimal? NOutOfBalanceAbsoluteValue { get; set; }

    public string CRep1Code { get; set; }

    public string CAaproducer1Name { get; set; }

    public string CSecurityName { get; set; }

    public bool BFlagPositionOnly { get; set; }

    public string CReinvest { get; set; }
}