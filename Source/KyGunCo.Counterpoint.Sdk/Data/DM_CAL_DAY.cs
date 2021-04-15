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

    public partial class DM_CAL_DAY 
    {
        [Required]
        [PrimaryKey]
        public DateTime DAT { get; set; }
        [References(typeof(DM_CAL_YR))]
        [Required]
        public int YR_ID { get; set; }
        [Required]
        public int DAY_OF_YR { get; set; }
        public DateTime? SAME_DAY_LST_YR { get; set; }
        [Required]
        public int WEEK_ID { get; set; }
        [Required]
        public int MNTH_ID { get; set; }
        [Required]
        public int SEAS_ID { get; set; }
        [Required]
        public string CALNDR_ID { get; set; }
        public byte[] ROW_TS { get; set; }
        [Compute]
        public int? DAY_OF_WEEK { get; set; }
    }

}
#pragma warning restore 1591
