﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetSavedQueryListResult
    {
        public int iKeyId { get; set; }
        public int iKeyOwningUser { get; set; }
        public string cName { get; set; }
        public bool bFlagPrevious { get; set; }
        public string mDescripton { get; set; }
        public bool bFlagInsuranceExcludeUnrelatedNames { get; set; }
        public bool bFlagInvestmentsExcludeUnrelatedNames { get; set; }
        public bool bFlagInsuranceSelectAll { get; set; }
        public bool bFlagInvestmentsSelectAll { get; set; }
        public int iInsuranceNamesRelationship { get; set; }
        public int iInvestmentsNamesRelationship { get; set; }
        public string cWhoChange { get; set; }
        public DateTime? dLastChange { get; set; }
        public string cWhoAdded { get; set; }
        public DateTime? dWhenAdded { get; set; }
        public Guid? gUid { get; set; }
    }
}
