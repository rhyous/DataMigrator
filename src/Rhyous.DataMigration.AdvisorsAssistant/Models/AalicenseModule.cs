﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AalicenseModule
{
    public int IKeyId { get; set; }

    public int IKeyLicense { get; set; }

    public int IKeyModule { get; set; }

    public DateTime? DExpirationDate { get; set; }

    public bool BFlagTrialPeriod { get; set; }

    public string CHashCode { get; set; }

    public int IMetaVersion { get; set; }

    public bool BFlagPositionOnly { get; set; }

    public string CModuleRegistration { get; set; }

    public string CModulePassword { get; set; }

    public bool BFlagDlfservice { get; set; }

    public DateTime? DDlfserviceTime { get; set; }

    public bool BFlagDlfserviceStarted { get; set; }

    public DateTime? DDlfserviceStarted { get; set; }

    public DateTime? DDlfserviceEnded { get; set; }

    public string CDlfserviceResult { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual Aalicense IKeyLicenseNavigation { get; set; }

    public virtual Aamodule IKeyModuleNavigation { get; set; }
}