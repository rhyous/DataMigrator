﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class Aaproducer
{
    public int IKeyId { get; set; }

    public int IKeyName { get; set; }

    public int IKeyOffice { get; set; }

    public int IKeyDefaultManager { get; set; }

    public int IKeyAccountPlaceHolder { get; set; }

    public string CName { get; set; }

    public string CAwloginId { get; set; }

    public string CAwloginPw { get; set; }

    public string CAwname { get; set; }

    public string CDvloginId { get; set; }

    public string CDvloginPw { get; set; }

    public string CAlbridgeFinancialInstitutionId { get; set; }

    public string CAlbridgePartnerUserId { get; set; }

    public bool BFlagAlbridgeUnattended { get; set; }

    public string CMoneyGuideProInstitutionId { get; set; }

    public string CMoneyGuideProVirtualDirectory { get; set; }

    public string COrionRepNumber { get; set; }

    public string COrionListedRepName { get; set; }

    public string COrionRepAuthentication { get; set; }

    public string CFinanceLogixAdvisorId { get; set; }

    public string CFinanceLogixAdvisorPassword { get; set; }

    public string CTdaApiAdvisorId { get; set; }

    public string CTdaApiAdvisorPassword { get; set; }

    public bool BFlagAgency { get; set; }

    public bool BFlagShowFullAddressOnReports { get; set; }

    public string CApikey1 { get; set; }

    public string CApikey2 { get; set; }

    public string CApikey3 { get; set; }

    public string CMacroRiskAdvisorId { get; set; }

    public string CMacroRiskAdvisorPassWord { get; set; }

    public string CDocupaceRepCode { get; set; }

    public string CAdvisorVaultUserName { get; set; }

    public string CAdvisorVaultBurstUploadLocation { get; set; }

    public string CCamid { get; set; }

    public string CCampassword { get; set; }

    public string CMacguserId { get; set; }

    public string CMacgpasswordEncrypted { get; set; }

    public DateTime? DMacgretrieveFrom { get; set; }

    public string CBldadvisorId { get; set; }

    public string CBldadvisorPassword { get; set; }

    public bool BFlagShareFileEnabled { get; set; }

    public string CShareFileAuthTokenEncrypted { get; set; }

    public string CShareFileSubDomain { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual ICollection<AapolicyPdcr> AapolicyPdcrs { get; set; } = new List<AapolicyPdcr>();

    public virtual Aaname IKeyNameNavigation { get; set; }

    public virtual Aaoffice IKeyOfficeNavigation { get; set; }
}