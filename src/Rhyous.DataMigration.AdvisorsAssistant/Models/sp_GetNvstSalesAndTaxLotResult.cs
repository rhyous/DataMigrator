﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetNvstSalesAndTaxLotResult
    {
        public int ikeytrans { get; set; }
        public int ikeylinkedtrans { get; set; }
        public DateTime? dTrandate { get; set; }
        public bool bFlagFreezeBasis { get; set; }
        [Column("ySharesAssigned", TypeName = "decimal(38,6)")]
        public decimal? ySharesAssigned { get; set; }
    }
}
