﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetNoteListPagingByAccountResult
    {
        public int? RowNum { get; set; }
        public int TopicKey { get; set; }
        public int NoteKey { get; set; }
        public string NotePage { get; set; }
        public bool bflagarchived { get; set; }
        public DateTime? dLastChange { get; set; }
        public string cWhoChange { get; set; }
        public string TopicDesc { get; set; }
        public DateTime? dbegin { get; set; }
    }
}
