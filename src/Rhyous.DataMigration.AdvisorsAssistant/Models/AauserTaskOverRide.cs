﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

/// <summary>
/// Add or Remove tasks from role of user.
/// </summary>
public partial class AauserTaskOverRide
{
    public int IKeyId { get; set; }

    public int IKeyUser { get; set; }

    public int IKeyTask { get; set; }

    public bool BFlagActivate { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AauserTaskType IKeyTaskNavigation { get; set; }

    public virtual Aauser IKeyUserNavigation { get; set; }
}