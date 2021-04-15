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

    public partial class VI_INV_PRC_CELL_EXT_NO_PRCS 
    {
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
        public decimal MIN_QTY { get; set; }
        [Required]
        public decimal MAX_QTY { get; set; }
        [Required]
        public decimal QTY_COMMIT { get; set; }
        [Required]
        public decimal QTY_ON_HND { get; set; }
        [Required]
        public decimal QTY_ON_PO { get; set; }
        [Required]
        public decimal QTY_ON_BO { get; set; }
        [Required]
        public decimal QTY_ON_SO { get; set; }
        [Required]
        public decimal QTY_ON_ORD { get; set; }
        [Required]
        public decimal QTY_ON_LWY { get; set; }
        [Required]
        public decimal QTY_ON_XFER_OUT { get; set; }
        [Required]
        public decimal QTY_ON_XFER_IN { get; set; }
        public decimal? QTY_AVAIL { get; set; }
        [Required]
        public decimal DROPSHIP_QTY_ON_CUST_ORD { get; set; }
        [Required]
        public decimal DROPSHIP_QTY_ON_PO { get; set; }
        public decimal? NET_QTY { get; set; }
        public decimal? AVG_COST { get; set; }
        [Required]
        public decimal LST_COST { get; set; }
        public decimal? EXT_COST { get; set; }
        public string DIM_1 { get; set; }
        public string DIM_2 { get; set; }
        public string DIM_3 { get; set; }
    }

}
#pragma warning restore 1591
