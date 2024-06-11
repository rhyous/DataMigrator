﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwExchangeAccountUser
{
    public int IKeyCalendar { get; set; }

    public int IKeyRole { get; set; }

    public int IKeyCurrentView { get; set; }

    public string CUserInitials { get; set; }

    public string CName { get; set; }

    public string CUserId { get; set; }

    public string CPassword { get; set; }

    public string CRecordStamp { get; set; }

    public bool BFlagLoggedIn { get; set; }

    public string CStationName { get; set; }

    public string COutlookAttachmentArchiveUserLocation { get; set; }

    public bool BFlagOverrideAttachmentArchivePath { get; set; }

    public int ISyncOption { get; set; }

    public string CViewName { get; set; }

    public int IKeyId { get; set; }

    public int IKeyUser { get; set; }

    public bool BFlagUsingExchange { get; set; }

    public bool BFlagUsingOl365 { get; set; }

    public bool BFlagEnableExchangeSynch { get; set; }

    public bool? BFlagServiceSynchEmail { get; set; }

    public bool? BFlagServiceSynchCalendar { get; set; }

    public bool? BFlagServiceSynchContacts { get; set; }

    public bool? BFlagServiceBirthdaysAnniversaries { get; set; }

    public bool BFlagServiceSyncThisUserGlobal { get; set; }

    public string CExchangeWebUri { get; set; }

    public string CExchangeEmail { get; set; }

    public string CExchangeAutodiscoveryEmail { get; set; }

    public int IConnectionType { get; set; }

    public string CExchangeLoginId { get; set; }

    public string CExchangePassword { get; set; }

    public string CExchangeDomain { get; set; }

    public string CServiceCategory { get; set; }

    public int? IKeyServiceProducer { get; set; }

    public DateTime? TServiceLastEmailSynch { get; set; }

    public DateTime? TAalastEmailSynch { get; set; }

    public string CForwardEmail { get; set; }

    public bool BFlagArchiveIncomingEmail { get; set; }

    public bool BFlagArchiveOutgoingEmail { get; set; }

    public bool BFlagForwardIncomingEmail { get; set; }

    public bool BFlagForwardOutgoingEmail { get; set; }

    public int IArchiveCheckDays { get; set; }

    public int IArchiveDaysOption { get; set; }

    public bool BFlagArchiveAllAccounts { get; set; }

    public string CArchiveAddresses { get; set; }

    public int IMailboxSearchOption { get; set; }

    public bool BRealTimeContactsExport { get; set; }

    public bool BRealTimeEventsExport { get; set; }

    public int IKeyRealTimeSyncProducer { get; set; }

    public string CSelectedSynchOption { get; set; }

    public bool BFlagUseEmailCategories { get; set; }

    public bool BFlagDoNotArchiveAttachments { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }
}