﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AaqueryConditionJoin
{
    public int Ikeyid { get; set; }

    public int IKeyQueryCondition { get; set; }

    public int IKeyJoinToTable { get; set; }

    public string CJoinToTableAlias { get; set; }

    public string CJoinToColumn { get; set; }

    public int IKeyJoinFromTable { get; set; }

    public string CJoinFromTableAlias { get; set; }

    public string CJoinFromColumn { get; set; }

    public bool BFlagJoinNot { get; set; }

    public string CFilterIntColumn { get; set; }

    public int IFilterIntValue { get; set; }

    public bool BFlagFilterNot { get; set; }

    public int ISortOrder { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}