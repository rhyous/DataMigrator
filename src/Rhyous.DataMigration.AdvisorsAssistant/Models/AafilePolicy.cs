﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AafilePolicy
{
    public int IKeyId { get; set; }

    public int IKeyLink { get; set; }

    public string CDescription { get; set; }

    public string MFileName { get; set; }

    public string CFileLink { get; set; }

    public int ICodeFileCat { get; set; }

    public int ICodeFileSource { get; set; }

    public int ICodeFileStatus { get; set; }

    public DateTime? DFileDate { get; set; }

    public string CFileFlag { get; set; }

    public int IFileSize { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecversion { get; set; }
}