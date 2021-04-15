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

    public partial class DM_FORCST_MNTH_CACHE 
    {
        [Required]
        public int MNTH_ID { get; set; }
        [References(typeof(DM_LOC_HIST))]
        [Required]
        public string LOC_ID { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string DIM_1_UPR { get; set; }
        [Required]
        public string DIM_2_UPR { get; set; }
        [Required]
        public string DIM_3_UPR { get; set; }
        public decimal? FORC_LEVEL { get; set; }
        public decimal? FORC_TREND { get; set; }
        public decimal? MNTH_INDX { get; set; }
        public int? CUTOFF_MNTH_ID { get; set; }
        [Required]
        public string USE_TI { get; set; }
        public DateTime? FORC_UPD_ON { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
    }

}
#pragma warning restore 1591
