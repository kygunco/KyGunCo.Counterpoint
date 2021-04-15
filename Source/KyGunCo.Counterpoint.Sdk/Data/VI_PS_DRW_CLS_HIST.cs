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

    public partial class VI_PS_DRW_CLS_HIST 
    {
        [Required]
        public string EVENT_NO { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string DRW_ID { get; set; }
        public string PAY_COD { get; set; }
        [Required]
        public long DRW_SESSION_ID { get; set; }
        [Required]
        public string SESSION_NAM { get; set; }
        public decimal? BEG_AMT { get; set; }
        public decimal? CLS_AMT { get; set; }
        public decimal? RECON_AMT { get; set; }
        [Required]
        public string NORM_ACTIV { get; set; }
        [Required]
        public string NORM_CNT { get; set; }
        [Required]
        public string NORM_RECON { get; set; }
        public decimal? POST_AMT { get; set; }
        [Required]
        public string ADD_DURING_POST { get; set; }
        public string CURNCY_COD { get; set; }
        public string CURNCY_COD_DESCR { get; set; }
        public decimal? EXCH_RATE_NUMER { get; set; }
        public decimal? EXCH_RATE_DENOM { get; set; }
        public double? EXCH_RATE { get; set; }
        public decimal? HOME_CURNCY_BEG_AMT { get; set; }
        public decimal? HOME_CURNCY_CLS_AMT { get; set; }
        public decimal? HOME_CURNCY_RECON_AMT { get; set; }
        public decimal? HOME_CURNCY_POST_AMT { get; set; }
        public decimal? HOME_CURNCY_DIST_AMT { get; set; }
        [Required]
        public string IS_FOREIGN { get; set; }
        public decimal? REMOVE_AMT { get; set; }
        public decimal? DROP_AMT { get; set; }
        public decimal? LOAN_AMT { get; set; }
    }

}
#pragma warning restore 1591
