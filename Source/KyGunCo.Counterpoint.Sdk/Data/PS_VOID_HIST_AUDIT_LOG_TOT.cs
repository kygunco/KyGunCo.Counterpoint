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

    public partial class PS_VOID_HIST_AUDIT_LOG_TOT 
    {
        [References(typeof(PS_VOID_HIST_AUDIT_LOG))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_VOID_HIST_AUDIT_LOG))]
        [Required]
        public long DOC_ID { get; set; }
        [References(typeof(PS_VOID_HIST_AUDIT_LOG))]
        [Required]
        public int LOG_SEQ_NO { get; set; }
        [Required]
        public string TOT_TYP { get; set; }
        public int? LINS { get; set; }
        [Required]
        public decimal SUB_TOT { get; set; }
        [Required]
        public decimal TOT_MISC { get; set; }
        public decimal? TOT_GFC_AMT { get; set; }
        public decimal? TOT_SVC_AMT { get; set; }
        [Required]
        public decimal NORM_TAX_AMT { get; set; }
        [Required]
        public decimal TAX_AMT { get; set; }
        public decimal? TOT_EXT_COST { get; set; }
        [Required]
        public decimal TOT_TND { get; set; }
        [Required]
        public decimal TOT_CHNG { get; set; }
        [Required]
        public decimal AMT_DUE { get; set; }
        [Required]
        public decimal TOT { get; set; }
        public decimal? DEP_NET_CHANGE { get; set; }
    }

}
#pragma warning restore 1591
