﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstTaxLot
{
    public int IKeyId { get; set; }

    public int IKeyTrans { get; set; }

    public int IKeySales { get; set; }

    public DateTime? DTrandate { get; set; }

    public DateTime? DHoldingDate { get; set; }

    public bool BFlagFreeze { get; set; }

    public bool BFlagPrimary { get; set; }

    public decimal NShares { get; set; }

    public decimal? NBasisPerShare { get; set; }

    public decimal NBasisPerShareRaw { get; set; }

    public decimal NBasisRatio { get; set; }

    public decimal NBasisPerShareAdjustment { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual AanvstLotAndSplitLink AanvstLotAndSplitLink { get; set; }

    public virtual AanvstSale IKeySalesNavigation { get; set; }
}