﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class Aaphone
{
    public int Ikeyid { get; set; }

    public int Ikeyclient { get; set; }

    public int IKeyHouseHold { get; set; }

    public int IUpdateVersion { get; set; }

    public int Icodephone { get; set; }

    public int ICodeAvailability { get; set; }

    public string CContact { get; set; }

    public string Ccountry { get; set; }

    public string Careacode { get; set; }

    public string Cphonenum { get; set; }

    public string Cphoneext { get; set; }

    public string CPhoneSearch { get; set; }

    public int ICodeRecordCreationSource { get; set; }

    public string MComment { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual Aaname IkeyclientNavigation { get; set; }
}