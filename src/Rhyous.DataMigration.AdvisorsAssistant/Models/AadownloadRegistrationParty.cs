﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AadownloadRegistrationParty
{
    public int IKeyId { get; set; }

    public int IKeyRegistration { get; set; }

    public string CLastName { get; set; }

    public string CFirstName { get; set; }

    public string CMiddle { get; set; }

    public string CPrefix { get; set; }

    public string CSuffix { get; set; }

    public string CTaxId { get; set; }

    public DateTime? DDob { get; set; }

    public int ICodeGender { get; set; }

    public int ICodeNameType { get; set; }

    public bool? BFlagOrganization { get; set; }

    public string CDownloadId { get; set; }

    public int ICodeRecordCreationSource { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}