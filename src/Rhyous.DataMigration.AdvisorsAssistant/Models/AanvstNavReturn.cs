﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstNavReturn
{
    public int IKeyId { get; set; }

    public decimal NMtdreturn { get; set; }

    public decimal NQtdreturn { get; set; }

    public decimal NYtdreturn { get; set; }

    public decimal N1YearReturn { get; set; }

    public decimal N3YearReturn { get; set; }

    public decimal N5YearReturn { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual ICollection<AanvstNav> AanvstNavs { get; set; } = new List<AanvstNav>();
}