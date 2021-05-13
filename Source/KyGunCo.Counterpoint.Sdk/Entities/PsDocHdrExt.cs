// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DOC_HDR_EXT
    public class PsDocHdrExt
    {
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public string UserNicsDros { get; set; } // USER_NICS_DROS (length: 30)
        public string User4473 { get; set; } // USER_4473 (length: 30)
        public string UserFfl { get; set; } // USER_FFL (length: 30)
        public string UserDlData2D { get; set; } // USER_DL_DATA_2D (length: 2147483647)
        public string UserIntrfacdToShip { get; set; } // USER_INTRFACD_TO_SHIP (length: 1)
        public int? UserShipRespStat { get; set; } // USER_SHIP_RESP_STAT
        public string UserShipResp { get; set; } // USER_SHIP_RESP (length: 2147483647)
        public string UserEcommAuthCode { get; set; } // USER_ECOMM_AUTH_CODE (length: 10)
        public string UserEcommOrdNo { get; set; } // USER_ECOMM_ORD_NO (length: 15)
        public string UserEcommReceiptNo { get; set; } // USER_ECOMM_RECEIPT_NO (length: 10)
        public DateTime? TktDat { get; set; } // TKT_DAT
        public DateTime? TktTim { get; set; } // TKT_TIM
        public int? TktTimHr { get; set; } // TKT_TIM_HR
        public string TaxCodChngd { get; set; } // TAX_COD_CHNGD (length: 1)
        public decimal? FoodStmpTaxAmt { get; set; } // FOOD_STMP_TAX_AMT
        public int? HdrDiscs { get; set; } // HDR_DISCS
        public string HdrDiscCod { get; set; } // HDR_DISC_COD (length: 10)
        public int? SalLins { get; set; } // SAL_LINS
        public decimal? SalLinTot { get; set; } // SAL_LIN_TOT
        public int? RetLins { get; set; } // RET_LINS
        public decimal? RetLinTot { get; set; } // RET_LIN_TOT
        public int? GfcLins { get; set; } // GFC_LINS
        public int? SvcLins { get; set; } // SVC_LINS
        public string SalHasTaxOvrd { get; set; } // SAL_HAS_TAX_OVRD (length: 1)
        public int? SalTaxOvrdLins { get; set; } // SAL_TAX_OVRD_LINS
        public decimal? SalGrossSubTot { get; set; } // SAL_GROSS_SUB_TOT
        public decimal? SalSubTot { get; set; } // SAL_SUB_TOT
        public decimal? SalTotHdrDiscntblAmt { get; set; } // SAL_TOT_HDR_DISCNTBL_AMT
        public decimal? SalTotHdrDisc { get; set; } // SAL_TOT_HDR_DISC
        public decimal? SalTotLinDisc { get; set; } // SAL_TOT_LIN_DISC
        public decimal? SalTotDisc { get; set; } // SAL_TOT_DISC
        public decimal? SalTotEstCost { get; set; } // SAL_TOT_EST_COST
        public decimal? SalTotExtCost { get; set; } // SAL_TOT_EXT_COST
        public decimal? SalTotWeight { get; set; } // SAL_TOT_WEIGHT
        public decimal? SalTotCube { get; set; } // SAL_TOT_CUBE
        public decimal? SalTotGfcAmt { get; set; } // SAL_TOT_GFC_AMT
        public decimal? SalTotSvcAmt { get; set; } // SAL_TOT_SVC_AMT
        public decimal? SalTotMisc { get; set; } // SAL_TOT_MISC
        public decimal? SalNormTaxAmt { get; set; } // SAL_NORM_TAX_AMT
        public decimal? SalTaxAmt { get; set; } // SAL_TAX_AMT
        public decimal? SalTotTnd { get; set; } // SAL_TOT_TND
        public decimal? SalTotChng { get; set; } // SAL_TOT_CHNG
        public decimal? SalNetTnd { get; set; } // SAL_NET_TND
        public decimal? SalTot { get; set; } // SAL_TOT
        public decimal? SalAmtDue { get; set; } // SAL_AMT_DUE
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
        public int? OrdLins { get; set; } // ORD_LINS
        public int? BoLins { get; set; } // BO_LINS
        public int? SoLins { get; set; } // SO_LINS
        public int? DsLins { get; set; } // DS_LINS
        public string HasEntdLins { get; set; } // HAS_ENTD_LINS (length: 1)
        public string HasPckdLins { get; set; } // HAS_PCKD_LINS (length: 1)
        public string HasPckvrfdLins { get; set; } // HAS_PCKVRFD_LINS (length: 1)
        public string HasInvcdLins { get; set; } // HAS_INVCD_LINS (length: 1)
        public string HasRlsdLins { get; set; } // HAS_RLSD_LINS (length: 1)
        public string OrdHasTaxOvrd { get; set; } // ORD_HAS_TAX_OVRD (length: 1)
        public int? OrdTaxOvrdLins { get; set; } // ORD_TAX_OVRD_LINS
        public decimal? OrdGrossSubTot { get; set; } // ORD_GROSS_SUB_TOT
        public decimal? OrdSubTot { get; set; } // ORD_SUB_TOT
        public decimal? OrdTotHdrDiscntblAmt { get; set; } // ORD_TOT_HDR_DISCNTBL_AMT
        public decimal? OrdTotHdrDisc { get; set; } // ORD_TOT_HDR_DISC
        public decimal? OrdTotLinDisc { get; set; } // ORD_TOT_LIN_DISC
        public decimal? OrdTotDisc { get; set; } // ORD_TOT_DISC
        public decimal? OrdTotEstCost { get; set; } // ORD_TOT_EST_COST
        public decimal? OrdTotExtCost { get; set; } // ORD_TOT_EXT_COST
        public decimal? OrdTotWeight { get; set; } // ORD_TOT_WEIGHT
        public decimal? OrdTotCube { get; set; } // ORD_TOT_CUBE
        public decimal? OrdTotMisc { get; set; } // ORD_TOT_MISC
        public decimal? OrdNormTaxAmt { get; set; } // ORD_NORM_TAX_AMT
        public decimal? OrdTaxAmt { get; set; } // ORD_TAX_AMT
        public decimal? OrdTaxAmtShipped { get; set; } // ORD_TAX_AMT_SHIPPED
        public decimal? OrdTot { get; set; } // ORD_TOT
        public decimal? OrdInitialMinDue { get; set; } // ORD_INITIAL_MIN_DUE
        public decimal? OrdTotTnd { get; set; } // ORD_TOT_TND
        public decimal? OrdTotChng { get; set; } // ORD_TOT_CHNG
        public decimal? OrdNetTnd { get; set; } // ORD_NET_TND
        public decimal? OrdAmtDue { get; set; } // ORD_AMT_DUE
        public decimal? ToRelGrossSubTot { get; set; } // TO_REL_GROSS_SUB_TOT
        public decimal? ToRelSubTot { get; set; } // TO_REL_SUB_TOT
        public decimal? ToRelTotHdrDiscntblAmt { get; set; } // TO_REL_TOT_HDR_DISCNTBL_AMT
        public decimal? ToRelTotHdrDisc { get; set; } // TO_REL_TOT_HDR_DISC
        public decimal? ToRelTotLinDisc { get; set; } // TO_REL_TOT_LIN_DISC
        public decimal? ToRelTotDisc { get; set; } // TO_REL_TOT_DISC
        public decimal? ToRelTotEstCost { get; set; } // TO_REL_TOT_EST_COST
        public decimal? ToRelTotWeight { get; set; } // TO_REL_TOT_WEIGHT
        public decimal? ToRelTotCube { get; set; } // TO_REL_TOT_CUBE
        public decimal? ToRelTotMisc { get; set; } // TO_REL_TOT_MISC
        public decimal? ToRelNormTaxAmt { get; set; } // TO_REL_NORM_TAX_AMT
        public decimal? ToRelTaxAmt { get; set; } // TO_REL_TAX_AMT
        public decimal? ToRelTaxAmtShipped { get; set; } // TO_REL_TAX_AMT_SHIPPED
        public decimal? ToRelTot { get; set; } // TO_REL_TOT
        public decimal? ToLeaveGrossSubTot { get; set; } // TO_LEAVE_GROSS_SUB_TOT
        public decimal? ToLeaveSubTot { get; set; } // TO_LEAVE_SUB_TOT
        public decimal? ToLeaveTotHdrDiscntblAmt { get; set; } // TO_LEAVE_TOT_HDR_DISCNTBL_AMT
        public decimal? ToLeaveTotHdrDisc { get; set; } // TO_LEAVE_TOT_HDR_DISC
        public decimal? ToLeaveTotLinDisc { get; set; } // TO_LEAVE_TOT_LIN_DISC
        public decimal? ToLeaveTotDisc { get; set; } // TO_LEAVE_TOT_DISC
        public decimal? ToLeaveTotEstCost { get; set; } // TO_LEAVE_TOT_EST_COST
        public decimal? ToLeaveTotWeight { get; set; } // TO_LEAVE_TOT_WEIGHT
        public decimal? ToLeaveTotCube { get; set; } // TO_LEAVE_TOT_CUBE
        public decimal? ToLeaveTotMisc { get; set; } // TO_LEAVE_TOT_MISC
        public decimal? ToLeaveNormTaxAmt { get; set; } // TO_LEAVE_NORM_TAX_AMT
        public decimal? ToLeaveTaxAmt { get; set; } // TO_LEAVE_TAX_AMT
        public decimal? ToLeaveTaxAmtShipped { get; set; } // TO_LEAVE_TAX_AMT_SHIPPED
        public decimal? ToLeaveTot { get; set; } // TO_LEAVE_TOT
        public string OrdMiscTyp1 { get; set; } // ORD_MISC_TYP_1 (length: 1)
        public decimal? OrdMiscAmt1 { get; set; } // ORD_MISC_AMT_1
        public decimal? OrdMiscPct1 { get; set; } // ORD_MISC_PCT_1
        public decimal? OrdMiscAmt1Shipped { get; set; } // ORD_MISC_AMT_1_SHIPPED
        public string OrdMiscTyp2 { get; set; } // ORD_MISC_TYP_2 (length: 1)
        public decimal? OrdMiscAmt2 { get; set; } // ORD_MISC_AMT_2
        public decimal? OrdMiscPct2 { get; set; } // ORD_MISC_PCT_2
        public decimal? OrdMiscAmt2Shipped { get; set; } // ORD_MISC_AMT_2_SHIPPED
        public string OrdMiscTyp3 { get; set; } // ORD_MISC_TYP_3 (length: 1)
        public decimal? OrdMiscAmt3 { get; set; } // ORD_MISC_AMT_3
        public decimal? OrdMiscPct3 { get; set; } // ORD_MISC_PCT_3
        public decimal? OrdMiscAmt3Shipped { get; set; } // ORD_MISC_AMT_3_SHIPPED
        public string OrdMiscTyp4 { get; set; } // ORD_MISC_TYP_4 (length: 1)
        public decimal? OrdMiscAmt4 { get; set; } // ORD_MISC_AMT_4
        public decimal? OrdMiscPct4 { get; set; } // ORD_MISC_PCT_4
        public decimal? OrdMiscAmt4Shipped { get; set; } // ORD_MISC_AMT_4_SHIPPED
        public string OrdMiscTyp5 { get; set; } // ORD_MISC_TYP_5 (length: 1)
        public decimal? OrdMiscAmt5 { get; set; } // ORD_MISC_AMT_5
        public decimal? OrdMiscPct5 { get; set; } // ORD_MISC_PCT_5
        public decimal? OrdMiscAmt5Shipped { get; set; } // ORD_MISC_AMT_5_SHIPPED
        public string ToRelMiscTyp1 { get; set; } // TO_REL_MISC_TYP_1 (length: 1)
        public decimal? ToRelMiscAmt1 { get; set; } // TO_REL_MISC_AMT_1
        public decimal? ToRelMiscPct1 { get; set; } // TO_REL_MISC_PCT_1
        public string ToRelMiscTyp2 { get; set; } // TO_REL_MISC_TYP_2 (length: 1)
        public decimal? ToRelMiscAmt2 { get; set; } // TO_REL_MISC_AMT_2
        public decimal? ToRelMiscPct2 { get; set; } // TO_REL_MISC_PCT_2
        public string ToRelMiscTyp3 { get; set; } // TO_REL_MISC_TYP_3 (length: 1)
        public decimal? ToRelMiscAmt3 { get; set; } // TO_REL_MISC_AMT_3
        public decimal? ToRelMiscPct3 { get; set; } // TO_REL_MISC_PCT_3
        public string ToRelMiscTyp4 { get; set; } // TO_REL_MISC_TYP_4 (length: 1)
        public decimal? ToRelMiscAmt4 { get; set; } // TO_REL_MISC_AMT_4
        public decimal? ToRelMiscPct4 { get; set; } // TO_REL_MISC_PCT_4
        public string ToRelMiscTyp5 { get; set; } // TO_REL_MISC_TYP_5 (length: 1)
        public decimal? ToRelMiscAmt5 { get; set; } // TO_REL_MISC_AMT_5
        public decimal? ToRelMiscPct5 { get; set; } // TO_REL_MISC_PCT_5
        public string ToLeaveMiscTyp1 { get; set; } // TO_LEAVE_MISC_TYP_1 (length: 1)
        public decimal? ToLeaveMiscAmt1 { get; set; } // TO_LEAVE_MISC_AMT_1
        public decimal? ToLeaveMiscPct1 { get; set; } // TO_LEAVE_MISC_PCT_1
        public string ToLeaveMiscTyp2 { get; set; } // TO_LEAVE_MISC_TYP_2 (length: 1)
        public decimal? ToLeaveMiscAmt2 { get; set; } // TO_LEAVE_MISC_AMT_2
        public decimal? ToLeaveMiscPct2 { get; set; } // TO_LEAVE_MISC_PCT_2
        public string ToLeaveMiscTyp3 { get; set; } // TO_LEAVE_MISC_TYP_3 (length: 1)
        public decimal? ToLeaveMiscAmt3 { get; set; } // TO_LEAVE_MISC_AMT_3
        public decimal? ToLeaveMiscPct3 { get; set; } // TO_LEAVE_MISC_PCT_3
        public string ToLeaveMiscTyp4 { get; set; } // TO_LEAVE_MISC_TYP_4 (length: 1)
        public decimal? ToLeaveMiscAmt4 { get; set; } // TO_LEAVE_MISC_AMT_4
        public decimal? ToLeaveMiscPct4 { get; set; } // TO_LEAVE_MISC_PCT_4
        public string ToLeaveMiscTyp5 { get; set; } // TO_LEAVE_MISC_TYP_5 (length: 1)
        public decimal? ToLeaveMiscAmt5 { get; set; } // TO_LEAVE_MISC_AMT_5
        public decimal? ToLeaveMiscPct5 { get; set; } // TO_LEAVE_MISC_PCT_5
        public int? LwyLins { get; set; } // LWY_LINS
        public string LwyHasTaxOvrd { get; set; } // LWY_HAS_TAX_OVRD (length: 1)
        public int? LwyTaxOvrdLins { get; set; } // LWY_TAX_OVRD_LINS
        public decimal? LwyGrossSubTot { get; set; } // LWY_GROSS_SUB_TOT
        public decimal? LwySubTot { get; set; } // LWY_SUB_TOT
        public decimal? LwyTotHdrDiscntblAmt { get; set; } // LWY_TOT_HDR_DISCNTBL_AMT
        public decimal? LwyTotHdrDisc { get; set; } // LWY_TOT_HDR_DISC
        public decimal? LwyTotLinDisc { get; set; } // LWY_TOT_LIN_DISC
        public decimal? LwyTotDisc { get; set; } // LWY_TOT_DISC
        public decimal? LwyTotEstCost { get; set; } // LWY_TOT_EST_COST
        public decimal? LwyTotExtCost { get; set; } // LWY_TOT_EXT_COST
        public decimal? LwyTotWeight { get; set; } // LWY_TOT_WEIGHT
        public decimal? LwyTotCube { get; set; } // LWY_TOT_CUBE
        public decimal? LwyTotMisc { get; set; } // LWY_TOT_MISC
        public decimal? LwyNormTaxAmt { get; set; } // LWY_NORM_TAX_AMT
        public decimal? LwyTaxAmt { get; set; } // LWY_TAX_AMT
        public decimal? LwyTaxAmtShipped { get; set; } // LWY_TAX_AMT_SHIPPED
        public decimal? LwyTot { get; set; } // LWY_TOT
        public decimal? LwyInitialMinDue { get; set; } // LWY_INITIAL_MIN_DUE
        public decimal? LwyTotTnd { get; set; } // LWY_TOT_TND
        public decimal? LwyTotChng { get; set; } // LWY_TOT_CHNG
        public decimal? LwyNetTnd { get; set; } // LWY_NET_TND
        public decimal? LwyAmtDue { get; set; } // LWY_AMT_DUE
        public string LwyMiscTyp1 { get; set; } // LWY_MISC_TYP_1 (length: 1)
        public decimal? LwyMiscAmt1 { get; set; } // LWY_MISC_AMT_1
        public decimal? LwyMiscPct1 { get; set; } // LWY_MISC_PCT_1
        public decimal? LwyMiscAmt1Shipped { get; set; } // LWY_MISC_AMT_1_SHIPPED
        public string LwyMiscTyp2 { get; set; } // LWY_MISC_TYP_2 (length: 1)
        public decimal? LwyMiscAmt2 { get; set; } // LWY_MISC_AMT_2
        public decimal? LwyMiscPct2 { get; set; } // LWY_MISC_PCT_2
        public decimal? LwyMiscAmt2Shipped { get; set; } // LWY_MISC_AMT_2_SHIPPED
        public string LwyMiscTyp3 { get; set; } // LWY_MISC_TYP_3 (length: 1)
        public decimal? LwyMiscAmt3 { get; set; } // LWY_MISC_AMT_3
        public decimal? LwyMiscPct3 { get; set; } // LWY_MISC_PCT_3
        public decimal? LwyMiscAmt3Shipped { get; set; } // LWY_MISC_AMT_3_SHIPPED
        public string LwyMiscTyp4 { get; set; } // LWY_MISC_TYP_4 (length: 1)
        public decimal? LwyMiscAmt4 { get; set; } // LWY_MISC_AMT_4
        public decimal? LwyMiscPct4 { get; set; } // LWY_MISC_PCT_4
        public decimal? LwyMiscAmt4Shipped { get; set; } // LWY_MISC_AMT_4_SHIPPED
        public string LwyMiscTyp5 { get; set; } // LWY_MISC_TYP_5 (length: 1)
        public decimal? LwyMiscAmt5 { get; set; } // LWY_MISC_AMT_5
        public decimal? LwyMiscPct5 { get; set; } // LWY_MISC_PCT_5
        public decimal? LwyMiscAmt5Shipped { get; set; } // LWY_MISC_AMT_5_SHIPPED
        public int? Lins { get; set; } // LINS
        public int? TaxOvrdLins { get; set; } // TAX_OVRD_LINS
        public decimal? GrossSubTot { get; set; } // GROSS_SUB_TOT
        public decimal? SubTot { get; set; } // SUB_TOT
        public decimal? TotHdrDiscntblAmt { get; set; } // TOT_HDR_DISCNTBL_AMT
        public decimal? TotHdrDisc { get; set; } // TOT_HDR_DISC
        public decimal? TotLinDisc { get; set; } // TOT_LIN_DISC
        public decimal? TotDisc { get; set; } // TOT_DISC
        public decimal? TotEstCost { get; set; } // TOT_EST_COST
        public decimal? TotExtCost { get; set; } // TOT_EXT_COST
        public decimal? TotWeight { get; set; } // TOT_WEIGHT
        public decimal? TotCube { get; set; } // TOT_CUBE
        public decimal? TotMisc { get; set; } // TOT_MISC
        public decimal? NormTaxAmt { get; set; } // NORM_TAX_AMT
        public decimal? TaxAmt { get; set; } // TAX_AMT
        public decimal? Tot { get; set; } // TOT
        public decimal? TotTnd { get; set; } // TOT_TND
        public decimal? TotChng { get; set; } // TOT_CHNG
        public decimal? NetTnd { get; set; } // NET_TND
        public decimal? AmtDue { get; set; } // AMT_DUE
        public decimal? MiscAmt1 { get; set; } // MISC_AMT_1
        public decimal? MiscPct1 { get; set; } // MISC_PCT_1
        public decimal? MiscAmt2 { get; set; } // MISC_AMT_2
        public decimal? MiscPct2 { get; set; } // MISC_PCT_2
        public decimal? MiscAmt3 { get; set; } // MISC_AMT_3
        public decimal? MiscPct3 { get; set; } // MISC_PCT_3
        public decimal? MiscAmt4 { get; set; } // MISC_AMT_4
        public decimal? MiscPct4 { get; set; } // MISC_PCT_4
        public decimal? MiscAmt5 { get; set; } // MISC_AMT_5
        public decimal? MiscPct5 { get; set; } // MISC_PCT_5
        public string DocDescr { get; set; } // DOC_DESCR (length: 30)
        public string PayAcctNo { get; set; } // PAY_ACCT_NO (length: 20)
        public string ApplyToDocNo { get; set; } // APPLY_TO_DOC_NO (length: 15)
        public DateTime? ApplyToDocDat { get; set; } // APPLY_TO_DOC_DAT
        public string ApplyToDocTyp { get; set; } // APPLY_TO_DOC_TYP (length: 1)
        public string PayApplyMeth { get; set; } // PAY_APPLY_METH (length: 1)
        public decimal? PayAmt { get; set; } // PAY_AMT
        public decimal? AbsPayAmt { get; set; } // ABS_PAY_AMT
        public string OrigQuotStrId { get; set; } // ORIG_QUOT_STR_ID (length: 10)
        public string OrigQuotStaId { get; set; } // ORIG_QUOT_STA_ID (length: 10)
        public string OrigQuotNo { get; set; } // ORIG_QUOT_NO (length: 15)
        public DateTime? QuotExpDat { get; set; } // QUOT_EXP_DAT
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
        public string BillFstLstNam { get; set; } // BILL_FST_LST_NAM (length: 40)
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
        public string ShipFstLstNam { get; set; } // SHIP_FST_LST_NAM (length: 40)
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
        public string IsOrder { get; set; } // IS_ORDER (length: 1)
        public decimal? SalAmtReceived { get; set; } // SAL_AMT_RECEIVED
        public decimal? TotTndAmt { get; set; } // TOT_TND_AMT
        public decimal? SalTotTndAmt { get; set; } // SAL_TOT_TND_AMT
        public decimal? SalOnlyNetTnd { get; set; } // SAL_ONLY_NET_TND
        public string DepOnlyTkt { get; set; } // DEP_ONLY_TKT (length: 1)
        public string UserOrigDocGuid { get; set; } // USER_ORIG_DOC_GUID (length: 500)
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
        public string UserIsLayaway { get; set; } = "N"; // USER_IS_LAYAWAY (length: 1)
        public string UserIsClass3 { get; set; } = "N"; // USER_IS_CLASS_3 (length: 1)

        // Foreign keys

        /// <summary>
        /// Parent PsDocHdr pointed by [PS_DOC_HDR_EXT].([DocIdExt]) (FK_PS_DOC_HDR_EXT_PS_DOC_HDR)
        /// </summary>
        public virtual PsDocHdr PsDocHdr { get; set; } // FK_PS_DOC_HDR_EXT_PS_DOC_HDR
    }

}
// </auto-generated>