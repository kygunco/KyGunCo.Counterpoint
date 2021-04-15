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

    public partial class PS_ORD_HIST_TAX 
    {
        [References(typeof(PS_ORD_HIST))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_ORD_HIST))]
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public string AUTH_COD { get; set; }
        [Required]
        public string RUL_COD { get; set; }
        public decimal? LIN_AMT { get; set; }
        public decimal? TXBL_LIN_AMT { get; set; }
        public decimal? TXBL_MISC_CHG_AMT_1 { get; set; }
        public decimal? TXBL_MISC_CHG_AMT_2 { get; set; }
        public decimal? TXBL_MISC_CHG_AMT_3 { get; set; }
        public decimal? TXBL_MISC_CHG_AMT_4 { get; set; }
        public decimal? TXBL_MISC_CHG_AMT_5 { get; set; }
        public decimal? TXBL_TAX_AMT { get; set; }
        public decimal? TXBL_QTY { get; set; }
        public decimal? TAX_AMT { get; set; }
        public decimal? NORM_TAX_AMT { get; set; }
        public decimal? TAX_AMT_EXACT { get; set; }
        public decimal? NORM_TAX_AMT_EXACT { get; set; }
    }

}
#pragma warning restore 1591
