﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetNameNewBizDataResult
    {
        public int UniqueNameID { get; set; }
        public int UniqueNewBizID { get; set; }
        public int iCodeAction { get; set; }
        public string cAction { get; set; }
        public DateTime? dInitial { get; set; }
        public DateTime? dCompleted { get; set; }
        public string Priority { get; set; }
        public int PriorityCode { get; set; }
        public decimal Amount { get; set; }
        public string VendorName { get; set; }
        public int iKeyVendor { get; set; }
        public string mNotePage { get; set; }
        public int? NoteKeyID { get; set; }
        public DateTime? dJustDate { get; set; }
        public string WhoChanged { get; set; }
        public DateTime? WhenChanged { get; set; }
        public string WhoAdded { get; set; }
        public DateTime? WhenAdded { get; set; }
        public Guid GUID { get; set; }
        public Guid UniqueNameGUID { get; set; }
    }
}