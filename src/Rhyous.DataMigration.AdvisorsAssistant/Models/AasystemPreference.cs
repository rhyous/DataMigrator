﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AasystemPreference
{
    public int Ikeyid { get; set; }

    public string CDataBaseVersion { get; set; }

    public bool? BFlagRecreateViews { get; set; }

    public bool BFlagValidateCodes { get; set; }

    public bool? BFlagValidateEncryption { get; set; }

    public bool? BFlagCheckPages { get; set; }

    public bool? BFlagUsePages { get; set; }

    public bool? BFlagEnableLinksInNotes { get; set; }

    public bool BFlagEnableLinksInArchivedEmailNotes { get; set; }

    public bool BFlagPromptToCreateAutoLoginFile { get; set; }

    public bool BFlagEnableCustomLinks { get; set; }

    public bool? BFlagShowAdvisoryWorldMenuOption { get; set; }

    public bool? BFlagShowDstvisionMenuOption { get; set; }

    public bool? BFlagShowAlbridgeApplinkMenuOption { get; set; }

    public bool? BFlagEnableMessenger { get; set; }

    public bool? BFlagShowNotification { get; set; }

    public bool BFlagLogCalendarEventNotifications { get; set; }

    public bool BFlagLogMessageNotification { get; set; }

    public DateTime? DLastNoteIndexBuild { get; set; }

    public DateTime? DLastReindex { get; set; }

    public DateTime? DLastLoginTimeCheck { get; set; }

    public bool BFlagTradeDateCalculations { get; set; }

    public bool? BFlagCustomNavigationMenuVisible { get; set; }

    public string CCustomNavigationMenuUrl { get; set; }

    public bool BFlagPreventUsersFromChoosingSynchWithOutlook { get; set; }

    public bool BFlagPreventUsersFromChoosingSynchWithExchange { get; set; }

    public bool BFlagPreventUsersFromChoosingSynchWithOl365 { get; set; }

    public bool BFlagPreventUsersFromChoosingSyncWithGoogle { get; set; }

    public bool BFlagShowExchangeServiceUserPreferences { get; set; }

    public bool BFlagShowSyncServiceSettingsOnUserPrefScreen { get; set; }

    public bool BFlagRestrictNewNametypesImportedFromOutlookOrExchange { get; set; }

    public string CDefaultOutlookAttachmentArchiveLocation { get; set; }

    public string CExchangeServiceAccountLoginId { get; set; }

    public string CExchangeServiceAccountPassword { get; set; }

    public string CExchangeServiceAccountDomain { get; set; }

    public string CLocalStationUpdatePath { get; set; }

    public DateTime? DDlfserviceLastCheck { get; set; }

    public int IDlfserviceMinimumStations { get; set; }

    public bool BFlagRestrictAddressesOnePerLocation { get; set; }

    public bool BFlagRestrictPhonesToOnePerLocation { get; set; }

    public bool? BFlagDlfpostDownloadProcessMarketValues { get; set; }

    public DateTime? DDlflastReindex { get; set; }

    public bool BFlagOutlookAllowUserToChangeAttachmentLocation { get; set; }

    public bool? BFlagRecordUserLogins { get; set; }

    public bool BFlagDocupace { get; set; }

    public string CDocupaceAesiv { get; set; }

    public string CDocupaceAeskey { get; set; }

    public string CDocupacePrivateId { get; set; }

    public string CDocupacePublicId { get; set; }

    public string CDocupaceUrl { get; set; }

    public string CPrimaryNameTypes { get; set; }

    public bool BFlagAdvisorVaultEnabled { get; set; }

    public bool? BFlagShowAdvisorVaultMenuOption { get; set; }

    public int IAdvisorVaultTemplateId { get; set; }

    public string CAdvisorVaultVaultIdentifier { get; set; }

    public string CAdvisorVaultPublicKeyEncrypted { get; set; }

    public string CAdvisorVaultPartnerIdencrypted { get; set; }

    public string CAdvisorVaultAdminUserName { get; set; }

    public string CAdvisorVaultBurstUploadDefaultLocation { get; set; }

    public bool BFlagAdvisorVaultBurstUploadDefaultForceAllProducers { get; set; }

    public int IAdvisorVaultStorageThreshold { get; set; }

    public int IAdvisorVaultStorageMaximum { get; set; }

    public string CAdvisorVaultAdminPasswordEncrypted { get; set; }

    public bool? BFlagEntireZipCodeInCityLookup { get; set; }

    public string CApikey1Label { get; set; }

    public string CApikey2Label { get; set; }

    public string CApikey3Label { get; set; }

    public string CApiserviceAccountKeyEncrypted { get; set; }

    public string CMobileCulture { get; set; }

    public bool BFlagShowAnnuityPolicyViewClientInsurance { get; set; }

    public bool BFlagShowAnnuityPolicyViewClientAnnuities { get; set; }

    public bool BFlagShowAnnuityAccountViewClientInvestments { get; set; }

    public bool BFlagShowAnnuityAccountViewClientAnnuities { get; set; }

    public bool BFlagIsReviewDatabase { get; set; }

    public string CReviewDatabaseMessage { get; set; }

    public bool BFlagMobileShowAccountNumbers { get; set; }

    public string CNlgFtpUserName { get; set; }

    public string CNlgFtpPasswordEncrypted { get; set; }

    public bool? BFlagNlgvalidate { get; set; }

    public string CMacgSysAdminName { get; set; }

    public string CMacgSysAdminPasswordEncrypted { get; set; }

    public string CBlackDiamondUserId { get; set; }

    public string CBlackDiamondUserPw { get; set; }

    public bool BFlagBlackDiamondAgreement { get; set; }

    public string CDefaultPhoneCountryCode { get; set; }

    public bool? BFlagSocialMedia { get; set; }

    public bool BFlagShowMacroRiskAnalyticsMenuOption { get; set; }

    public bool BFlagShowBlackDiamondMenuOption { get; set; }

    public bool BFlagShowRiskAlyzeMenuOption { get; set; }

    public string CGoogleClientSecretEncrypted { get; set; }

    public string CGoogleClientIdEncrypted { get; set; }

    public string CGoogleCorporateDomain { get; set; }

    public string CGoogleRedirectUrl { get; set; }

    public string CGoogleOauthTokenUri { get; set; }

    public string CGoogleAppType { get; set; }

    public string CGoogleAuthProviderX509 { get; set; }

    public int INameLookpupAccessAll { get; set; }

    public bool? BFlagShowTdaveoMenuOption { get; set; }

    public bool? BFlagShowNetx360MenuOption { get; set; }

    public bool? BFlagAutoCalcInvestments { get; set; }

    public bool BFlagAutoCalcRor { get; set; }

    public bool BFlagHostedCalcInvestments { get; set; }

    public bool BFlagHostedCalcRor { get; set; }

    public bool? BFlagSharefileShowMenuOption { get; set; }

    public bool BFlagShareFileEnabled { get; set; }

    public string CShareFileClientIdEncrypted { get; set; }

    public string CShareFileClientSecretEncrypted { get; set; }

    public string CSharefilePrimaryDomain { get; set; }

    public bool? BFlagShowCustodianContactInfoOnReports { get; set; }

    public bool? BFlagStrongPasswordEnable { get; set; }

    public int IMustChangePasswordDays { get; set; }

    public int ICannotChangePasswordDays { get; set; }

    public int ICannotRepeatPasswords { get; set; }

    public int ILockoutAttempts { get; set; }

    public bool BFlagDownloadLock { get; set; }

    public int IDaysToRollover { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public bool BFlagMfaenabled { get; set; }

    public int IMfafreq { get; set; }
}