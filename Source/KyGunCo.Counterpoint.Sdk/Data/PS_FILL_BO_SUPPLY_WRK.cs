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

    public partial class PS_FILL_BO_SUPPLY_WRK 
    {
        [Required]
        public Guid SESS_ID { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string LOC_ID { get; set; }
        [Required]
        public string DIM_1_UPR { get; set; }
        [Required]
        public string DIM_2_UPR { get; set; }
        [Required]
        public string DIM_3_UPR { get; set; }
        [Required]
        public decimal QTY_ON_HND { get; set; }
        [Required]
        public decimal QTY_COMMIT { get; set; }
        [Compute]
        public decimal? QTY_AVAIL { get; set; }
    }

}
#pragma warning restore 1591
