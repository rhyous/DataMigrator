﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_ServiceDLFActiveModulesResult
    {
        public int? iKeyId { get; set; }
        public string cModule { get; set; }
        public string cDescription { get; set; }
        public bool? bFlagDLFService { get; set; }
        public DateTime? dDLFServiceTime { get; set; }
        public bool? bFlagDLFServiceStarted { get; set; }
        public DateTime? dDLFServiceStarted { get; set; }
        public DateTime? dDLFServiceEnded { get; set; }
        public DateTime? dExpirationDate { get; set; }
        public bool? bFlagTrialPeriod { get; set; }
        public DateTime? dServerDateTime { get; set; }
        public bool? bFlagDLFPostDownloadProcessMarketValues { get; set; }
    }
}