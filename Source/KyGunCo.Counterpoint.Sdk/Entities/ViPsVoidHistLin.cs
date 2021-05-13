// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_VOID_HIST_LIN
    public class ViPsVoidHistLin
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int LinSeqNo { get; set; } // LIN_SEQ_NO
        public int SeqNo { get; set; } // SEQ_NO
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public Guid LinGuid { get; set; } // LIN_GUID
        public string LinTyp { get; set; } // LIN_TYP (length: 1)
        public Guid? LinkLinGuid { get; set; } // LINK_LIN_GUID
        public string Ref { get; set; } // REF (length: 50)
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string RetReas { get; set; } // RET_REAS (length: 10)
        public DateTime PostDat { get; set; } // POST_DAT
        public DateTime? TktDat { get; set; } // TKT_DAT
        public string IsDiscntbl { get; set; } // IS_DISCNTBL (length: 1)
        public string IsManEntdWght { get; set; } // IS_MAN_ENTD_WGHT (length: 1)
        public string IsWeighed { get; set; } // IS_WEIGHED (length: 1)
        public string IsKitPar { get; set; } // IS_KIT_PAR (length: 1)
        public Guid? ParLinGuid { get; set; } // PAR_LIN_GUID
        public string ParItemNo { get; set; } // PAR_ITEM_NO (length: 20)
        public decimal? KitCompQty { get; set; } // KIT_COMP_QTY
        public string KitCompQtyUnitFlg { get; set; } // KIT_COMP_QTY_UNIT_FLG (length: 1)
        public decimal? KitCompUpcharge { get; set; } // KIT_COMP_UPCHARGE
        public string KitCompItemNo { get; set; } // KIT_COMP_ITEM_NO (length: 20)
        public string KitCompDim1Upr { get; set; } // KIT_COMP_DIM_1_UPR (length: 15)
        public string KitCompDim2Upr { get; set; } // KIT_COMP_DIM_2_UPR (length: 15)
        public string KitCompDim3Upr { get; set; } // KIT_COMP_DIM_3_UPR (length: 15)
        public string KitSubsTyp { get; set; } // KIT_SUBS_TYP (length: 1)
        public string KitPrcAdjTyp { get; set; } // KIT_PRC_ADJ_TYP (length: 1)
        public string KitAdjPrcLvl { get; set; } // KIT_ADJ_PRC_LVL (length: 1)
        public string StkLocId { get; set; } // STK_LOC_ID (length: 10)
        public string PrcLocId { get; set; } // PRC_LOC_ID (length: 10)
        public string PftCtr { get; set; } // PFT_CTR (length: 20)
        public string Barcod { get; set; } // BARCOD (length: 20)
        public string RndmWeightBarcod { get; set; } // RNDM_WEIGHT_BARCOD (length: 20)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Descr { get; set; } // DESCR (length: 50)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public string ItemTyp { get; set; } // ITEM_TYP (length: 1)
        public string TrkMeth { get; set; } // TRK_METH (length: 1)
        public string IsFoodStmpElig { get; set; } // IS_FOOD_STMP_ELIG (length: 1)
        public string IsFoodStmpLin { get; set; } // IS_FOOD_STMP_LIN (length: 1)
        public string TareCod { get; set; } // TARE_COD (length: 10)
        public decimal? TareWeight { get; set; } // TARE_WEIGHT
        public int? TareCodIdx { get; set; } // TARE_COD_IDX
        public decimal? UnitWeight { get; set; } // UNIT_WEIGHT
        public decimal? UnitCube { get; set; } // UNIT_CUBE
        public string NormIsTxbl { get; set; } // NORM_IS_TXBL (length: 1)
        public string IsTxbl { get; set; } // IS_TXBL (length: 1)
        public string HasTaxOvrd { get; set; } // HAS_TAX_OVRD (length: 1)
        public string NormTaxCateg { get; set; } // NORM_TAX_CATEG (length: 10)
        public string TaxCateg { get; set; } // TAX_CATEG (length: 10)
        public decimal TaxAmtAlloc { get; set; } // TAX_AMT_ALLOC
        public decimal NormTaxAmtAlloc { get; set; } // NORM_TAX_AMT_ALLOC
        public string TaxCategChngd { get; set; } // TAX_CATEG_CHNGD (length: 1)
        public decimal QtySold { get; set; } // QTY_SOLD
        public decimal QtyNumer { get; set; } // QTY_NUMER
        public decimal QtyDenom { get; set; } // QTY_DENOM
        public string QtyUnit { get; set; } // QTY_UNIT (length: 15)
        public string SellUnit { get; set; } // SELL_UNIT (length: 1)
        public decimal? Prc1 { get; set; } // PRC_1
        public decimal? Prc1Disc { get; set; } // PRC_1_DISC
        public decimal? Prc1DiscPct { get; set; } // PRC_1_DISC_PCT
        public decimal? UnitRetlVal { get; set; } // UNIT_RETL_VAL
        public decimal? UnitRetlValDisc { get; set; } // UNIT_RETL_VAL_DISC
        public decimal? UnitRetlValDiscPct { get; set; } // UNIT_RETL_VAL_DISC_PCT
        public decimal? UnitRetlAtPost { get; set; } // UNIT_RETL_AT_POST
        public decimal? UnitRetlAtPostDisc { get; set; } // UNIT_RETL_AT_POST_DISC
        public decimal? UnitRetlAtPostDiscPct { get; set; } // UNIT_RETL_AT_POST_DISC_PCT
        public decimal? RegPrc { get; set; } // REG_PRC
        public decimal? RegPrcDisc { get; set; } // REG_PRC_DISC
        public decimal? RegPrcDiscPct { get; set; } // REG_PRC_DISC_PCT
        public decimal? CalcPrc { get; set; } // CALC_PRC
        public decimal? CalcPrcDisc { get; set; } // CALC_PRC_DISC
        public decimal? CalcPrcDiscPct { get; set; } // CALC_PRC_DISC_PCT
        public string MixMatchCod { get; set; } // MIX_MATCH_COD (length: 10)
        public decimal? MixMatchContrib { get; set; } // MIX_MATCH_CONTRIB
        public string MixMatchPrcBasedOn { get; set; } // MIX_MATCH_PRC_BASED_ON (length: 1)
        public decimal? Prc { get; set; } // PRC
        public string UsrEntdPrc { get; set; } // USR_ENTD_PRC (length: 1)
        public string HasPrcOvrd { get; set; } // HAS_PRC_OVRD (length: 1)
        public string PrcOvrdReas { get; set; } // PRC_OVRD_REAS (length: 10)
        public decimal? PresumedCost { get; set; } // PRESUMED_COST
        public decimal? CostEntd { get; set; } // COST_ENTD
        public string UseCostEntd { get; set; } // USE_COST_ENTD (length: 1)
        public decimal? Cost { get; set; } // COST
        public decimal? StdCost { get; set; } // STD_COST
        public decimal? TotCostCorr { get; set; } // TOT_COST_CORR
        public decimal? LinLoyPtsEarnd { get; set; } // LIN_LOY_PTS_EARND
        public string LoyPtEarnRulDescr { get; set; } // LOY_PT_EARN_RUL_DESCR (length: 30)
        public int? LoyPtEarnRulSeqNo { get; set; } // LOY_PT_EARN_RUL_SEQ_NO
        public string LoyPtRdmRulDescr { get; set; } // LOY_PT_RDM_RUL_DESCR (length: 30)
        public int? LoyPtRdmRulSeqNo { get; set; } // LOY_PT_RDM_RUL_SEQ_NO
        public decimal? ExtWeight { get; set; } // EXT_WEIGHT
        public decimal? ExtCube { get; set; } // EXT_CUBE
        public decimal? ExtCost { get; set; } // EXT_COST
        public decimal? EstExtCost { get; set; } // EST_EXT_COST
        public decimal GrossExtPrc { get; set; } // GROSS_EXT_PRC
        public decimal? DiscntdExtPrc { get; set; } // DISCNTD_EXT_PRC
        public decimal ExtPrc { get; set; } // EXT_PRC
        public decimal CalcExtPrc { get; set; } // CALC_EXT_PRC
        public decimal? GrossDispExtPrc { get; set; } // GROSS_DISP_EXT_PRC
        public decimal? DiscntdDispExtPrc { get; set; } // DISCNTD_DISP_EXT_PRC
        public decimal? DispExtPrc { get; set; } // DISP_EXT_PRC
        public decimal? LinDiscAmt { get; set; } // LIN_DISC_AMT
        public decimal? HdrDiscAmt { get; set; } // HDR_DISC_AMT
        public string IsSingleCell { get; set; } // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public int? NoOfSersEntd { get; set; } // NO_OF_SERS_ENTD
        public string SerNo { get; set; } // SER_NO (length: 30)
        public string SerDescr { get; set; } // SER_DESCR (length: 53)
        public int? EcSeqNo { get; set; } // EC_SEQ_NO
        public long? GftRgstryId { get; set; } // GFT_RGSTRY_ID
        public string PoPreqNo { get; set; } // PO_PREQ_NO (length: 15)
        public string PoOrdNo { get; set; } // PO_ORD_NO (length: 20)
        public int? PoLinSeqNo { get; set; } // PO_LIN_SEQ_NO
        public string PoRecvrNo { get; set; } // PO_RECVR_NO (length: 15)
        public int? PoRecvrLinSeqNo { get; set; } // PO_RECVR_LIN_SEQ_NO
        public decimal? PoQtyExpectd { get; set; } // PO_QTY_EXPECTD
        public decimal? PoTotQtyRecvd { get; set; } // PO_TOT_QTY_RECVD
        public int? PoRecvrCnt { get; set; } // PO_RECVR_CNT
        public string PoOrdDescr { get; set; } // PO_ORD_DESCR (length: 90)
        public string PoRecvStat { get; set; } // PO_RECV_STAT (length: 1)
        public decimal? PromptNo1 { get; set; } // PROMPT_NO_1
        public string PromptCod1 { get; set; } // PROMPT_COD_1 (length: 10)
        public string PromptAlpha1 { get; set; } // PROMPT_ALPHA_1 (length: 30)
        public DateTime? PromptDat1 { get; set; } // PROMPT_DAT_1
        public string Prompt1Str { get; set; } // PROMPT_1_STR (length: 30)
        public decimal? PromptNo2 { get; set; } // PROMPT_NO_2
        public string PromptCod2 { get; set; } // PROMPT_COD_2 (length: 10)
        public string PromptAlpha2 { get; set; } // PROMPT_ALPHA_2 (length: 30)
        public DateTime? PromptDat2 { get; set; } // PROMPT_DAT_2
        public string Prompt2Str { get; set; } // PROMPT_2_STR (length: 30)
        public decimal? PromptNo3 { get; set; } // PROMPT_NO_3
        public string PromptCod3 { get; set; } // PROMPT_COD_3 (length: 10)
        public string PromptAlpha3 { get; set; } // PROMPT_ALPHA_3 (length: 30)
        public DateTime? PromptDat3 { get; set; } // PROMPT_DAT_3
        public string Prompt3Str { get; set; } // PROMPT_3_STR (length: 30)
        public DateTime? BusDatExt { get; set; } // BUS_DAT_EXT
        public long? DocIdExt { get; set; } // DOC_ID_EXT
        public int? LinSeqNoExt { get; set; } // LIN_SEQ_NO_EXT
        public decimal? UserBuybackPrc { get; set; } // USER_BUYBACK_PRC
        public string UserBuybackTradeinItemNo { get; set; } // USER_BUYBACK_TRADEIN_ITEM_NO (length: 20)
        public string UserBuybackTradeinDescr { get; set; } // USER_BUYBACK_TRADEIN_DESCR (length: 30)
        public string UserBuybackTradeinSerNo { get; set; } // USER_BUYBACK_TRADEIN_SER_NO (length: 30)
        public string UserBuybackTradeinItemNote { get; set; } // USER_BUYBACK_TRADEIN_ITEM_NOTE (length: 2147483647)
        public decimal? UserTradeinBuybackExtCost { get; set; } // USER_TRADEIN_BUYBACK_EXT_COST
        public string UserBuybackTradeinTrxType { get; set; } // USER_BUYBACK_TRADEIN_TRX_TYPE (length: 10)
        public decimal? UserBuybackTradeinConsideration { get; set; } // USER_BUYBACK_TRADEIN_CONSIDERATION
        public string UserBuybackTradeinRecvrNo { get; set; } // USER_BUYBACK_TRADEIN_RECVR_NO (length: 15)
        public int? UserBuybackTradeinRecvrLinSeqNo { get; set; } // USER_BUYBACK_TRADEIN_RECVR_LIN_SEQ_NO
        public string UserTradeinBuybackProcessed { get; set; } // USER_TRADEIN_BUYBACK_PROCESSED (length: 1)
        public string UserTradeInProcessed { get; set; } // USER_TRADE_IN_PROCESSED (length: 1)
        public string UserConsignmentItemNo { get; set; } // USER_CONSIGNMENT_ITEM_NO (length: 20)
        public string UserConsignmentDescr { get; set; } // USER_CONSIGNMENT_DESCR (length: 30)
        public string UserConsignmentSerNo { get; set; } // USER_CONSIGNMENT_SER_NO (length: 30)
        public string UserConsignmentItemNote { get; set; } // USER_CONSIGNMENT_ITEM_NOTE (length: 2147483647)
        public decimal? UserConsignmentExtCost { get; set; } // USER_CONSIGNMENT_EXT_COST
        public string UserConsignmentTrxType { get; set; } // USER_CONSIGNMENT_TRX_TYPE (length: 10)
        public decimal? UserConsignmentConsideration { get; set; } // USER_CONSIGNMENT_CONSIDERATION
        public string UserConsignmentRecvrNo { get; set; } // USER_CONSIGNMENT_RECVR_NO (length: 15)
        public int? UserConsignmentRecvrLinSeqNo { get; set; } // USER_CONSIGNMENT_RECVR_LIN_SEQ_NO
        public string UserConsignmentProcessed { get; set; } // USER_CONSIGNMENT_PROCESSED (length: 1)
        public string UserConsignmentPayoutItemNo { get; set; } // USER_CONSIGNMENT_PAYOUT_ITEM_NO (length: 20)
        public string UserConsignmentPayoutLocId { get; set; } // USER_CONSIGNMENT_PAYOUT_LOC_ID (length: 10)
        public string UserConsignmentPayoutSerNo { get; set; } // USER_CONSIGNMENT_PAYOUT_SER_NO (length: 30)
        public DateTime? UserConsignmentPayoutRecvdDt { get; set; } // USER_CONSIGNMENT_PAYOUT_RECVD_DT
        public int? UserRentalAmmoCount { get; set; } // USER_RENTAL_AMMO_COUNT
        public string UserIntakeType { get; set; } // USER_INTAKE_TYPE (length: 15)
        public string UserIntakeDocNo { get; set; } // USER_INTAKE_DOC_NO (length: 15)
    }

}
// </auto-generated>