﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AaoutlookStore
{
    public int IKeyId { get; set; }

    public string COutlookFolderName { get; set; }

    public string COutlookFolderEntryId { get; set; }

    public string COutlookStoreId { get; set; }

    public int IKeyUserId { get; set; }

    public string CMachineName { get; set; }

    public string CUserName { get; set; }

    public string CUserDomainName { get; set; }

    public bool? BFlagExchangeServer { get; set; }

    public int ISyncSourceType { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AaoutlookEntryCalendar AaoutlookEntryCalendar { get; set; }

    public virtual ICollection<AaoutlookEntryName> AaoutlookEntryNames { get; set; } = new List<AaoutlookEntryName>();
}