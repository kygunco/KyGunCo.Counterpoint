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

    public partial class VI_UNPSTD_SER_NO 
    {
        [Required]
        public string TRX_TYPE { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        public string SER_NO { get; set; }
        [Required]
        public string LOC_ID { get; set; }
        public string DOC_NO { get; set; }
        [Required]
        public DateTime TRX_DAT { get; set; }
        [Required]
        public string BAT_ID { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string STA_ID { get; set; }
    }

}
#pragma warning restore 1591
