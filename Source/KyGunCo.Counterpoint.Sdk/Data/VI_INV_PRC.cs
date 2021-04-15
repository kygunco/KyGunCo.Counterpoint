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

    public partial class VI_INV_PRC 
    {
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string LOC_ID { get; set; }
        public string BIN_1 { get; set; }
        public string BIN_2 { get; set; }
        public string BIN_3 { get; set; }
        public string BIN_4 { get; set; }
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
        public decimal QTY_ON_XFER_OUT { get; set; }
        [Required]
        public decimal QTY_ON_XFER_IN { get; set; }
        [Required]
        public decimal LST_AVG_COST { get; set; }
        [Required]
        public decimal LST_COST { get; set; }
        [Required]
        public decimal STD_COST { get; set; }
        [Required]
        public decimal COST_OF_SLS_PCT { get; set; }
        public DateTime? FST_RECV_DAT { get; set; }
        public DateTime? LST_RECV_DAT { get; set; }
        public DateTime? FST_SAL_DAT { get; set; }
        public DateTime? LST_SAL_DAT { get; set; }
        public DateTime? LST_CNT_DAT { get; set; }
        public DateTime? LST_ORD_DAT { get; set; }
        public DateTime? NXT_EXPECTD_DAT { get; set; }
        public string NXT_EXPECTD_PO { get; set; }
        [Required]
        public decimal GL_VAL { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        [Required]
        public decimal QTY_ON_ORD { get; set; }
        [Required]
        public decimal QTY_ON_LWY { get; set; }
        [Required]
        public decimal QTY_ON_SO { get; set; }
        public DateTime? RS_UTC_DT { get; set; }
        public decimal? AVG_COST { get; set; }
        public decimal? NET_QTY { get; set; }
        public decimal? QTY_AVAIL { get; set; }
        public string STK_STAT_PER_QTY_ON_HND { get; set; }
        public string STK_STAT_PER_QTY_AVAIL { get; set; }
        public string STK_STAT_PER_NET_QTY { get; set; }
        public decimal? REORD_PNT { get; set; }
        public decimal? EOQ { get; set; }
        public decimal? SFTY_STK { get; set; }
        public decimal? SRVC_LEVL { get; set; }
        public decimal? ANNL_HLD_COST { get; set; }
        public decimal? ANNL_HLD_COST_PERC { get; set; }
        public decimal? ORD_COST_PER_ORDER { get; set; }
        public DateTime? EOQ_CALC_ON { get; set; }
        [Required]
        public byte RS_STAT { get; set; }
        [Required]
        public decimal DROPSHIP_QTY_ON_CUST_ORD { get; set; }
        [Required]
        public decimal DROPSHIP_QTY_ON_PO { get; set; }
        public decimal? INV_REG_PRC { get; set; }
        public decimal? INV_PRC_1 { get; set; }
        public decimal? INV_PRC_2 { get; set; }
        public decimal? INV_PRC_3 { get; set; }
        public decimal? INV_PRC_4 { get; set; }
        public decimal? INV_PRC_5 { get; set; }
        public decimal? INV_PRC_6 { get; set; }
        public decimal? INV_ALT_1_REG_PRC { get; set; }
        public decimal? INV_ALT_1_PRC_1 { get; set; }
        public decimal? INV_ALT_1_PRC_2 { get; set; }
        public decimal? INV_ALT_1_PRC_3 { get; set; }
        public decimal? INV_ALT_1_PRC_4 { get; set; }
        public decimal? INV_ALT_1_PRC_5 { get; set; }
        public decimal? INV_ALT_1_PRC_6 { get; set; }
        public decimal? INV_ALT_2_REG_PRC { get; set; }
        public decimal? INV_ALT_2_PRC_1 { get; set; }
        public decimal? INV_ALT_2_PRC_2 { get; set; }
        public decimal? INV_ALT_2_PRC_3 { get; set; }
        public decimal? INV_ALT_2_PRC_4 { get; set; }
        public decimal? INV_ALT_2_PRC_5 { get; set; }
        public decimal? INV_ALT_2_PRC_6 { get; set; }
        public decimal? INV_ALT_3_REG_PRC { get; set; }
        public decimal? INV_ALT_3_PRC_1 { get; set; }
        public decimal? INV_ALT_3_PRC_2 { get; set; }
        public decimal? INV_ALT_3_PRC_3 { get; set; }
        public decimal? INV_ALT_3_PRC_4 { get; set; }
        public decimal? INV_ALT_3_PRC_5 { get; set; }
        public decimal? INV_ALT_3_PRC_6 { get; set; }
        public decimal? INV_ALT_4_REG_PRC { get; set; }
        public decimal? INV_ALT_4_PRC_1 { get; set; }
        public decimal? INV_ALT_4_PRC_2 { get; set; }
        public decimal? INV_ALT_4_PRC_3 { get; set; }
        public decimal? INV_ALT_4_PRC_4 { get; set; }
        public decimal? INV_ALT_4_PRC_5 { get; set; }
        public decimal? INV_ALT_4_PRC_6 { get; set; }
        public decimal? INV_ALT_5_REG_PRC { get; set; }
        public decimal? INV_ALT_5_PRC_1 { get; set; }
        public decimal? INV_ALT_5_PRC_2 { get; set; }
        public decimal? INV_ALT_5_PRC_3 { get; set; }
        public decimal? INV_ALT_5_PRC_4 { get; set; }
        public decimal? INV_ALT_5_PRC_5 { get; set; }
        public decimal? INV_ALT_5_PRC_6 { get; set; }
        public decimal? PFT_VAL { get; set; }
        public decimal? RET_VAL { get; set; }
    }

}
#pragma warning restore 1591
