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

    public partial class PS_TKT_HIST 
    {
        [Required]
        public DateTime BUS_DAT { get; set; }
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string EVENT_NO { get; set; }
        [Required]
        public string STA_ID { get; set; }
        [Required]
        public string TKT_NO { get; set; }
        [Required]
        public Guid DOC_GUID { get; set; }
        public DateTime? TKT_DT { get; set; }
        [Required]
        public string TKT_TYP { get; set; }
        public string DRW_ID { get; set; }
        public long? DRW_SESSION_ID { get; set; }
        public string USR_ID { get; set; }
        public string SLS_REP { get; set; }
        public string STK_LOC_ID { get; set; }
        public string PRC_LOC_ID { get; set; }
        public string PFT_CTR { get; set; }
        public string CUST_NO { get; set; }
        public byte? BILL_TO_CONTACT_ID { get; set; }
        public byte? SHIP_TO_CONTACT_ID { get; set; }
        public string LOY_PGM_COD { get; set; }
        public string TERMS_COD { get; set; }
        public string SHIP_VIA_COD { get; set; }
        public string SHIP_ZONE_COD { get; set; }
        public DateTime? SHIP_DAT { get; set; }
        public string NORM_TAX_COD { get; set; }
        public string TAX_COD { get; set; }
        public string TAX_EXEMPT_NO { get; set; }
        public string TAX_OVRD_REAS { get; set; }
        public string CUST_PO_NO { get; set; }
        public string LST_FRM_GRP_PRTD { get; set; }
        public string LST_FRM_PRTD { get; set; }
        public int? TIMES_PRTD { get; set; }
        public decimal? FOOD_STMP_AMT { get; set; }
        [Required]
        public int FOOD_STMP_LINS { get; set; }
        public decimal? FOOD_STMP_TAX_AMT { get; set; }
        public decimal? FOOD_STMP_NORM_TAX_AMT { get; set; }
        public int? SAL_LINS { get; set; }
        [Required]
        public decimal SAL_LIN_TOT { get; set; }
        [Required]
        public int GFC_LINS { get; set; }
        [Required]
        public int SVC_LINS { get; set; }
        public int? RET_LINS { get; set; }
        [Required]
        public decimal RET_LIN_TOT { get; set; }
        [Required]
        public string HAS_TAX_OVRD { get; set; }
        [Required]
        public int TAX_OVRD_LINS { get; set; }
        public int? LINS { get; set; }
        [Required]
        public decimal SUB_TOT { get; set; }
        public decimal? TOT_EXT_COST { get; set; }
        [Required]
        public decimal TOT_WEIGHT { get; set; }
        [Required]
        public decimal TOT_CUBE { get; set; }
        public decimal? TOT_GFC_AMT { get; set; }
        public decimal? TOT_SVC_AMT { get; set; }
        [Required]
        public decimal TOT_MISC { get; set; }
        [Required]
        public decimal NORM_TAX_AMT { get; set; }
        [Required]
        public decimal TAX_AMT { get; set; }
        [Required]
        public decimal TOT_TND { get; set; }
        [Required]
        public decimal TOT_CHNG { get; set; }
        [Required]
        public decimal TOT { get; set; }
        public string DATA_UPGRADE_STAT { get; set; }
        public string REF { get; set; }
        [Required]
        public decimal TOT_HDR_DISC { get; set; }
        [Required]
        public decimal TOT_LIN_DISC { get; set; }
        [Required]
        public bool IS_OFFLINE { get; set; }
        public string AGG_STAT { get; set; }
        public int? RECEIPT_NUM { get; set; }
        [Required]
        public decimal TOT_TIP_AMT { get; set; }
    }

}
#pragma warning restore 1591
