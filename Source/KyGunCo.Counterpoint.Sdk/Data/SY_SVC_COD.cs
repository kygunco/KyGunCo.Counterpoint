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

    public partial class SY_SVC_COD 
    {
        [Required]
        [PrimaryKey]
        public string SVC_COD { get; set; }
        [Required]
        public string DESCR { get; set; }
        public string DESCR_UPR { get; set; }
        [Required]
        public string SELL_DESCR { get; set; }
        public decimal? DFLT_AMT { get; set; }
        [Required]
        public string ALLOW_AMT_CHNG { get; set; }
        public string LIAB_ACCT_NO { get; set; }
        [Required]
        public string LIAB_METH { get; set; }
        public string RDM_ACCT_NO { get; set; }
        [Required]
        public string RDM_METH { get; set; }
        [Required]
        public string SVC_TYP { get; set; }
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
