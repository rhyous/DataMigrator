﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_dlfGetPlansNotFoundResult
    {
        public string cFilename { get; set; }
        public string cRecordType { get; set; }
        public string cPlanAbbreviation { get; set; }
        public string cPlanDescription { get; set; }
        public int iCodeCompany { get; set; }
        public string cCompanyCode { get; set; }
        public string cCompanyDescription { get; set; }
        public string cAACompanyDescription { get; set; }
        public int iCodeProductClass { get; set; }
        public int iCodePlanType { get; set; }
        public string cPlanTypeCode { get; set; }
        public string cPlanTypeDescription { get; set; }
        public string cAAPlanTypeDescription { get; set; }
    }
}
