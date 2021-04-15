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

    public partial class IM_INV_MSD 
    {
        [Required]
        public int SITE_ID { get; set; }
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string LOC_ID { get; set; }
        public decimal? QTY_COMMIT { get; set; }
        public decimal? QTY_ON_HND { get; set; }
        public decimal? QTY_ON_PO { get; set; }
        public decimal? QTY_ON_BO { get; set; }
        public decimal? QTY_ON_XFER_OUT { get; set; }
        public decimal? QTY_ON_XFER_IN { get; set; }
        public decimal? GL_VAL { get; set; }
        public decimal? QTY_ON_ORD { get; set; }
        public decimal? QTY_ON_LWY { get; set; }
        public decimal? QTY_ON_SO { get; set; }
        public decimal? DROPSHIP_QTY_ON_CUST_ORD { get; set; }
        public decimal? DROPSHIP_QTY_ON_PO { get; set; }
    }

}
#pragma warning restore 1591
