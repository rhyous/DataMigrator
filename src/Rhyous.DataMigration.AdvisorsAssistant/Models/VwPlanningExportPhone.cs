﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwPlanningExportPhone
{
    public int UniqueNameId { get; set; }

    public Guid NameGuid { get; set; }

    public Guid PhoneGuid { get; set; }

    public string PhoneTypeAbbreviation { get; set; }

    public string PhoneTypeDescription { get; set; }

    public string Contact { get; set; }

    public string CountryCode { get; set; }

    public string Areacode { get; set; }

    public string PhoneNumber { get; set; }

    public string PhoneExtension { get; set; }

    public string FullPhone { get; set; }

    public bool? Primary { get; set; }
}