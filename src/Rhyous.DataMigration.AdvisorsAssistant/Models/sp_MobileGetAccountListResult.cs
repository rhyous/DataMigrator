﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_MobileGetAccountListResult
    {
        public int iKeyID { get; set; }
        public string cRelationships { get; set; }
        public string AccountType { get; set; }
        public decimal yMktVal { get; set; }
        public DateTime? dProcess { get; set; }
        public string AccountNumber { get; set; }
        public string AccountNumberUnmasked { get; set; }
        public string AccountTitle { get; set; }
        public string AccountTitleUnmasked { get; set; }
        public decimal? NetAdditions { get; set; }
        public DateTime? dOldestValueDate { get; set; }
        public string Custodian { get; set; }
    }
}
