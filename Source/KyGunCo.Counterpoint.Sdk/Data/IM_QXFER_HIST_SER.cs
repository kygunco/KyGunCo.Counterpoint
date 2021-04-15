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

    public partial class IM_QXFER_HIST_SER 
    {
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public string EVENT_NO { get; set; }
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public string BAT_ID { get; set; }
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public string ITEM_NO { get; set; }
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public string FROM_LOC_ID { get; set; }
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public string TO_LOC_ID { get; set; }
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public DateTime TRX_DAT { get; set; }
        [References(typeof(IM_QXFER_HIST))]
        [Required]
        public int SEQ_NO { get; set; }
        [Required]
        public string SER_NO { get; set; }
        public int? SER_SEQ_NO { get; set; }
        public decimal? SER_COST { get; set; }
        [Required]
        public decimal MISC_CHRG_AMT { get; set; }
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
        [Compute]
        public decimal? ORIG_SER_COST { get; set; }
    }

}
#pragma warning restore 1591
