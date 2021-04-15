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

    public partial class AR_OPN_ITEM 
    {
        [References(typeof(AR_CUST))]
        [Required]
        public string CUST_NO { get; set; }
        [Required]
        public DateTime DOC_DAT { get; set; }
        [Required]
        public string DOC_NO { get; set; }
        [Required]
        public string DOC_TYP { get; set; }
        public decimal? AMT { get; set; }
        public decimal? ENTD_AMT { get; set; }
        public decimal? TOT_WRTOFF_AMT { get; set; }
        public decimal? DISC_TAKEN { get; set; }
        [Required]
        public string TERMS_COD { get; set; }
        [Required]
        public DateTime DUE_DAT { get; set; }
        [Required]
        public DateTime DISC_DAT { get; set; }
        public decimal? DISC_PCT { get; set; }
        public string SLS_REP { get; set; }
        public string REF { get; set; }
        public string STR_ID { get; set; }
        [Required]
        public string SELF_APPLIED { get; set; }
        public DateTime? LST_REAPPL_DT { get; set; }
        public string LST_REAPPL_USR_ID { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public string WRK_STMNT_ACTIV { get; set; }
        public decimal? WRK_STMNT_BEG_BAL { get; set; }
        public decimal? WRK_STMNT_END_BAL { get; set; }
        public string STA_ID { get; set; }
        public string EVENT_NO { get; set; }
        public string CUST_PO_NO { get; set; }
        [Compute]
        public int? STMNT_DOC_TYP_ORDER { get; set; }
        public long? DOC_ID { get; set; }
    }

}
#pragma warning restore 1591
