﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_NameVisibilityManyResult
    {
        public int? NameKeyID { get; set; }
        public bool? Visible { get; set; }
        public string Message { get; set; }
        public int? SwitchViewKeyID { get; set; }
        public string SwitchViewLabel { get; set; }
    }
}
