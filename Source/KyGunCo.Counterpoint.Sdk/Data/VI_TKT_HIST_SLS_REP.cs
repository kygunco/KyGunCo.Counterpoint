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

    public partial class VI_TKT_HIST_SLS_REP 
    {
        [Required]
        public string STR_ID { get; set; }
        public string SLS_REP { get; set; }
        public string NAM { get; set; }
        [Required]
        public DateTime POST_DAT { get; set; }
        public int? TKT_COUNT { get; set; }
        public decimal? SAL_SUB_TOT { get; set; }
        public decimal? SAL_TOT_COST { get; set; }
        public int? SAL_LINS { get; set; }
        public int? RET_LINS { get; set; }
        public int? MULT_SALS { get; set; }
    }

}
#pragma warning restore 1591
