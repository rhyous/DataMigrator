﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class Aaaddress
{
    public int Ikeyid { get; set; }

    public int Ikeyclient { get; set; }

    public int IKeyHouseHold { get; set; }

    public int IUpdateVersion { get; set; }

    public int Icodeaddress { get; set; }

    public bool BFlagPrimary { get; set; }

    public string Cgreet { get; set; }

    public string Caddressee { get; set; }

    public string Ctitle { get; set; }

    public string CBusinessName { get; set; }

    public string Cstreet1 { get; set; }

    public string Cstreet2 { get; set; }

    public string Cstreet3 { get; set; }

    public string Ccity { get; set; }

    public string Cstate { get; set; }

    public string Czip { get; set; }

    public string CCounty { get; set; }

    public string Ccountry { get; set; }

    public string Croute { get; set; }

    public string Caddrpoint { get; set; }

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