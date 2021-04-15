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

    public partial class VI_PS_LWY_HIST_AUDIT_LOG 
    {
        [Required]
        public DateTime BUS_DAT { get; set; }
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int LOG_SEQ_NO { get; set; }
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
        public string ACTIV { get; set; }
        public string LOG_ENTRY { get; set; }
        public string CURR_STR_ID { get; set; }
        public string CURR_STA_ID { get; set; }
        public string CURR_DRW_ID { get; set; }
        public string CURR_USR_ID { get; set; }
        public string CURR_WKSTN_NAM { get; set; }
        public string CURR_SERV_NAM { get; set; }
        public string CURR_DB_NAM { get; set; }
        public DateTime? CURR_DT { get; set; }
        public DateTime? CURR_DAT { get; set; }
        public DateTime? CURR_TIM { get; set; }
        [Required]
        public string DOC_TYP { get; set; }
        [Required]
        public Guid DOC_GUID { get; set; }
        public string LINK_STR_ID { get; set; }
        public string LINK_STA_ID { get; set; }
        public string LINK_DOC_NO { get; set; }
        public string LINK_TKT_NO { get; set; }
        public Guid? LINK_DOC_GUID { get; set; }
        public int? SAL_LINS { get; set; }
        public decimal? SAL_SUB_TOT { get; set; }
        public decimal? SAL_TOT_SVC_AMT { get; set; }
        public decimal? SAL_TOT_GFC_AMT { get; set; }
        public decimal? SAL_TOT_MISC { get; set; }
        public decimal? SAL_NORM_TAX_AMT { get; set; }
        public decimal? SAL_TAX_AMT { get; set; }
        public decimal? SAL_TOT_EXT_COST { get; set; }
        public decimal? SAL_TOT_EST_COST { get; set; }
        public decimal? SAL_TOT { get; set; }
        public decimal? SAL_TOT_TND { get; set; }
        public decimal? SAL_TOT_CHNG { get; set; }
        public decimal? SAL_NET_TND { get; set; }
        public decimal? SAL_AMT_DUE { get; set; }
        public decimal? DEP_NET_CHANGE { get; set; }
        public int? ORD_LINS { get; set; }
        public decimal? ORD_SUB_TOT { get; set; }
        public decimal? ORD_TOT_MISC { get; set; }
        public decimal? ORD_NORM_TAX_AMT { get; set; }
        public decimal? ORD_TAX_AMT { get; set; }
        public decimal? ORD_TOT_EXT_COST { get; set; }
        public decimal? ORD_TOT_EST_COST { get; set; }
        public decimal? ORD_TOT { get; set; }
        public decimal? ORD_TOT_TND { get; set; }
        public decimal? ORD_TOT_CHNG { get; set; }
        public decimal? ORD_NET_TND { get; set; }
        public decimal? ORD_AMT_DUE { get; set; }
        public int? LWY_LINS { get; set; }
        public decimal? LWY_SUB_TOT { get; set; }
        public decimal? LWY_TOT_MISC { get; set; }
        public decimal? LWY_NORM_TAX_AMT { get; set; }
        public decimal? LWY_TAX_AMT { get; set; }
        public decimal? LWY_TOT_EXT_COST { get; set; }
        public decimal? LWY_TOT_EST_COST { get; set; }
        public decimal? LWY_TOT { get; set; }
        public decimal? LWY_TOT_TND { get; set; }
        public decimal? LWY_TOT_CHNG { get; set; }
        public decimal? LWY_NET_TND { get; set; }
        public decimal? LWY_AMT_DUE { get; set; }
        public int? LINS { get; set; }
        public decimal? SUB_TOT { get; set; }
        public decimal? TOT_SVC_AMT { get; set; }
        public decimal? TOT_GFC_AMT { get; set; }
        public decimal? TOT_MISC { get; set; }
        public decimal? NORM_TAX_AMT { get; set; }
        public decimal? TAX_AMT { get; set; }
        public decimal? TOT_EXT_COST { get; set; }
        public decimal? TOT_EST_COST { get; set; }
        public decimal? TOT { get; set; }
        public decimal? TOT_TND { get; set; }
        public decimal? TOT_CHNG { get; set; }
        public decimal? AMT_DUE { get; set; }
        public decimal? NET_TND { get; set; }
    }

}
#pragma warning restore 1591
