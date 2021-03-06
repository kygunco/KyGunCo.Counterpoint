// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_TKT_HIST
    public class ViPsTktHist
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public Guid DocGuid { get; set; } // DOC_GUID
        public DateTime? TktDat { get; set; } // TKT_DAT
        public DateTime? TktTim { get; set; } // TKT_TIM
        public DateTime? TktDt { get; set; } // TKT_DT
        public DateTime PostDat { get; set; } // POST_DAT
        public string DocTyp { get; set; } // DOC_TYP (length: 1)
        public string TktTyp { get; set; } // TKT_TYP (length: 1)
        public string DrwId { get; set; } // DRW_ID (length: 10)
        public long? DrwSessionId { get; set; } // DRW_SESSION_ID
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string StkLocId { get; set; } // STK_LOC_ID (length: 10)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public string PftCtr { get; set; } // PFT_CTR (length: 20)
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public byte? BillToContactId { get; set; } // BILL_TO_CONTACT_ID
        public byte? ShipToContactId { get; set; } // SHIP_TO_CONTACT_ID
        public string LoyPgmCod { get; set; } // LOY_PGM_COD (length: 10)
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public string ShipViaCod { get; set; } // SHIP_VIA_COD (length: 10)
        public string ShipZoneCod { get; set; } // SHIP_ZONE_COD (length: 30)
        public DateTime? ShipDat { get; set; } // SHIP_DAT
        public string NormTaxCod { get; set; } // NORM_TAX_COD (length: 10)
        public string TaxCod { get; set; } // TAX_COD (length: 10)
        public string TaxCodChngd { get; set; } // TAX_COD_CHNGD (length: 1)
        public string TaxExemptNo { get; set; } // TAX_EXEMPT_NO (length: 30)
        public string TaxOvrdReas { get; set; } // TAX_OVRD_REAS (length: 10)
        public string CustPoNo { get; set; } // CUST_PO_NO (length: 20)
        public string LstFrmGrpPrtd { get; set; } // LST_FRM_GRP_PRTD (length: 10)
        public string LstFrmPrtd { get; set; } // LST_FRM_PRTD (length: 100)
        public int? TimesPrtd { get; set; } // TIMES_PRTD
        public decimal? FoodStmpAmt { get; set; } // FOOD_STMP_AMT
        public int FoodStmpLins { get; set; } // FOOD_STMP_LINS
        public decimal? FoodStmpTaxAmt { get; set; } // FOOD_STMP_TAX_AMT
        public string Ref { get; set; } // REF (length: 50)
        public int? HdrDiscs { get; set; } // HDR_DISCS
        public string HdrDiscCod { get; set; } // HDR_DISC_COD (length: 10)
        public int? SalLins { get; set; } // SAL_LINS
        public decimal SalLinTot { get; set; } // SAL_LIN_TOT
        public int? RetLins { get; set; } // RET_LINS
        public decimal RetLinTot { get; set; } // RET_LIN_TOT
        public int GfcLins { get; set; } // GFC_LINS
        public int SvcLins { get; set; } // SVC_LINS
        public string SalHasTaxOvrd { get; set; } // SAL_HAS_TAX_OVRD (length: 1)
        public int SalTaxOvrdLins { get; set; } // SAL_TAX_OVRD_LINS
        public decimal? SalGrossSubTot { get; set; } // SAL_GROSS_SUB_TOT
        public decimal SalSubTot { get; set; } // SAL_SUB_TOT
        public decimal SalTotHdrDisc { get; set; } // SAL_TOT_HDR_DISC
        public decimal SalTotLinDisc { get; set; } // SAL_TOT_LIN_DISC
        public decimal? SalTotDisc { get; set; } // SAL_TOT_DISC
        public decimal? SalTotCost { get; set; } // SAL_TOT_COST
        public decimal? SalTotEstCost { get; set; } // SAL_TOT_EST_COST
        public decimal SalTotWeight { get; set; } // SAL_TOT_WEIGHT
        public decimal SalTotCube { get; set; } // SAL_TOT_CUBE
        public decimal? SalTotGfcAmt { get; set; } // SAL_TOT_GFC_AMT
        public decimal? SalTotSvcAmt { get; set; } // SAL_TOT_SVC_AMT
        public decimal SalTotMisc { get; set; } // SAL_TOT_MISC
        public decimal SalNormTaxAmt { get; set; } // SAL_NORM_TAX_AMT
        public decimal SalTaxAmt { get; set; } // SAL_TAX_AMT
        public decimal SalTot { get; set; } // SAL_TOT
        public decimal SalTotTnd { get; set; } // SAL_TOT_TND
        public decimal SalTotChng { get; set; } // SAL_TOT_CHNG
        public decimal? SalNetTnd { get; set; } // SAL_NET_TND
        public decimal TotTipAmt { get; set; } // TOT_TIP_AMT
        public decimal SalAmtDue { get; set; } // SAL_AMT_DUE
        public string SalMiscTyp1 { get; set; } // SAL_MISC_TYP_1 (length: 1)
        public decimal? SalMiscAmt1 { get; set; } // SAL_MISC_AMT_1
        public decimal? SalMiscPct1 { get; set; } // SAL_MISC_PCT_1
        public string SalMiscTyp2 { get; set; } // SAL_MISC_TYP_2 (length: 1)
        public decimal? SalMiscAmt2 { get; set; } // SAL_MISC_AMT_2
        public decimal? SalMiscPct2 { get; set; } // SAL_MISC_PCT_2
        public string SalMiscTyp3 { get; set; } // SAL_MISC_TYP_3 (length: 1)
        public decimal? SalMiscAmt3 { get; set; } // SAL_MISC_AMT_3
        public decimal? SalMiscPct3 { get; set; } // SAL_MISC_PCT_3
        public string SalMiscTyp4 { get; set; } // SAL_MISC_TYP_4 (length: 1)
        public decimal? SalMiscAmt4 { get; set; } // SAL_MISC_AMT_4
        public decimal? SalMiscPct4 { get; set; } // SAL_MISC_PCT_4
        public string SalMiscTyp5 { get; set; } // SAL_MISC_TYP_5 (length: 1)
        public decimal? SalMiscAmt5 { get; set; } // SAL_MISC_AMT_5
        public decimal? SalMiscPct5 { get; set; } // SAL_MISC_PCT_5
        public decimal? SalMiscTaxAmtAlloc1 { get; set; } // SAL_MISC_TAX_AMT_ALLOC_1
        public decimal? SalMiscNormTaxAmtAlloc1 { get; set; } // SAL_MISC_NORM_TAX_AMT_ALLOC_1
        public decimal? SalMiscTaxAmtAlloc2 { get; set; } // SAL_MISC_TAX_AMT_ALLOC_2
        public decimal? SalMiscNormTaxAmtAlloc2 { get; set; } // SAL_MISC_NORM_TAX_AMT_ALLOC_2
        public decimal? SalMiscTaxAmtAlloc3 { get; set; } // SAL_MISC_TAX_AMT_ALLOC_3
        public decimal? SalMiscNormTaxAmtAlloc3 { get; set; } // SAL_MISC_NORM_TAX_AMT_ALLOC_3
        public decimal? SalMiscTaxAmtAlloc4 { get; set; } // SAL_MISC_TAX_AMT_ALLOC_4
        public decimal? SalMiscNormTaxAmtAlloc4 { get; set; } // SAL_MISC_NORM_TAX_AMT_ALLOC_4
        public decimal? SalMiscTaxAmtAlloc5 { get; set; } // SAL_MISC_TAX_AMT_ALLOC_5
        public decimal? SalMiscNormTaxAmtAlloc5 { get; set; } // SAL_MISC_NORM_TAX_AMT_ALLOC_5
        public int? Lins { get; set; } // LINS
        public int TaxOvrdLins { get; set; } // TAX_OVRD_LINS
        public decimal? GrossSubTot { get; set; } // GROSS_SUB_TOT
        public decimal SubTot { get; set; } // SUB_TOT
        public decimal TotHdrDisc { get; set; } // TOT_HDR_DISC
        public decimal TotLinDisc { get; set; } // TOT_LIN_DISC
        public decimal? TotDisc { get; set; } // TOT_DISC
        public decimal? TotCost { get; set; } // TOT_COST
        public decimal TotWeight { get; set; } // TOT_WEIGHT
        public decimal TotCube { get; set; } // TOT_CUBE
        public decimal TotMisc { get; set; } // TOT_MISC
        public decimal NormTaxAmt { get; set; } // NORM_TAX_AMT
        public decimal TaxAmt { get; set; } // TAX_AMT
        public decimal TotTnd { get; set; } // TOT_TND
        public decimal TotChng { get; set; } // TOT_CHNG
        public decimal? NetTnd { get; set; } // NET_TND
        public decimal Tot { get; set; } // TOT
        public decimal AmtDue { get; set; } // AMT_DUE
        public decimal? MiscAmt1 { get; set; } // MISC_AMT_1
        public decimal? MiscAmt2 { get; set; } // MISC_AMT_2
        public decimal? MiscAmt3 { get; set; } // MISC_AMT_3
        public decimal? MiscAmt4 { get; set; } // MISC_AMT_4
        public decimal? MiscAmt5 { get; set; } // MISC_AMT_5
        public decimal? MiscPct1 { get; set; } // MISC_PCT_1
        public decimal? MiscPct2 { get; set; } // MISC_PCT_2
        public decimal? MiscPct3 { get; set; } // MISC_PCT_3
        public decimal? MiscPct4 { get; set; } // MISC_PCT_4
        public decimal? MiscPct5 { get; set; } // MISC_PCT_5
        public decimal? MiscTaxAmtAlloc1 { get; set; } // MISC_TAX_AMT_ALLOC_1
        public decimal? MiscNormTaxAmtAlloc1 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_1
        public decimal? MiscTaxAmtAlloc2 { get; set; } // MISC_TAX_AMT_ALLOC_2
        public decimal? MiscNormTaxAmtAlloc2 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_2
        public decimal? MiscTaxAmtAlloc3 { get; set; } // MISC_TAX_AMT_ALLOC_3
        public decimal? MiscNormTaxAmtAlloc3 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_3
        public decimal? MiscTaxAmtAlloc4 { get; set; } // MISC_TAX_AMT_ALLOC_4
        public decimal? MiscNormTaxAmtAlloc4 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_4
        public decimal? MiscTaxAmtAlloc5 { get; set; } // MISC_TAX_AMT_ALLOC_5
        public decimal? MiscNormTaxAmtAlloc5 { get; set; } // MISC_NORM_TAX_AMT_ALLOC_5
        public string DocDescr { get; set; } // DOC_DESCR (length: 30)
        public string PayAcctNo { get; set; } // PAY_ACCT_NO (length: 20)
        public string PayApplyMeth { get; set; } // PAY_APPLY_METH (length: 1)
        public decimal? PayAmt { get; set; } // PAY_AMT
        public decimal? AbsPayAmt { get; set; } // ABS_PAY_AMT
        public string OrigQuotStrId { get; set; } // ORIG_QUOT_STR_ID (length: 10)
        public string OrigQuotStaId { get; set; } // ORIG_QUOT_STA_ID (length: 10)
        public string OrigQuotNo { get; set; } // ORIG_QUOT_NO (length: 15)
        public string OrigHoldStrId { get; set; } // ORIG_HOLD_STR_ID (length: 10)
        public string OrigHoldStaId { get; set; } // ORIG_HOLD_STA_ID (length: 10)
        public string OrigHoldNo { get; set; } // ORIG_HOLD_NO (length: 15)
        public decimal? LinLoyPtsEarnd { get; set; } // LIN_LOY_PTS_EARND
        public int? LoyPtsEarndGross { get; set; } // LOY_PTS_EARND_GROSS
        public int? LoyPtsAdjForRdm { get; set; } // LOY_PTS_ADJ_FOR_RDM
        public int? LoyPtsAdjForIncRnd { get; set; } // LOY_PTS_ADJ_FOR_INC_RND
        public int? LoyPtsAdjForOverMax { get; set; } // LOY_PTS_ADJ_FOR_OVER_MAX
        public int? LoyPtsEarndNet { get; set; } // LOY_PTS_EARND_NET
        public int? LoyPtsRdm { get; set; } // LOY_PTS_RDM
        public int? LoyPtsBal { get; set; } // LOY_PTS_BAL
        public int? EcStrId { get; set; } // EC_STR_ID
        public string EcImpEventNo { get; set; } // EC_IMP_EVENT_NO (length: 15)
        public DateTime? EcLstPubDt { get; set; } // EC_LST_PUB_DT
        public string EcLstPubEventNo { get; set; } // EC_LST_PUB_EVENT_NO (length: 15)
        public string EcOrdNo { get; set; } // EC_ORD_NO (length: 9)
        public string EcBatId { get; set; } // EC_BAT_ID (length: 6)
        public string EcCustNo { get; set; } // EC_CUST_NO (length: 10)
        public string EcAffilCod { get; set; } // EC_AFFIL_COD (length: 10)
        public decimal? EcOrdTot { get; set; } // EC_ORD_TOT
        public string BillNam { get; set; } // BILL_NAM (length: 40)
        public string BillNamUpr { get; set; } // BILL_NAM_UPR (length: 40)
        public string BillFstNam { get; set; } // BILL_FST_NAM (length: 15)
        public string BillFstNamUpr { get; set; } // BILL_FST_NAM_UPR (length: 15)
        public string BillLstNam { get; set; } // BILL_LST_NAM (length: 25)
        public string BillLstNamUpr { get; set; } // BILL_LST_NAM_UPR (length: 25)
        public string BillSalutation { get; set; } // BILL_SALUTATION (length: 10)
        public string BillAdrs1 { get; set; } // BILL_ADRS_1 (length: 40)
        public string BillAdrs2 { get; set; } // BILL_ADRS_2 (length: 40)
        public string BillAdrs3 { get; set; } // BILL_ADRS_3 (length: 40)
        public string BillCity { get; set; } // BILL_CITY (length: 20)
        public string BillState { get; set; } // BILL_STATE (length: 10)
        public string BillZipCod { get; set; } // BILL_ZIP_COD (length: 15)
        public string BillCntry { get; set; } // BILL_CNTRY (length: 20)
        public string BillPhone1 { get; set; } // BILL_PHONE_1 (length: 25)
        public string BillPhone2 { get; set; } // BILL_PHONE_2 (length: 25)
        public string BillNamTyp { get; set; } // BILL_NAM_TYP (length: 1)
        public string BillEmailAdrs1 { get; set; } // BILL_EMAIL_ADRS_1 (length: 50)
        public string BillEmailAdrs2 { get; set; } // BILL_EMAIL_ADRS_2 (length: 50)
        public string BillContct1 { get; set; } // BILL_CONTCT_1 (length: 40)
        public string BillContct2 { get; set; } // BILL_CONTCT_2 (length: 40)
        public string BillFax1 { get; set; } // BILL_FAX_1 (length: 25)
        public string BillFax2 { get; set; } // BILL_FAX_2 (length: 25)
        public string BillFstLstNam { get; set; } // BILL_FST_LST_NAM (length: 42)
        public string ShipNam { get; set; } // SHIP_NAM (length: 40)
        public string ShipFstNam { get; set; } // SHIP_FST_NAM (length: 15)
        public string ShipLstNam { get; set; } // SHIP_LST_NAM (length: 25)
        public string ShipSalutation { get; set; } // SHIP_SALUTATION (length: 10)
        public string ShipAdrs1 { get; set; } // SHIP_ADRS_1 (length: 40)
        public string ShipAdrs2 { get; set; } // SHIP_ADRS_2 (length: 40)
        public string ShipAdrs3 { get; set; } // SHIP_ADRS_3 (length: 40)
        public string ShipCity { get; set; } // SHIP_CITY (length: 20)
        public string ShipState { get; set; } // SHIP_STATE (length: 10)
        public string ShipZipCod { get; set; } // SHIP_ZIP_COD (length: 15)
        public string ShipCntry { get; set; } // SHIP_CNTRY (length: 20)
        public string ShipPhone1 { get; set; } // SHIP_PHONE_1 (length: 25)
        public string ShipPhone2 { get; set; } // SHIP_PHONE_2 (length: 25)
        public string ShipAdrsId { get; set; } // SHIP_ADRS_ID (length: 10)
        public string ShipNamTyp { get; set; } // SHIP_NAM_TYP (length: 1)
        public string ShipEmailAdrs1 { get; set; } // SHIP_EMAIL_ADRS_1 (length: 50)
        public string ShipEmailAdrs2 { get; set; } // SHIP_EMAIL_ADRS_2 (length: 50)
        public string ShipContct1 { get; set; } // SHIP_CONTCT_1 (length: 40)
        public string ShipContct2 { get; set; } // SHIP_CONTCT_2 (length: 40)
        public string ShipFax1 { get; set; } // SHIP_FAX_1 (length: 25)
        public string ShipFax2 { get; set; } // SHIP_FAX_2 (length: 25)
        public string ShipFstLstNam { get; set; } // SHIP_FST_LST_NAM (length: 42)
        public string ProfCod1 { get; set; } // PROF_COD_1 (length: 10)
        public string ProfCod2 { get; set; } // PROF_COD_2 (length: 10)
        public string ProfCod3 { get; set; } // PROF_COD_3 (length: 10)
        public string ProfCod4 { get; set; } // PROF_COD_4 (length: 10)
        public string ProfCod5 { get; set; } // PROF_COD_5 (length: 10)
        public decimal? ProfNo1 { get; set; } // PROF_NO_1
        public decimal? ProfNo2 { get; set; } // PROF_NO_2
        public decimal? ProfNo3 { get; set; } // PROF_NO_3
        public decimal? ProfNo4 { get; set; } // PROF_NO_4
        public decimal? ProfNo5 { get; set; } // PROF_NO_5
        public string ProfAlpha1 { get; set; } // PROF_ALPHA_1 (length: 30)
        public string ProfAlpha2 { get; set; } // PROF_ALPHA_2 (length: 30)
        public string ProfAlpha3 { get; set; } // PROF_ALPHA_3 (length: 30)
        public string ProfAlpha4 { get; set; } // PROF_ALPHA_4 (length: 30)
        public string ProfAlpha5 { get; set; } // PROF_ALPHA_5 (length: 30)
        public DateTime? ProfDat1 { get; set; } // PROF_DAT_1
        public DateTime? ProfDat2 { get; set; } // PROF_DAT_2
        public DateTime? ProfDat3 { get; set; } // PROF_DAT_3
        public DateTime? ProfDat4 { get; set; } // PROF_DAT_4
        public DateTime? ProfDat5 { get; set; } // PROF_DAT_5
        public string OrigOrdStrId { get; set; } // ORIG_ORD_STR_ID (length: 10)
        public string OrigOrdStaId { get; set; } // ORIG_ORD_STA_ID (length: 10)
        public string OrigOrdNo { get; set; } // ORIG_ORD_NO (length: 15)
        public decimal? OrigOrdTot { get; set; } // ORIG_ORD_TOT
        public decimal? OrigOrdAmtDue { get; set; } // ORIG_ORD_AMT_DUE
        public long? OrigOrdDocId { get; set; } // ORIG_ORD_DOC_ID
        public decimal? OrdDepAmtReceived { get; set; } // ORD_DEP_AMT_RECEIVED
        public decimal? OrdDepAmtApplied { get; set; } // ORD_DEP_AMT_APPLIED
        public decimal? OrdDepAmtForfeit { get; set; } // ORD_DEP_AMT_FORFEIT
        public decimal? OrdDepAmtRefunded { get; set; } // ORD_DEP_AMT_REFUNDED
        public decimal? OrdDepNetChange { get; set; } // ORD_DEP_NET_CHANGE
        public decimal? OrdDepBalBefore { get; set; } // ORD_DEP_BAL_BEFORE
        public decimal? OrdDepBalAfter { get; set; } // ORD_DEP_BAL_AFTER
        public DateTime? OrigOrdDat { get; set; } // ORIG_ORD_DAT
        public DateTime? OrigOrdTim { get; set; } // ORIG_ORD_TIM
        public string OrigOrdCancelled { get; set; } // ORIG_ORD_CANCELLED (length: 1)
        public string OrigOrdIsActive { get; set; } // ORIG_ORD_IS_ACTIVE (length: 1)
        public string OrigLwyStrId { get; set; } // ORIG_LWY_STR_ID (length: 10)
        public string OrigLwyStaId { get; set; } // ORIG_LWY_STA_ID (length: 10)
        public string OrigLwyNo { get; set; } // ORIG_LWY_NO (length: 15)
        public decimal? OrigLwyTot { get; set; } // ORIG_LWY_TOT
        public decimal? OrigLwyAmtDue { get; set; } // ORIG_LWY_AMT_DUE
        public long? OrigLwyDocId { get; set; } // ORIG_LWY_DOC_ID
        public decimal? LwyDepAmtReceived { get; set; } // LWY_DEP_AMT_RECEIVED
        public decimal? LwyDepAmtApplied { get; set; } // LWY_DEP_AMT_APPLIED
        public decimal? LwyDepAmtForfeit { get; set; } // LWY_DEP_AMT_FORFEIT
        public decimal? LwyDepAmtRefunded { get; set; } // LWY_DEP_AMT_REFUNDED
        public decimal? LwyDepNetChange { get; set; } // LWY_DEP_NET_CHANGE
        public decimal? LwyDepBalBefore { get; set; } // LWY_DEP_BAL_BEFORE
        public decimal? LwyDepBalAfter { get; set; } // LWY_DEP_BAL_AFTER
        public DateTime? OrigLwyDat { get; set; } // ORIG_LWY_DAT
        public DateTime? OrigLwyTim { get; set; } // ORIG_LWY_TIM
        public string OrigLwyCancelled { get; set; } // ORIG_LWY_CANCELLED (length: 1)
        public string OrigLwyIsActive { get; set; } // ORIG_LWY_IS_ACTIVE (length: 1)
        public string OrigDocStat { get; set; } // ORIG_DOC_STAT (length: 1)
        public decimal? DepAmtReceived { get; set; } // DEP_AMT_RECEIVED
        public decimal? DepAmtApplied { get; set; } // DEP_AMT_APPLIED
        public decimal? DepAmtForfeit { get; set; } // DEP_AMT_FORFEIT
        public decimal? DepAmtRefunded { get; set; } // DEP_AMT_REFUNDED
        public decimal? DepNetChange { get; set; } // DEP_NET_CHANGE
        public decimal? DepBalBefore { get; set; } // DEP_BAL_BEFORE
        public decimal? DepBalAfter { get; set; } // DEP_BAL_AFTER
        public decimal? SalOnlyNetTnd { get; set; } // SAL_ONLY_NET_TND
        public decimal? SalAmtReceived { get; set; } // SAL_AMT_RECEIVED
        public decimal? TotTndAmt { get; set; } // TOT_TND_AMT
        public decimal? SalTotTndAmt { get; set; } // SAL_TOT_TND_AMT
        public string DepOnlyTkt { get; set; } // DEP_ONLY_TKT (length: 1)
        public int? TktDatMon { get; set; } // TKT_DAT_MON
        public int? TktDatWeek { get; set; } // TKT_DAT_WEEK
        public int? TktDatQtr { get; set; } // TKT_DAT_QTR
        public int? TktDatDow { get; set; } // TKT_DAT_DOW
        public int? TktTimHr { get; set; } // TKT_TIM_HR
        public int? TktDatMd { get; set; } // TKT_DAT_MD
        public DateTime? BusDatExt { get; set; } // BUS_DAT_EXT
        public long? DocIdExt { get; set; } // DOC_ID_EXT
        public string UserNicsDros { get; set; } // USER_NICS_DROS (length: 30)
        public string User4473 { get; set; } // USER_4473 (length: 30)
        public string UserFfl { get; set; } // USER_FFL (length: 30)
        public string UserIntrfacdToShip { get; set; } // USER_INTRFACD_TO_SHIP (length: 1)
        public int? UserShipRespStat { get; set; } // USER_SHIP_RESP_STAT
        public string UserShipResp { get; set; } // USER_SHIP_RESP (length: 2147483647)
        public string UserEcommAuthCode { get; set; } // USER_ECOMM_AUTH_CODE (length: 10)
        public string UserEcommOrdNo { get; set; } // USER_ECOMM_ORD_NO (length: 15)
        public string UserEcommReceiptNo { get; set; } // USER_ECOMM_RECEIPT_NO (length: 10)
        public string UserDlData2D { get; set; } // USER_DL_DATA_2D (length: 2147483647)
        public int? E4473SeqNo { get; set; } // E4473_SEQ_NO
        public string E4473FirstName { get; set; } // E4473_FIRST_NAME (length: 256)
        public string E4473MiddleName { get; set; } // E4473_MIDDLE_NAME (length: 256)
        public string E4473LastName { get; set; } // E4473_LAST_NAME (length: 256)
        public string E4473Addrs1 { get; set; } // E4473_ADDRS_1 (length: 256)
        public string E4473Addrs2 { get; set; } // E4473_ADDRS_2 (length: 256)
        public string E4473City { get; set; } // E4473_CITY (length: 256)
        public string E4473County { get; set; } // E4473_COUNTY (length: 256)
        public string E4473State { get; set; } // E4473_STATE (length: 256)
        public string E4473ZipCod { get; set; } // E4473_ZIP_COD (length: 256)
        public string E4473ActivDutyAddrs1 { get; set; } // E4473_ACTIV_DUTY_ADDRS_1 (length: 256)
        public string E4473ActivDutyAddrs2 { get; set; } // E4473_ACTIV_DUTY_ADDRS_2 (length: 256)
        public string E4473ActivDutyCity { get; set; } // E4473_ACTIV_DUTY_CITY (length: 256)
        public string E4473ActivDutyCounty { get; set; } // E4473_ACTIV_DUTY_COUNTY (length: 256)
        public string E4473ActivDutyState { get; set; } // E4473_ACTIV_DUTY_STATE (length: 256)
        public string E4473ActivDutyZipCod { get; set; } // E4473_ACTIV_DUTY_ZIP_COD (length: 256)
        public string E4473Alien { get; set; } // E4473_ALIEN (length: 256)
        public string E4473AlienNum { get; set; } // E4473_ALIEN_NUM (length: 256)
        public string E4473Birthdate { get; set; } // E4473_BIRTHDATE (length: 256)
        public string E4473Citizenship { get; set; } // E4473_CITIZENSHIP (length: 256)
        public string E4473Ethnicity { get; set; } // E4473_ETHNICITY (length: 256)
        public string E4473Gender { get; set; } // E4473_GENDER (length: 256)
        public string E4473HeightFt { get; set; } // E4473_HEIGHT_FT (length: 256)
        public string E4473HeightIn { get; set; } // E4473_HEIGHT_IN (length: 256)
        public string E4473PlaceOfBirthCity { get; set; } // E4473_PLACE_OF_BIRTH_CITY (length: 256)
        public string E4473PlaceOfBirthForeign { get; set; } // E4473_PLACE_OF_BIRTH_FOREIGN (length: 256)
        public string E4473PlaceOfBirthState { get; set; } // E4473_PLACE_OF_BIRTH_STATE (length: 256)
        public string E4473Race { get; set; } // E4473_RACE (length: 256)
        public string E4473ResidenceState { get; set; } // E4473_RESIDENCE_STATE (length: 256)
        public string E4473SocSecNum { get; set; } // E4473_SOC_SEC_NUM (length: 256)
        public string E4473Weight { get; set; } // E4473_WEIGHT (length: 256)
        public string E4473Upin { get; set; } // E4473_UPIN (length: 256)
        public string E4473C11A { get; set; } // E4473_C11A (length: 256)
        public string E4473C11B { get; set; } // E4473_C11B (length: 256)
        public string E4473C11C { get; set; } // E4473_C11C (length: 256)
        public string E4473C11D { get; set; } // E4473_C11D (length: 256)
        public string E4473C11E { get; set; } // E4473_C11E (length: 256)
        public string E4473C11F { get; set; } // E4473_C11F (length: 256)
        public string E4473C11G { get; set; } // E4473_C11G (length: 256)
        public string E4473C11H { get; set; } // E4473_C11H (length: 256)
        public string E4473C11I { get; set; } // E4473_C11I (length: 256)
        public string E4473C11J { get; set; } // E4473_C11J (length: 256)
        public string E4473C11K { get; set; } // E4473_C11K (length: 256)
        public string E4473C11L { get; set; } // E4473_C11L (length: 256)
        public string E4473C12B { get; set; } // E4473_C12B (length: 256)
        public string E4473C12C { get; set; } // E4473_C12C (length: 256)
        public string E4473C12D1 { get; set; } // E4473_C12D1 (length: 256)
        public string E4473C12D2 { get; set; } // E4473_C12D2 (length: 256)
        public byte? UserShippingEasyStat { get; set; } // USER_SHIPPING_EASY_STAT
        public string UserShippingEasyResponse { get; set; } // USER_SHIPPING_EASY_RESPONSE (length: 1000)
        public int? UserShippingEasyId { get; set; } // USER_SHIPPING_EASY_ID
    }

}
// </auto-generated>
