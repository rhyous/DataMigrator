﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwPlanningExportInsured
{
    public Guid InsuredRelationshipGuid { get; set; }

    public int UniqueNameId { get; set; }

    public Guid PolicyOwnerNameGuid { get; set; }

    public Guid PolicyGuid { get; set; }

    public Guid CoverageGuid { get; set; }

    public string InsuredRelationshipAbbreviation { get; set; }

    public string InsuredRelationshipDescription { get; set; }

    public Guid InsuredNameGuid { get; set; }

    public string InsuredFullName { get; set; }
}