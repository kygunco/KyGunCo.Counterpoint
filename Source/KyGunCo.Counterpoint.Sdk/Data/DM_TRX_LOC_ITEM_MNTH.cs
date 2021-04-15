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

    public partial class DM_TRX_LOC_ITEM_MNTH 
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
        [Required]
        public decimal SLS_QTY { get; set; }
        [Required]
        public decimal RTN_QTY { get; set; }
        [Required]
        public decimal ADJ_QTY { get; set; }
        [Required]
        public decimal XFER_OUT_QTY { get; set; }
        [Required]
        public decimal XFER_IN_QTY { get; set; }
        [Required]
        public decimal QXFER_OUT_QTY { get; set; }
        [Required]
        public decimal QXFER_IN_QTY { get; set; }
        [Required]
        public decimal QASSEM_QTY { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
    }

}
#pragma warning restore 1591
