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

    public partial class PS_LWY_HIST_PMT_EXT 
    {
        [References(typeof(PS_LWY_HIST_PMT))]
        [Required]
        public DateTime BUS_DAT_EXT { get; set; }
        [References(typeof(PS_LWY_HIST_PMT))]
        [Required]
        public long DOC_ID_EXT { get; set; }
        [References(typeof(PS_LWY_HIST_PMT))]
        [Required]
        public int PMT_SEQ_NO_EXT { get; set; }
    }

}
#pragma warning restore 1591
