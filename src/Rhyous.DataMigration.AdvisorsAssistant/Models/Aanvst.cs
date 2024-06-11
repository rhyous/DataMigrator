﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class Aanvst
{
    public int Ikeyid { get; set; }

    public int Ikeyacct { get; set; }

    public int Ikeysymbol { get; set; }

    public int IKeyFlex { get; set; }

    public int IKeyVal { get; set; }

    public int IKeyCurrentPosition { get; set; }

    public int? ICodeInvestmentClass { get; set; }

    public int IKeycomm { get; set; }

    public int IKeyModule { get; set; }

    public int IKeyDlffileCreated { get; set; }

    public int ICodeStatus { get; set; }

    public bool BFlagAcctCashBalance { get; set; }

    public bool Bflagror { get; set; }

    public DateTime? DInitialized { get; set; }

    public bool BFlagInitialized { get; set; }

    public bool BFlagInitValuesOnly { get; set; }

    public bool BFlagNeedSummedValuesCalculation { get; set; }

    public bool BFlagNeedRorcalculation { get; set; }

    public bool BFlagNeedBasisCalculation { get; set; }

    public bool BFlagNeedValuationsCalculation { get; set; }

    public DateTime? DLastTransaction { get; set; }

    public DateTime? DFirstTransaction { get; set; }

    public DateTime? DProcessStart { get; set; }

    public DateTime? DLastReconcile { get; set; }

    public DateTime? DLastPeriodicValuation { get; set; }

    public string CLastPeriodicType { get; set; }

    public int ICodeGainsOption { get; set; }

    public int ICodeDividendOption { get; set; }

    public int ICodeBasisType { get; set; }

    public DateTime? DEffective { get; set; }

    public DateTime? Dliquidated { get; set; }

    public bool Bflagintbear { get; set; }

    public bool Bflagautocalc { get; set; }

    public bool Bflagreinvest { get; set; }

    public bool Bflagaccrue { get; set; }

    public DateTime? Dcallable { get; set; }

    public decimal Nannualrate { get; set; }

    public DateTime? Dmaturedate { get; set; }

    public decimal Yfacevalue { get; set; }

    public int ICodeInterestPaymentFrequency { get; set; }

    public int ICodeInterestCompound { get; set; }

    public bool Bflagautoplan { get; set; }

    public bool Bflagautobuy { get; set; }

    public int Icodepurchmode { get; set; }

    public DateTime? Dbeginplan { get; set; }

    public decimal Nplaninvest { get; set; }

    public decimal Nloadpct { get; set; }

    public decimal Ncommpct { get; set; }

    public bool BFlagAutoWithDrawal { get; set; }

    public bool BFlagGenerateAutoWithDrawal { get; set; }

    public int ICodeWithDrawalMode { get; set; }

    public DateTime? DBeginWithDrawal { get; set; }

    public DateTime? DLastWithDrawal { get; set; }

    public decimal NAutoWithDrawal { get; set; }

    public bool BFlagTrailerCommission { get; set; }

    public int Itimesyear { get; set; }

    public int ITrailerBeginsNmonthsAfterAcquired { get; set; }

    public decimal Nbasispoints { get; set; }

    public DateTime? Dbegintrailer { get; set; }

    public DateTime? Dpaidthrutrailer { get; set; }

    public string Cdlinvtype { get; set; }

    public string CHoldStrategy { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual ICollection<AaformNvst> AaformNvsts { get; set; } = new List<AaformNvst>();

    public virtual ICollection<AanvSum> AanvSums { get; set; } = new List<AanvSum>();

    public virtual ICollection<AanvTran> AanvTrans { get; set; } = new List<AanvTran>();

    public virtual ICollection<AanvstPosition> AanvstPositions { get; set; } = new List<AanvstPosition>();

    public virtual AanvstValue IKeyValNavigation { get; set; }
}