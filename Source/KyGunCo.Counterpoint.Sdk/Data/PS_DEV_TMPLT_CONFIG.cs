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

    public partial class PS_DEV_TMPLT_CONFIG 
    {
        [References(typeof(PS_DEV_TMPLT))]
        [Required]
        public long DEV_TMPLT_ID { get; set; }
        [References(typeof(PS_DEV_CFG))]
        [Required]
        public long DEV_CFG_ID { get; set; }
    }

}
#pragma warning restore 1591
