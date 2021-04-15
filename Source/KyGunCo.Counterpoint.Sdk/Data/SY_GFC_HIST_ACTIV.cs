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

    public partial class SY_GFC_HIST_ACTIV 
    {
        [References(typeof(SY_GFC_HIST))]
        [Required]
        public string EVENT_NO { get; set; }
        [References(typeof(SY_GFC_HIST))]
        [Required]
        public string GFC_NO { get; set; }
        [Required]
        public int SEQ_NO { get; set; }
        public DateTime? DAT { get; set; }
        [Required]
        public string STR_ID { get; set; }
        public string STA_ID { get; set; }
        public string DOC_NO { get; set; }
        [Required]
        public string ACTIV_TYP { get; set; }
        [Required]
        public decimal AMT { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
    }

}
#pragma warning restore 1591
