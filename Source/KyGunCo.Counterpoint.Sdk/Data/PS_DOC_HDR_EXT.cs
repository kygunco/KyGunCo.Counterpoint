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

    public partial class PS_DOC_HDR_EXT 
    {
        [References(typeof(PS_DOC_HDR))]
        [Required]
        [PrimaryKey]
        public long DOC_ID_EXT { get; set; }
        public string USER_NICS_DROS { get; set; }
        public string USER_4473 { get; set; }
        public string USER_FFL { get; set; }
        public string USER_DL_DATA_2D { get; set; }
        public string USER_INTRFACD_TO_SHIP { get; set; }
        public int? USER_SHIP_RESP_STAT { get; set; }
        public string USER_SHIP_RESP { get; set; }
        public string USER_ECOMM_AUTH_CODE { get; set; }
        public string USER_ECOMM_ORD_NO { get; set; }
        public string USER_ECOMM_RECEIPT_NO { get; set; }
        public DateTime? TKT_DAT { get; set; }
        public DateTime? TKT_TIM { get; set; }
        public int? TKT_TIM_HR { get; set; }
        public string TAX_COD_CHNGD { get; set; }
        public decimal? FOOD_STMP_TAX_AMT { get; set; }
        public int? HDR_DISCS { get; set; }
        public string HDR_DISC_COD { get; set; }
        public int? SAL_LINS { get; set; }
        public decimal? SAL_LIN_TOT { get; set; }
        public int? RET_LINS { get; set; }
        public decimal? RET_LIN_TOT { get; set; }
        public int? GFC_LINS { get; set; }
        public int? SVC_LINS { get; set; }
        public string SAL_HAS_TAX_OVRD { get; set; }
        public int? SAL_TAX_OVRD_LINS { get; set; }
        public decimal? SAL_GROSS_SUB_TOT { get; set; }
        public decimal? SAL_SUB_TOT { get; set; }
        public decimal? SAL_TOT_HDR_DISCNTBL_AMT { get; set; }
        public decimal? SAL_TOT_HDR_DISC { get; set; }
        public decimal? SAL_TOT_LIN_DISC { get; set; }
        public decimal? SAL_TOT_DISC { get; set; }
        public decimal? SAL_TOT_EST_COST { get; set; }
        public decimal? SAL_TOT_EXT_COST { get; set; }
        public decimal? SAL_TOT_WEIGHT { get; set; }
        public decimal? SAL_TOT_CUBE { get; set; }
        public decimal? SAL_TOT_GFC_AMT { get; set; }
        public decimal? SAL_TOT_SVC_AMT { get; set; }
        public decimal? SAL_TOT_MISC { get; set; }
        public decimal? SAL_NORM_TAX_AMT { get; set; }
        public decimal? SAL_TAX_AMT { get; set; }
        public decimal? SAL_TOT_TND { get; set; }
        public decimal? SAL_TOT_CHNG { get; set; }
        public decimal? SAL_NET_TND { get; set; }
        public decimal? SAL_TOT { get; set; }
        public decimal? SAL_AMT_DUE { get; set; }
        public string SAL_MISC_TYP_1 { get; set; }
        public decimal? SAL_MISC_AMT_1 { get; set; }
        public decimal? SAL_MISC_PCT_1 { get; set; }
        public string SAL_MISC_TYP_2 { get; set; }
        public decimal? SAL_MISC_AMT_2 { get; set; }
        public decimal? SAL_MISC_PCT_2 { get; set; }
        public string SAL_MISC_TYP_3 { get; set; }
        public decimal? SAL_MISC_AMT_3 { get; set; }
        public decimal? SAL_MISC_PCT_3 { get; set; }
        public string SAL_MISC_TYP_4 { get; set; }
        public decimal? SAL_MISC_AMT_4 { get; set; }
        public decimal? SAL_MISC_PCT_4 { get; set; }
        public string SAL_MISC_TYP_5 { get; set; }
        public decimal? SAL_MISC_AMT_5 { get; set; }
        public decimal? SAL_MISC_PCT_5 { get; set; }
        public int? ORD_LINS { get; set; }
        public int? BO_LINS { get; set; }
        public int? SO_LINS { get; set; }
        public int? DS_LINS { get; set; }
        public string HAS_ENTD_LINS { get; set; }
        public string HAS_PCKD_LINS { get; set; }
        public string HAS_PCKVRFD_LINS { get; set; }
        public string HAS_INVCD_LINS { get; set; }
        public string HAS_RLSD_LINS { get; set; }
        public string ORD_HAS_TAX_OVRD { get; set; }
        public int? ORD_TAX_OVRD_LINS { get; set; }
        public decimal? ORD_GROSS_SUB_TOT { get; set; }
        public decimal? ORD_SUB_TOT { get; set; }
        public decimal? ORD_TOT_HDR_DISCNTBL_AMT { get; set; }
        public decimal? ORD_TOT_HDR_DISC { get; set; }
        public decimal? ORD_TOT_LIN_DISC { get; set; }
        public decimal? ORD_TOT_DISC { get; set; }
        public decimal? ORD_TOT_EST_COST { get; set; }
        public decimal? ORD_TOT_EXT_COST { get; set; }
        public decimal? ORD_TOT_WEIGHT { get; set; }
        public decimal? ORD_TOT_CUBE { get; set; }
        public decimal? ORD_TOT_MISC { get; set; }
        public decimal? ORD_NORM_TAX_AMT { get; set; }
        public decimal? ORD_TAX_AMT { get; set; }
        public decimal? ORD_TAX_AMT_SHIPPED { get; set; }
        public decimal? ORD_TOT { get; set; }
        public decimal? ORD_INITIAL_MIN_DUE { get; set; }
        public decimal? ORD_TOT_TND { get; set; }
        public decimal? ORD_TOT_CHNG { get; set; }
        public decimal? ORD_NET_TND { get; set; }
        public decimal? ORD_AMT_DUE { get; set; }
        public decimal? TO_REL_GROSS_SUB_TOT { get; set; }
        public decimal? TO_REL_SUB_TOT { get; set; }
        public decimal? TO_REL_TOT_HDR_DISCNTBL_AMT { get; set; }
        public decimal? TO_REL_TOT_HDR_DISC { get; set; }
        public decimal? TO_REL_TOT_LIN_DISC { get; set; }
        public decimal? TO_REL_TOT_DISC { get; set; }
        public decimal? TO_REL_TOT_EST_COST { get; set; }
        public decimal? TO_REL_TOT_WEIGHT { get; set; }
        public decimal? TO_REL_TOT_CUBE { get; set; }
        public decimal? TO_REL_TOT_MISC { get; set; }
        public decimal? TO_REL_NORM_TAX_AMT { get; set; }
        public decimal? TO_REL_TAX_AMT { get; set; }
        public decimal? TO_REL_TAX_AMT_SHIPPED { get; set; }
        public decimal? TO_REL_TOT { get; set; }
        public decimal? TO_LEAVE_GROSS_SUB_TOT { get; set; }
        public decimal? TO_LEAVE_SUB_TOT { get; set; }
        public decimal? TO_LEAVE_TOT_HDR_DISCNTBL_AMT { get; set; }
        public decimal? TO_LEAVE_TOT_HDR_DISC { get; set; }
        public decimal? TO_LEAVE_TOT_LIN_DISC { get; set; }
        public decimal? TO_LEAVE_TOT_DISC { get; set; }
        public decimal? TO_LEAVE_TOT_EST_COST { get; set; }
        public decimal? TO_LEAVE_TOT_WEIGHT { get; set; }
        public decimal? TO_LEAVE_TOT_CUBE { get; set; }
        public decimal? TO_LEAVE_TOT_MISC { get; set; }
        public decimal? TO_LEAVE_NORM_TAX_AMT { get; set; }
        public decimal? TO_LEAVE_TAX_AMT { get; set; }
        public decimal? TO_LEAVE_TAX_AMT_SHIPPED { get; set; }
        public decimal? TO_LEAVE_TOT { get; set; }
        public string ORD_MISC_TYP_1 { get; set; }
        public decimal? ORD_MISC_AMT_1 { get; set; }
        public decimal? ORD_MISC_PCT_1 { get; set; }
        public decimal? ORD_MISC_AMT_1_SHIPPED { get; set; }
        public string ORD_MISC_TYP_2 { get; set; }
        public decimal? ORD_MISC_AMT_2 { get; set; }
        public decimal? ORD_MISC_PCT_2 { get; set; }
        public decimal? ORD_MISC_AMT_2_SHIPPED { get; set; }
        public string ORD_MISC_TYP_3 { get; set; }
        public decimal? ORD_MISC_AMT_3 { get; set; }
        public decimal? ORD_MISC_PCT_3 { get; set; }
        public decimal? ORD_MISC_AMT_3_SHIPPED { get; set; }
        public string ORD_MISC_TYP_4 { get; set; }
        public decimal? ORD_MISC_AMT_4 { get; set; }
        public decimal? ORD_MISC_PCT_4 { get; set; }
        public decimal? ORD_MISC_AMT_4_SHIPPED { get; set; }
        public string ORD_MISC_TYP_5 { get; set; }
        public decimal? ORD_MISC_AMT_5 { get; set; }
        public decimal? ORD_MISC_PCT_5 { get; set; }
        public decimal? ORD_MISC_AMT_5_SHIPPED { get; set; }
        public string TO_REL_MISC_TYP_1 { get; set; }
        public decimal? TO_REL_MISC_AMT_1 { get; set; }
        public decimal? TO_REL_MISC_PCT_1 { get; set; }
        public string TO_REL_MISC_TYP_2 { get; set; }
        public decimal? TO_REL_MISC_AMT_2 { get; set; }
        public decimal? TO_REL_MISC_PCT_2 { get; set; }
        public string TO_REL_MISC_TYP_3 { get; set; }
        public decimal? TO_REL_MISC_AMT_3 { get; set; }
        public decimal? TO_REL_MISC_PCT_3 { get; set; }
        public string TO_REL_MISC_TYP_4 { get; set; }
        public decimal? TO_REL_MISC_AMT_4 { get; set; }
        public decimal? TO_REL_MISC_PCT_4 { get; set; }
        public string TO_REL_MISC_TYP_5 { get; set; }
        public decimal? TO_REL_MISC_AMT_5 { get; set; }
        public decimal? TO_REL_MISC_PCT_5 { get; set; }
        public string TO_LEAVE_MISC_TYP_1 { get; set; }
        public decimal? TO_LEAVE_MISC_AMT_1 { get; set; }
        public decimal? TO_LEAVE_MISC_PCT_1 { get; set; }
        public string TO_LEAVE_MISC_TYP_2 { get; set; }
        public decimal? TO_LEAVE_MISC_AMT_2 { get; set; }
        public decimal? TO_LEAVE_MISC_PCT_2 { get; set; }
        public string TO_LEAVE_MISC_TYP_3 { get; set; }
        public decimal? TO_LEAVE_MISC_AMT_3 { get; set; }
        public decimal? TO_LEAVE_MISC_PCT_3 { get; set; }
        public string TO_LEAVE_MISC_TYP_4 { get; set; }
        public decimal? TO_LEAVE_MISC_AMT_4 { get; set; }
        public decimal? TO_LEAVE_MISC_PCT_4 { get; set; }
        public string TO_LEAVE_MISC_TYP_5 { get; set; }
        public decimal? TO_LEAVE_MISC_AMT_5 { get; set; }
        public decimal? TO_LEAVE_MISC_PCT_5 { get; set; }
        public int? LWY_LINS { get; set; }
        public string LWY_HAS_TAX_OVRD { get; set; }
        public int? LWY_TAX_OVRD_LINS { get; set; }
        public decimal? LWY_GROSS_SUB_TOT { get; set; }
        public decimal? LWY_SUB_TOT { get; set; }
        public decimal? LWY_TOT_HDR_DISCNTBL_AMT { get; set; }
        public decimal? LWY_TOT_HDR_DISC { get; set; }
        public decimal? LWY_TOT_LIN_DISC { get; set; }
        public decimal? LWY_TOT_DISC { get; set; }
        public decimal? LWY_TOT_EST_COST { get; set; }
        public decimal? LWY_TOT_EXT_COST { get; set; }
        public decimal? LWY_TOT_WEIGHT { get; set; }
        public decimal? LWY_TOT_CUBE { get; set; }
        public decimal? LWY_TOT_MISC { get; set; }
        public decimal? LWY_NORM_TAX_AMT { get; set; }
        public decimal? LWY_TAX_AMT { get; set; }
        public decimal? LWY_TAX_AMT_SHIPPED { get; set; }
        public decimal? LWY_TOT { get; set; }
        public decimal? LWY_INITIAL_MIN_DUE { get; set; }
        public decimal? LWY_TOT_TND { get; set; }
        public decimal? LWY_TOT_CHNG { get; set; }
        public decimal? LWY_NET_TND { get; set; }
        public decimal? LWY_AMT_DUE { get; set; }
        public string LWY_MISC_TYP_1 { get; set; }
        public decimal? LWY_MISC_AMT_1 { get; set; }
        public decimal? LWY_MISC_PCT_1 { get; set; }
        public decimal? LWY_MISC_AMT_1_SHIPPED { get; set; }
        public string LWY_MISC_TYP_2 { get; set; }
        public decimal? LWY_MISC_AMT_2 { get; set; }
        public decimal? LWY_MISC_PCT_2 { get; set; }
        public decimal? LWY_MISC_AMT_2_SHIPPED { get; set; }
        public string LWY_MISC_TYP_3 { get; set; }
        public decimal? LWY_MISC_AMT_3 { get; set; }
        public decimal? LWY_MISC_PCT_3 { get; set; }
        public decimal? LWY_MISC_AMT_3_SHIPPED { get; set; }
        public string LWY_MISC_TYP_4 { get; set; }
        public decimal? LWY_MISC_AMT_4 { get; set; }
        public decimal? LWY_MISC_PCT_4 { get; set; }
        public decimal? LWY_MISC_AMT_4_SHIPPED { get; set; }
        public string LWY_MISC_TYP_5 { get; set; }
        public decimal? LWY_MISC_AMT_5 { get; set; }
        public decimal? LWY_MISC_PCT_5 { get; set; }
        public decimal? LWY_MISC_AMT_5_SHIPPED { get; set; }
        public int? LINS { get; set; }
        public int? TAX_OVRD_LINS { get; set; }
        public decimal? GROSS_SUB_TOT { get; set; }
        public decimal? SUB_TOT { get; set; }
        public decimal? TOT_HDR_DISCNTBL_AMT { get; set; }
        public decimal? TOT_HDR_DISC { get; set; }
        public decimal? TOT_LIN_DISC { get; set; }
        public decimal? TOT_DISC { get; set; }
        public decimal? TOT_EST_COST { get; set; }
        public decimal? TOT_EXT_COST { get; set; }
        public decimal? TOT_WEIGHT { get; set; }
        public decimal? TOT_CUBE { get; set; }
        public decimal? TOT_MISC { get; set; }
        public decimal? NORM_TAX_AMT { get; set; }
        public decimal? TAX_AMT { get; set; }
        public decimal? TOT { get; set; }
        public decimal? TOT_TND { get; set; }
        public decimal? TOT_CHNG { get; set; }
        public decimal? NET_TND { get; set; }
        public decimal? AMT_DUE { get; set; }
        public decimal? MISC_AMT_1 { get; set; }
        public decimal? MISC_PCT_1 { get; set; }
        public decimal? MISC_AMT_2 { get; set; }
        public decimal? MISC_PCT_2 { get; set; }
        public decimal? MISC_AMT_3 { get; set; }
        public decimal? MISC_PCT_3 { get; set; }
        public decimal? MISC_AMT_4 { get; set; }
        public decimal? MISC_PCT_4 { get; set; }
        public decimal? MISC_AMT_5 { get; set; }
        public decimal? MISC_PCT_5 { get; set; }
        public string DOC_DESCR { get; set; }
        public string PAY_ACCT_NO { get; set; }
        public string APPLY_TO_DOC_NO { get; set; }
        public DateTime? APPLY_TO_DOC_DAT { get; set; }
        public string APPLY_TO_DOC_TYP { get; set; }
        public string PAY_APPLY_METH { get; set; }
        public decimal? PAY_AMT { get; set; }
        public decimal? ABS_PAY_AMT { get; set; }
        public string ORIG_QUOT_STR_ID { get; set; }
        public string ORIG_QUOT_STA_ID { get; set; }
        public string ORIG_QUOT_NO { get; set; }
        public DateTime? QUOT_EXP_DAT { get; set; }
        public string ORIG_HOLD_STR_ID { get; set; }
        public string ORIG_HOLD_STA_ID { get; set; }
        public string ORIG_HOLD_NO { get; set; }
        public decimal? LIN_LOY_PTS_EARND { get; set; }
        public int? LOY_PTS_EARND_GROSS { get; set; }
        public int? LOY_PTS_ADJ_FOR_RDM { get; set; }
        public int? LOY_PTS_ADJ_FOR_INC_RND { get; set; }
        public int? LOY_PTS_ADJ_FOR_OVER_MAX { get; set; }
        public int? LOY_PTS_EARND_NET { get; set; }
        public int? LOY_PTS_RDM { get; set; }
        public int? LOY_PTS_BAL { get; set; }
        public string BILL_NAM { get; set; }
        public string BILL_NAM_UPR { get; set; }
        public string BILL_FST_NAM { get; set; }
        public string BILL_FST_NAM_UPR { get; set; }
        public string BILL_LST_NAM { get; set; }
        public string BILL_LST_NAM_UPR { get; set; }
        public string BILL_SALUTATION { get; set; }
        public string BILL_ADRS_1 { get; set; }
        public string BILL_ADRS_2 { get; set; }
        public string BILL_ADRS_3 { get; set; }
        public string BILL_CITY { get; set; }
        public string BILL_STATE { get; set; }
        public string BILL_ZIP_COD { get; set; }
        public string BILL_CNTRY { get; set; }
        public string BILL_PHONE_1 { get; set; }
        public string BILL_PHONE_2 { get; set; }
        public string BILL_NAM_TYP { get; set; }
        public string BILL_EMAIL_ADRS_1 { get; set; }
        public string BILL_EMAIL_ADRS_2 { get; set; }
        public string BILL_CONTCT_1 { get; set; }
        public string BILL_CONTCT_2 { get; set; }
        public string BILL_FAX_1 { get; set; }
        public string BILL_FAX_2 { get; set; }
        public string BILL_FST_LST_NAM { get; set; }
        public string SHIP_NAM { get; set; }
        public string SHIP_FST_NAM { get; set; }
        public string SHIP_LST_NAM { get; set; }
        public string SHIP_SALUTATION { get; set; }
        public string SHIP_ADRS_1 { get; set; }
        public string SHIP_ADRS_2 { get; set; }
        public string SHIP_ADRS_3 { get; set; }
        public string SHIP_CITY { get; set; }
        public string SHIP_STATE { get; set; }
        public string SHIP_ZIP_COD { get; set; }
        public string SHIP_CNTRY { get; set; }
        public string SHIP_PHONE_1 { get; set; }
        public string SHIP_PHONE_2 { get; set; }
        public string SHIP_ADRS_ID { get; set; }
        public string SHIP_NAM_TYP { get; set; }
        public string SHIP_EMAIL_ADRS_1 { get; set; }
        public string SHIP_EMAIL_ADRS_2 { get; set; }
        public string SHIP_CONTCT_1 { get; set; }
        public string SHIP_CONTCT_2 { get; set; }
        public string SHIP_FAX_1 { get; set; }
        public string SHIP_FAX_2 { get; set; }
        public string SHIP_FST_LST_NAM { get; set; }
        public string PROF_COD_1 { get; set; }
        public string PROF_COD_2 { get; set; }
        public string PROF_COD_3 { get; set; }
        public string PROF_COD_4 { get; set; }
        public string PROF_COD_5 { get; set; }
        public decimal? PROF_NO_1 { get; set; }
        public decimal? PROF_NO_2 { get; set; }
        public decimal? PROF_NO_3 { get; set; }
        public decimal? PROF_NO_4 { get; set; }
        public decimal? PROF_NO_5 { get; set; }
        public string PROF_ALPHA_1 { get; set; }
        public string PROF_ALPHA_2 { get; set; }
        public string PROF_ALPHA_3 { get; set; }
        public string PROF_ALPHA_4 { get; set; }
        public string PROF_ALPHA_5 { get; set; }
        public DateTime? PROF_DAT_1 { get; set; }
        public DateTime? PROF_DAT_2 { get; set; }
        public DateTime? PROF_DAT_3 { get; set; }
        public DateTime? PROF_DAT_4 { get; set; }
        public DateTime? PROF_DAT_5 { get; set; }
        public string ORIG_ORD_STR_ID { get; set; }
        public string ORIG_ORD_STA_ID { get; set; }
        public string ORIG_ORD_NO { get; set; }
        public decimal? ORIG_ORD_TOT { get; set; }
        public decimal? ORIG_ORD_AMT_DUE { get; set; }
        public long? ORIG_ORD_DOC_ID { get; set; }
        public decimal? ORD_DEP_AMT_RECEIVED { get; set; }
        public decimal? ORD_DEP_AMT_APPLIED { get; set; }
        public decimal? ORD_DEP_AMT_FORFEIT { get; set; }
        public decimal? ORD_DEP_AMT_REFUNDED { get; set; }
        public decimal? ORD_DEP_NET_CHANGE { get; set; }
        public decimal? ORD_DEP_BAL_BEFORE { get; set; }
        public decimal? ORD_DEP_BAL_AFTER { get; set; }
        public DateTime? ORIG_ORD_DAT { get; set; }
        public DateTime? ORIG_ORD_TIM { get; set; }
        public string ORIG_ORD_CANCELLED { get; set; }
        public string ORIG_ORD_IS_ACTIVE { get; set; }
        public string ORIG_LWY_STR_ID { get; set; }
        public string ORIG_LWY_STA_ID { get; set; }
        public string ORIG_LWY_NO { get; set; }
        public decimal? ORIG_LWY_TOT { get; set; }
        public decimal? ORIG_LWY_AMT_DUE { get; set; }
        public long? ORIG_LWY_DOC_ID { get; set; }
        public decimal? LWY_DEP_AMT_RECEIVED { get; set; }
        public decimal? LWY_DEP_AMT_APPLIED { get; set; }
        public decimal? LWY_DEP_AMT_FORFEIT { get; set; }
        public decimal? LWY_DEP_AMT_REFUNDED { get; set; }
        public decimal? LWY_DEP_NET_CHANGE { get; set; }
        public decimal? LWY_DEP_BAL_BEFORE { get; set; }
        public decimal? LWY_DEP_BAL_AFTER { get; set; }
        public DateTime? ORIG_LWY_DAT { get; set; }
        public DateTime? ORIG_LWY_TIM { get; set; }
        public string ORIG_LWY_CANCELLED { get; set; }
        public string ORIG_LWY_IS_ACTIVE { get; set; }
        public string ORIG_DOC_STAT { get; set; }
        public decimal? DEP_AMT_RECEIVED { get; set; }
        public decimal? DEP_AMT_APPLIED { get; set; }
        public decimal? DEP_AMT_FORFEIT { get; set; }
        public decimal? DEP_AMT_REFUNDED { get; set; }
        public decimal? DEP_NET_CHANGE { get; set; }
        public decimal? DEP_BAL_BEFORE { get; set; }
        public decimal? DEP_BAL_AFTER { get; set; }
        public string IS_ORDER { get; set; }
        public decimal? SAL_AMT_RECEIVED { get; set; }
        public decimal? TOT_TND_AMT { get; set; }
        public decimal? SAL_TOT_TND_AMT { get; set; }
        public decimal? SAL_ONLY_NET_TND { get; set; }
        public string DEP_ONLY_TKT { get; set; }
        public string USER_ORIG_DOC_GUID { get; set; }
        public int? E4473_SEQ_NO { get; set; }
        public string E4473_FIRST_NAME { get; set; }
        public string E4473_MIDDLE_NAME { get; set; }
        public string E4473_LAST_NAME { get; set; }
        public string E4473_ADDRS_1 { get; set; }
        public string E4473_ADDRS_2 { get; set; }
        public string E4473_CITY { get; set; }
        public string E4473_COUNTY { get; set; }
        public string E4473_STATE { get; set; }
        public string E4473_ZIP_COD { get; set; }
        public string E4473_ACTIV_DUTY_ADDRS_1 { get; set; }
        public string E4473_ACTIV_DUTY_ADDRS_2 { get; set; }
        public string E4473_ACTIV_DUTY_CITY { get; set; }
        public string E4473_ACTIV_DUTY_COUNTY { get; set; }
        public string E4473_ACTIV_DUTY_STATE { get; set; }
        public string E4473_ACTIV_DUTY_ZIP_COD { get; set; }
        public string E4473_ALIEN { get; set; }
        public string E4473_ALIEN_NUM { get; set; }
        public string E4473_BIRTHDATE { get; set; }
        public string E4473_CITIZENSHIP { get; set; }
        public string E4473_ETHNICITY { get; set; }
        public string E4473_GENDER { get; set; }
        public string E4473_HEIGHT_FT { get; set; }
        public string E4473_HEIGHT_IN { get; set; }
        public string E4473_PLACE_OF_BIRTH_CITY { get; set; }
        public string E4473_PLACE_OF_BIRTH_FOREIGN { get; set; }
        public string E4473_PLACE_OF_BIRTH_STATE { get; set; }
        public string E4473_RACE { get; set; }
        public string E4473_RESIDENCE_STATE { get; set; }
        public string E4473_SOC_SEC_NUM { get; set; }
        public string E4473_WEIGHT { get; set; }
        public string E4473_UPIN { get; set; }
        public string E4473_C11A { get; set; }
        public string E4473_C11B { get; set; }
        public string E4473_C11C { get; set; }
        public string E4473_C11D { get; set; }
        public string E4473_C11E { get; set; }
        public string E4473_C11F { get; set; }
        public string E4473_C11G { get; set; }
        public string E4473_C11H { get; set; }
        public string E4473_C11I { get; set; }
        public string E4473_C11J { get; set; }
        public string E4473_C11K { get; set; }
        public string E4473_C11L { get; set; }
        public string E4473_C12B { get; set; }
        public string E4473_C12C { get; set; }
        public string E4473_C12D1 { get; set; }
        public string E4473_C12D2 { get; set; }
        public byte? USER_SHIPPING_EASY_STAT { get; set; }
        public string USER_SHIPPING_EASY_RESPONSE { get; set; }
        public int? USER_SHIPPING_EASY_ID { get; set; }
        public string USER_IS_LAYAWAY { get; set; }
        public string USER_IS_CLASS_3 { get; set; }
    }

}
#pragma warning restore 1591
