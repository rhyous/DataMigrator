﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class PrssecurityMatrix
{
    public int IKeyId { get; set; }

    public string CMatrix { get; set; }

    public string CCodeId { get; set; }

    public string CDescription { get; set; }

    public int ICodeNvstType { get; set; }

    public bool BFlagFixedValue { get; set; }

    public bool BFlagOption { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}