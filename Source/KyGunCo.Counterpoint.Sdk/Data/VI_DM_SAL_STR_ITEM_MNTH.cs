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

    public partial class VI_DM_SAL_STR_ITEM_MNTH 
    {
        [Required]
        public int MNTH_ID { get; set; }
        [Required]
        public string STR_ID { get; set; }
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
        public string VEND_NO { get; set; }
        [Required]
        public string CATEG_COD { get; set; }
        [Required]
        public string SUBCAT_COD { get; set; }
        [Required]
        public int PART_TKT_CNT { get; set; }
        [Required]
        public decimal SLS_QTY { get; set; }
        [Required]
        public decimal SLS_EXT_PRC { get; set; }
        [Required]
        public int SLS_LIN_CNT { get; set; }
        [Required]
        public decimal RTN_QTY { get; set; }
        [Required]
        public decimal RTN_EXT_PRC { get; set; }
        [Required]
        public int RTN_LIN_CNT { get; set; }
        [Required]
        public decimal TOT_EXT_COST { get; set; }
        [Required]
        public decimal TOT_EXT_CALC_PRC { get; set; }
        [Required]
        public decimal TOT_EXT_RETL_VAL { get; set; }
        [Required]
        public decimal TOT_EXT_REG_PRC { get; set; }
        [Required]
        public decimal TOT_EXT_PRC_1 { get; set; }
        public byte[] ROW_TS { get; set; }
        public decimal? SLS_AVG_PRC { get; set; }
        public decimal? TOT_QTY_SOLD { get; set; }
        public decimal? TOT_EXT_PRC { get; set; }
        public int? TOT_LIN_CNT { get; set; }
        public decimal? TOT_PFT { get; set; }
        public decimal? TOT_DISC_CALC { get; set; }
        public decimal? TOT_DISC_RETL { get; set; }
        public decimal? TOT_DISC_REG { get; set; }
        public decimal? TOT_DISC_PRC_1 { get; set; }
        public decimal? TOT_PFT_PCT { get; set; }
        public decimal? TOT_RTN_PCT_QTY { get; set; }
        public decimal? TOT_RTN_PCT_PRC { get; set; }
    }

}
#pragma warning restore 1591
