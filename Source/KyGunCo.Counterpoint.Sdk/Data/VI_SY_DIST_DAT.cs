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

    public partial class VI_SY_DIST_DAT 
    {
        [Required]
        public string ACCT_NO { get; set; }
        [Required]
        public DateTime DIST_DAT { get; set; }
        public string ACT_TYP { get; set; }
        public string PKG_ID { get; set; }
        public string DIST_GRP { get; set; }
        public string DIST_TYP { get; set; }
        public string EVENT_NO { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string DESCR { get; set; }
        public string GL_ACCT_NO { get; set; }
        public string INTRFACD { get; set; }
        public string FST_DOC_NO { get; set; }
        public string FST_REF { get; set; }
        public decimal? DEBIT_AMT { get; set; }
        public decimal? CREDIT_AMT { get; set; }
        public decimal? AMT { get; set; }
        public int? NO_ENTRIES { get; set; }
    }

}
#pragma warning restore 1591
