﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AacalEventNotification
{
    public int IKeyId { get; set; }

    public int IKeyEvent { get; set; }

    public int IKeyCalUser { get; set; }

    public int IKeyEventDetail { get; set; }

    public DateTime? DNextNotify { get; set; }

    public bool BFlagAcknowledged { get; set; }

    public bool BFlagNotified { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AacalUser IKeyCalUserNavigation { get; set; }

    public virtual AacalEventDetail IKeyEventDetailNavigation { get; set; }

    public virtual AacalEvent IKeyEventNavigation { get; set; }
}