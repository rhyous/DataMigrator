﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetCalendarDayResult
    {
        public string cdescription { get; set; }
        public int DetailKeyID { get; set; }
        public Guid DetailKeyGUID { get; set; }
        public int EventKeyID { get; set; }
        public Guid EventKeyGUID { get; set; }
        public string EventTypeDesc { get; set; }
        public DateTime? dBegin { get; set; }
        public DateTime? dEnd { get; set; }
        public DateTime? dDue { get; set; }
        public DateTime? dJustDate { get; set; }
        public bool bFlagCompleted { get; set; }
        public string EventSubTypeDesc { get; set; }
        public string ClientName { get; set; }
        public int iCodeEventType { get; set; }
        public int iCodeEventSubType { get; set; }
        public int iRecurOption { get; set; }
        public int iSourceType { get; set; }
    }
}