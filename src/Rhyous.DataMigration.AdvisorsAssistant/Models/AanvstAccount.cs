﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class AanvstAccount
{
    public int IKeyId { get; set; }

    public int IKeyPrimaryClient { get; set; }

    public int IKeyOwner { get; set; }

    public int IKeyPrimaryProducer { get; set; }

    public int IKeyProducerLevel1 { get; set; }

    public int IKeyProducerLevel2 { get; set; }

    public int IKeyProducerLevel3 { get; set; }

    public int IKeyProducerLevel4 { get; set; }

    public int IKeyManagerLevel1 { get; set; }

    public int IKeyManagerLevel2 { get; set; }

    public int IKeyManagerLevel3 { get; set; }

    public int IKeyManagerLevel4 { get; set; }

    public int IKeyCashBal { get; set; }

    public int IKeyFlex { get; set; }

    public int IKeyModule { get; set; }

    public int IKeyModulePreference { get; set; }

    public int IKeyDlffileCreated { get; set; }

    public string MBeneficiary { get; set; }

    public string Cacctnum { get; set; }

    public string Ccontrolnum { get; set; }

    public string Coldcontrol { get; set; }

    public string CTitle { get; set; }

    public int Icodeaccttype { get; set; }

    public int ICodeCustodian { get; set; }

    public int Icodestatus { get; set; }

    public int ICodeTaxStatus { get; set; }

    public int Icoderegister { get; set; }

    public int Icodeobjective { get; set; }

    public int IcodeStrategy { get; set; }

    public int ICodeBasisType { get; set; }

    public bool? BFlagRor { get; set; }

    public bool Bflagcarry { get; set; }

    public bool Bflagqualified { get; set; }

    public bool BFlagClDirect { get; set; }

    public bool? BFlagShowCashBalance { get; set; }

    public bool BFlagAdvisoryAccount { get; set; }

    public DateTime? Deffective { get; set; }

    public DateTime? Dclose { get; set; }

    public DateTime? Dprocess { get; set; }

    public DateTime? DRorvalue { get; set; }

    public string Cwhoprocess { get; set; }

    public decimal Ymktval { get; set; }

    public decimal YDistributionsPaidout { get; set; }

    public decimal YDistributionsReinvested { get; set; }

    public decimal YCapGainLongPaidOut { get; set; }

    public decimal YCapGainShortPaidOut { get; set; }

    public decimal YInterestPaidOut { get; set; }

    public decimal YDividendPaidOut { get; set; }

    public decimal YCapGainLongReinvested { get; set; }

    public decimal YCapGainShortReinvested { get; set; }

    public decimal YInterestReinvested { get; set; }

    public decimal YDividendReinvested { get; set; }

    public decimal YMoneyIn { get; set; }

    public decimal YMoneyOut { get; set; }

    public decimal YClientMoneyIn { get; set; }

    public decimal YClientMoneyOut { get; set; }

    public decimal YClientNet { get; set; }

    public decimal YOutSideMoneyIn { get; set; }

    public decimal YOutSideMoneyOut { get; set; }

    public decimal YOutSideMoneyNet { get; set; }

    public decimal YNetTransfers { get; set; }

    public decimal YNetExpenses { get; set; }

    public decimal YNetFees { get; set; }

    public decimal YNetAdjustments { get; set; }

    public decimal YNetGift { get; set; }

    public decimal YUnrealGain { get; set; }

    public decimal YRealGain { get; set; }

    public decimal YCostBasis { get; set; }

    public decimal Nrordollar { get; set; }

    public decimal Nrortime { get; set; }

    public decimal NRorsimple { get; set; }

    public string CDlOfficeNumber { get; set; }

    public decimal YDlCashBalance { get; set; }

    public decimal YDlcashAvailable { get; set; }

    public decimal YDlMoneyMarketBalance { get; set; }

    public decimal YDlMarketValue { get; set; }

    public decimal YDlmarketValueLong { get; set; }

    public decimal YDlMarketValueShort { get; set; }

    public decimal YDlEquity { get; set; }

    public decimal YDlMarginBalance { get; set; }

    public decimal YDlMarginMarketValue { get; set; }

    public decimal YDlSmabalance { get; set; }

    public DateTime? DDlCashValuation { get; set; }

    public DateTime? DDlMarginValuation { get; set; }

    public DateTime? DDlRegistration { get; set; }

    public DateTime? DDlPosition { get; set; }

    public bool? BFlagUseFchoutsidePositions { get; set; }

    public bool BFlagPositionOnly { get; set; }

    public int ICodeRecordCreationSource { get; set; }

    public string CAuthorizedPerson { get; set; }

    public string CHoldStrategy { get; set; }

    public int ICodeRiskTolerance { get; set; }

    public int ICodeLiquidityTimePeriod { get; set; }

    public int ICodeTimeHorizon { get; set; }

    public decimal YLiquidity { get; set; }

    public DateTime? DAnnuitization { get; set; }

    public DateTime? DAnnuityMaturity { get; set; }

    public int ICodeAnnuitySurrenderPeriod { get; set; }

    public decimal NInterestRate { get; set; }

    public decimal NMortalityExpenseRate { get; set; }

    public string CWhoChange { get; set; }

    public DateTime? DLastChange { get; set; }

    public string CWhoAdded { get; set; }

    public DateTime? DWhenAdded { get; set; }

    public string CSerialId { get; set; }

    public Guid GUid { get; set; }

    public int IRecVersion { get; set; }

    public virtual ICollection<AanvstNewBiz> AanvstNewBizs { get; set; } = new List<AanvstNewBiz>();
}