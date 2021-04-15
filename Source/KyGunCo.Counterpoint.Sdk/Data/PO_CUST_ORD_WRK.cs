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

    public partial class PO_CUST_ORD_WRK 
    {
        [Required]
        public Guid SESS_ID { get; set; }
        [Required]
        public string STR_ID { get; set; }
        [Required]
        public string STA_ID { get; set; }
        [Required]
        public string TKT_NO { get; set; }
        [Required]
        public int TKT_LIN_SEQ_NO { get; set; }
        public string ITEM_NO { get; set; }
        public string LOC_ID { get; set; }
        public decimal? QTY { get; set; }
        public decimal? QTY_NUMER { get; set; }
        public decimal? QTY_DENOM { get; set; }
        public string CUST_NO { get; set; }
        public string BILL_NAM { get; set; }
        public DateTime? TKT_DAT { get; set; }
        public decimal? QTY_ON_HND { get; set; }
        public decimal? QTY_ON_PO { get; set; }
        public decimal? QTY_COMMIT { get; set; }
        public decimal? QTY_ON_BO { get; set; }
        [Required]
        public decimal MIN_QTY { get; set; }
        [Required]
        public decimal MAX_QTY { get; set; }
        public decimal? AVG_COST { get; set; }
        public decimal? LST_COST { get; set; }
        public decimal? UNIT_RETL_VAL { get; set; }
        [Required]
        public string DESCR { get; set; }
        public string ITEM_VEND_NO { get; set; }
        public int? QTY_DECS { get; set; }
        [Required]
        public string TRK_METH { get; set; }
        public string VEND_NO { get; set; }
        public decimal? VEND_ITEM_COST { get; set; }
        public string VEND_ITEM_NO { get; set; }
        public string VEND_DESCR { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string LST_MAINT_USR_ID { get; set; }
        public DateTime? LST_LCK_DT { get; set; }
        public byte[] ROW_TS { get; set; }
        public string LIN_DESCR { get; set; }
        public DateTime? TKT_TIM { get; set; }
        public decimal? QTY_ON_SO { get; set; }
        public decimal? QTY_ON_ORD { get; set; }
        public decimal? QTY_ON_LWY { get; set; }
        public string UNIT { get; set; }
        [Required]
        public string QTY_UNIT { get; set; }
        public decimal? COST_ENTD { get; set; }
        [Required]
        public string USE_COST_ENTD { get; set; }
        [Compute]
        public decimal? EXT_AVG_COST { get; set; }
        [Compute]
        public decimal? EXT_LST_COST { get; set; }
        [Compute]
        public decimal? EXT_RETL_PRC { get; set; }
        [Compute]
        public decimal? EXT_VEND_ITEM_COST { get; set; }
        [Compute]
        public decimal? NET_QTY { get; set; }
        [Compute]
        public decimal? QTY_AVAIL { get; set; }
        [Required]
        public long DOC_ID { get; set; }
    }

}
#pragma warning restore 1591
