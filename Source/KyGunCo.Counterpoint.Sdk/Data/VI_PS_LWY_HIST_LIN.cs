// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace KyGunCo.Counterpoint.Sdk.Data
{
    using System;
    using ServiceStack.DataAnnotations;
    using ServiceStack.Model;
    using ServiceStack;

    public partial class VI_PS_LWY_HIST_LIN 
    {
        [Required]
        public DateTime BUS_DAT { get; set; }
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int LIN_SEQ_NO { get; set; }
        [Required]
        public int SEQ_NO { get; set; }
        [Required]
        public string EVENT_NO { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string STA_ID { get; set; }
        [Required]
        public string TKT_NO { get; set; }
        [Required]
        public Guid LIN_GUID { get; set; }
        [Required]
        public string LIN_TYP { get; set; }
        public Guid? LINK_LIN_GUID { get; set; }
        public string REF { get; set; }
        public string SLS_REP { get; set; }
        [Required]
        public DateTime POST_DAT { get; set; }
        public DateTime? TKT_DAT { get; set; }
        [Required]
        public string IS_DISCNTBL { get; set; }
        [Required]
        public string IS_MAN_ENTD_WGHT { get; set; }
        [Required]
        public string IS_WEIGHED { get; set; }
        [Required]
        public string IS_KIT_PAR { get; set; }
        public Guid? PAR_LIN_GUID { get; set; }
        public string PAR_ITEM_NO { get; set; }
        public decimal? KIT_COMP_QTY { get; set; }
        public string KIT_COMP_QTY_UNIT_FLG { get; set; }
        public decimal? KIT_COMP_UPCHARGE { get; set; }
        public string KIT_COMP_ITEM_NO { get; set; }
        public string KIT_COMP_DIM_1_UPR { get; set; }
        public string KIT_COMP_DIM_2_UPR { get; set; }
        public string KIT_COMP_DIM_3_UPR { get; set; }
        public string KIT_SUBS_TYP { get; set; }
        public string KIT_PRC_ADJ_TYP { get; set; }
        public string KIT_ADJ_PRC_LVL { get; set; }
        public string STK_LOC_ID { get; set; }
        public string PRC_LOC_ID { get; set; }
        public string PFT_CTR { get; set; }
        public string BARCOD { get; set; }
        public string RNDM_WEIGHT_BARCOD { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        public string DESCR { get; set; }
        public string CATEG_COD { get; set; }
        public string SUBCAT_COD { get; set; }
        public string ITEM_VEND_NO { get; set; }
        [Required]
        public string ITEM_TYP { get; set; }
        [Required]
        public string TRK_METH { get; set; }
        public string TARE_COD { get; set; }
        public decimal? TARE_WEIGHT { get; set; }
        public int? TARE_COD_IDX { get; set; }
        public decimal? UNIT_WEIGHT { get; set; }
        public decimal? UNIT_CUBE { get; set; }
        [Required]
        public string NORM_IS_TXBL { get; set; }
        [Required]
        public string IS_TXBL { get; set; }
        [Required]
        public string HAS_TAX_OVRD { get; set; }
        public string NORM_TAX_CATEG { get; set; }
        public string TAX_CATEG { get; set; }
        [Required]
        public decimal TAX_AMT_ALLOC { get; set; }
        [Required]
        public decimal NORM_TAX_AMT_ALLOC { get; set; }
        [Required]
        public string TAX_CATEG_CHNGD { get; set; }
        [Required]
        public decimal QTY_SOLD { get; set; }
        [Required]
        public decimal QTY_NUMER { get; set; }
        [Required]
        public decimal QTY_DENOM { get; set; }
        public string QTY_UNIT { get; set; }
        [Required]
        public string SELL_UNIT { get; set; }
        [Required]
        public decimal ORIG_QTY { get; set; }
        [Required]
        public decimal QTY_SHIPPED { get; set; }
        public decimal? PRC_1 { get; set; }
        public decimal? PRC_1_DISC { get; set; }
        public decimal? PRC_1_DISC_PCT { get; set; }
        public decimal? UNIT_RETL_VAL { get; set; }
        public decimal? UNIT_RETL_VAL_DISC { get; set; }
        public decimal? UNIT_RETL_VAL_DISC_PCT { get; set; }
        public decimal? UNIT_RETL_AT_POST { get; set; }
        public decimal? REG_PRC { get; set; }
        public decimal? REG_PRC_DISC { get; set; }
        public decimal? REG_PRC_DISC_PCT { get; set; }
        public decimal? CALC_PRC { get; set; }
        public decimal? CALC_PRC_DISC { get; set; }
        public decimal? CALC_PRC_DISC_PCT { get; set; }
        public string MIX_MATCH_COD { get; set; }
        public decimal? MIX_MATCH_CONTRIB { get; set; }
        [Required]
        public string MIX_MATCH_PRC_BASED_ON { get; set; }
        public decimal? PRC { get; set; }
        [Required]
        public string USR_ENTD_PRC { get; set; }
        [Required]
        public string HAS_PRC_OVRD { get; set; }
        public string PRC_OVRD_REAS { get; set; }
        public decimal? PRESUMED_COST { get; set; }
        public decimal? COST_ENTD { get; set; }
        [Required]
        public string USE_COST_ENTD { get; set; }
        public decimal? COST { get; set; }
        public decimal? STD_COST { get; set; }
        public decimal? TOT_COST_CORR { get; set; }
        public decimal? EXT_WEIGHT { get; set; }
        public decimal? EXT_CUBE { get; set; }
        public decimal? EXT_COST { get; set; }
        public decimal? EST_EXT_COST { get; set; }
        [Required]
        public decimal GROSS_EXT_PRC { get; set; }
        public decimal? DISCNTD_EXT_PRC { get; set; }
        [Required]
        public decimal EXT_PRC { get; set; }
        [Required]
        public decimal CALC_EXT_PRC { get; set; }
        public decimal? GROSS_DISP_EXT_PRC { get; set; }
        public decimal? DISCNTD_DISP_EXT_PRC { get; set; }
        public decimal? DISP_EXT_PRC { get; set; }
        public decimal? LIN_DISC_AMT { get; set; }
        public decimal? HDR_DISC_AMT { get; set; }
        [Required]
        public string IS_SINGLE_CELL { get; set; }
        public string DIM_1_UPR { get; set; }
        public string DIM_2_UPR { get; set; }
        public string DIM_3_UPR { get; set; }
        public string CELL_DESCR { get; set; }
        public int? NO_OF_SERS_ENTD { get; set; }
        public string SER_NO { get; set; }
        public string SER_DESCR { get; set; }
        public long? GFT_RGSTRY_ID { get; set; }
        public string PO_PREQ_NO { get; set; }
        public string PO_ORD_NO { get; set; }
        public int? PO_LIN_SEQ_NO { get; set; }
        public string PO_RECVR_NO { get; set; }
        public int? PO_RECVR_LIN_SEQ_NO { get; set; }
        public decimal? PO_QTY_EXPECTD { get; set; }
        public decimal? PO_TOT_QTY_RECVD { get; set; }
        public int? PO_RECVR_CNT { get; set; }
        public string PO_ORD_DESCR { get; set; }
        public string PO_RECV_STAT { get; set; }
        public decimal? PROMPT_NO_1 { get; set; }
        public string PROMPT_COD_1 { get; set; }
        public string PROMPT_ALPHA_1 { get; set; }
        public DateTime? PROMPT_DAT_1 { get; set; }
        public string PROMPT_1_STR { get; set; }
        public decimal? PROMPT_NO_2 { get; set; }
        public string PROMPT_COD_2 { get; set; }
        public string PROMPT_ALPHA_2 { get; set; }
        public DateTime? PROMPT_DAT_2 { get; set; }
        public string PROMPT_2_STR { get; set; }
        public decimal? PROMPT_NO_3 { get; set; }
        public string PROMPT_COD_3 { get; set; }
        public string PROMPT_ALPHA_3 { get; set; }
        public DateTime? PROMPT_DAT_3 { get; set; }
        public string PROMPT_3_STR { get; set; }
        public DateTime? BUS_DAT_EXT { get; set; }
        public long? DOC_ID_EXT { get; set; }
        public int? LIN_SEQ_NO_EXT { get; set; }
        public decimal? USER_BUYBACK_PRC { get; set; }
        public string USER_BUYBACK_TRADEIN_ITEM_NO { get; set; }
        public string USER_BUYBACK_TRADEIN_DESCR { get; set; }
        public string USER_BUYBACK_TRADEIN_SER_NO { get; set; }
        public string USER_BUYBACK_TRADEIN_ITEM_NOTE { get; set; }
        public decimal? USER_TRADEIN_BUYBACK_EXT_COST { get; set; }
        public string USER_BUYBACK_TRADEIN_TRX_TYPE { get; set; }
        public decimal? USER_BUYBACK_TRADEIN_CONSIDERATION { get; set; }
        public string USER_BUYBACK_TRADEIN_RECVR_NO { get; set; }
        public int? USER_BUYBACK_TRADEIN_RECVR_LIN_SEQ_NO { get; set; }
        public string USER_TRADEIN_BUYBACK_PROCESSED { get; set; }
        public string USER_TRADE_IN_PROCESSED { get; set; }
        public string USER_CONSIGNMENT_ITEM_NO { get; set; }
        public string USER_CONSIGNMENT_DESCR { get; set; }
        public string USER_CONSIGNMENT_SER_NO { get; set; }
        public string USER_CONSIGNMENT_ITEM_NOTE { get; set; }
        public decimal? USER_CONSIGNMENT_EXT_COST { get; set; }
        public string USER_CONSIGNMENT_TRX_TYPE { get; set; }
        public decimal? USER_CONSIGNMENT_CONSIDERATION { get; set; }
        public string USER_CONSIGNMENT_RECVR_NO { get; set; }
        public int? USER_CONSIGNMENT_RECVR_LIN_SEQ_NO { get; set; }
        public string USER_CONSIGNMENT_PROCESSED { get; set; }
        public string USER_CONSIGNMENT_PAYOUT_ITEM_NO { get; set; }
        public string USER_CONSIGNMENT_PAYOUT_LOC_ID { get; set; }
        public string USER_CONSIGNMENT_PAYOUT_SER_NO { get; set; }
        public DateTime? USER_CONSIGNMENT_PAYOUT_RECVD_DT { get; set; }
        public int? USER_RENTAL_AMMO_COUNT { get; set; }
        public string USER_INTAKE_TYPE { get; set; }
        public string USER_INTAKE_DOC_NO { get; set; }
    }

}
#pragma warning restore 1591
