﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_MobileGetEventDataResult
    {
        public string cdescription { get; set; }
        public int DetailKeyID { get; set; }
        public int EventKeyID { get; set; }
        public string EventTypeDesc { get; set; }
        public string cLocation { get; set; }
        public string EventSubTypeDesc { get; set; }
        public int iPriority { get; set; }
        public int iCodeEventType { get; set; }
        public int iCodeEventSubType { get; set; }
        public DateTime? dBegin { get; set; }
        public DateTime? dEnd { get; set; }
        public DateTime? dDue { get; set; }
        public DateTime? dJustDate { get; set; }
        public int iRecurOption { get; set; }
        public string tBegin { get; set; }
        public string tEnd { get; set; }
        public string ClientName { get; set; }
        public bool bFlagCompleted { get; set; }
        public int? iKeyName { get; set; }
        public string UserName { get; set; }
        public int? iKeyCalendar { get; set; }
        public int iColor { get; set; }
    }
}