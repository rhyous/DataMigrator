﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetAppointmentDataSetResult
    {
        public int EventId { get; set; }
        public int Id { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Subject { get; set; }
        public string Properties { get; set; }
        public int Color { get; set; }
        public string location { get; set; }
        public string cLocation { get; set; }
        public int ipriority { get; set; }
    }
}
