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

    public partial class PS_USR_DRW 
    {
        [References(typeof(SY_USR))]
        [Required]
        public string USR_ID { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string DRW_ID { get; set; }
        [Required]
        public string ALLOW_ACTIV { get; set; }
        [Required]
        public string ALLOW_CNT { get; set; }
        [Required]
        public string ALLOW_USE { get; set; }
        [Required]
        public string ALLOW_RECON { get; set; }
        [Required]
        public string ALLOW_POST { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        [Required]
        public string ALLOW_LOAN { get; set; }
        [Required]
        public string ALLOW_DROP { get; set; }
        [Required]
        public string ALLOW_VOID { get; set; }
    }

}
#pragma warning restore 1591
