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

    public partial class VI_PS_ITEM_LOC_MONTHLY_HIST 
    {
        [Required]
        public string ITEM_NO { get; set; }
        [Required]
        public string STK_LOC_ID { get; set; }
        [Required]
        public int PriorMonths { get; set; }
        public string mo { get; set; }
        public string yr { get; set; }
        public decimal? Returns { get; set; }
        public decimal? Sales_excl_returns { get; set; }
        public decimal? Sales { get; set; }
        public decimal? Qty_Sold { get; set; }
        public int? Tickets { get; set; }
        public decimal? Avg_Ticket { get; set; }
        public decimal? Pct_Returns { get; set; }
    }

}
#pragma warning restore 1591
