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

    public partial class AR_TERMS_COD 
    {
        [Required]
        [PrimaryKey]
        public string TERMS_COD { get; set; }
        [Required]
        public string DESCR { get; set; }
        public string DESCR_UPR { get; set; }
        public int? NET_DUE_DAYS { get; set; }
        public int? PROX_DUE_DAY { get; set; }
        [Required]
        public string USE_PROX_DUE_DAY { get; set; }
        public int? NET_DISC_DAYS { get; set; }
        public int? PROX_DISC_DAY { get; set; }
        [Required]
        public string USE_PROX_DISC_DAY { get; set; }
        public decimal? DISC_PCT { get; set; }
        [Required]
        public string DISC_ACCT_NO { get; set; }
        public int? CUTOFF_DAY { get; set; }
        [Required]
        public string CUTOFF_IS_EOM { get; set; }
        [Required]
        public string DISC_METH { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public DateTime? RS_UTC_DT { get; set; }
        [Required]
        public byte RS_STAT { get; set; }
    }

}
#pragma warning restore 1591
