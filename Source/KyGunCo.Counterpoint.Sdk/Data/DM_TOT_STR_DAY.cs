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

    public partial class DM_TOT_STR_DAY 
    {
        [Required]
        public DateTime POST_DAT { get; set; }
        [References(typeof(DM_STR_HIST))]
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public int TKT_CNT { get; set; }
        [Required]
        public decimal SLS_QTY { get; set; }
        [Required]
        public decimal SLS_EXT_PRC { get; set; }
        [Required]
        public int SLS_LIN_CNT { get; set; }
        [Required]
        public decimal RTN_QTY { get; set; }
        [Required]
        public decimal RTN_EXT_PRC { get; set; }
        [Required]
        public int RTN_LIN_CNT { get; set; }
        [Required]
        public decimal TOT_EXT_COST { get; set; }
        [Required]
        public decimal TOT_EXT_CALC_PRC { get; set; }
        [Required]
        public decimal TOT_EXT_RETL_VAL { get; set; }
        [Required]
        public decimal TOT_EXT_REG_PRC { get; set; }
        [Required]
        public decimal TOT_EXT_PRC_1 { get; set; }
        public byte[] ROW_TS { get; set; }
        public decimal? TAX_AMT { get; set; }
    }

}
#pragma warning restore 1591
