﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_DLFAdditionsByFileQueryResult
    {
        public int? FileKey { get; set; }
        public string cOriginalFilename { get; set; }
        public DateTime? dFile { get; set; }
        public DateTime? dProcessed { get; set; }
        public DateTime? dDateOfRecord { get; set; }
        public int? Accounts { get; set; }
        public int? Investments { get; set; }
        public int? Positions { get; set; }
        public int? Transactions { get; set; }
        public int? Securities { get; set; }
        public int? Prices { get; set; }
    }
}