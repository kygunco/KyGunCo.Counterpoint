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

    public partial class PS_TKT_HIST_PMT_CHK 
    {
        [References(typeof(PS_TKT_HIST_PMT))]
        [Required]
        public DateTime BUS_DAT { get; set; }
        [References(typeof(PS_TKT_HIST_PMT))]
        [Required]
        public long DOC_ID { get; set; }
        [References(typeof(PS_TKT_HIST_PMT))]
        [Required]
        public int PMT_SEQ_NO { get; set; }
        public string CHK_ACCT_NO { get; set; }
        public string CHK_TRANSIT_NO { get; set; }
        public string CHK_NO { get; set; }
        public string CHK_DRIV_LIC_NO { get; set; }
        public string CHK_DRIV_LIC_STATE { get; set; }
        public DateTime? CHK_BIRTH_DAT { get; set; }
    }

}
#pragma warning restore 1591
