﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_NameGetLastActivityManyResult
    {
        public int? NameKeyID { get; set; }
        public DateTime? LatestDate { get; set; }
        public string LatestActionDesc { get; set; }
    }
}
