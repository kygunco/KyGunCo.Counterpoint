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

    public partial class IM_FORCST_MNTH 
    {
        [Required]
        [PrimaryKey]
        public string FORCST_COD { get; set; }
        [Required]
        public string DESCR { get; set; }
        [Required]
        public DateTime FORCST_DAT { get; set; }
        [Required]
        public string IS_LOC_GRP { get; set; }
        [References(typeof(IM_LOC))]
        public string LOC_ID { get; set; }
        public string LOC_GRP_ID { get; set; }
        [Required]
        public string ITEM_FILT { get; set; }
        [Required]
        public string ITEM_FILT_TMPLT { get; set; }
        [Required]
        public string ITEM_FILT_TEXT { get; set; }
        [Required]
        public int FORCST_MNTH_ID { get; set; }
        public int? HIST_BEG_MNTH_ID { get; set; }
        [Required]
        public int HIST_END_MNTH_ID { get; set; }
        public decimal? ALPHA { get; set; }
        public decimal? BETA { get; set; }
        public decimal? GAMMA { get; set; }
        [Required]
        public string FORCST_METH { get; set; }
        [Required]
        public string CREATED_BY { get; set; }
        public string COMMNT { get; set; }
        public string ERR_REF { get; set; }
        [Required]
        public string NO_CUTOFF { get; set; }
        [Required]
        public string USE_XFER_IN { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
    }

}
#pragma warning restore 1591
