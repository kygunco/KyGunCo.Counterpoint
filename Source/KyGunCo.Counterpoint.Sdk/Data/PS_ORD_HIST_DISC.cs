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

    public partial class PS_ORD_HIST_DISC 
    {
        [References(typeof(PS_ORD_HIST))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_ORD_HIST))]
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int DISC_SEQ_NO { get; set; }
        [References(typeof(PS_ORD_HIST_LIN))]
        public int? LIN_SEQ_NO { get; set; }
        [Required]
        public long DISC_ID { get; set; }
        [Required]
        public string APPLY_TO { get; set; }
        [Required]
        public string DISC_TYP { get; set; }
        [Required]
        public decimal DISC_AMT { get; set; }
        [Required]
        public decimal DISC_PCT { get; set; }
        [Required]
        public decimal DISC_AMT_SHIPPED { get; set; }
    }

}
#pragma warning restore 1591
