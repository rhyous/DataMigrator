﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetNoteListFormListMessagesResult
    {
        public int iKeyID { get; set; }
        public string cDescription { get; set; }
        public string NoteTypeDesc { get; set; }
        public DateTime? began { get; set; }
        public DateTime? latest { get; set; }
        public int? dFollowup { get; set; }
        public int? NoteCount { get; set; }
        public int iCodeNoteType { get; set; }
        public int iKeyWorkflow { get; set; }
    }
}
