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

    public partial class VI_SER_NO 
    {
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string SER_NO { get; set; }
        public string LOC_ID { get; set; }
        [Required]
        public string STAT { get; set; }
        [Required]
        public string PREV_STAT { get; set; }
        public decimal? SER_COST { get; set; }
        public DateTime? WARR_DAT_1 { get; set; }
        public DateTime? WARR_DAT_2 { get; set; }
        [Required]
        public string MAN_ENTD { get; set; }
        public DateTime? RECV_DAT { get; set; }
        public string VEND_NO { get; set; }
        public string PROMPT_COD_1 { get; set; }
        public string PROMPT_ALPHA_1 { get; set; }
        public DateTime? PROMPT_DAT_1 { get; set; }
        public decimal? PROMPT_NO_1 { get; set; }
        public string PROMPT_1_STR { get; set; }
        public string PROMPT_COD_2 { get; set; }
        public string PROMPT_ALPHA_2 { get; set; }
        public DateTime? PROMPT_DAT_2 { get; set; }
        public decimal? PROMPT_NO_2 { get; set; }
        public string PROMPT_2_STR { get; set; }
        public string PROMPT_COD_3 { get; set; }
        public string PROMPT_ALPHA_3 { get; set; }
        public DateTime? PROMPT_DAT_3 { get; set; }
        public decimal? PROMPT_NO_3 { get; set; }
        public string PROMPT_3_STR { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public string DESCR { get; set; }
        public int? PRC_DECS { get; set; }
        public string ACTIV_TYP { get; set; }
        public string EVENT_NO { get; set; }
        public string BAT_ID { get; set; }
        public DateTime? DAT { get; set; }
        public int? TRX_SEQ_NO { get; set; }
        public string FROM_LOC_ID { get; set; }
        public string RECVR_NO { get; set; }
        public string RTV_NO { get; set; }
        public string STR_ID { get; set; }
        public string STA_ID { get; set; }
        public string TKT_NO { get; set; }
        public string POSTED { get; set; }
        public string DOC_NO { get; set; }
        public string CUST_NO { get; set; }
        public decimal? PRC { get; set; }
    }

}
#pragma warning restore 1591
