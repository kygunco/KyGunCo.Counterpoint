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

    public partial class VI_PS_VALIDATED_RETURNS_LIN_SER 
    {
        public int? BUS_DAT { get; set; }
        [Required]
        public long DOC_ID { get; set; }
        [Required]
        public int LIN_SEQ_NO { get; set; }
        [Required]
        public string SER_NO { get; set; }
        public int? SER_SEQ_NO { get; set; }
        public decimal? SER_COST { get; set; }
        [Required]
        public decimal QTY_RET { get; set; }
    }

}
#pragma warning restore 1591
