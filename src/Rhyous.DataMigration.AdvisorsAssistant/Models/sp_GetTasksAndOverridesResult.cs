﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetTasksAndOverridesResult
    {
        public string GroupName { get; set; }
        public string TaskName { get; set; }
        public string TaskFunction { get; set; }
        public bool? bFlagDefault { get; set; }
        public bool? bFlagOverride { get; set; }
        public int? iKeyTask { get; set; }
        public int? iKeyGroup { get; set; }
        public int? iKeyOverride { get; set; }
        public string rolename { get; set; }
        public int? roleKey { get; set; }
        public bool? bFlagActivate { get; set; }
        public int? iKeyOvrUser { get; set; }
        public int iKeyTableID { get; set; }
    }
}
