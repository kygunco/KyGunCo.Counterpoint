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

    public partial class AR_ADJ_TRX 
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
        [Required]
        public string BAT_ID { get; set; }
        public int? ENTRY_SEQ_NO { get; set; }
        [Required]
        public string APPLY_TO_METH { get; set; }
        public DateTime? APPLY_TO_DOC_DAT { get; set; }
        [Required]
        public string APPLY_TO_DOC_NO { get; set; }
        [Required]
        public string APPLY_TO_DOC_TYP { get; set; }
        public decimal? AMT { get; set; }
        [Required]
        public decimal ENTD_AMT { get; set; }
        public string STR_ID { get; set; }
        public string REF { get; set; }
        [Required]
        public string ACCT_NO { get; set; }
        [Required]
        public string TERMS_COD { get; set; }
        [Required]
        public DateTime DUE_DAT { get; set; }
        [Required]
        public DateTime DISC_DAT { get; set; }
        public decimal? DISC_PCT { get; set; }
        public string SLS_REP { get; set; }
        public string ERR_REF { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
    }

}
#pragma warning restore 1591
