﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_MobileGetCoverageRiderListResult
    {
        public int iKeyID { get; set; }
        public string RiderType { get; set; }
        public decimal RiderBenefit { get; set; }
        public DateTime? dEffective { get; set; }
        public DateTime? dExpiration { get; set; }
        public string InsuredName { get; set; }
    }
}
